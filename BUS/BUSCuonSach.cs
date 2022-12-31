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
        public List<CUONSACH> GetAllCuonSachAvai()
        {
            List<CUONSACH> CuonSachList = new List<CUONSACH>();
            foreach(CUONSACH cs in DALCuonSach.Instance.GetAllCuonSach())
                if(cs.TinhTrang == 1)
                    CuonSachList.Add(cs);
            return CuonSachList;
        }
        public SACH GetSachOfCuonSach(string MaCuonSach)
        {
            CUONSACH cs;
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
           
            return DALSach.Instance.GetSachById((int)cs.idSach);
        }

        public string UpdAnCuonSach(string id,int data)
        {
            CUONSACH cs = DALCuonSach.Instance.GetCuonSachByMa(id);
            if (data == 1 && cs.TinhTrang == 0)
                return "Không thể ẩn vì còn sách đang được mượn";
            if (cs.TinhTrang == 0) return "";
            if (DALCuonSach.Instance.UpdAnCuonSach(cs.id, data))
                return "";
            return "Lỗi";
        }
        public string DelCuonSach(string MaCuonSach)
        {
            CUONSACH cs;
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            if(cs==null)
            {
                return "Mã cuốn sách không hợp lệ";
            }
            if (cs.TinhTrang == 0)
                return "Cuốn sách đang được mượn không thể xoá";
            if (DALCuonSach.Instance.DelCuonSach(cs.id))
                return "";
            return "Không thể xoá cuốn sách";
        }
        public CUONSACH GetCuonSach(int id)
        {
            return DALCuonSach.Instance.GetCuonSachById(id);
        }
        public CUONSACH GetCuonSach(string id)
        {
            return DALCuonSach.Instance.GetCuonSachByMa(id);
        }
    }

}
