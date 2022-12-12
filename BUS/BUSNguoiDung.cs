using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net;

namespace BUS
{
    internal class BUSNguoiDung
    {
        public static BUSNguoiDung instance;
        public static BUSNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new BUSNguoiDung();
                return instance;
            }
            set => instance = value;
        }
        public List<NGUOIDUNG> GetAllNguoiDung()
        {
            return DALNguoiDung.Instance.GetAllNguoiDung();
        }
        public string DelNguoidung(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            if(nd == null)
            {
                return "Mã người dùng không hợp lệ";
            }
            if (DALNguoiDung.Instance.DelNguoiDung(nd.id)) return "";
            return "Không thể xoá người dùng";
        }
        public string AddNguoiDung(string ten, DateTime NgaySinh,string ChucVu,string tenDN,string MK,int NhomNguoiDung)
        {
            if (DALNguoiDung.Instance.AddNguoiDung(ten, NgaySinh, ChucVu, tenDN, MK, NhomNguoiDung))
                return "";
            return "Không thể thêm người dùng";
        }
        public NGUOIDUNG GetNguoiDung(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            return nd;
        }
        public String UpdNguoiDung(string maNguoiDung, string ten, DateTime NgaySinh, string ChucVu, string NhomNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            if(nd == null )
            {
                return "Người dùng không hợp lệ";

            }
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(NhomNguoiDung);
            if (nnd == null)
                return " Nhóm người dùng không hợp lệ";
            if (DALNguoiDung.Instance.UpdNguoiDung(nd.id, ten, NgaySinh, ChucVu, nnd.id))
                return "";
            return "Không thể update người dùng";
        }
    }
}
