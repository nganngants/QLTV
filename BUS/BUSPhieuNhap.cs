using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class BUSPhieuNhap
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
        public List<PHIEUNHAPSACH> GetAllPhieuNhap()
        {
            return DALPhieuNhapSach.Instance.GetAllPhieuNhapSach();
        }
        public PHIEUNHAPSACH GetPhieuNhap(int MaPhieuNhap)
        {
            PHIEUNHAPSACH pn;
            pn = DALPhieuNhapSach.Instance.GetPhieuById(MaPhieuNhap);
            return pn;
        }
        public int AddPhieuNhap(int Ngay, int Thang, int Nam)
        {
            DateTime NgayNhap = new DateTime(Nam, Thang, Ngay);
            if(DateTime.Now < ) { return -1; };
            if (DALPhieuNhapSach.Instance.AddPhieuNhap(NgayNhap))
            {
                List<PHIEUNHAPSACH> pn = DALPhieuNhapSach.Instance.FindPhieuByNgayNhap(Ngay, Thang, Nam);
                return pn[0].SoPhieuNhap;
            }    
            return -1;
        }
        public string DelPhieuNhap(int id)
        {
            PHIEUNHAPSACH pn = DALPhieuNhapSach.Instance.GetPhieuById(id);
            if (pn == null)
                return "Số phiểu nhập không hợp lệ";
            if(DALPhieuNhapSach.Instance.DelPhieuNhap(id))
                return "";
            return "Không thể xoá phiếu nhập";
        }
        public string UpdatePhieuNhap(int id,DateTime NgayNhap)
        {
            PHIEUNHAPSACH pn = DALPhieuNhapSach.Instance.GetPhieuById(id);
            if (pn == null)
                return "Số phiểu nhập không hợp lệ";
            if (DALPhieuNhapSach.Instance.UpdPhieuNhap(id, NgayNhap, null))
                return "";
            return "Không thể cập nhật phiếu nhập";

        }
    }
}
