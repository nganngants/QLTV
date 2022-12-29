using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuThu
    {
        private static DALPhieuThu instance;

        public static DALPhieuThu Instance 
        { 
            get
            {
                if (instance == null) instance = new DALPhieuThu();
                return instance;
            }
            set => instance = value; 
        }

        public List<PHIEUTHU> GetAllPhieuThu ()
        {
            return QLTVDb.Instance.PHIEUTHUs.AsNoTracking().ToList ();
        }

        public PHIEUTHU GetPhieuThuById (int id)
        {
            return QLTVDb.Instance.PHIEUTHUs.Find(id);
        }

        public List <PHIEUTHU> FindPhieuThuByNgay (int? ngay, int? thang, int? nam)
        {
            List<PHIEUTHU> res = GetAllPhieuThu();
            if (ngay != null) res = res.Where(p => p.NgayLap.Day == ngay).ToList();
            if (thang != null) res = res.Where(p => p.NgayLap.Month == thang).ToList();
            if (nam != null) res = res.Where(p => p.NgayLap.Year == nam).ToList();
            return res;
        }

        /// <summary>
        /// Add PHIEUTHU and also update TongNo of DOCGIA
        /// </summary>
        /// <param name="idDocGia"></param>
        /// <param name="soTienThu"></param>
        /// <param name="ngayLap"></param>
        /// <returns></returns>
        public bool AddPhieuThu (int idDocGia, int soTienThu, DateTime ngayLap)
        {
            try
            {
                var phieu = new PHIEUTHU
                {
                    idDocGia = idDocGia,
                    DOCGIA = DALDocGia.Instance.GetDocGiaById(idDocGia),
                    SoTienThu = soTienThu,
                    NgayLap = ngayLap
                };
                var dg = DALDocGia.Instance.GetDocGiaById(idDocGia);
                dg.TongNoHienTai -= soTienThu;

                QLTVDb.Instance.PHIEUTHUs.Add(phieu);
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
        /// Updating soTienThu of PHIEUTHU also updates TongNo of DOCGIA
        /// </summary>
        /// <param name="soPhieu"></param>
        /// <param name="soTienThu"></param>
        /// <param name="ngayLap"></param>
        /// <returns></returns>
        public bool UpdPhieuThu (int soPhieu, int? soTienThu, DateTime? ngayLap)
        {
            try
            {
                var phieu = GetPhieuThuById(soPhieu);
                if (phieu == null) return false;

                if (soTienThu != null)
                {
                    var dg = DALDocGia.Instance.GetDocGiaById((int)phieu.idDocGia);
                    dg.TongNoHienTai += (int)phieu.SoTienThu - (int)soTienThu;
                    //Console.WriteLine("DAL: ", soTienThu);
                    phieu.SoTienThu = (int)soTienThu;
                }
                if (ngayLap != null) phieu.NgayLap = ngayLap.Value;
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
        /// Deleting PHIEUTHU will increase TongNo of DOCGIA by its SoTienThu
        /// </summary>
        /// <param name="soPhieu"></param>
        /// <returns></returns>
        public bool DelPhieuThu (int soPhieu)
        {
            try
            {
                var phieu = GetPhieuThuById(soPhieu);
                if (phieu == null) return false;

                var dg = DALDocGia.Instance.GetDocGiaById((int)phieu.idDocGia);
                dg.TongNoHienTai += phieu.SoTienThu;

                QLTVDb.Instance.PHIEUTHUs.Remove(phieu);
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
