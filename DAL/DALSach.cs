using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public bool UpdAnSach(int id,int data)
        {
            try
            {
                SACH sach = QLTVDb.Instance.SACHes.Find(id);
                sach.DaAn = data;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public List<SACH> GetAllSach()
        {
            return QLTVDb.Instance.SACHes.AsNoTracking().ToList();
        }

        public SACH GetSachById (int id)
        {
            return QLTVDb.Instance.SACHes.Find(id);
        }
        /// <summary>
        /// Get SACH by maSach
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public SACH GetSachByMa (string maSach)
        {
            var res = QLTVDb.Instance.SACHes.AsNoTracking().Where(s => s.MaSach == maSach);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
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

        /// <summary>
        /// Add info for new Sach (with soLuong = 0)
        /// return id of new Sach
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="donGia"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public int AddSachMoi(TUASACH tuaSach, int donGia, int namXB, string nhaXB)
        {
            try
            {
                SACH sach = new SACH
                {
                    TUASACH = tuaSach,
                    idTuaSach = tuaSach.id,
                    SoLuong = 0,
                    SoLuongConLai = 0,
                    NamXB = namXB,
                    DonGia = donGia,
                    NhaXB = nhaXB
                };
                QLTVDb.Instance.SACHes.Add(sach);
                QLTVDb.Instance.SaveChanges();
                return sach.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool AddSachDaCo (int id, int soLuongThem)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                sach.SoLuong += soLuongThem;
                sach.SoLuongConLai += soLuongThem;
                sach.DaAn = 0;
                Console.WriteLine("{0} {1}", id, sach.SoLuong);
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
        public bool UpdSach(int id, int? namXB, string nhaXB)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                if (namXB != null) sach.NamXB = (int)namXB;
                if (nhaXB != null) sach.NhaXB = nhaXB;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        

        /// <summary>
        /// Deleting a SACH also delete all CUONSACHs belonging to it
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public bool DelSach(int id)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                //List<CUONSACH> dsCuonSach = DALCuonSach.Instance.FindCuonSach(sach, null);
                //foreach (CUONSACH cuonSach in dsCuonSach)
                //{
                //    DALCuonSach.Instance.DelCuonSach(cuonSach.MaCuonSach);
                //}
                QLTVDb.Instance.SACHes.Remove(sach);
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
