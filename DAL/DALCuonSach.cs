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
        public QLTVDb db;

        public DALCuonSach(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALCuonSach()
        {
            db = new QLTVDb();
        }

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
        public bool UpdAnCuonSach(int id,int data)
        {
            try
            {
                CUONSACH cuonsach = db.CUONSACHes.Find(id);
                SACH sach = cuonsach.SACH;
                
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }
        public List<CUONSACH> GetAllCuonSach()
        {
            var dsCuonSach = db.CUONSACHes.Select(s => new
            {
                s.id

            }).ToList();

            var cuonSaches = new List<CUONSACH>();

            foreach (var b in dsCuonSach)
            {
                CUONSACH cuonsach = db.CUONSACHes.Find(b.id);
                cuonSaches.Add(cuonsach);
            }

            return cuonSaches;
        }
        /// <summary>
        /// Get CUONSACH by Id
        /// </summary>
        /// <param name="idCuonSach"></param>
        /// <returns></returns>
        public CUONSACH GetCuonSachById (int idCuonSach)
        {
            return db.CUONSACHes.Find(idCuonSach);
        }

        /// <summary>
        /// Get CUONSACH by Ma
        /// </summary>
        /// <param name="maCuonSach"></param>
        /// <returns></returns>
        public CUONSACH GetCuonSachByMa(string maCuonSach)
        {
            CUONSACH cuonsach = db.CUONSACHes.FirstOrDefault(p => p.MaCuonSach == maCuonSach);
            return cuonsach;
        }

        /// <summary>
        /// Find CUONSACHs by filter
        /// </summary>
        /// <param name="sach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>


        public bool AddCuonSach (CUONSACH cuonSach)
        {
            db.CUONSACHes.Add(cuonSach);
            db.SaveChanges();
            return true;
        }

        public bool UpdCuonSach(int idCuonSach, int? tinhTrang)
        {
            try
            {
                CUONSACH cuonsach = GetCuonSachById(idCuonSach);
                if (cuonsach == null) return false;
                SACH sach = cuonsach.SACH;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelCuonSach(int idCuonSach)
        {
            try
            {
                var cuonSach = GetCuonSachById(idCuonSach);
                if (cuonSach == null) return false;
                var sach = cuonSach.SACH;
                db.CUONSACHes.Remove(cuonSach);
               
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
