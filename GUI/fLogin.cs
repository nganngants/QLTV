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
            string usrname = txtUsername.Text;
            string usrpwd = txtUserpwd.Text;
            if (BUSLogin.Instance.checkValidLogin(usrname, usrpwd))
            {
                fMainForm f = new fMainForm();
                this.Hide();
                f.ShowDialog();
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
