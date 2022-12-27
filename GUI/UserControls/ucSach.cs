using BUS;
using DTO;
using GUI.BM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.UserControls
{
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
            Binding();
        }
        private List<SACH> SachList;

        public void Binding()
        {
            SachList = BUSSach.Instance.GetAllSach();
            this.SachGrid.DataSource = SachList;
            int i = 0;
            foreach(DataGridViewRow row in SachGrid.Rows)
            {
                row.Cells["TuaSach"].Value = SachList[i].TUASACH.TenTuaSach + " (" + SachList[i].TUASACH.MaTuaSach + ")";
                i++;
            }
        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddSachMoi();
            f.ShowDialog();
            Binding();
        }

        private void butAddOld_Click(object sender, EventArgs e)
        {
            var f = new fAddSachDaCo();
            f.ShowDialog();
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if(idDel.Count ==0) { return; }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " sách?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSSach.Instance.DelSach(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            SuccDia.Show("Đã xoá thành công " + cnt + " sách");
            Binding();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }


        private void butMaSach_Click(object sender, EventArgs e)
        {
            string pat = txtMaSach.Text;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in SachList)
            {
                if (sach.MaSach.Contains(pat))
                    Res.Add(sach);
            }
            this.SachGrid.DataSource = Res;
            int i = 0;
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                row.Cells["TuaSach"].Value = Res[i].TUASACH.TenTuaSach + " (" + Res[i].TUASACH.MaTuaSach + ")";
                i++;
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void butTenSach_Click(object sender, EventArgs e)
        {
            string pat = txtTenSach.Text;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in SachList)
            {
                if (sach.TUASACH.TenTuaSach.Contains(pat))
                    Res.Add(sach);
            }
            this.SachGrid.DataSource = Res;
            int i = 0;
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                row.Cells["TuaSach"].Value = Res[i].TUASACH.TenTuaSach + " (" + Res[i].TUASACH.MaTuaSach + ")";
                i++;
            }
        }
    }
}
