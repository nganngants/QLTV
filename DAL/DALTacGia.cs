using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {

        public QLTVDb db;

        public DALTacGia(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALTacGia()
        {
            db = new QLTVDb();
        }

        private static DALTacGia instance;

        public static DALTacGia Instance 
        { 
            get
            {
                if (instance == null) instance = new DALTacGia();
                return instance;
            }
            set => instance = value; 
        }

        public List<TACGIA> GetAllTacGia()
        {
            var dsTacGia = db.TACGIAs.Select(s => new
            {
                s.id

            }).ToList();

            var tacgias = new List<TACGIA>();

            foreach (var b in dsTacGia)
            {
                TACGIA tacgia = db.TACGIAs.Find(b.id);
                tacgias.Add(tacgia);
            }

            return tacgias;
        }

        public TACGIA GetTacGiaById (int id)
        {
            return db.TACGIAs.Find(id);
        }

        /// <summary>
        /// get TACGIA by maTacGia
        /// </summary>
        /// <param name="maTacGia"></param>
        /// <returns></returns>
        public TACGIA GetTacGiaByMa(string maTacGia)
        {
            TACGIA tacgia = db.TACGIAs.FirstOrDefault(p => p.MATACGIA == maTacGia);
            return tacgia;
        }

        /// <summary>
        /// find TACGIA by filter 
        /// </summary>
        /// <param name="tenTacGia"></param>
        /// <returns></returns>
        public List<TACGIA> FindTacGia(string tenTacGia)
        {
            return db.TACGIAs.Where(t => t.TenTacGia == tenTacGia).Select(t => t).ToList();
        }
        public int AddTacGia (TACGIA tacgia)
        {
            db.TACGIAs.Add(tacgia);
            db.SaveChanges();
            return tacgia.id;
        }

        public bool UpdTacGia(int id, string tenTacGia)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                tacgia.TenTacGia = tenTacGia;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTacGia(int id)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                db.TACGIAs.Remove(tacgia);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
