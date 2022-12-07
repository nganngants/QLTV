using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class BUSSach
    {
        private static BUSSach instance;
        public static BUSSach Instance
        {
            get
            {
                if (instance == null) instance = new BUSSach();
                return instance;
            }
            set => instance = value;
        }
        public List<SACH> GetAllSach()
        {
            return DALSach.Instance.GetAllSach();
        }
        public string AddSach(string MaTuaSach, int SoLuong, int DonGia, int NamXb, string NhaXB)
        {
            try
            {
                TUASACH ts = DALTuaSach.Instance.GetTuaSachByMa(MaTuaSach);
            }
            catch
            {
                return "Tựa sách không hợp lệ";
            }

            if (DALSach.Instance.AddSachMoi(ts, SoLuong, DonGia, NamXb, NhaXB))
                return "";
            return "Không thể thêm sách";
        }
        public string DelSach(string id)
        {
            SACH sach = DALSach.Instance.GetSach(id);
            foreach(CUONSACH cs in sach.CUONSACHes)
            {
                if(cs.TinhTrang == 1)
                {
                    return "Không thể xoá sách vì đang có người mượn."
                }
            }
            if (DALCuonSach.Instance.DelSach(id))
                return "";
            return "Không thể xoá sách.";
        }
        public SACH GetSach(string id)
        {
            return DALSach.Instance.GetSach(id);
        }
    }
}
