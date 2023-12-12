using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCT_BCLuotMuonTheoTheLoai
    {
        public QLTVDb db;

        public DALCT_BCLuotMuonTheoTheLoai(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALCT_BCLuotMuonTheoTheLoai()
        {
            db = new QLTVDb();
        }

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
            var dsCTBC = db.CT_BCLUOTMUONTHEOTHELOAI.Select(s => new
            {
                s.idBaoCao

            }).ToList();

            var baocaos = new List<CT_BCLUOTMUONTHEOTHELOAI>();

            foreach (var b in dsCTBC)
            {
                CT_BCLUOTMUONTHEOTHELOAI baocao = db.CT_BCLUOTMUONTHEOTHELOAI.Find(b.idBaoCao);
                baocaos.Add(baocao);
            }

            return baocaos;
        }

        public CT_BCLUOTMUONTHEOTHELOAI GetCTBC (int idBC, int idTheLoai)
        {
            CT_BCLUOTMUONTHEOTHELOAI ctbc = db.CT_BCLUOTMUONTHEOTHELOAI.FirstOrDefault(p => p.idBaoCao == idBC && p.idTheLoai == idTheLoai);
            return ctbc;
        }

        public bool AddCTBC (CT_BCLUOTMUONTHEOTHELOAI ctbc)
        {
            db.CT_BCLUOTMUONTHEOTHELOAI.Add(ctbc);
            db.SaveChanges();
            return true;
        }

        public bool UpdCTBC (int idBC, int idTL, int soLuotMuon)
        {
            try
            {
                var ct = GetCTBC(idBC, idTL);
                if (ct == null) return false;
                ct.SoLuotMuon = soLuotMuon;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool DelCTBC (int idBC, int idTL)
        {
            try
            {
                var ct = GetCTBC(idBC, idTL);
                if (ct == null) return false;

                db.CT_BCLUOTMUONTHEOTHELOAI.Remove(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
             
                return false;
            }
        }
    }
}
