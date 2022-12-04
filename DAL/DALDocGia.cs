using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Check when some errors occur:
    * Did u save changes to db ?
    * Is some value null and u forget to handle that?
    * Did u return correct value?
    * Check SPELLING
 */
namespace DAL
{
    public class DALDocGia
    {
        private static DALDocGia instance;

        public static DALDocGia Instance 
        { 
            get
            {
                if (instance == null) instance = new DALDocGia();
                return instance;
            }
            set => instance = value; 
        }

        /// <summary>
        /// Adding new DocGia object
        /// </summary>
        /// <param name="tenDocGia"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="email"></param>
        /// <param name="ngayLapThe"></param>
        /// <param name="ngayHetHan"></param>
        /// <param name="maLoaiDocGia"></param>
        /// <param name="tongNoHienTai"></param>
        /// <returns></returns>
        public bool AddDocGia(string tenDocGia, DateTime ngaySinh, string diaChi, string email,
            DateTime ngayLapThe, DateTime ngayHetHan, string maLoaiDocGia, int tongNoHienTai)
        {
            try
            {
                var obj = new DOCGIA();
                obj.TenDocGia = tenDocGia;
                obj.NgaySinh = ngaySinh;
                obj.DiaChi = diaChi;
                obj.Email = email;
                obj.NgayLapThe = ngayLapThe;
                obj.NgayHetHan = ngayHetHan;
                obj.MaLoaiDocGia = maLoaiDocGia;
                obj.TongNoHienTai = tongNoHienTai;
                QLTVDb.Instance.DOCGIAs.Add(obj);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// return a DOCGIA object match the input maDocGia
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <returns></returns>
        public DOCGIA GetDocGiaById (string maDocGia)
        {
            return QLTVDb.Instance.DOCGIAs.Find(maDocGia);

        }

        /// <summary>
        /// return a list of all DOCGIA objects
        /// </summary>
        /// <returns>List<DOCGIA></returns>
        public List<DOCGIA> GetAllDocGia()
        {
            return QLTVDb.Instance.DOCGIAs.ToList();
        }

        /// <summary>
        /// return list of DOCGIA match the input filter
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <param name="tenDocGia"></param>
        /// <param name="email"></param>
        /// <param name="maLoaiDocGia"></param>
        /// <returns></returns>
        public List<DOCGIA> FindDocGia(string maDocGia, string tenDocGia, string email, string maLoaiDocGia)
        {
            var res = QLTVDb.Instance.DOCGIAs.ToList();
            if (maDocGia != null) res = res.Where(d => d.MaDocGia == maDocGia).Select(d => d).ToList();
            if (tenDocGia != null) res = res.Where(d => d.TenDocGia == tenDocGia).Select(d => d).ToList();
            if (email != null) res = res.Where(d => d.Email == email).Select(d => d).ToList();
            if (maLoaiDocGia != null) res = res.Where(d => d.MaLoaiDocGia == maLoaiDocGia).Select(d => d).ToList();
            return res;
        }

        public bool UpdDocGia(string maDocGia, string tenDocGia, DateTime? ngaySinh, string diaChi, string email,
            DateTime? ngayHetHan, string maLoaiDocGia)
        {
            try
            {
                DOCGIA dg = QLTVDb.Instance.DOCGIAs.Find(maDocGia);
                if (dg == null) return false;

                if (tenDocGia != null) dg.TenDocGia = tenDocGia;
                if (ngaySinh != null) dg.NgaySinh = (DateTime)ngaySinh;
                if (diaChi != null) dg.DiaChi = diaChi;
                if (email != null) dg.Email = email;
                if (ngayHetHan != null) dg.NgayHetHan = (DateTime)ngayHetHan;
                if (maLoaiDocGia != null) dg.MaLoaiDocGia = maLoaiDocGia;

                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTongNoDocGia (string maDocGia, int tongNoMoi)
        {
            try
            {
                DOCGIA dg = QLTVDb.Instance.DOCGIAs.Find(maDocGia);
                if (dg == null) return false;
                dg.TongNoHienTai = tongNoMoi;
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
