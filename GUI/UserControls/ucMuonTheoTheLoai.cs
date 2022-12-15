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
    public partial class ucMuonTheoTheLoai : UserControl
    {
        public ucMuonTheoTheLoai()
        {
            InitializeComponent();
        }

        private void butChangePass_Click(object sender, EventArgs e)
        {
            var f = new BMBCTKMuonTheoTheLoai();
            f.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            var f = new BMBCTKMuonTheoTheLoai();
            f.Show();

        }
    }
}
