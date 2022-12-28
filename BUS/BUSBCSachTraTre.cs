using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUSBCSachTraTre
     {
        private static BUSBCSachTraTre instance;
        public static BUSBCSachTraTre Instance
        {
            get
            {
                if (instance == null) instance = new BUSBCSachTraTre();
                return instance;
            }
            set => instance = value;
        }
        public List<BCSACHTRATRE> GetAllBC()
        {
            return DALBCSachTraTre.Instance.GetAllBaoCao();
        }
        public string AddBaoCao(DateTime NgayBC)
        {
            if (NgayBC > DateTime.Now) return "Ngày báo cáo không hợp lệ";
            List<PHIEUMUONTRA> lpmt = DALPhieuMuonTra.Instance.FindPhieuMuonTre(NgayBC);
            if (!lpmt.Any()) return "Không có sách trả trễ trong ngày này";
            foreach(PHIEUMUONTRA pmt in lpmt )
            {
                if(pmt.NgayTra == null)
                {
                    int SoNgayTraTre = ((TimeSpan)(NgayBC - pmt.HanTra)).Days;
                     DALBCSachTraTre.Instance.AddBaoCao(NgayBC, (int)pmt.idCuonSach,(DateTime)pmt.NgayMuon,SoNgayTraTre);
                }
            }
            return "";
        }
        public string DelBaoCao(DateTime NgayBC)
        {
            List<BCSACHTRATRE> lbc = DALBCSachTraTre.Instance.FindBaoCaoByDate(NgayBC).ToList();
            if (lbc.Count == 0) return "Chưa có báo cáo nào vào ngày này";
            foreach (BCSACHTRATRE bc in lbc)
            {
                if (DALBCSachTraTre.Instance.DelBaoCao(NgayBC, bc.idCuonSach))
                    continue;
                return "Lỗi";
            }
            return "";
        }
        public List<BCSACHTRATRE>GetBaoCao(DateTime NgayBC)
        {
            List<BCSACHTRATRE> lbc = DALBCSachTraTre.Instance.FindBaoCaoByDate(NgayBC);
            if (lbc.Count == 0) return null;
            return lbc;
        }
     }
}
