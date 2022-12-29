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
            return QLTVDb.Instance.CT_PHIEUNHAP.AsNoTracking().ToList();
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
                    PHIEUNHAPSACH = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu),
                    idSach = idSach,
                    SACH = DALSach.Instance.GetSachById(idSach),
                    DonGia = donGia,
                    SoLuongNhap = soLuongNhap,
                    ThanhTien = donGia * soLuongNhap
                };
                QLTVDb.Instance.CT_PHIEUNHAP.Add(ct);

                // update tongTien in PhieuNhap
                DALPhieuNhapSach.Instance.UpdPhieuNhap(soPhieu, null, phieu.TongTien + ct.ThanhTien);

                // Add Sach
                DALSach.Instance.AddSachDaCo(idSach, soLuongNhap);

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
