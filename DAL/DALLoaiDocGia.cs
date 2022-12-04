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
        public List<LOAIDOCGIA> GetAllLoaiDocgia ()
        {
            return QLTVDb.Instance.LOAIDOCGIAs.ToList();
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
        /// return LOAIDOCGIA object match with the input maLoaiDocGia
        /// </summary>
        /// <param name="maLoaiDocGia"></param>
        /// <returns>LOAIDOCGIA</returns>
        public LOAIDOCGIA GetLoaiDocGia (string maLoaiDocGia)
        {
            return QLTVDb.Instance.LOAIDOCGIAs.Find(maLoaiDocGia);
        }
        
        /// <summary>
        /// return a list of LOAIDOCGIA objects match with the input tenLoaiDocGia
        /// </summary>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns>List<LOAIDOCGIA></returns>
        public List<LOAIDOCGIA> FindLoaiDocGia(string tenLoaiDocGia)
        {
            return QLTVDb.Instance.LOAIDOCGIAs.Where(i => i.TenLoaiDocGia == tenLoaiDocGia).Select(i => i).ToList();
        }

        /// <summary>
        /// update tenLoaiDocGia property of the LOAIDOCGIA object matching the input maLoaiDocGia
        /// </summary>
        /// <param name="maLoaiDocGia"></param>
        /// <param name="tenLoaiDocGia"></param>
        /// <returns>true if successfully updated, false otherwise</returns>
        public bool UpdLoaiDocGia (string maLoaiDocGia, string tenLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA ldg = QLTVDb.Instance.LOAIDOCGIAs.Find(maLoaiDocGia);
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

        public bool DelLoaiDocGia(string maLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA ldg = QLTVDb.Instance.LOAIDOCGIAs.Find(maLoaiDocGia);
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
