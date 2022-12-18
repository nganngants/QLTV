﻿using DAL;
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
        public string AddSach(int id, int SoLuong, int DonGia, int NamXb, string NhaXB)
        {
            TUASACH ts;
            ts = DALTuaSach.Instance.GetTuaSachById(id);
            if(ts == null)
            {
                return "Tựa sách không hợp lệ";
            }
            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            if ((int)DateTime.Now.Year - NamXb > thamso.KhoangCachXuatBan)
                return "Năm xuất bản không hợp lệ";
            int idSach = DALSach.Instance.AddSachMoi(ts, DonGia, NamXb, NhaXB);
            if (idSach != -1)
                return "";
            return "Không thể thêm sách";
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
                if(cs.TinhTrang == 1)
                {
                    return "Không thể xoá sách vì đang có người mượn.";
                }
            }
            if (DALSach.Instance.DelSach(id))
                return "";
            return "Không thể xoá sách.";
        }
        public SACH GetSach(string id)
        {
            return DALSach.Instance.GetSachByMa(id);
        }
    }
}
