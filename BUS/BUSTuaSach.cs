using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
     public class BUSTuaSach
    {
        private static BUSTuaSach instance;
        public static BUSTuaSach Instance
        {
            get
            {
                if (instance == null) instance = new BUSTuaSach();
                return instance;
            }
            set => instance = value;
        }
        public List<TUASACH> GetAllTuaSach()
        {
            return DALTuaSach.Instance.GetAllTuaSach();
        }
        public TUASACH GetTuaSach(int MATUASACH)
        {

            TUASACH ts = DALTuaSach.Instance.GetTuaSachById(MATUASACH);
            return ts;
        }
        public List<TUASACH> FindTuaSach(string name, THELOAI theloai, List<TACGIA> tacgia)
        {
            return DALTuaSach.Instance.FindTuaSach(name,theloai,tacgia);
        }
        public string AddTuaSach(string name, THELOAI theloai, List<TACGIA> tacgia)
        {
            if (DALTuaSach.Instance.AddTuaSach(name, theloai, tacgia))
                return "";
            return "Không thể thêm tựa sách";
        }
        public string DelTuaSach(int matuasach)
        {
            TUASACH ts;
            ts = DALTuaSach.Instance.GetTuaSachById(matuasach);

            if(ts == null)
            {
                return "Mã tựa sách không hợp lệ";
            }
            foreach(SACH sach in ts.SACHes)
            {
                foreach(CUONSACH cs in sach.CUONSACHes)
                {
                    if (cs.TinhTrang == 0)
                        return "Tựa sách "+ts.MaTuaSach + " còn sách đang được mượn. Không thể xoá";
                }
            }
            if (DALTuaSach.Instance.DelTuaSach(ts.id))
                return "";
            return "Không thể xoá tựa sách.";
        }
        public string UpdTuaSach(int id,string TenTuaSach,THELOAI theLoai,List<TACGIA> TacGia)
        {
            if (DALTuaSach.Instance.UpdTuaSach(id, TenTuaSach, theLoai, TacGia))
                return "";
            return "Không thể cập nhật tựa sách";
        }
        public string UpdAnTuaSach(int id,int data)
        {
            TUASACH ts = DALTuaSach.Instance.GetTuaSachById(id);
            foreach(SACH sach in ts.SACHes)
            {
                string err = BUSSach.Instance.UpdAnSach(sach.id, data);
                if (err != "")
                    return err;
            }
            if (DALTuaSach.Instance.UpdAnTuaSach(id, data))
                return "";
            return "Lỗi";
        }
    }
}
