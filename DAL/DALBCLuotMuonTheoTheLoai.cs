using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBCLuotMuonTheoTheLoai
    {
        public QLTVDb db;

        public DALBCLuotMuonTheoTheLoai(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALBCLuotMuonTheoTheLoai()
        {
            db = new QLTVDb();
        }
        private static DALBCLuotMuonTheoTheLoai instance;

        public static DALBCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALBCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<BCLUOTMUONTHEOTHELOAI> GetAllBaoCao()
        {
            var dsBaoCao = db.BCLUOTMUONTHEOTHELOAIs.Select(s => new
            {
                s.id

            }).ToList();

            var baocaos = new List<BCLUOTMUONTHEOTHELOAI>();

            foreach (var b in dsBaoCao) 
            {
                BCLUOTMUONTHEOTHELOAI tacgia = db.BCLUOTMUONTHEOTHELOAIs.Find(b.id);
                baocaos.Add(tacgia);
            }

            return baocaos;
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoById(int id)
        {
            return db.BCLUOTMUONTHEOTHELOAIs.Find(id);
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoByMa (string ma)
        {
            BCLUOTMUONTHEOTHELOAI baocao = db.BCLUOTMUONTHEOTHELOAIs.FirstOrDefault(p => p.MaBaoCao == ma);
            return baocao;
        }

        public List<BCLUOTMUONTHEOTHELOAI> FindBaoCaoByDate(int? thang, int? nam)
        {
            return db.BCLUOTMUONTHEOTHELOAIs.Where(t => t.Thang == thang && t.Nam == nam).Select(t => t).ToList();
        }
        /// <summary>
        /// Notes: When added BC and its all CT_BCs, you need to call Compute(id) function to compute their values
        /// </summary>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public int AddBaoCao (BCLUOTMUONTHEOTHELOAI bc)
        {
            db.BCLUOTMUONTHEOTHELOAIs.Add(bc);
            db.SaveChanges();
            return bc.id;
        }

        /// <summary>
        /// this function will recompute TongSoLuotMuon for BaoCao and TiLe for each CT_BaoCao
        /// </summary>
        /// <param name="id"></param>
    

        public bool DelBaoCao(int id)
        {
            try
            {
                var bc = GetBaoCaoById(id);
                if (bc == null) return false;

                db.BCLUOTMUONTHEOTHELOAIs.Remove(bc);
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
