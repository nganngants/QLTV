using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuThu
    {
        public QLTVDb db;

        public DALPhieuThu(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALPhieuThu()
        {
            db = new QLTVDb();
        }

        private static DALPhieuThu instance;

        public static DALPhieuThu Instance 
        { 
            get
            {
                if (instance == null) instance = new DALPhieuThu();
                return instance;
            }
            set => instance = value; 
        }

        public List<PHIEUTHU> GetAllPhieuThu ()
        {
            return db.PHIEUTHUs.ToList ();
        }

        public PHIEUTHU GetPhieuThuById (int id)
        {
            return db.PHIEUTHUs.Find(id);
        }

        public List <PHIEUTHU> FindPhieuThuByNgay (int? ngay, int? thang, int? nam)
        {
            return db.PHIEUTHUs.Where(i => i.NgayLap.Day == ngay && i.NgayLap.Month == thang && i.NgayLap.Year == nam).ToList();
        }

        /// <summary>
        /// Add PHIEUTHU and also update TongNo of DOCGIA
        /// </summary>
        /// <param name="idDocGia"></param>
        /// <param name="soTienThu"></param>
        /// <param name="ngayLap"></param>
        /// <returns></returns>
        public bool AddPhieuThu (PHIEUTHU phieuThu)
        {
            db.PHIEUTHUs.Add(phieuThu);
            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// Updating soTienThu of PHIEUTHU also updates TongNo of DOCGIA
        /// </summary>
        /// <param name="soPhieu"></param>
        /// <param name="soTienThu"></param>
        /// <param name="ngayLap"></param>
        /// <returns></returns>
        public bool UpdPhieuThu (int soPhieu, int? soTienThu, DateTime? ngayLap)
        {
            try
            {
                var phieu = GetPhieuThuById(soPhieu);
                if (phieu == null) return false;

               
                if (ngayLap != null) phieu.NgayLap = ngayLap.Value;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }

        /// <summary>
        /// Deleting PHIEUTHU will increase TongNo of DOCGIA by its SoTienThu
        /// </summary>
        /// <param name="soPhieu"></param>
        /// <returns></returns>
        public bool DelPhieuThu (int soPhieu)
        {
            try
            {
                var phieu = GetPhieuThuById(soPhieu);
                if (phieu == null) return false;

              

                db.PHIEUTHUs.Remove(phieu);
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
