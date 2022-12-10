using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Diagnostics.Contracts;

namespace BUS
{
    internal class BUSTheLoai
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
        public THELOAI GetTheLoai(string id)
        {   
            return DALTheLoai.Instance.GetTheLoaiByMa(id);
        }
        public bool DelTheLoai(string id)
        {
            return DALTheLoai.Instance.DelTheLoai(GetTheLoai(id).id);
        }
        public bool UpdTheLoai(string id,string name)
        {
            return DALTheLoai.Instance.UpdTheLoai(GetTheLoai(id).id, name);
        }
    }
}
