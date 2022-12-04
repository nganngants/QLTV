using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    internal class BUSLoaiDocGia
    {
        private static BUSLoaiDocGia instance;
        public static BUSLoaiDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSLoaiDocGia();
                return instance;
            }
            set => instance = value;
        }
        public List<LOAIDOCGIA> GetAllLoaiDocGia()
        {
            return DALLoaiDocGia.Instance.GetAllLoaiDocgia();
        }
        public bool DelLoaiDocGia(string id)
        {
            return (DALLoaiDocGia.Instance.DelLoaiDocGia(id)) ;
        }
        public bool AddLoaiDocGia(string name)
        {
            return (DALLoaiDocGia.Instance.AddLoaiDocGia(name));
        }
    }
}
