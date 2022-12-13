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
        public string AddTacGia(string name)
        {
            if (DALTacGia.Instance.AddTacGia(name))
                return "";
            return "Khong the them tac gia";
        }
        public string DelTacGia(int id)
        {
            TACGIA tg = DALTacGia.Instance.GetTacGiaById(id);
            if (tg == null) return "Mã tác giả không hợp lệ ";
            if (DALTacGia.Instance.DelTacGia(id))
                return "";
            return "Khong the xoa tac gia";
        }
        public TACGIA GetTacGia(string MaTacGia)
        {
            TACGIA tg;
            tg = DALTacGia.Instance.GetTacGiaByMa(MaTacGia);
            return tg;
                
        }
        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }
    }
}
