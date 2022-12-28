using GUI;
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
    public partial class ucQLND : UserControl
    {
        public ucQLND()
        {
            InitializeComponent();
            InitializeContainer();
            butNguoiDung.Checked = true;
            
        }
        private void InitializeContainer()
        {

            // add ca 2 UC DG va LoaiDG vao container
            container.Controls.Add(new ucNguoiDung() { Dock = DockStyle.Fill, Name = "nguoidung" });
            container.Controls.Add(new ucNhomND() { Dock = DockStyle.Fill, Name = "nhomnd" });

        }

        private void butNguoiDung_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("nguoidung", false);
            con[0].BringToFront();
        }

        private void butNhomND_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("nhomnd", false);
            con[0].BringToFront();
        }
    }
}
