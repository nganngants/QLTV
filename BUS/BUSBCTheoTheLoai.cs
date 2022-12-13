using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace BUS
{
     public class BUSBCTheoTheLoai
    {
        private static BUSBCTheoTheLoai instance;
        public static BUSBCTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSBCTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }
        public List<BCLUOTMUONTHEOTHELOAI> GetAllBC()
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetAllBaoCao();
        }
        public string AddBC(DateTime NgayLap)
        {
            int thang = NgayLap.Month;
            int nam = NgayLap.Year;
            if (NgayLap > DateTime.Now) return "Ngày báo cáo không hợp lệ";
            if (DALBCLuotMuonTheoTheLoai.Instance.AddBaoCao(thang, nam))
            {
                List<BCLUOTMUONTHEOTHELOAI> bc = DALBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(thang, nam);
                List<THELOAI> ltl = DALTheLoai.Instance.GetAllTheLoai();
                foreach (THELOAI tl in ltl)
                {
                    if (BUSCT_BCLuotMuonTheoThang.Instance.AddCT_BCLuotMuon(bc[0].id, tl.id, thang, nam) == "")
                        continue;
                }    
            }    
            return "KHông thể lập báo cáo";
        }
        public string DelBC(string Mabc)
        {
            BCLUOTMUONTHEOTHELOAI bc = DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoByMa(Mabc);
            if(bc == null )
            {
                return "Mã báo cáo không hợp lệ";
            }
            if (DALBCLuotMuonTheoTheLoai.Instance.DelBaoCao(bc.id))
                return "";
            return "Lỗi khi xoá báo cáo ";
        }
        
    }
}
