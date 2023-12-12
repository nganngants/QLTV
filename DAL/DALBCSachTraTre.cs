using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBCSachTraTre
    {
        public QLTVDb db;

        public DALBCSachTraTre(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALBCSachTraTre()
        {
            db = new QLTVDb();
        }
        private static DALBCSachTraTre instance;

        public static DALBCSachTraTre Instance
        {
            get
            {
                if (instance == null) instance = new DALBCSachTraTre();
                return instance;
            }
            set => instance = value;
        }

        public List<BCSACHTRATRE> GetAllBaoCao ()
        {
            var dsBaoCao = db.BCSACHTRATREs.Select(s => new
            {
                s.idCuonSach

            }).ToList();

            var baocaos = new List<BCSACHTRATRE>();

            foreach (var b in dsBaoCao)
            {
                BCSACHTRATRE baocao = db.BCSACHTRATREs.Find(b.idCuonSach);
                baocaos.Add(baocao);
            }

            return baocaos;
        }

        public BCSACHTRATRE GetBaoCao(DateTime Ngay, int idCuonSach)
        {
            BCSACHTRATRE ctbc = db.BCSACHTRATREs.FirstOrDefault(p => p.Ngay == Ngay);
            return ctbc;
        }

        public List<BCSACHTRATRE> FindBaoCaoByDate(DateTime ngayBC)
        {
            return db.BCSACHTRATREs.Where(b => b.Ngay.Date == ngayBC.Date).ToList();
        }

        public List<BCSACHTRATRE> FindBaoCaoByCuonSach (int idCuonSach)
        {
            return db.BCSACHTRATREs.Where(b => b.idCuonSach == idCuonSach).ToList();   
        }

        public bool AddBaoCao(BCSACHTRATRE baocao)
        {
            db.BCSACHTRATREs.Add(baocao);
            db.SaveChanges();
            return true;
        }

        public bool DelBaoCao (DateTime ngayBC, int idCuonSach)
        {
            try
            {
                var bc = GetBaoCao(ngayBC, idCuonSach);
                if (bc == null) return false;
                db.BCSACHTRATREs.Remove(bc);
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
