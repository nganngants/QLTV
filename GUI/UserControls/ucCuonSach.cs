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
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
            
        }
        private void Binding(List<CUONSACH> CuonSachList)
        {
            CuonSachGrid.Rows.Clear();
            foreach(CUONSACH cs in CuonSachList)
            {
                string TinhTrang = (cs.TinhTrang == 1) ? ("Còn") : ("Đã được mượn");
                CuonSachGrid.Rows.Add(0,cs.MaCuonSach,cs.SACH.TUASACH.MaTuaSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach, TinhTrang);
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
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((string)row.Cells["MaCuonSach"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn xoá " + idDel.Count + " cuốn sách?") == DialogResult.No) return;
            foreach (string id in idDel)
            {
            Retry:
                string error = BUSCuonSach.Instance.DelCuonSach(id);
                if (error != "")
                {
                    if (MessageBox.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã xoá thành công " + cnt + " cuốn sách");
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void CuonSachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Sorting(int idx)
        {
            this.CuonSachGrid.Sort(this.CuonSachGrid.Columns[idx], ListSortDirection.Descending);
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
    }
}
