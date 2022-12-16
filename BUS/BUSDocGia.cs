using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
     public class BUSDocGia
    {
        private static BUSDocGia instance;
        public static BUSDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSDocGia();
                return instance;
            }
            set => instance = value;     
        }
        public List<DOCGIA> GetAllDocGia()
        {
            return DALDocGia.Instance.GetAllDocGia();
        }
        public DOCGIA GetDocGia(string MaDocGia)
        {
            DOCGIA dg;
            try
            {
               dg =  DALDocGia.Instance.GetDocGiaByMa(MaDocGia);
                return dg;
            }
            catch
            {
                return null;
            }
        }
        public int GetSoSachDangMuon(int id)
        {
            int cnt = 0;
            DOCGIA dg = DALDocGia.Instance.GetDocGiaById(id);
            foreach (PHIEUMUONTRA pmt in dg.PHIEUMUONTRAs)
                if (pmt.NgayTra == null)
                    cnt++;
            return cnt;
        }
        public string DelDocGia(string MaDocGia)
        {
            DOCGIA dg;
            try
            {
            dg = DALDocGia.Instance.GetDocGiaByMa(MaDocGia);
            }
            catch
            {
                return "Mã độc giả không hợp lệ";
            }
            foreach( PHIEUMUONTRA PhieuMuon in dg.PHIEUMUONTRAs)
            {
                if(PhieuMuon.NgayTra==null)
                return "Độc giả còn sách đang mượn";
            }
            DALDocGia.Instance.DelDocGia(dg.ID);
            return "";
        }
    }
}
