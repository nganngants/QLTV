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
            CUONSACH cs;
            try
            {
                cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            }
            catch
            {
                return null;
                throw;
            }
            return DALSach.Instance.GetSachById((int)cs.idSach);
        }
        public string DelCuonSach(string MaCuonSach)
        {
            CUONSACH cs;
            try
            {
                cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            }
            catch
            {
                return "Mã cuốn sách không hợp lệ";
            }
            if (DALCuonSach.Instance.DelCuonSach(cs.id))
                return "";
            return "Không thể xoá cuốn sách";
        }
    }

}
