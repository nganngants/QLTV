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
            labelMaCS.Text +=" "+ PhieuMuon.CUONSACH.MaCuonSach;
            labelTenCS.Text += PhieuMuon.CUONSACH.SACH.TUASACH.TenTuaSach;
            labelSoPhieu.Text += PhieuMuon.SoPhieuMuonTra;
            labelNgayMuon.Text = ((DateTime)PhieuMuon.NgayMuon).ToShortDateString();
            labelHanTra.Text = ((DateTime)PhieuMuon.HanTra).ToShortDateString();
            labelHoTen.Text +=" "+ PhieuMuon.DOCGIA.TenDocGia;
            labelMaDG.Text +=": " +PhieuMuon.DOCGIA.MaDocGia;
            labelTheLoai.Text += PhieuMuon.CUONSACH.SACH.TUASACH.THELOAI.TenTheLoai;
            labelTongNoHienTai.Text += PhieuMuon.DOCGIA.TongNoHienTai.ToString();
            if(PhieuMuon.NgayTra !=null)
            {
                dateNgayTra.Visible= false;
                labelNgayTra.Visible = true;
                labelNgayTra.Text = ((DateTime)PhieuMuon.NgayTra).ToShortDateString();
                butSave.Visible = false;
                isDaTra.CheckState = CheckState.Checked;
                isDaTra.Enabled =false;
            }
            if (PhieuMuon.NgayTra != null) dateNgayTra.Value = (DateTime)PhieuMuon.NgayTra;
            else
            dateNgayTra.Value = DateTime.Now.Date;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            labelDonGiaPhat.Text += thamso.DonGiaPhat.ToString();
            int TienPhat = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            labelSoNgayTre.Text = "Số ngày trả trễ: " +TienPhat.ToString();
            labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * TienPhat).ToString();
            labelTongNoMoi.Text = "Tổng nợ mới: " + ((int)PhieuMuon.DOCGIA.TongNoHienTai + thamso.DonGiaPhat * TienPhat).ToString();
        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (isDaTra.Checked == true)
            {
                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                int TienPhat = 0;
                if (dateNgayTra.Value > PhieuMuon.HanTra)
                    TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
                labelSoNgayTre.Text = "Số ngày trả trễ: " + TienPhat.ToString();
                labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * TienPhat).ToString();
                labelTongNoMoi.Text = "Tổng nợ mới: " + ((int)PhieuMuon.DOCGIA.TongNoHienTai + thamso.DonGiaPhat * TienPhat).ToString();
            }
        }

        private void isDaTra_CheckedChanged(object sender, EventArgs e)
        {
            if(isDaTra.Checked == true) 
            {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            int TienPhat = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            labelSoNgayTre.Text = "Số ngày trả trễ: " + TienPhat.ToString();
            labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * TienPhat).ToString();
            labelTongNoMoi.Text = "Tổng nợ mới: " + ((int)PhieuMuon.DOCGIA.TongNoHienTai+ thamso.DonGiaPhat * TienPhat).ToString();
            }
            else
            {
                labelSoNgayTre.Text = "Số ngày trả trễ: ";
                labelTienPhat.Text = "Tiền phạt: ";
                labelTongNoMoi.Text = "Tổng nợ mới: ";
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (isDaTra.Checked == false) return; 
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            if (dateNgayTra.Value < PhieuMuon.NgayMuon)
            {
                MessageBox.Show("Ngày trả không được trước ngày mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            string err = BUSPhieuMuonTra.Instance.UpdPhieuMuonTra(PhieuMuon.SoPhieuMuonTra, dateNgayTra.Value.Date);
            
            if(err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int TienPhat = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            err = BUSDocGia.Instance.UpdTongNo(PhieuMuon.DOCGIA.ID, (int)PhieuMuon.DOCGIA.TongNoHienTai + (int)(thamso.DonGiaPhat * TienPhat));
            MessageBox.Show("Đã cập nhật phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
