using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLoaiDocGia
    {
        public  QLTVDb db;

        public DALLoaiDocGia(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALLoaiDocGia()
        {
            db = new QLTVDb();
        }
        private static DALLoaiDocGia instance;

        public static DALLoaiDocGia Instance
        { 
            get
            {
                if (instance == null) instance = new DALLoaiDocGia();
                return instance;
            }
            set => instance = value;
        }

        /// <summary>
        /// get a list of all LOAIDOCGIA objects
        /// </summary>
        /// <returns> List <LOAIDOCGIA> </returns>
        public List<LOAIDOCGIA> GetAllLoaiDocGia ()
        {
            return db.LOAIDOCGIAs.ToList();
        }

        /// <summary>
        /// Add new LOAIDOCGIA object
        /// </summary>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns></returns>
        public bool AddLoaiDocGia (LOAIDOCGIA loaiDocGia)
        {
            db.LOAIDOCGIAs.Add(loaiDocGia);
            db.SaveChanges();
            return true;
        }
        /// <summary>
        /// Get LOAIDOCGIA by input id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LOAIDOCGIA GetLoaiDocGiaById (int id)
        {
            return db.LOAIDOCGIAs.Find(id);
        }
        /// <summary>
        /// return LOAIDOCGIA object match with the input maLoaiDocGia
        /// </summary>
        /// <param name="maLoaiDocGia"></param>
        /// <returns>LOAIDOCGIA</returns>
        public LOAIDOCGIA GetLoaiDocGiaByMa (string maLoaiDocGia)
        {
            LOAIDOCGIA loaiDocGia = db.LOAIDOCGIAs.FirstOrDefault(p => p.MaLoaiDocGia == maLoaiDocGia);
            return loaiDocGia;
        }
        
        /// <summary>
        /// return a list of LOAIDOCGIA objects match with the input tenLoaiDocGia
        /// </summary>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns>List<LOAIDOCGIA></returns>
        public List<LOAIDOCGIA> FindLoaiDocGia(string tenLoaiDocGia)
        {
            return db.LOAIDOCGIAs.Where(i => i.TenLoaiDocGia == tenLoaiDocGia).ToList();
        }

        /// <summary>
        /// update tenLoaiDocGia property of the LOAIDOCGIA object matching the input maLoaiDocGia
        /// </summary>
        /// <param name="maLoaiDocGia"></param>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns>true if successfully updated, false otherwise</returns>
        public bool UpdLoaiDocGia (int id, string tenLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA ldg = GetLoaiDocGiaById(id);
                if (ldg == null) return false;
                if (tenLoaiDocGia != null) ldg.TenLoaiDocGia = tenLoaiDocGia;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelLoaiDocGia(int id)
        {
            try
            {
                LOAIDOCGIA ldg = GetLoaiDocGiaById(id);
                if (ldg == null) return false;
                db.LOAIDOCGIAs.Remove(ldg);
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
