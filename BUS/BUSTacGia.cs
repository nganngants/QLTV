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
    internal class BUSTacGia
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
        public string DelTacGia(string MaTacGia)
        {
            if (DALTacGia.Instance.DelTacGia(MaTacGia))
                return "";
            return "Khong the xoa tac gia";
        }
        public TACGIA GetTacGia(string MaTacGia)
        {
            return DALTacGia.Instance.GetTacGia(MaTacGia);
        }
        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }
    }
}
