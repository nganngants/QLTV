using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        private static DALTacGia instance;

        public static DALTacGia Instance 
        { 
            get
            {
                if (instance == null) instance = new DALTacGia();
                return instance;
            }
            set => instance = value; 
        }

        public List<TACGIA> GetAllTacGia()
        {
            return QLTVDb.Instance.TACGIAs.ToList();
        }

        public TACGIA GetTacGia(string maTacGia)
        {
            return QLTVDb.Instance.TACGIAs.Find(maTacGia);
        }

        public List<TACGIA> FindTacGia(string tenTacGia)
        {
            return QLTVDb.Instance.TACGIAs.Where(t => t.TenTacGia == tenTacGia).Select(t => t).ToList();
        }
        public bool AddTacGia (string tenTacGia)
        {
            try
            {
                TACGIA tacGia = new TACGIA { TenTacGia = tenTacGia };
                QLTVDb.Instance.TACGIAs.Add(tacGia);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTacGia(string maTacGia, string tenTacGia)
        {
            try
            {
                TACGIA tacgia = QLTVDb.Instance.TACGIAs.Find(maTacGia);
                if (tacgia == null) return false;
                tacgia.TenTacGia = tenTacGia;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTacGia(string maTacGia)
        {
            try
            {
                TACGIA tacgia = QLTVDb.Instance.TACGIAs.Find(maTacGia);
                if (tacgia == null) return false;
                QLTVDb.Instance.TACGIAs.Remove(tacgia);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
