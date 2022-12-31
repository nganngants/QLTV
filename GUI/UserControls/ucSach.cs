using BUS;
using DTO;
using GUI;
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
            Binding(BUSSach.Instance.GetAllSach());
            comboTinhTrang.Items.Add("Còn");
            comboTinhTrang.Items.Add("Hết");
            comboTinhTrang.Items.Add("Chưa ẩn");
            comboTinhTrang.Items.Add("Đã ẩn");

        }
        private List<SACH> SachList;
       

        public void Binding(List<SACH> SachList)
        {
            SachGrid.Rows.Clear();
            foreach(SACH sach in SachList)
            {
                SachGrid.Rows.Add(0,sach.id, sach.MaSach, sach.TUASACH.MaTuaSach, sach.TUASACH.TenTuaSach, sach.NamXB, sach.NhaXB, sach.SoLuong, sach.SoLuongConLai, sach.DaAn);
            }

        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddSachMoi();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
        }

        private void butAddOld_Click(object sender, EventArgs e)
        {
            var f = new fAddSachDaCo();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
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
            if (MessageBox.Show("Bạn có chắc muốn ẩn " + idDel.Count + " sách?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                SACH sach = BUSSach.Instance.GetSach(id);
                if (sach.DaAn == 1) continue;
                string error = BUSSach.Instance.UpdAnSach(id,1);
                if (error != "")
                {
                    if (MessageBox.Show(error,"", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã ẩn thành công " + cnt + " sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding(BUSSach.Instance.GetAllSach());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtMaSach.Text = "";

        }


        private void butMaSach_Click(object sender, EventArgs e)
        {
            string pat = txtMaSach.Text;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in SachList)
            {
                if (sach.MaSach.Contains(pat) || sach.TUASACH.TenTuaSach.Contains(pat) || sach.TUASACH.MaTuaSach.Contains(pat))
                    Res.Add(sach);
            }
            Binding(Res);
          
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void butTenSach_Click(object sender, EventArgs e)
        {
            int idx = comboTinhTrang.SelectedIndex;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach(SACH sach in SachList)
            {
                if (sach.SoLuongConLai > 0 && comboTinhTrang.Text == "Còn")
                    Res.Add(sach);
                if (sach.SoLuongConLai == 0 && comboTinhTrang.Text == "Hết")
                    Res.Add(sach);
                if(sach.DaAn == 1 && comboTinhTrang.Text == "Đã ẩn")
                    Res.Add(sach);
                if(sach.DaAn == 0 && comboTinhTrang.Text == "Chưa ẩn")
                    Res.Add(sach);
            }
            Binding(Res);
        }

        private void butHien_Click(object sender, EventArgs e)
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
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn hiện " + idDel.Count + " sách?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                SACH sach = BUSSach.Instance.GetSach(id);
                if (sach.DaAn == 0) continue;
                string error = BUSSach.Instance.UpdAnSach(id, 0);
                if (error != "")
                {
                    if (MessageBox.Show(error, "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã hiện thành công " + cnt + " sách", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding(BUSSach.Instance.GetAllSach());
        }
    }
}
