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
    public partial class fPhieuMuonSach : Form
    {
        public fPhieuMuonSach()
        {
            InitializeComponent();
            init();
            
        }
        private void init()
        {
            List<CUONSACH> CuonSachList = BUSCuonSach.Instance.GetAllCuonSachAvai();
            comboCuonSach.DataSource = CuonSachList;
            comboCuonSach.DisplayMember = "MaCuonSach";
            comboCuonSach.ValueMember = "id";
            
            var docGiaList = BUSDocGia.Instance.GetAllDocGia();
            comboDocGia.DataSource = docGiaList;
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.ValueMember = "id";
            if (CuonSachList.Count == 0)
                return;
            
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            //Console.WriteLine(Convert.ToInt32(comboCuonSach.SelectedValue));
            labelTenCS.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            if(docGiaList.Count != 0)
            { 
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
            labelTongNoHienTai.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();

            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text =  NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
            }

        }
        private DateTime NgayTra;
        private DateTime NgayMuon;

        

        private void dateNgayMuon_ValueChanged_1(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text =NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
        }

        private void butSave_Click_1(object sender, EventArgs e)
        {
            if (comboCuonSach.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn cuốn sách");
                return;
            }
            if (comboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn độc giả");
                return;
            }

            NgayMuon = dateNgayMuon.Value.Date;
           
            if (NgayMuon > DateTime.Now)
            {
                ErrorDia.Show("Ngày mượn không hợp lệ");
                return;
            }
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            string error = BUSPhieuMuonTra.Instance.AddPhieuMuonTra(cuonsach.MaCuonSach, docgia.MaDocGia, NgayMuon);
            if (error != "")
            {
                ErrorDia.Show(error);
                return;
            }
            SuccDia.Show("Thêm phiếu mượn thành công");
            this.Close();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOCGIA docgia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            if (docgia == null) return;
           
            labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
            labelTongNoHienTai.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();
        }

        private void comboCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSach(Convert.ToInt32(comboCuonSach.SelectedValue));
            if (cuonsach == null) return;
            labelTenCS.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
        }
    }
}
