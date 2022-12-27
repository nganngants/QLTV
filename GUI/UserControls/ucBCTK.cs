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
    public partial class ucBCTK : UserControl
    {
        public ucBCTK()
        {
            InitializeComponent();
            InitializeContainer();

            //Khi vua vao page BCTK thi hien tab "Muon theo the loai" truoc
            butTheLoai.Checked = true;
        }

        private void InitializeContainer()
        {

            // add ca 2 UC MuonTheoTheLoai va SachTraTre vao container
            container.Controls.Add(new ucMuonTheoTheLoai() { Dock = DockStyle.Fill, Name = "theloai" });
            container.Controls.Add(new ucSachTraTre() { Dock = DockStyle.Fill, Name = "tratre" });

        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Muon theo the loai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butTheLoai_Click(object sender, EventArgs e)
        {
            // tim UC MuonTheoTheLoai va dem no len hien thi
            Control[] con = container.Controls.Find("theloai", false);
            con[0].BringToFront();
        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Sach tra tre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butTraTre_Click(object sender, EventArgs e)
        {
            // tim UC SachTraTre va dem no len hien thi
            Control[] con = container.Controls.Find("tratre", false);
            con[0].BringToFront();
        }
    }
}
