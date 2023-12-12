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
        public QLTVDb db;

        public DALDocGia(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALDocGia()
        {
            db = new QLTVDb();
        }
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
        public bool AddDocGia(DOCGIA docGia)
        {
            db.DOCGIAs.Add(docGia);
            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// return a DOCGIA object match the input maDocGia
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <returns></returns>
        public DOCGIA GetDocGiaById (int idDocGia)
        {
            return  db.DOCGIAs.Find(idDocGia);

        }

        public DOCGIA GetDocGiaByMa (string maDocGia)
        {
            DOCGIA docGia = db.DOCGIAs.FirstOrDefault(p => p.MaDocGia == maDocGia);
            return docGia;
        }
        /// <summary>
        /// return a list of all DOCGIA objects
        /// </summary>
        /// <returns>List<DOCGIA></returns>
        public List<DOCGIA> GetAllDocGia()
        {
            var dsDocGia = db.DOCGIAs.Select(s => new
            {
                s.ID

            }).ToList();

            var docgias = new List<DOCGIA>();

            foreach (var b in dsDocGia)
            {
                DOCGIA docGia = db.DOCGIAs.Find(b.ID);
                docgias.Add(docGia);
            }

            return docgias;
        }

        /// <summary>
        /// find DOCGIA of an specific idNguoiDung
        /// </summary>
        /// <param name="idNguoiDung"></param>
        /// <returns></returns>
        public DOCGIA FindDocGiaByIdND (int idNguoiDung)
        {
            DOCGIA docGia = db.DOCGIAs.FirstOrDefault(p => p.idNguoiDung == idNguoiDung);
            return docGia;
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

                db.SaveChanges();
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
                db.SaveChanges();
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
                db.DOCGIAs.Remove(dg);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
