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
using BUS;
namespace GUI.BM
{
    public partial class BMQLCuonSach : Form
    {
        private CUONSACH cuonsach;
        public BMQLCuonSach(string MaCuonSach)
        {

            InitializeComponent();
            cuonsach = BUSCuonSach.Instance.GetCuonSach(MaCuonSach);
            CustomLabel();
        }
        public void CustomLabel()
        {
            this.MaCuonSachLabel.Text += " "+ cuonsach.MaCuonSach;
            this.MaSachLabel.Text +=" "+ cuonsach.SACH.MaSach;
            this.TenSachLabel.Text += " " + cuonsach.SACH.TUASACH.TenTuaSach;
            this.TheLoaiLabel.Text += " " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            this.TinhTrangLabel.Text += " " + ((cuonsach.TinhTrang == 0) ? "Chưa được mượn" : "Đã được mượn");
            this.NamXBLabel.Text += " " + cuonsach.SACH.NamXB;
            this.NxbLabel.Text += " " + cuonsach.SACH.NhaXB;
            foreach (TACGIA tg in cuonsach.SACH.TUASACH.TACGIAs)
                this.TacGiaLabel.Text += " " + tg.TenTacGia + ",";
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMQLCuonSach_Load(object sender, EventArgs e)
        {

        }
    }
}
