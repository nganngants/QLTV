﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
     public class BUSLoaiDocGia
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
            return DALLoaiDocGia.Instance.GetAllLoaiDocGia();
        }
        public string DelLoaiDocGia(int id)
        {
            if (DALLoaiDocGia.Instance.DelLoaiDocGia(id))
                return "";
            return "Không thể xoá loại độc giá";
        }
        public string AddLoaiDocGia(string name)
        {
            if (name == "") return "Tên loại độc giả không hợp lệ";
            if (DALLoaiDocGia.Instance.AddLoaiDocGia(name))
                return "";
            return "Không thể thêm loại độc giả";
        }
    }
}
