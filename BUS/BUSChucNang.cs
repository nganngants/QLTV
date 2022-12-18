using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
     public class BUSChucNang
    {
        private static BUSChucNang instance;
        public static BUSChucNang Instance
        {
            get
            {
                if (instance == null) instance = new BUSChucNang();
                return instance;
            }
            set => instance = value;
        }
        public List<CHUCNANG> GetAllChucNang()
        {
            return DALChucNang.Instance.GetAllChucNang();
        }

        public CHUCNANG GetChucNangById (int id)
        {
            return DALChucNang.Instance.GetChucNangById(id);
        }
        public string DelChucNang(string MaCN )
        {
            CHUCNANG cn = DALChucNang.Instance.GetChucNangByMa(MaCN);
            if(DALChucNang.Instance.DelChucNang(cn.id))
                return "";
            return "Không thể xoá chức năng";
        }
     
    }
}
