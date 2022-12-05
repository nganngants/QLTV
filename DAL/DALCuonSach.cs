using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCuonSach
    {
        private static DALCuonSach instance;
        public static DALCuonSach Instance 
        { 
            get
            {
                if (instance == null) instance = new DALCuonSach();
                return instance;
            }
            set => instance = value; 
        }

        public List<CUONSACH> GetAllCuonSach()
        {
            return QLTVDb.Instance.CUONSACHes.ToList();
        }
        /// <summary>
        /// Get CUONSACH by Id
        /// </summary>
        /// <param name="maCuonSach"></param>
        /// <returns></returns>
        public CUONSACH GetCuonSach (string maCuonSach)
        {
            return QLTVDb.Instance.CUONSACHes.Find(maCuonSach);
        }

        /// <summary>
        /// Find CUONSACHs by filter
        /// </summary>
        /// <param name="sach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public List<CUONSACH> FindCuonSach (SACH sach, int? tinhTrang)
        {
            List<CUONSACH> res = GetAllCuonSach();
            if (sach != null) res = res.Where(c => c.SACH == sach).ToList();
            if (tinhTrang != null) res = res.Where(c => c.TinhTrang == tinhTrang).ToList();
            return res;
        }

        public bool AddCuonSach (SACH sach, int tinhTrang)
        {
            try
            {
                CUONSACH cuonsach = new CUONSACH
                {
                    MaSach = sach.MaSach,
                    SACH = sach,
                    TinhTrang = tinhTrang
                };
                QLTVDb.Instance.CUONSACHes.Add(cuonsach);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdCuonSach(string maCuonSach, int? tinhTrang)
        {
            try
            {
                CUONSACH cuonsach = GetCuonSach(maCuonSach);
                if (cuonsach == null) return false;
                if (tinhTrang != null) cuonsach.TinhTrang = tinhTrang;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelCuonSach(string maCuonSach)
        {
            try
            {
                var cuonSach = GetCuonSach(maCuonSach);
                if (cuonSach == null) return false;
                QLTVDb.Instance.CUONSACHes.Remove(cuonSach);
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
