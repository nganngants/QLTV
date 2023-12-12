using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSach
    {

        public QLTVDb db;
        
        public DALSach(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALSach()
        {
            db = new QLTVDb();
        }

        private static DALSach instance;
     
        public static DALSach Instance
        {
            get
            {
                if (instance == null) instance= new DALSach();
                return instance;
            }
            set => instance = value; 
        }
        public bool UpdAnSach(int id,int data)
        {
                SACH sach = db.SACHes.Find(id);
                if(sach == null) return false;

                sach.DaAn = data;
               
                db.SaveChanges();
                return true;
            
          
        }
        public List<SACH> GetAllSach()
        {
            // return db.SACHes.AsNoTracking().ToList();
            var dsSach = db.SACHes.Select(s => new
            {
                s.id

            }).ToList();

            var saches = new List<SACH>();

            foreach (var b in dsSach)
            {
                SACH benh = db.SACHes.Find(b.id);
                saches.Add(benh);
            }

            return saches;
        }

        public SACH GetSachById (int id)
        {
            //return QLTVDb.Instance.SACHes.Find(id);
            SACH sach = db.SACHes.Find(id);
            return sach;
        }
        /// <summary>
        /// Get SACH by maSach
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public SACH GetSachByMa (string maSach)
        {
            SACH sach = db.SACHes.FirstOrDefault(p => p.MaSach == maSach);
            return sach;
        }
        /// <summary>
        /// Find SACHs by filter
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
     

        /// <summary>
        /// Add info for new Sach (with soLuong = 0)
        /// return id of new Sach
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="donGia"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public int AddSachMoi(SACH sach)
        {
            db.SACHes.Add(sach);
            db.SaveChanges();
            return sach.id;
        }

        public bool AddSachDaCo (int id, int soLuongThem)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                sach.SoLuong += soLuongThem;
                sach.SoLuongConLai += soLuongThem;
                sach.DaAn = 0;
                Console.WriteLine("{0} {1}", id, sach.SoLuong);
                db.SaveChanges();
                return true;
            }
            catch 
            { 
                return false; 
            }
        }

        /// <summary>
        /// Change SACH information
        /// </summary>
        /// <param name="maSach"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
       

        /// <summary>
        /// Deleting a SACH also delete all CUONSACHs belonging to it
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public bool DelSach(int id)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;

                db.SACHes.Remove(sach);
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
