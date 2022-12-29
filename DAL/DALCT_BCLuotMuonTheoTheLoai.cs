using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCT_BCLuotMuonTheoTheLoai
    {
        private static DALCT_BCLuotMuonTheoTheLoai instance;

        public static DALCT_BCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALCT_BCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<CT_BCLUOTMUONTHEOTHELOAI> GetAllCTBC ()
        {
            return QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.AsNoTracking().ToList();
        }

        public CT_BCLUOTMUONTHEOTHELOAI GetCTBC (int idBC, int idTheLoai)
        {
            return QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.Find(new object[] { idBC, idTheLoai });
        }

        public bool AddCTBC (int idBC, int idTheLoai, int soLuotMuon)
        {
            try
            {
                var ct = new CT_BCLUOTMUONTHEOTHELOAI
                {
                    idBaoCao = idBC,
                    BCLUOTMUONTHEOTHELOAI = DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoById(idBC),
                    idTheLoai = idTheLoai,
                    THELOAI = DALTheLoai.Instance.GetTheLoaiById(idTheLoai),
                    SoLuotMuon = soLuotMuon
                };
                QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.Add(ct);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdCTBC (int idBC, int idTL, int soLuotMuon)
        {
            try
            {
                var ct = GetCTBC(idBC, idTL);
                if (ct == null) return false;
                ct.SoLuotMuon = soLuotMuon;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelCTBC (int idBC, int idTL)
        {
            try
            {
                var ct = GetCTBC(idBC, idTL);
                if (ct == null) return false;

                QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.Remove(ct);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
