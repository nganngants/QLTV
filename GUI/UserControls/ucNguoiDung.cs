using BUS;
using GUI.BM;
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
            var f = new fInfoNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGrid.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
            f.Show();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
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
                if (nd.TenNguoiDung.ToLower().Contains(pat) || nd.MaNguoiDung.ToLower().Contains(pat))
                    Res.Add(nd);
                else if (nd.ChucVu != null && nd.ChucVu.ToLower().Contains(pat))
                    Res.Add(nd);
                   
            }
            Bind(Res);
        }
    }
}
