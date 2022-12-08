using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    internal class BUSPhieuMuonTra
    {
        private static BUSPhieuMuonTra instance;
        public static BUSPhieuMuonTra Instance
        {
            get
            {
                if (instance == null) instance = new BUSPhieuMuonTra();
                return instance;
            }
            set => instance = value;
        }
        public string AddPhieuMuonTra(string MaCuonSach, string MaDocGia, DateTime NgayMuon)
        {
            CUONSACH cs;
            DOCGIA dg;
            if (NgayMuon > DateTime.Now) return "Ngày mượn không hợp lệ.";
            try
            {
                 cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            }
            catch
            {
                return "Thông tin sách không hợp lệ";
            }
            try
            {
                dg = DALDocGia.Instance.GetDocGiaByMa(MaDocGia);
            }
            catch
            {
                return "Thông tin độc giả không hợp lệ";
            }
            THAMSO thamso = DALThamSo.instance.GetAllThamSo();
            //System.TimeSpan duration = new System.TimeSpan(thamso.ThoiHanMuonSach, 0, 0, 0);
            DateTime HanTra = NgayMuon.AddDays(thamso.ThoiHanMuonSach);
            if (cs.TinhTrang == 1) return "Cuốn sách đã được mượn!";
            if (DALPhieuMuonTra.Instance.AddPhieuMuonTra(dg.ID, cs.id, NgayMuon, HanTra))
                return "";
            return "Không thể thêm phiếu mượn.";
        }
        public string DelPhieuMuon(int id)
        { 
            PHIEUMUONTRA pm;
            try
            {
                pm = DALPhieuMuonTra.Instance.GetPhieuMuonTraById(id);
            }
            catch
            {
                return "Số phiếu mượn không hợp lệ";
            }
            if (pm.NgayTra == null)
                return "Không thể xoá phiếu mượn vì còn sách chưa trả.";
            if (DALPhieuMuonTra.Instance.DelPhieuMuonTra(id))
                return "";
            return "Không thể xoá phiếu mượn.";
        }
        public string UpdPhieuMuonTra(int MaPhieuMuon,DateTime NgayTra) 
        {
            PHIEUMUONTRA pm;
            try
            {
            pm = DALPhieuMuonTra.Instance.GetPhieuMuonTraById(MaPhieuMuon);
            }
            catch
            {
                return "Số phiếu mượn không hợp lệ";
            }
            if(pm.NgayTra != null)
            {
                return "Phiếu mượn đã được trả";
            }
            if (NgayTra > DateTime.Now)
                return "Ngày trả không hợp lệ.";
            int SoNgayTraTre = ((TimeSpan)(NgayTra - pm.HanTra)).Days;
            THAMSO ts = DALThamSo.Instance.GetAllThamSo();
            int TienPhat = (SoNgayTraTre * ts.DonGiaPhat)*(NgayTra > pm.HanTra);
            if (DALPhieuMuonTra.Instance.UpdPhieuMuonTra(MaPhieuMuon,pm.NgayMuon,pm.HanTra,DateTime.Now, TienPhat))
                return "";
            return "Lỗi không thể cập nhật phiếu mượn.";
        }
        public List<PHIEUMUONTRA> GetPHIEUMUONTRA()
        {
            return DALPhieuMuonTra.Instance.GetAllPhieuMuonTra();
        }
    }
}
