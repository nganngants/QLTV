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
            return QLTVDb.Instance.LOAIDOCGIAs.AsNoTracking().ToList();
        }

        /// <summary>
        /// Add new LOAIDOCGIA object
        /// </summary>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns></returns>
        public bool AddLoaiDocGia (string tenLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA obj = new LOAIDOCGIA { TenLoaiDocGia = tenLoaiDocGia };
                QLTVDb.Instance.LOAIDOCGIAs.Add(obj);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Get LOAIDOCGIA by input id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LOAIDOCGIA GetLoaiDocGiaById (int id)
        {
            return QLTVDb.Instance.LOAIDOCGIAs.Find(id);
        }
        /// <summary>
        /// return LOAIDOCGIA object match with the input maLoaiDocGia
        /// </summary>
        /// <param name="maLoaiDocGia"></param>
        /// <returns>LOAIDOCGIA</returns>
        public LOAIDOCGIA GetLoaiDocGiaByMa (string maLoaiDocGia)
        {
            var res = QLTVDb.Instance.LOAIDOCGIAs.AsNoTracking().Where(l => l.MaLoaiDocGia == maLoaiDocGia);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        
        /// <summary>
        /// return a list of LOAIDOCGIA objects match with the input tenLoaiDocGia
        /// </summary>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns>List<LOAIDOCGIA></returns>
        public List<LOAIDOCGIA> FindLoaiDocGia(string tenLoaiDocGia)
        {
            return QLTVDb.Instance.LOAIDOCGIAs.AsNoTracking().Where(i => i.TenLoaiDocGia == tenLoaiDocGia).Select(i => i).ToList();
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
                QLTVDb.Instance.SaveChanges();
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
                QLTVDb.Instance.LOAIDOCGIAs.Remove(ldg);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
