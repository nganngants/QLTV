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

namespace GUI.UserControls
{
    public partial class ucThayDoiQuiDinh : UserControl
    {
        public ucThayDoiQuiDinh()
        {
            InitializeComponent();
        }

        private void butChangePass_Click(object sender, EventArgs e)
        {
            var f = new BMThayDoiTheLoai();
            f.Show();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var f = new BMThayDoiNhomNguoiDung();
            f.Show();
        }
    }
}
