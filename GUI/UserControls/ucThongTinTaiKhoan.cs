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
            init();
        }
        private void butChangePass_Click(object sender, EventArgs e)
        {
            var f = new fChangePassword(usr.id);
            f.Show();
        }
        private void init()
        {

            labelName.Text = usr.TenNguoiDung;
            labelRole.Text = usr.NHOMNGUOIDUNG.TenNhomNguoiDung;
            if(usr.ChucVu !=null)
            labelChucVu.Text +=" "+ usr.ChucVu;
            if(usr.NgaySinh !=null)
            labelNgaySinh.Text += " "+((DateTime)usr.NgaySinh).ToShortDateString();
            labelMaND.Text +=usr.MaNguoiDung;
            labelUsrName.Text += usr.TenDangNhap;
            listView1.Clear();
            foreach (CHUCNANG cn in usr.NHOMNGUOIDUNG.CHUCNANGs)
                listView1.Items.Add(cn.TenManHinh);
        }
        
    }
}
