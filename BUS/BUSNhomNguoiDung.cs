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
                return "";
            return "Không thể cập nhật nhóm người dùng";
        }

        public string AddChucNangForNhom(string maNhomNguoiDung, List<String> dsChucNang)
        {
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach(var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";
                ds.Add(cn);
            }
            // REMEMBER TO ADD LOGIC HERE

            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(maNhomNguoiDung);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (DALNhomNguoiDung.Instance.AddChucNangForNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";

        }

        public string DelChucNangForNhom (string maNhomNguoiDung, List <String> dsChucNang)
        {
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach (var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";
                ds.Add(cn);
            }
            // REMEMBER TO ADD LOGIC HERE

            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(maNhomNguoiDung);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (DALNhomNguoiDung.Instance.DelChucNangForNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";
        }
    }
}
