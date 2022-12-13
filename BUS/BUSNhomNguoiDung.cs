using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
     public class BUSNhomNguoiDung
    {
        public static BUSNhomNguoiDung instance;
        public static BUSNhomNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new BUSNhomNguoiDung();
                return instance;
            }
            set => instance = value;
        }
        public List<NHOMNGUOIDUNG> GetAllNhomNguoiDung()
        {
            return DALNhomNguoiDung.Instance.GetAllNhomNguoiDung();
        }
        public string DelNhomNguoiDung(string maNhomNguoiDung)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(maNhomNguoiDung);
            if(nnd == null)
            { return "Mã nhóm người dùng không đúng"; }
            if (DALNhomNguoiDung.Instance.DelNhomNguoiDung(nnd.id))
                return "";
            return "Không thể xoá nhóm người dùng";
        }
        public string AddNhomNguoiDung(string tenNhom)
        {
            if (DALNhomNguoiDung.Instance.AddNhomNguoiDung(tenNhom))
                return "";
            return "Không thể thêm nhóm người dùng";
        }
        public string UpdNhomNguoiDung(string maNhomNguoiDung, string name)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(maNhomNguoiDung);
            if (nnd == null)
            { return "Mã nhóm người dùng không đúng"; }
            if (DALNhomNguoiDung.Instance.UpdNhomNguoiDung(nnd.id, name))
                return "Không thể cập nhật nhóm người dùng";
            return "";
        }
    }
}
