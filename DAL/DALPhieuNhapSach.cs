using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuNhapSach
    {
        public QLTVDb db;

        public DALPhieuNhapSach(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALPhieuNhapSach()
        {
            db = new QLTVDb();
        }
        private static DALPhieuNhapSach instance;

        public static DALPhieuNhapSach Instance 
        { 
            get
            {
                if (instance == null) instance = new DALPhieuNhapSach();
                return instance;
            }
            set => instance = value; 
        }

        public List<PHIEUNHAPSACH> GetAllPhieuNhapSach()
        {
            return db.PHIEUNHAPSACHes.ToList();
        }

        public PHIEUNHAPSACH GetPhieuById (int id)
        {
            return db.PHIEUNHAPSACHes.Find(id);
        }

        public List<PHIEUNHAPSACH> FindPhieuByNgayNhap(int? ngay, int? thang, int? nam)
        {
            return db.PHIEUNHAPSACHes.Where(i => i.NgayNhap.Day == ngay && i.NgayNhap.Month == thang && i.NgayNhap.Year == nam).ToList();
        }

        public int AddPhieuNhap (PHIEUNHAPSACH pheuNhapSach)
        {
            db.PHIEUNHAPSACHes.Add(pheuNhapSach);
            db.SaveChanges();
            return pheuNhapSach.SoPhieuNhap;
        }


        public bool UpdPhieuNhap(int id, DateTime? ngayNhap, int? tongTien)
        {
            try
            {
                PHIEUNHAPSACH phieu = db.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                if (ngayNhap != null) phieu.NgayNhap = ngayNhap.Value;
                if (tongTien != null) phieu.TongTien = tongTien.Value;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool DelPhieuNhap(int id)
        {
            try
            {
                PHIEUNHAPSACH phieu = db.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                db.PHIEUNHAPSACHes.Remove(phieu);
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
