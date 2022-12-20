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

namespace GUI
{
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            NGUOIDUNG usr = BUSLogin.usr;
            if(txtMKHT.Text != usr.MatKhau)
            {
                ErrorDia.Show("Mật khẩu hiện tại không đúng");
                return; 
            }
            if(txtMKM.Text != txtRMKM.Text)
            {
                ErrorDia.Show("Mật khẩu mới không khớp");
                return;
            }
            BUSNguoiDung.Instance.UpdMK(usr.id, txtMKM.Text);
            SuccDia.Show("Cập nhật mật khẩu thành công");
            this.Close();
        }

        private void txtRMKM_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
