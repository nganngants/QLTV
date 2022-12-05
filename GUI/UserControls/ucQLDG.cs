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
    public partial class ucQLDG : UserControl
    {
        public ucQLDG()
        {
            InitializeComponent();
            InitializeContainer();

            //Khi vua vao page QLDG thi hien tab "Doc Gia" truoc
            butDocGia.Checked = true;
        }

        private void InitializeContainer()
        {
            ucdg = new ucDocGia();
            ucdg.Dock = DockStyle.Fill;

            ucloaidg = new ucLoaiDG();
            ucloaidg.Dock = DockStyle.Fill;

            // add ca 2 UC DG va LoaiDG vao container
            container.Controls.Add(new ucDocGia() { Dock = DockStyle.Fill, Name = "docgia" });
            container.Controls.Add(new ucLoaiDG() { Dock = DockStyle.Fill, Name = "loaidg" });

        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Doc Gia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDocGia_Click(object sender, EventArgs e)
        {
            // tim UC DocGia va dem no len hien thi
            Control[] con = container.Controls.Find("docgia", false);
            con[0].BringToFront();
        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Loai Doc Gia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butLoaiDG_Click(object sender, EventArgs e)
        {
            // tim UC LoaiDG va dem no len hien thi
            Control[] con = container.Controls.Find("loaidg", false);
            con[0].BringToFront();
        }
    }
}
