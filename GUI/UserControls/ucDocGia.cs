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
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            var f = new BMLapTheDocGia();
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucDocGia_Load(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddDocGia();
            f.ShowDialog();
        }

        private void butDel_Click(object sender, EventArgs e)
        {

        }
    }
}
