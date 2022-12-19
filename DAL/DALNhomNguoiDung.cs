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
            return QLTVDb.Instance.NHOMNGUOIDUNGs.AsNoTracking().ToList ();
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungById (int id)
        {
            return QLTVDb.Instance.NHOMNGUOIDUNGs.Find(id);
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungByMa (string ma)
        {
            var res = QLTVDb.Instance.NHOMNGUOIDUNGs.AsNoTracking().Where(n => n.MaNhomNguoiDung == ma);
            return (res.Any() ? res.First() : null);
        }

        public int AddNhomNguoiDung (string tenNhom)
        {
            try
            {
                var nhom = new NHOMNGUOIDUNG
                {
                    TenNhomNguoiDung = tenNhom
                };
                QLTVDb.Instance.NHOMNGUOIDUNGs.Add(nhom);
                QLTVDb.Instance.SaveChanges();
                return nhom.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.InnerException.ToString ());
                return -1;
            }
        }

        public bool UpdNhomNguoiDung(int id, string tenNhom)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                nhom.TenNhomNguoiDung = tenNhom;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
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
                Console.WriteLine(ex.InnerException.ToString());
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
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelNhomNguoiDung (int id)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                QLTVDb.Instance.NHOMNGUOIDUNGs.Remove(nhom);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
