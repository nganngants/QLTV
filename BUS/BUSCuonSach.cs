using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    internal class BUSCuonSach
    {
        private static BUSCuonSach instance;
        public static BUSCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new BUSCuonSach();
                return instance;
            }
            set => instance = value;
        }
        public List<CUONSACH> GetAllCuonSach()
        {
            return DALCuonSach.Instance.GetAllCuonSach();
        }
        public SACH GetSachOfCuonSach(string MaCuonSach)
        {
            CUONSACH cs = DAlCuonSach.Instance.GetCuonSach(MaCuonSach);
            return DALSach.Instance.GetSach(cs.MaSach);
        }
        public string DelCuonSach(string MaCuonSach)
        {
            if (DALCuonSach.Instance.DelCuonSach(MaCuonSach))
                return "";
            return "Không thể xoá cuốn sách";
        }
    }

}
