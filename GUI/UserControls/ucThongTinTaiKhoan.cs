using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucThongTinTaiKhoan : UserControl
    {
        private NGUOIDUNG usr;
        public ucThongTinTaiKhoan(int id)
        {
            InitializeComponent();
            usr = BUSNguoiDung.Instance.GetNguoiDungById(id);
            Bind();
        }

        private void Bind()
        {
            labelRole.Text = usr.NHOMNGUOIDUNG.TenNhomNguoiDung;
            labelName.Text = usr.TenNguoiDung;

        }
        private void butChangePass_Click(object sender, EventArgs e)
        {
            var f = new fChangePassword(usr.id);
            f.Show();
        }

        
    }
}
