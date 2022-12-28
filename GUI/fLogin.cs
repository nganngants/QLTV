using BUS;
using DTO;
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

                var user = BUSNguoiDung.Instance.GetNguoiDungById(id);
                bool isDG = false;
                foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
                {
                    if (cn.TenChucNang == "DG") { isDG = true; break; }
                }
                this.Hide();
                if (isDG)
                {
                    var f = new fHome(id);
                    f.ShowDialog();
                }
                else
                {
                    var f = new fManager(id);
                    f.ShowDialog(); 
                }
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
