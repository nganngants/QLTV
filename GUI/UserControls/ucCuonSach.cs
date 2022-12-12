using GUI.Tab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GUI.UserControls
{
    public partial class ucCuonSach : UserControl
    {
        public ucCuonSach()
        {
            InitializeComponent();
            InitializeTabs();
        }
        private void InitializeTabs()
        {
            tabthemcuonsach = new Tab.tabThemCuonSach();
            tabthemcuonsach.Dock = DockStyle.Fill;
            this.pageThem.Controls.Add(tabthemcuonsach);

        }
    }
}
