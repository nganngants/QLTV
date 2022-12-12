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
        public ucThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void butChangePass_Click(object sender, EventArgs e)
        {
            var f = new fChangePassword();
            f.Show();
        }

        
    }
}
