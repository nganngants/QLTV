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

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void resetTextboxs()
        {
            txtUsername.Clear();
            txtUserpwd.Clear();
            txtUsername.Focus();
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string userpwd = txtUserpwd.Text;
            BUSLogin bLogin = new BUSLogin();
            int id = bLogin.checkValidLogin(username, userpwd);
            if (id != -1)
            {
                MessageBox.Show("Đăng nhập thành công!\nChào mừng " + username + "!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = new fMainForm(id);
                //BmPhieuThuTienPhat f = new BmPhieuThuTienPhat();
                this.Hide();
                f.ShowDialog();
                this.resetTextboxs();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.resetTextboxs();
            }
        }

    }
}
