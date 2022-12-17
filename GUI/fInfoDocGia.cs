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
    public partial class fInfoDocGia : Form
    {
        private static int id;
        public fInfoDocGia(int _id)
        {
            InitializeComponent();
            id = _id;
        }
        private void fInfoDocGia_Load(object sender, EventArgs e)
        {

        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditDocGia(id);
            f.ShowDialog();
        }
    }
}
