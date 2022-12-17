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
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditNguoiDung(id);
            f.ShowDialog();
        }
    }
}
