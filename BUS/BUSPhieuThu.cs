using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUSPhieuThu
    {
        private static BUSPhieuThu instance;
        public static BUSPhieuThu Instance
        {
            get
            {
                if (instance == null) instance = new BUSPhieuThu();
                return instance;
            }
            set => instance = value;
        }
        public List<PHIEUTHU> GetAllPhieuThu()
        {
            return DALPhieuThu.Instance.GetAllPhieuThu();
        }
        public List<PHIEUTHU> FindPhieuThu(int? ngay, int ?thang, int ?nam)
        {
            return DALPhieuThu.Instance.FindPhieuThuByNgay(ngay, thang, nam);
        }
        public PHIEUTHU GetPhieuThu(int id)
        {
            PHIEUTHU pt;
            pt = DALPhieuThu.Instance.GetPhieuThuById(id);
            if(pt == null)
            { 
                //Console.WriteLine("Mã phiếu thu không hợp lệ");
                return null;
            }
            return pt;
        }
        public string DelPhieuThu(int id)
        {
            PHIEUTHU pt;
            pt = DALPhieuThu.Instance.GetPhieuThuById(id);
            if(pt==null)
                return "Mã phiểu thu không hợp lệ";
            if(DALPhieuThu.Instance.DelPhieuThu(id))
            return "";
            return "Không thể xoá phiểu thu";
        }
        public string AddPhieuThu(int idDocGia, int soTienThu, DateTime ngayLap)
        {
            DOCGIA dg;
            dg = DALDocGia.Instance.GetDocGiaById(idDocGia);
            if(dg == null)
                return "Không tìm thấy độc giả";
            THAMSO ts = DALThamSo.Instance.GetAllThamSo();
            if (dg.TongNoHienTai < soTienThu && ts.AD_QDKTTienThu == 1) return "Số tiền thu không hợp lệ";
            if (DALPhieuThu.Instance.AddPhieuThu(idDocGia, soTienThu, ngayLap))
                return "";
            return "Không thể thêm phiếu thu";

        }
    }
}
