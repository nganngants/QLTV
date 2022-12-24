using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInfoNguoiDung : Form
    {
        private static int id;
        public fInfoNguoiDung(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nd = BUSNguoiDung.Instance.GetNguoiDungById(id);
            if (nd == null)
            {
                errorDia.Show("Có lỗi xảy ra, vui lòng thử lại!");
                this.Close();
            }
            if (nd.ChucVu != null) labelChucVu.Text = nd.ChucVu;
            else labelChucVu.Text = "";
            labelHoTen.Text = nd.TenNguoiDung;
            labelMaNd.Text = nd.MaNguoiDung;
            if (nd.NgaySinh != null) labelNgaySinh.Text = nd.NgaySinh.Value.ToShortDateString();
            else labelNgaySinh.Text = "";
            labelNhomND.Text = nd.NHOMNGUOIDUNG.TenNhomNguoiDung;
            labelTenDN.Text = nd.TenDangNhap;
        }
        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditNguoiDung(id);
            f.ShowDialog();
            Bind();
        }
    }
}
