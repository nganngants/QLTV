using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUSCT_PhieuNhap
    {
        private static BUSCT_PhieuNhap instance;
        public static BUSCT_PhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUSCT_PhieuNhap();
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
            if (soLuongNhap <= 0) return "Số lượng nhập không hợp lệ";
            if (donGia < 0) return "Đơn giá không hợp lệ";
            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            
            if (DALCTPhieuNhap.Instance.AddCTPhieuNhap(soPhieu, idSach, donGia, soLuongNhap))
                return "";
            return "Không thể nhập sách này";
        }
        
    }
}
