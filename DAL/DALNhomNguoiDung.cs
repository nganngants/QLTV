using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhomNguoiDung
    {
        public QLTVDb db;

        public DALNhomNguoiDung(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALNhomNguoiDung()
        {
            db = new QLTVDb();
        }
        private static DALNhomNguoiDung instance;

        public static DALNhomNguoiDung Instance 
        { 
            get
            {
                if (instance == null) instance = new DALNhomNguoiDung();
                return instance;
            }
            set => instance = value; 
        }

        public List<NHOMNGUOIDUNG> GetAllNhomNguoiDung ()
        {
            return db.NHOMNGUOIDUNGs.ToList ();
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungById (int id)
        {
            return db.NHOMNGUOIDUNGs.Find(id);
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungByMa (string ma)
        {
            NHOMNGUOIDUNG nhomNguoiDung = db.NHOMNGUOIDUNGs.FirstOrDefault(p => p.MaNhomNguoiDung == ma);
            return nhomNguoiDung;
        }

        public int AddNhomNguoiDung (NHOMNGUOIDUNG nhomNguoiDung)
        {
            db.NHOMNGUOIDUNGs.Add(nhomNguoiDung);
            db.SaveChanges();
            return nhomNguoiDung.id;
        }

        public bool UpdNhomNguoiDung(int id, string tenNhom)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                nhom.TenNhomNguoiDung = tenNhom;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }

        public bool AddChucNangForNhom (int id, List<CHUCNANG> dsChucNang)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                nhom.CHUCNANGs.Clear();
                nhom.CHUCNANGs = dsChucNang;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DelChucNangForNhom (int id, List<CHUCNANG> dsChucNang)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                foreach (var cn in dsChucNang)
                {
                    if (!nhom.CHUCNANGs.Contains(cn)) nhom.CHUCNANGs.Remove(cn);
                }
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }
        public bool DelNhomNguoiDung (int id)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                db.NHOMNGUOIDUNGs.Remove(nhom);
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
