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
            DateTime ngayLapThe, DateTime ngayHetHan, int idLoaiDocGia, int tongNoHienTai, int idND)
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
                obj.idLoaiDocGia = idLoaiDocGia;
                obj.TongNoHienTai = tongNoHienTai;
                obj.idNguoiDung = idND;
                obj.NGUOIDUNG = DALNguoiDung.Instance.GetNguoiDungById(idND);
                QLTVDb.Instance.DOCGIAs.Add(obj);
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
        /// return a DOCGIA object match the input maDocGia
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <returns></returns>
        public DOCGIA GetDocGiaById (int idDocGia)
        {
            return QLTVDb.Instance.DOCGIAs.Find(idDocGia);

        }

        public DOCGIA GetDocGiaByMa (string maDocGia)
        {
            var res = QLTVDb.Instance.DOCGIAs.AsNoTracking().Where(d => d.MaDocGia == maDocGia);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        /// <summary>
        /// return a list of all DOCGIA objects
        /// </summary>
        /// <returns>List<DOCGIA></returns>
        public List<DOCGIA> GetAllDocGia()
        {
            return QLTVDb.Instance.DOCGIAs.AsNoTracking().ToList();
        }

        /// <summary>
        /// return list of DOCGIA match the input filter
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <param name="tenDocGia"></param>
        /// <param name="email"></param>
        /// <param name="maLoaiDocGia"></param>
        /// <returns></returns>
        public List<DOCGIA> FindDocGia(string tenDocGia, string email, int? idLoaiDocGia)
        {
            var res = QLTVDb.Instance.DOCGIAs.ToList();
            if (tenDocGia != null) res = res.Where(d => d.TenDocGia == tenDocGia).Select(d => d).ToList();
            if (email != null) res = res.Where(d => d.Email == email).Select(d => d).ToList();
            if (idLoaiDocGia != null) res = res.Where(d => d.idLoaiDocGia == idLoaiDocGia).Select(d => d).ToList();
            return res;
        }

        /// <summary>
        /// find DOCGIA of an specific idNguoiDung
        /// </summary>
        /// <param name="idNguoiDung"></param>
        /// <returns></returns>
        public DOCGIA FindDocGiaByIdND (int idNguoiDung)
        {
            return QLTVDb.Instance.DOCGIAs.AsNoTracking().Where(d => d.idNguoiDung == idNguoiDung).First();
        }


        public bool UpdDocGia(int idDocGia, string tenDocGia, DateTime? ngaySinh, string diaChi, string email,
            DateTime? ngayHetHan, int? idLoaiDocGia)
        {
            try
            {
                DOCGIA dg = GetDocGiaById(idDocGia);
                if (dg == null) return false;

                if (tenDocGia != null) dg.TenDocGia = tenDocGia;
                if (ngaySinh != null) dg.NgaySinh = (DateTime)ngaySinh;
                if (diaChi != null) dg.DiaChi = diaChi;
                if (email != null) dg.Email = email;
                if (ngayHetHan != null) dg.NgayHetHan = (DateTime)ngayHetHan;
                if (idLoaiDocGia != null) dg.idLoaiDocGia = (int)idLoaiDocGia;

                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTongNoDocGia (int idDocGia, int tongNoMoi)
        {
            try
            {
                DOCGIA dg = GetDocGiaById(idDocGia);
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

        public bool DelDocGia (int idDocGia)
        {
            try
            {
                DOCGIA dg = GetDocGiaById(idDocGia);
                if (dg == null) return false;
                QLTVDb.Instance.DOCGIAs.Remove(dg);
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
