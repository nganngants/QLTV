using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DTO;
using BUS;
namespace GUI.UserControls
{

    public partial class ucCuonSach : UserControl
    {
        public ucCuonSach()
        {
            InitializeComponent();
            comboList = new List<string> { "Đã được mượn", "Còn", "Bị ẩn" };
            comboTinhTrang.DataSource = comboList;
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }
        List<int> tt;
        List<string> comboList;
        public void Binding(List<CUONSACH> CuonSachList)
        {
            CuonSachGrid.Rows.Clear();
            foreach(CUONSACH cs in CuonSachList)
            {
                string TinhTrang = comboList[(int)cs.TinhTrang];
                CuonSachGrid.Rows.Add(0,cs.MaCuonSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach + " (" + cs.SACH.TUASACH.MaTuaSach + " )", TinhTrang);
            }
            
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucCuonSach_Load(object sender, EventArgs e)
        {
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();
            foreach (DataGridViewRow row in CuonSachGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1" && row.Cells["TinhTrang"].Value != "Đang được muuợn")
                {
                    idDel.Add((string)row.Cells["MaCuonSach"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn ẩn " + idDel.Count + " cuốn sách?", "Ẩn cuốn sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No) return;
            foreach (string id in idDel)
            {
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(id);
                if (cuonsach.DaAn == 1) continue;
            Retry:
                string error = BUSCuonSach.Instance.UpdAnCuonSach(id,1);
                if (error != "")
                {
                    if (MessageBox.Show(error,"Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã ẩn thành công " + cnt + " cuốn sách","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void CuonSachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Sorting(int idx)
        {
           // this.CuonSachGrid.Sort(this.CuonSachGrid.Columns[idx], ListSortDirection.Descending);
        }
        private void CuonSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                Sorting(e.ColumnIndex);
                return;
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
            txtMaSach.Text = "";
        }

        private void butMaSach_Click(object sender, EventArgs e)
        {
            string pat = txtMaSach.Text.ToLower();
            var Res =new  List<CUONSACH>();
            foreach(CUONSACH cs in BUSCuonSach.Instance.GetAllCuonSach())
            {
                if (cs.MaCuonSach.ToLower().Contains(pat) || cs.SACH.MaSach.ToLower().Contains(pat) || cs.SACH.TUASACH.MaTuaSach.ToLower().Contains(pat) || cs.SACH.TUASACH.TenTuaSach.ToLower().Contains(pat))
                    Res.Add(cs);
            }
            Binding(Res);
        }

        private void butTinhTrang_Click(object sender, EventArgs e)
        {
            int idx = comboTinhTrang.SelectedIndex;
            
            var Res = new List<CUONSACH>();
            foreach (CUONSACH cs in BUSCuonSach.Instance.GetAllCuonSach())
            {
               if(cs.TinhTrang == idx)Res.Add(cs);
            }
            Binding(Res);
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();
            foreach (DataGridViewRow row in CuonSachGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((string)row.Cells["MaCuonSach"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn hiện " + idDel.Count + " cuốn sách?", "Hiện cuốn sách",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (string id in idDel)
            {
                CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(id);
                if (cuonsach.DaAn == 0) continue;
                Retry:
                string error = BUSCuonSach.Instance.UpdAnCuonSach(id, 0);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã hiện thành công " + cnt + " cuốn sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }
    }
}
