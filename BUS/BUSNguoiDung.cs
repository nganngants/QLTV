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
     public class BUSNguoiDung
    {
        private static BUSNguoiDung instance;
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
            if (nd.TenDangNhap == "admin")
            {
                return "Không thể xoá người dùng này";
            }
            bool isDG = false;
            foreach (CHUCNANG cn in nd.NHOMNGUOIDUNG.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") isDG = true;
            }
            if (isDG) return "Không thể xóa người dùng là độc giả";
            if (DALNguoiDung.Instance.DelNguoiDung(nd.id)) return "";
            return "Không thể xoá người dùng";
        }
        public int AddNguoiDung(string ten, DateTime NgaySinh,string ChucVu,string tenDN,string MK,int NhomNguoiDung)
        {
            foreach (NGUOIDUNG nd in BUSNguoiDung.Instance.GetAllNguoiDung())
                if (nd.TenDangNhap == tenDN)
                    return -1;
            int id = DALNguoiDung.Instance.AddNguoiDung(ten, NgaySinh, ChucVu, tenDN, MK, NhomNguoiDung);
            return id;
        }
        public NGUOIDUNG GetNguoiDung(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            return nd;
        }

        public NGUOIDUNG GetNguoiDungById (int id)
        {
            return DALNguoiDung.Instance.GetNguoiDungById(id);
        }
        public bool UpdMK(int id,string MatKhau)
        {
            return DALNguoiDung.Instance.UpdPassword(id, MatKhau);
        }
        public String UpdNguoiDung(int id, string ten, DateTime NgaySinh, string ChucVu, int idNhomNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungById(id);
            if(nd == null )
            {
                return "Người dùng không hợp lệ";

            }
            if (nd.TenDangNhap == "admin")
                return "Không thể sửa người dùng này";
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(idNhomNguoiDung);
            if (nnd == null)
                return " Nhóm người dùng không hợp lệ";
            if (DALNguoiDung.Instance.UpdNguoiDung(nd.id, ten, NgaySinh, ChucVu, nnd.id))
                return "";
            return "Không thể update người dùng";
        }
    }
}
