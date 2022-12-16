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
    public partial class ucTuaSach : UserControl
    {
        public ucTuaSach()
        {
            InitializeComponent();
        }

        private void ucTuaSach_Load(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddTuaSach();
            f.ShowDialog();
        }


    }
}
