using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTheLoai
    {
        public QLTVDb db;

        public DALTheLoai(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALTheLoai()
        {
            db = new QLTVDb();
        }

        private static DALTheLoai instance;

        public static DALTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<THELOAI> GetAllTheLoai()
        {
            return  db.THELOAIs.ToList();
        }

        /// <summary>
        /// get THELOAI by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public THELOAI GetTheLoaiById (int id)
        {
            return db.THELOAIs.Find(id);
        }

        /// <summary>
        /// get THELOAI by MaTheLoai
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <returns></returns>
        public THELOAI GetTheLoaiByMa(string maTheLoai)
        {
            THELOAI theLoai = db.THELOAIs.FirstOrDefault(p => p.MaTheLoai == maTheLoai);
            return theLoai;
        }

        /// <summary>
        /// Find THELOAI by filter
        /// </summary>
        /// <param name="tenTheLoai"></param>
        /// <returns></returns>
        public List<THELOAI> FindTheLoai(string tenTheLoai)
        {
            return db.THELOAIs.Where(t => t.TenTheLoai == tenTheLoai).Select(t => t).ToList();
        }

        public bool AddTheLoai(THELOAI theLoai)
        {
            db.THELOAIs.Add(theLoai);
            db.SaveChanges();
            return true;
        }

        public bool UpdTheLoai(int id, string tenTheLoai)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                theloai.TenTheLoai = tenTheLoai;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTheLoai(int id)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                db.THELOAIs.Remove(theloai);
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
