using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUSCT_BCLuotMuonTheoThang
    {
        private static BUSCT_BCLuotMuonTheoThang instance;
        public static BUSCT_BCLuotMuonTheoThang Instance
        {
            get
            {
                if (instance == null) instance = new BUSCT_BCLuotMuonTheoThang();
                return instance;
            }
            set => instance = value;
        }
        public List<CT_BCLUOTMUONTHEOTHELOAI> GetAllCT_BCLuotMuon()
        {
            return DALCT_BCLuotMuonTheoTheLoai.Instance.GetAllCTBC();
        }
        public string AddCT_BCLuotMuon(int id, int idTL, int month, int year)
        {
            int soLuot = 0;
            THELOAI tl = DALTheLoai.Instance.GetTheLoaiById(idTL);
            List<TUASACH> lts = DALTuaSach.Instance.FindTuaSach(null, tl, null);
            foreach(TUASACH ts in lts)
             foreach(SACH sach in ts.SACHes)
                {
                    foreach(CUONSACH cs in sach.CUONSACHes.ToList())
                    {
                        foreach(PHIEUMUONTRA pmt in cs.PHIEUMUONTRAs)
                        {
                            DateTime nm = (DateTime)pmt.NgayMuon;
                            if (nm.Month == month && nm.Year == year)
                                soLuot++;
                        }
                    }
                }
            if (DALCT_BCLuotMuonTheoTheLoai.Instance.AddCTBC(id, tl.id, soLuot))
                return "";
            return "Lỗi";

        }
    }
}
