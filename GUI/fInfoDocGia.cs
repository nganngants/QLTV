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
    public partial class fInfoDocGia : Form
    {
        DOCGIA DocGia;
        public fInfoDocGia(int _id)
        {
            InitializeComponent();
            DocGia = BUSDocGia.Instance.GetDocGia(_id);
            Binding();
        }
        private void fInfoDocGia_Load(object sender, EventArgs e)
        {
            
        }
        private void Binding()
        {
            PhieuMuonGrid.Rows.Clear();
            foreach(PHIEUMUONTRA pmt in DocGia.PHIEUMUONTRAs)
            {
                DateTime NgayMuon = (DateTime)(pmt.NgayMuon);
                string NgayTra = "Chưa trả";
                if (pmt.NgayTra != null)
                NgayTra = ((DateTime)(pmt.NgayTra)).ToShortDateString();
                
                DateTime HanTra = (DateTime)(pmt.HanTra);

                PhieuMuonGrid.Rows.Add(pmt.SoPhieuMuonTra, pmt.CUONSACH.MaCuonSach, pmt.CUONSACH.SACH.TUASACH.TenTuaSach, NgayMuon.ToShortDateString(), HanTra.ToShortDateString(), NgayTra, pmt.SoTienPhat);
            }
            labelMaDG.Text = DocGia.MaDocGia;
            labelHoTen.Text = DocGia.TenDocGia;
            labelEmail.Text = DocGia.Email;
            labelMaLoaiDG.Text = DocGia.LOAIDOCGIA.TenLoaiDocGia;
            labelDiaChi.Text = DocGia.DiaChi;
            labelNgayLapThe.Text = DocGia.NgayLapThe.ToShortDateString();
            labelNgayHetHan.Text = DocGia.NgayHetHan.ToShortDateString();
            labelNgaySinh.Text = DocGia.NgaySinh.ToShortDateString();
            labelTongNo.Text = DocGia.TongNoHienTai.ToString();
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditDocGia(DocGia.ID);
            f.ShowDialog();
            Binding();
        }

        private void PhieuMuonGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (e.ColumnIndex == 0) return;
            if (idx == -1) return;
            var f = new fEditPhieuMuon((Convert.ToInt32(PhieuMuonGrid.Rows[idx].Cells["SoPhieuMuon"].Value)));
            f.ShowDialog();
            Binding();
            return;
        }
    }
}
