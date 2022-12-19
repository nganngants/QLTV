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

namespace GUI
{
    public partial class fEditPhieuMuon : Form
    {
       
        private PHIEUMUONTRA PhieuMuon;
        public fEditPhieuMuon(int idPhieuMuon)
        {
            InitializeComponent();
            PhieuMuon = BUSPhieuMuonTra.Instance.GetPhieuMuonTra(idPhieuMuon);
            init();
        }
        private void init()
        {
            labelMaCS.Text += PhieuMuon.CUONSACH.MaCuonSach;
            labelTenCS.Text += PhieuMuon.CUONSACH.SACH.TUASACH.TenTuaSach;
            labelSoPhieu.Text += PhieuMuon.SoPhieuMuonTra;
            labelNgayMuon.Text += ((DateTime)PhieuMuon.NgayMuon).ToShortDateString();
            labelHanTra.Text += ((DateTime)PhieuMuon.HanTra).ToShortDateString();
            labelHoTen.Text += PhieuMuon.DOCGIA.TenDocGia;
            labelTheLoai.Text += PhieuMuon.CUONSACH.SACH.TUASACH.THELOAI.TenTheLoai;

        }

    }
}
