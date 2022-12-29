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
            return QLTVDb.Instance.NGUOIDUNGs.AsNoTracking().ToList();
        }

        public NGUOIDUNG GetNguoiDungById(int id)
        {
            return QLTVDb.Instance.NGUOIDUNGs.Find(id);
        }

        public NGUOIDUNG GetNguoiDungByMa (string maNguoiDung)
        {
            var res = QLTVDb.Instance.NGUOIDUNGs.AsNoTracking().Where(n => n.MaNguoiDung == maNguoiDung);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        public NGUOIDUNG GetNguoiDungByUsername (string username)
        {
            var res = QLTVDb.Instance.NGUOIDUNGs.AsNoTracking().Where(n => n.TenDangNhap == username);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        public int AddNguoiDung(string tenNguoiDung, DateTime ngaySinh, string chucVu,
                                 string tenDangNhap, string matKhau, int idNhomNguoiDung)
        {
            
            try
            {
                var nd = new NGUOIDUNG
                {
                    TenNguoiDung = tenNguoiDung,
                    NgaySinh = ngaySinh,
                    ChucVu = chucVu,
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    idNhomNguoiDung = idNhomNguoiDung,
                    NHOMNGUOIDUNG = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(idNhomNguoiDung)
                };
                QLTVDb.Instance.NGUOIDUNGs.Add(nd);
                QLTVDb.Instance.SaveChanges();
                return nd.id;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
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
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
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
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelNguoiDung (int id)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                QLTVDb.Instance.NGUOIDUNGs.Remove(nd);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public List<NGUOIDUNG> getAllNguoiDung()
        {
            throw new NotImplementedException();
        }
    }
}