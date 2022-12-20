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
        private List<CUONSACH> CuonSachList;
        public ucCuonSach()
        {
            InitializeComponent();
            Binding();
            
        }
        private void Binding()
        {
            CuonSachList = BUSCuonSach.Instance.GetAllCuonSach();
            CuonSachGrid.Rows.Clear();
            foreach(CUONSACH cs in CuonSachList)
            {
                string TinhTrang = (cs.TinhTrang == 1) ? ("Còn") : ("Đã được mượn");
                CuonSachGrid.Rows.Add(0,cs.MaCuonSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach, TinhTrang);
            }
            
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucCuonSach_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();
            foreach (DataGridViewRow row in CuonSachGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((string)row.Cells["MaCuonSach"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " cuốn sách?") == DialogResult.No) return;
            foreach (string id in idDel)
            {
            Retry:
                string error = BUSCuonSach.Instance.DelCuonSach(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            SuccDia.Show("Đã xoá thành công " + cnt + " cuốn sách");
            Binding();
        }

        private void CuonSachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CuonSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
