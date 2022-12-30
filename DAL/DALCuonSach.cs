using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCuonSach
    {
        private static DALCuonSach instance;
        public static DALCuonSach Instance 
        { 
            get
            {
                if (instance == null) instance = new DALCuonSach();
                return instance;
            }
            set => instance = value; 
        }
        public bool UpdAnCuonSach(int id,int data)
        {
            try
            {
                CUONSACH cuonsach = QLTVDb.Instance.CUONSACHes.Find(id);
                SACH sach = cuonsach.SACH;
                if(data != cuonsach.DaAn)
                {
                    if (data == 1) sach.SoLuongConLai--;
                    if(data == 0) sach.SoLuongConLai++;
                }
                if (data == 1) cuonsach.TinhTrang = 2;
                else 
                    if(cuonsach.TinhTrang ==2) 
                    cuonsach.TinhTrang = 1;
                cuonsach.DaAn = data;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public List<CUONSACH> GetAllCuonSach()
        {
            return QLTVDb.Instance.CUONSACHes.AsNoTracking().ToList();
        }
        /// <summary>
        /// Get CUONSACH by Id
        /// </summary>
        /// <param name="idCuonSach"></param>
        /// <returns></returns>
        public CUONSACH GetCuonSachById (int idCuonSach)
        {
            return QLTVDb.Instance.CUONSACHes.Find(idCuonSach);
        }

        /// <summary>
        /// Get CUONSACH by Ma
        /// </summary>
        /// <param name="maCuonSach"></param>
        /// <returns></returns>
        public CUONSACH GetCuonSachByMa(string maCuonSach)
        {
            var res = QLTVDb.Instance.CUONSACHes.AsNoTracking().Where(c => c.MaCuonSach == maCuonSach);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        /// <summary>
        /// Find CUONSACHs by filter
        /// </summary>
        /// <param name="sach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public List<CUONSACH> FindCuonSach (SACH sach, int? tinhTrang)
        {
            List<CUONSACH> res = GetAllCuonSach();
            if (sach != null) res = res.Where(c => c.SACH == sach).ToList();
            if (tinhTrang != null) res = res.Where(c => c.TinhTrang == tinhTrang).ToList();
            return res;
        }

        public bool AddCuonSach (SACH sach, int tinhTrang = 0)
        {
            try
            {
                CUONSACH cuonsach = new CUONSACH
                {
                    idSach = sach.id,
                    SACH = sach,
                    TinhTrang = tinhTrang,
                    DaAn = 0
                };
                QLTVDb.Instance.CUONSACHes.Add(cuonsach);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdCuonSach(int idCuonSach, int? tinhTrang)
        {
            try
            {
                CUONSACH cuonsach = GetCuonSachById(idCuonSach);
                if (cuonsach == null) return false;
                SACH sach = cuonsach.SACH;

                if (tinhTrang != null) if (tinhTrang == cuonsach.TinhTrang) return false;
                    else
                    {
                        cuonsach.TinhTrang = (int)tinhTrang;
                        if (tinhTrang == 1) sach.SoLuongConLai++;
                        else sach.SoLuongConLai--;
                    }
                        QLTVDb.Instance.SaveChanges();
                        return true;
                    }
            catch
            {
                return false;
            }
        }
        public bool DelCuonSach(int idCuonSach)
        {
            try
            {
                var cuonSach = GetCuonSachById(idCuonSach);
                if (cuonSach == null) return false;
                var sach = cuonSach.SACH;
                QLTVDb.Instance.CUONSACHes.Remove(cuonSach);
                sach.SoLuongConLai--;
                sach.SoLuong--;
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
