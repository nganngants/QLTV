using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSach
    {
        private static DALSach instance;
        public static DALSach Instance
        {
            get
            {
                if (instance == null) instance= new DALSach();
                return instance;
            }
            set { instance = value; }
        }

        public List<SACH> GetAllSach()
        {
            return QLTVDb.Instance.SACHes.ToList();
        }

        /// <summary>
        /// Get SACH by Id
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public SACH GetSach (string maSach)
        {
            return QLTVDb.Instance.SACHes.Find(maSach);
        }
        /// <summary>
        /// Find SACHs by filter
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public List<SACH> FindSach(TUASACH tuaSach, int? namXB, string nhaXB) 
        {
            List<SACH> res = GetAllSach();
            if (tuaSach != null) res = res.Where(s => s.TUASACH == tuaSach).Select(s => s).ToList();
            if (namXB != null) res = res.Where(s => s.NamXB == namXB).Select(s => s).ToList();
            if (nhaXB != null) res = res.Where(s => s.NhaXB == nhaXB).Select(s => s).ToList();
            return res;
        }

        public bool AddSachMoi(TUASACH tuaSach, int soLuong, int donGia, int? namXB, string nhaXB)
        {
            try
            {
                SACH sach = new SACH
                {
                    TUASACH = tuaSach,
                    MaTuaSach = tuaSach.MaTuaSach,
                    SoLuong = soLuong,
                    SoLuongConLai = soLuong,
                    NamXB = namXB,
                    DonGia = donGia,
                    NhaXB = nhaXB
                };
                QLTVDb.Instance.SACHes.Add(sach);
                for (int i = 0; i < soLuong; ++i)
                {
                    DALCuonSach.Instance.AddCuonSach(sach, 1);
                }
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddSachDaCo (string maSach, int soLuongThem)
        {
            try
            {
                SACH sach = QLTVDb.Instance.SACHes.Find(maSach);
                if (sach == null) return false;
                sach.SoLuong += soLuongThem;
                sach.SoLuongConLai += soLuongThem;
                for (int i = 0; i < soLuongThem; ++i)
                {
                    DALCuonSach.Instance.AddCuonSach(sach, 1);
                }
                QLTVDb.Instance.SaveChanges();
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
        public bool UpdSach(string maSach, int? namXB, string nhaXB)
        {
            try
            {
                SACH sach = QLTVDb.Instance.SACHes.Find(maSach);
                if (sach == null) return false;
                if (namXB != null) sach.NamXB = namXB;
                if (nhaXB != null) sach.NhaXB = nhaXB;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// change SACH quantity
        /// </summary>
        /// <param name="maSach"></param>
        /// <param name="soLuong"></param>
        /// <param name="soLuongConLai"></param>
        /// <returns></returns>
        public bool UpdSLSach(string maSach, int soLuong, int soLuongConLai)
        {
            try
            {
                SACH sach = QLTVDb.Instance.SACHes.Find(maSach);
                if (sach == null) return false;
                sach.SoLuong = soLuong;
                sach.SoLuongConLai = soLuongConLai;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deleting a SACH also delete all CUONSACHs belonging to it
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public bool DelSach(string maSach)
        {
            try
            {
                SACH sach = GetSach(maSach);
                if (sach == null) return false;
                List<CUONSACH> dsCuonSach = DALCuonSach.Instance.FindCuonSach(sach, null);
                foreach (CUONSACH cuonSach in dsCuonSach)
                {
                    DALCuonSach.Instance.DelCuonSach(cuonSach.MaCuonSach);
                }
                QLTVDb.Instance.SACHes.Remove(sach);
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
