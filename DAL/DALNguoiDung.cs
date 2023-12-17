using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNguoiDung
    {
        public QLTVDb db;

        public DALNguoiDung(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALNguoiDung()
        {
            db = new QLTVDb();
        }
        private static DALNguoiDung instance;

        public static DALNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new DALNguoiDung();
                return instance;
            }
            set => instance = value;
        }

        public List<NGUOIDUNG> GetAllNguoiDung()
        {
            return db.NGUOIDUNGs.ToList();
        }

        public NGUOIDUNG GetNguoiDungById(int id)
        {
            return db.NGUOIDUNGs.Find(id);
        }

        public NGUOIDUNG GetNguoiDungByMa (string maNguoiDung)
        {
            NGUOIDUNG nguoiDung = db.NGUOIDUNGs.FirstOrDefault(p => p.MaNguoiDung == maNguoiDung);
            return nguoiDung;
        }

        public NGUOIDUNG GetNguoiDungByUsername (string username)
        {
            NGUOIDUNG nguoiDung = db.NGUOIDUNGs.FirstOrDefault(p => p.TenDangNhap == username);
            return nguoiDung;
        }

        public int AddNguoiDung(NGUOIDUNG nguoiDung)
        {
            db.NGUOIDUNGs.Add(nguoiDung);
            db.SaveChanges();
            return nguoiDung.id;
        }

        public bool UpdNguoiDung(int id, string tenNguoiDung, DateTime? ngaySinh, string chucVu,
                                 int? idNhomNguoiDung)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                if (tenNguoiDung != null) nd.TenNguoiDung = tenNguoiDung;
                if (ngaySinh != null) nd.NgaySinh = ngaySinh;
                if (chucVu != null) nd.ChucVu = chucVu;
                if (idNhomNguoiDung != null) nd.idNhomNguoiDung = (int)idNhomNguoiDung;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }

        public bool UpdPassword (int id, string password)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                nd.MatKhau = password;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            
                return false;
            }
        }

        public bool DelNguoiDung (int id)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                db.NGUOIDUNGs.Remove(nd);
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