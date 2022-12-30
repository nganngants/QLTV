using BUS;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI.UserControls
{
    public partial class ucNguoiDung : UserControl
    {
        public ucNguoiDung()
        {
            InitializeComponent();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNguoiDung();
            f.ShowDialog();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void Bind(List<NGUOIDUNG> NguoiDungList)
        {
            dataGrid.Rows.Clear();
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));

            foreach (NGUOIDUNG nd in NguoiDungList)
                dataGrid.Rows.Add(nd.id,"0", nd.MaNguoiDung, 
                    nd.TenNguoiDung,  nd.ChucVu, nd.TenDangNhap, nd.NHOMNGUOIDUNG.TenNhomNguoiDung,img);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return;
            if (e.ColumnIndex == 1) return;
            if (e.ColumnIndex == 7)
            {
                var fedit = new fEditNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGrid.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
                fedit.ShowDialog();
                Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
                return;
            }
            var f = new fInfoNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGrid.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
            f.Show();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
            txtFind.Text = "";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<NGUOIDUNG> Res = new List<NGUOIDUNG>();
            foreach(NGUOIDUNG nd in BUSNguoiDung.Instance.GetAllNguoiDung())
            {
                if (nd.TenNguoiDung.ToLower().Contains(pat) 
                    || nd.MaNguoiDung.ToLower().Contains(pat)
                    || nd.TenDangNhap.ToLower().Contains(pat))
                    Res.Add(nd);
                else if (nd.ChucVu != null && nd.ChucVu.ToLower().Contains(pat))
                    Res.Add(nd);
                   
            }
            Bind(Res);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((string)row.Cells["MaNguoiDung"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn xoá " + idDel.Count + " người dùng?", "Xóa người dùng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (string id in idDel)
            {
            Retry:
                string error = BUSNguoiDung.Instance.DelNguoidung(id);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã xoá thành công " + cnt + " người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }
    }
}
