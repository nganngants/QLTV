using BUS;
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
            butTuaSach_Click(this, EventArgs.Empty);
        }

        private ucSach ucsach;
        private ucTuaSach uctuaSach;
        private ucCuonSach uccuonSach;
        private ucTheLoai uctheLoai;
        private ucTacGia uctacGia;
        private ucPhieuNhap ucphieuNhap;
        private void InitializeContainer()
        {
            // add ca 3 UC Sach, Cuon sach va Tua sach vao container
            ucsach = new ucSach() { Dock = DockStyle.Fill, Name = "sach" };
            uctuaSach = new ucTuaSach() { Dock = DockStyle.Fill, Name = "tuasach" };
            uccuonSach = new ucCuonSach() { Dock = DockStyle.Fill, Name = "cuonsach" };
            uctacGia = new ucTacGia() { Dock = DockStyle.Fill, Name = "tacgia" };
            uctheLoai = new ucTheLoai() { Dock = DockStyle.Fill, Name = "theloai" };
            ucphieuNhap = new ucPhieuNhap() { Dock = DockStyle.Fill, Name = "phieunhap" };
            container.Controls.Add(ucsach);
            container.Controls.Add(uctuaSach);
            container.Controls.Add(uccuonSach);
            container.Controls.Add(uctacGia);
            container.Controls.Add(uctheLoai);
            container.Controls.Add(ucphieuNhap);
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
            ucsach.Binding(BUSSach.Instance.GetAllSach());
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
            uctuaSach.Binding(BUSTuaSach.Instance.GetAllTuaSach());
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
            uccuonSach.Binding(BUSCuonSach.Instance.GetAllCuonSach());
            con[0].BringToFront();
            //con[0].
        }

        private void butTacGia_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("tacgia", false);
            uctacGia.Binding();
            con[0].BringToFront();
        }

        private void butTheLoai_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("theloai", false);
            con[0].BringToFront();
        }

        private void butPhieuNhap_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("phieunhap", false);
            ucphieuNhap.Binding(BUSPhieuNhap.Instance.GetAllPhieuNhap());
            con[0].BringToFront();
        }
    }
}
