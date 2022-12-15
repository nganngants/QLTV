using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Markup;

namespace BUS
{
     public class BUSCuonSach
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
        public CUONSACH GetCuonSach(string MaCuonSach)
        {

            CUONSACH cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            return cs;
        }
        public string DelCuonSach(string MaCuonSach)
        {
            CUONSACH cs;
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            if(cs==null)
            {
                return "Mã cuốn sách không hợp lệ";
            }
            if (DALCuonSach.Instance.DelCuonSach(cs.id))
                return "";
            return "Không thể xoá cuốn sách";
        }
    }

}
