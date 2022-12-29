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

namespace GUI.UserControls
{
    public partial class ucHome_TTTK : UserControl
    {
        private static DOCGIA dg;
        private static NGUOIDUNG user;

        public ucHome_TTTK(int idNguoiDung)
        {
            InitializeComponent();
            dg = BUSDocGia.Instance.FindDocGiaByIdND(idNguoiDung);
            user = BUSNguoiDung.Instance.GetNguoiDungById(idNguoiDung);
            Binding();
        }

        private void Binding()
        {
            labelMaDG.Text = dg.MaDocGia;
            labelLoaiDG.Text = dg.LOAIDOCGIA.TenLoaiDocGia;
            labelDiaChi.Text = dg.DiaChi;
            labelEmail.Text = dg.Email;
            labelHoTen.Text = dg.TenDocGia;
            labelNgayHetHan.Text = dg.NgayHetHan.ToShortDateString();
            labelNgayLapThe.Text = dg.NgayLapThe.ToShortDateString();
            labelNgaySinh.Text = dg.NgaySinh.ToShortDateString();
            labelTenDangNhap.Text = "Tên đăng nhập: " + user.TenDangNhap;
            labelTongNo.Text = dg.TongNoHienTai.ToString();
            var phieumuonList = BUSPhieuMuonTra.Instance.FindPhieuMuonByDocGia(dg.ID);
            foreach (var pm in phieumuonList)
            {
                string nt;
                if (pm.NgayTra == null) nt = "Chưa trả";
                else nt = pm.NgayTra.Value.ToShortDateString();
                PhieuMuonGrid.Rows.Add(pm.SoPhieuMuonTra, pm.CUONSACH.MaCuonSach,
                    pm.CUONSACH.SACH.TUASACH.TenTuaSach, pm.NgayMuon.ToShortDateString(), pm.HanTra.ToShortDateString(),
                   nt, pm.SoTienPhat);
            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fChangePassword(user.id);
            f.ShowDialog();

        }
    }
}
