using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUSSach
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
        public string UpdAnSach(int id,int data)
        {
            SACH sach = DALSach.Instance.GetSachById(id);
            foreach (CUONSACH cs in sach.CUONSACHes)
            {
                if (cs.TinhTrang == 0 && data == 1) return "Sách đang có người mượn, không thể ẩn";
            }
            foreach (CUONSACH cs in sach.CUONSACHes)
            {
                string err = BUSCuonSach.Instance.UpdAnCuonSach(cs.MaCuonSach, data);
                if (err != "") return err;
            }
            if (DALSach.Instance.UpdAnSach(id, data))
                return "";
            else return "Lỗi";
        }
        public Tuple<string,int> AddSach(int id, int SoLuong, int DonGia, int NamXb, string NhaXB)
        {
            TUASACH ts;
            ts = DALTuaSach.Instance.GetTuaSachById(id);
            if(ts == null)
            {
                return Tuple.Create("Tựa sách không hợp lệ",-1);
            }
            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            if ((int)DateTime.Now.Year - NamXb > thamso.KhoangCachXuatBan || (int)DateTime.Now.Year - NamXb <0)
                return Tuple.Create("Năm xuất bản không hợp lệ",-1);
            int idSach = DALSach.Instance.AddSachMoi(ts, DonGia, NamXb, NhaXB);
            if (idSach != -1)
                return Tuple.Create("",idSach);
            return Tuple.Create("Không thể thêm sách"   , -1)   ;
        }
        public TUASACH GetTuaSachOfSach(string MaSach)
        {
            TUASACH ts;
            ts = DALTuaSach.Instance.GetTuaSachByMa(MaSach);
            if(ts == null)
            {
                return null;
            }
            return ts;
        }
        public string DelSach(int id)
        {
            SACH sach = DALSach.Instance.GetSachById(id);
            foreach(CUONSACH cs in sach.CUONSACHes)
            {
                if(cs.TinhTrang == 0)
                {
                    return "Không thể xoá sách vì đang có người mượn.";
                }
            }
            if (DALSach.Instance.DelSach(id))
                return "";
            return "Không thể xoá sách.";
        }
        public SACH GetSach(int id)
        {
            return DALSach.Instance.GetSachById(id);
        }
    }
}
