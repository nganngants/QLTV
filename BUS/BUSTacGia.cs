using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net;

namespace BUS
{
     public class BUSTacGia
    {
        private static BUSTacGia instance;
        public static BUSTacGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSTacGia();
                return instance;
            }
            set => instance = value;
        }
        public List<TACGIA> GetAllTacGia()
        {
            return DALTacGia.Instance.GetAllTacGia();
        }
        public int AddTacGia(string name)
        {
            return (DALTacGia.Instance.AddTacGia(name));
             
        }
        public string DelTacGia(int id)
        {
            TACGIA tg = DALTacGia.Instance.GetTacGiaById(id);
            if (tg == null) return "Mã tác giả không hợp lệ ";
            if (DALTacGia.Instance.DelTacGia(tg.id))
                return "";
            return "Khong the xoa tac gia";
        }
        public TACGIA GetTacGia(int id)
        {
            TACGIA tg;
            tg = DALTacGia.Instance.GetTacGiaById(id);
            return tg;
                
        }
        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }
        public bool UpdTacGia(int id,string name)
        {
            TACGIA tacgia = DALTacGia.Instance.GetTacGiaById(id);
            if (tacgia == null) return false;
            if (DALTacGia.Instance.UpdTacGia(id, name))
                return true;
            else return false;
        }
    }
}
