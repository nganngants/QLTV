using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTPhieuNhap
    {
        private static DALCTPhieuNhap instance;

        public static DALCTPhieuNhap Instance 
        {
            get
            {
                if (instance == null) instance = new DALCTPhieuNhap();
                return instance;
            }
            set => instance = value; 
        }

        public List<CT_PHIEUNHAP> GetAllCTPhieuNhap ()
        {
            return QLTVDb.Instance.CT_PHIEUNHAP.ToList();
        }

        public CT_PHIEUNHAP GetCT_PHIEUNHAP(int soPhieu, int idSach)
        {
            return QLTVDb.Instance.CT_PHIEUNHAP.Find(new object[] { soPhieu, idSach });
        }

        public bool AddCTPhieuNhap (int soPhieu, int idSach, int donGia, int soLuongNhap)
        {
            try
            {
                var phieu = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu);
                var sach = DALSach.Instance.GetSachById(idSach);
                if (phieu == null || sach == null) return false;


                var ct = new CT_PHIEUNHAP
                {
                    SoPhieuNhap = soPhieu,
                    idSach = idSach,
                    DonGia = donGia,
                    SoLuongNhap = soLuongNhap,
                    ThanhTien = donGia * soLuongNhap
                };
                QLTVDb.Instance.CT_PHIEUNHAP.Add(ct);
                DALPhieuNhapSach.Instance.UpdPhieuNhap(soPhieu, null, phieu.TongTien + ct.ThanhTien);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdCTPhieuNhap (int soPhieu, int idSach, int? donGia, int? soLuongNhap)
        {
            try
            {
                var phieu = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu);
                var sach = DALSach.Instance.GetSachById(idSach);
                if (phieu == null || sach == null) return false;

                var ct = GetCT_PHIEUNHAP(soPhieu, idSach);
                if (donGia != null) ct.DonGia = donGia;
                if (soLuongNhap != null) ct.SoLuongNhap = soLuongNhap;
                int thanhTienCu = (int)ct.ThanhTien;

                // update ThanhTien of CTPhieu and TongTien of Phieu
                ct.ThanhTien = donGia * soLuongNhap;
                DALPhieuNhapSach.Instance.UpdPhieuNhap(soPhieu, null, 
                                                       phieu.TongTien - thanhTienCu + ct.ThanhTien);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelCTPhieuNhap(int soPhieu, int idSach)
        {
            try
            {
                var ct = GetCT_PHIEUNHAP(soPhieu, idSach);
                if (ct == null) return false;
                var phieu = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu);

                // update TongTien of Phieu
                DALPhieuNhapSach.Instance.UpdPhieuNhap(soPhieu, null, phieu.TongTien - ct.ThanhTien);
                QLTVDb.Instance.CT_PHIEUNHAP.Remove(ct);
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
