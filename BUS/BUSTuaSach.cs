using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Diagnostics.Contracts;

namespace BUS
{
    internal class BUSTuaSach
    {
        private static BUSLogin instance;
        public static BUSLogin Instance
        {
            get
            {
                if (instance == null) instance = new BUSLogin();
                return instance;
            }
            set => instance = value;
        }
        public List<TUASACH> GetAllTuaSach()
        {
            return DALTuaSach.Instance.GetAllTuaSach(); 
        }
        public TUASACH GetTuaSach(string id)
        {
            return DALTuaSach.Instance.GetTuaSach(id);
        }
        public bool AddTuaSach(string name, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            return DALTuaSach.Instance.AddTuaSach(name, theLoai, dsTacGia);
        }
        public List<TUASACH> FindTuaSach(string name,THELOAI theloai, List<TACGIA> tacgia)
        {
            return DALTuaSach.Instance.FindTuaSach(name,theloai,tacgia);
        }
        public bool DelTuaSach(string id)
        {

            return DALTuaSach.Instance.DelTuaSach(id);
        }
        public bool UpdTuaSach(string id,string name, THELOAI theloai, List<TACGIA> tacgia,List<SACH> sach)
        {
            return DALTuaSach.Instance.UpdTuaSach(id, name, theloai, tacgia,sach);
        }
    }
}
