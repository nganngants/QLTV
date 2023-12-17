using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DALCTPhieuNhap
    {

        public QLTVDb db;

        public DALCTPhieuNhap(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALCTPhieuNhap()
        {
            db = new QLTVDb();
        }


        private static DALCTPhieuNhap instance;

        public static DALCTPhieuNhap Instance 
        {
            get
            {
                if (instance == null) instance = new DALCTPhieuNhap();
                return instance;
            }
            set => instance = value; 
        }

        public List<CT_PHIEUNHAP> GetAllCTPhieuNhap ()
        {
            var dsCTPhieuNhap = db.CT_PHIEUNHAP.Select(s => new
            {
                s.SoPhieuNhap

            }).ToList();

            var phieunhaps = new List<CT_PHIEUNHAP>();

            foreach (var b in dsCTPhieuNhap)
            {
                CT_PHIEUNHAP phieunhap = db.CT_PHIEUNHAP.Find(b.SoPhieuNhap);
                phieunhaps.Add(phieunhap);
            }

            return phieunhaps;
        }

        public CT_PHIEUNHAP GetCT_PHIEUNHAP(int soPhieu, int idSach)
        {
            CT_PHIEUNHAP CTPhieuNhap = db.CT_PHIEUNHAP.FirstOrDefault(p => p.SoPhieuNhap == soPhieu);
            return CTPhieuNhap;
        }

        public bool AddCTPhieuNhap (CT_PHIEUNHAP CTPhieuNhap)
        {
            db.CT_PHIEUNHAP.Add(CTPhieuNhap);
            db.SaveChanges();
            return true;
        }


    }
}
