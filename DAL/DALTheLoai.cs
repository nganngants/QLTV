using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTheLoai
    {
        private static DALTheLoai instance;

        public static DALTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<THELOAI> GetAllTheLoai()
        {
            return QLTVDb.Instance.THELOAIs.ToList();
        }

        public THELOAI GetTheLoai(string maTheLoai)
        {
            return QLTVDb.Instance.THELOAIs.Find(maTheLoai);
        }

        public List<THELOAI> FindTheLoai(string tenTheLoai)
        {
            return QLTVDb.Instance.THELOAIs.Where(t => t.TenTheLoai == tenTheLoai).Select(t => t).ToList();
        }

        public bool AddTheLoai(string tenTheLoai)
        {
            try
            {
                THELOAI theloai = new THELOAI { TenTheLoai = tenTheLoai };
                QLTVDb.Instance.THELOAIs.Add(theloai);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTheLoai(string maTheLoai, string tenTheLoai)
        {
            try
            {
                var theloai = QLTVDb.Instance.THELOAIs.Find(maTheLoai);
                if (theloai == null) return false;
                theloai.TenTheLoai = tenTheLoai;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTheLoai(string maTheLoai)
        {
            try
            {
                var theloai = QLTVDb.Instance.THELOAIs.Find(maTheLoai);
                if (theloai == null) return false;
                QLTVDb.Instance.THELOAIs.Remove(theloai);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
