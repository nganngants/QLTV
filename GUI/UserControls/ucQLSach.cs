using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.UserControls
{
    public partial class ucQLSach : UserControl
    {
        public ucQLSach()
        {
            InitializeComponent();
            InitializeContainer();

            //Khi vua vao page QLDSach thi hien tab "TuaSach" truoc
            butTuaSach.Checked = true;
        }

        private void InitializeContainer()
        {
            // add ca 3 UC Sach, Cuon sach va Tua sach vao container
            container.Controls.Add(new ucSach() { Dock = DockStyle.Fill, Name = "sach" });
            container.Controls.Add(new ucTuaSach() { Dock = DockStyle.Fill, Name = "tuasach" });
            container.Controls.Add(new ucCuonSach() { Dock = DockStyle.Fill, Name = "cuonsach" });
            container.Controls.Add(new ucTacGia() { Dock = DockStyle.Fill, Name = "tacgia" });
            container.Controls.Add(new ucTheLoai() { Dock = DockStyle.Fill, Name = "theloai" });
        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Sach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSach_Click(object sender, EventArgs e)
        {
            // tim UC Sach va dem no len hien thi
            Control[] con = container.Controls.Find("sach", false);
            con[0].BringToFront();
        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Tua sach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butTuaSach_Click(object sender, EventArgs e)
        {
            // tim UC Tua sach va dem no len hien thi
            Control[] con = container.Controls.Find("tuasach", false);
            con[0].BringToFront();
        }

        /// <summary>
        /// Ham xu li khi chuyen sang tab Cuon sach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCuonsach_Click_1(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("cuonsach", false);
            con[0].BringToFront();
        }

        private void butTacGia_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("tacgia", false);
            con[0].BringToFront();
        }

        private void butTheLoai_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("theloai", false);
            con[0].BringToFront();
        }
    }
}
