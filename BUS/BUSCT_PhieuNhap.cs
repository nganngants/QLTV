using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class BUSCT_PhieuNhap
    {
        private static BUSPhieuNhap instance;
        public static BUSPhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUSPhieuNhap();
                return instance;
            }
            set => instance = value;
        }
        public List<CT_PHIEUNHAP> GetAllCT_PHIEUNHAP()
        {
            return DALCTPhieuNhap.Instance.GetAllCTPhieuNhap();

        }
        public string AddCtPhieuNhap(int soPhieu, int idSach,int  donGia,int soLuongNhap)
        {
            PHIEUNHAPSACH pn = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu);
            if(pn == null)
            {
                return "Phiếu nhập sách không hợp lệ";
            }
            SACH sach = DALSach.Instance.GetSachById(idSach);
            if (sach == null) return "Mã sách không hợp lệ";
           // List<CT_PHIEUNHAP> ct = DALCTPhieuNhap.Instance.GetAllCTPhieuNhap();
      
            if (DALCTPhieuNhap.Instance.AddCTPhieuNhap(soPhieu, idSach, donGia, soLuongNhap))
                return "";
            return "Không thể nhập sách này";
        }
        public string DelCTPhieuNhap ( int soPhieu,int idSach)
        {
            if (DALCTPhieuNhap.Instance.DelCTPhieuNhap(soPhieu, idSach))
                return "";
            return "Không thể xoá phiếu nhập";
        }
    }
}
