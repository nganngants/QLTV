using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            THAMSO thamso = DALThamSo.instance.GetAllThamSo();
            //System.TimeSpan duration = new System.TimeSpan(thamso.ThoiHanMuonSach, 0, 0, 0);
            DateTime HanTra = NgayMuon.AddDays(thamso.ThoiHanMuonSach);
            CUONSACH cs = DAlCuonSach.Instance.GetCuonSach(MaCuonSach);
            if (cs.TinhTrang == 1) return "Cuốn sách đã được mượn!";
            if (DALPhieuMuonTra.Instance.AddPhieuMuonTra(MaCuonSach, MaDocGia, NgayMuon, HanTra)
                return "";
            return "Không thể thêm phiếu mượn.";
        }
        public string DelPhieuMuon(string MaPhieuMuon)
        {
            PHIEUMUONTRA pm = DAlPhieuMuonTra.Instance.GetPhieuMuonTra(MaPhieuMuon);
            if(pm.NgayTra == null)
                return "Không thể xoá phiếu mượn vì còn sách chưa trả."
            if (DALPhieuMuonTra.Instance.DelPhieuMuonTra(MaPhieuMuon))
                return "";
            return "Không thể xoá phiếu mượn.";
        }
        public string UpdPhieuMuonTra(string MaPhieuMuon) 
        {
            PHIEUMUONTRA pm = DAlPhieuMuonTra.Instance.GetPhieuMuonTra(MaPhieuMuon);
            if(pm.NgayTra != null)
            {
                return "Phiếu mượn đã được trả";
            }
            int SoNgayTraTre = (DateTime.Now - pm.HanTra).TotalDays;
            THAMSO ts = DALThamSo.Instance.GetAllThamSo();
            int TienPhat = (SoNgayTraTre * ts.DonGiaPhat)*(DateTime.Now > pm.HanTra);
            if (DAlPhieuMuonTra.Instance.UpdPhieuMuonTra(MaPhieuMuon, DateTime.Now, TienPhat))
                return "";
            return "Lỗi không thể cập nhật phiếu mượn.";
        }
        public List<PHIEUMUONTRA> GetPHIEUMUONTRA()
        {
            return DAlPhieuMuonTra.Instance.GetAllPhieuMuonTra();
        }
    }
}
