using GUI.UserControls;
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
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
            InitializeUCs();
        }

        /// <summary>
        /// ham khoi tao cac User Control
        /// </summary>
        private void InitializeUCs()
        {
            // ucBan la de hien thi khi cac tab khong duoc su dung
            /* //just for test:
            ucBan = new UserControls.ucBanAccess();
            ucBan.Dock = DockStyle.Fill;
            this.pageHome.Controls.Add(ucBan);
            */

            // tao UC QLDG moi va add no vao page QLDG
            ucqldg = new UserControls.ucQLDG();
            ucqldg.Dock = DockStyle.Fill;
            this.pageQLDG.Controls.Add(ucqldg);
        }
        /// <summary>
        /// viet lai event nhan nut thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitControlBox_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) this.Close();
        }

        private void pageHome_Click(object sender, EventArgs e)
        {

        }
    }
}
