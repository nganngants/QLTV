using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChucNang
    {
        private static DALChucNang instance;

        public static DALChucNang Instance
        {
            get
            {
                if (instance == null) instance = new DALChucNang();
                return instance;
            }
            set => instance = value;
        }

        public List<CHUCNANG> GetAllChucNang()
        {
            return QLTVDb.Instance.CHUCNANGs.AsNoTracking().ToList();
        }

        public CHUCNANG GetChucNangById (int id)
        {
            return QLTVDb.Instance.CHUCNANGs.Find(id);
        }

        public CHUCNANG GetChucNangByMa(string ma)
        {
            var res = QLTVDb.Instance.CHUCNANGs.AsNoTracking().Where(c => c.MaChucNang == ma);
            return (res.Any() ? res.First() : null);
        }

        public bool AddChucNang(string tenChucNang, string tenManHinh)
        {
            try
            {
                var cn = new CHUCNANG
                {
                    TenChucNang = tenChucNang,
                    TenManHinh = tenManHinh
                };
                QLTVDb.Instance.CHUCNANGs.Add(cn);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdChucNang (int id, string tenChucNang, string tenManHinh) 
        {
            try
            {
                var cn = GetChucNangById(id);
                if (cn == null) return false;

                if (tenChucNang != null) cn.TenChucNang = tenChucNang;
                if (tenManHinh != null) cn.TenManHinh = tenManHinh;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelChucNang(int id)
        {
            try
            {
                var cn = GetChucNangById(id);
                if (cn == null) return false;

                QLTVDb.Instance.CHUCNANGs.Remove(cn);
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
