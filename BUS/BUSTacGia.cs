using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
        public TACGIA GetTacGia(string id)
        {
            return DALTacGia.Instance.GetTacGia(id);
        }
        public bool DelTacGia(string id)
        {
            return DALTacGia.Instance.DelTacGia(id);
        }
        public bool AddTacGia(string name)
        {
            return DALTacGia.Instance.AddTacGia(name);
        }
        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }
        //public bool UpdTacGia(string name)
    }
}
