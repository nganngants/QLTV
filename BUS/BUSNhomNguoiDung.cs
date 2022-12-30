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
        private static BUSNhomNguoiDung instance;
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

        public NHOMNGUOIDUNG GetNhomNguoiDungById(int id)
        {
            return DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
        }
        public string DelNhomNguoiDung(int maNhomNguoiDung)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(maNhomNguoiDung);
            if(nnd == null)
            { return "Mã nhóm người dùng không đúng"; }
            if (nnd.id == 1)
                return "Không thể xoá nhóm người dùng Quản Lý";
            bool isDG = false;
            foreach (CHUCNANG cn in nnd.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") isDG = true;
            }
            if (isDG && nnd.NGUOIDUNGs.Count > 0) 
                return "Không thể xóa nhóm người dùng này vì các người dùng thuộc nhóm có quyền độc giả!";
            if (DALNhomNguoiDung.Instance.DelNhomNguoiDung(nnd.id))
                return "";
            return "Không thể xoá nhóm người dùng";
        }
        public int AddNhomNguoiDung(string tenNhom)
        {
            if (tenNhom == "Quản Lý") return -1;
            try
            {
                int id = DALNhomNguoiDung.Instance.AddNhomNguoiDung(tenNhom);
                return id;
            }
            
            catch
            {
                //Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }
        public string UpdNhomNguoiDung(string maNhomNguoiDung, string name)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(maNhomNguoiDung);
            if (nnd == null)
            { return "Mã nhóm người dùng không đúng"; }
            if (name == "Quản Lý") return "Không thể đặt tên này";
            if(nnd.id == 1)
            {
                return "Không thể sửa nhóm người dùng Quản lý";
            }
            if (DALNhomNguoiDung.Instance.UpdNhomNguoiDung(nnd.id, name))
                return "";
            return "Không thể cập nhật nhóm người dùng";
        }

        public string AddChucNangForNhom(int maNhomNguoiDung, List<String> dsChucNang)
        {
            //Console.WriteLine("Into BUS: {0}", dsChucNang.Count);
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach(var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                //Console.WriteLine(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";

                ds.Add(cn);
            }

            // REMEMBER TO ADD LOGIC HERE

            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(maNhomNguoiDung);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (nnd.id == 1) return "Không thể chỉnh sửa nhóm người dùng này";
            if (DALNhomNguoiDung.Instance.AddChucNangForNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";

        }

        public string DelChucNangForNhom(int id, List <String> dsChucNang)
        {
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach (var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";
                ds.Add(cn);
            }
            // REMEMBER TO ADD LOGIC HERE

            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (nnd.id == 1)
                return "Không thể chỉnh sửa nhóm người dùng này";
            if (DALNhomNguoiDung.Instance.DelChucNangForNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";
        }
    }
}
