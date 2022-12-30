using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;

namespace BUS
{
     public class BUSTheLoai
    {
        private static BUSTheLoai instance;
        public static BUSTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSTheLoai();
                return instance;
            }
            set => instance = value;
        }
        public List<THELOAI> GetAllTheLoai()
        {
            return DALTheLoai.Instance.GetAllTheLoai();
        }
        public List<THELOAI> FindTheLoai(string name) 
        {
            return DALTheLoai.Instance.FindTheLoai(name);
        }
        public THELOAI GetTheLoai(int id)
        {   
            return DALTheLoai.Instance.GetTheLoaiById(id);
        }
        public bool DelTheLoai(int id)
        {
            return DALTheLoai.Instance.DelTheLoai(id);
        }
        public bool UpdTheLoai(int id,string name)
        {
            return DALTheLoai.Instance.UpdTheLoai(id, name);
        }

        public bool AddTheLoai (string name)
        {
            return DALTheLoai.Instance.AddTheLoai(name);
        }
    }
}
