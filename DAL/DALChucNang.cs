using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChucNang
    {

        public QLTVDb db;

        public DALChucNang(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALChucNang()
        {
            db = new QLTVDb();
        }

        private static DALChucNang instance;

        public static DALChucNang Instance
        {
            get
            {
                if (instance == null) instance = new DALChucNang();
                return instance;
            }
            set => instance = value;
        }

        public List<CHUCNANG> GetAllChucNang()
        {
            var dsChucNang = db.CHUCNANGs.Select(s => new
            {
                s.id

            }).ToList();

            var chucnangs = new List<CHUCNANG>();

            foreach (var b in dsChucNang)
            {
                CHUCNANG chucnang = db.CHUCNANGs.Find(b.id);
                chucnangs.Add(chucnang);
            }

            return chucnangs;
        }

        public CHUCNANG GetChucNangById (int id)
        {
            CHUCNANG chucNang = db.CHUCNANGs.FirstOrDefault(p => p.id == id);
            return chucNang;
        }

        public CHUCNANG GetChucNangByMa(string ma)
        {
            CHUCNANG chucNang = db.CHUCNANGs.FirstOrDefault(p => p.MaChucNang == ma);
            return chucNang;
        }

        
    }
}
