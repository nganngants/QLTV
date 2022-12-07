﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        private static DALTacGia instance;

        public static DALTacGia Instance 
        { 
            get
            {
                if (instance == null) instance = new DALTacGia();
                return instance;
            }
            set => instance = value; 
        }

        public List<TACGIA> GetAllTacGia()
        {
            return QLTVDb.Instance.TACGIAs.ToList();
        }

        public TACGIA GetTacGiaById (int id)
        {
            return QLTVDb.Instance.TACGIAs.Find(id);
        }

        /// <summary>
        /// get TACGIA by maTacGia
        /// </summary>
        /// <param name="maTacGia"></param>
        /// <returns></returns>
        public TACGIA GetTacGiaByMa(string maTacGia)
        {
            return QLTVDb.Instance.TACGIAs.Where(t => t.MATACGIA == maTacGia).FirstOrDefault();
        }

        /// <summary>
        /// find TACGIA by filter 
        /// </summary>
        /// <param name="tenTacGia"></param>
        /// <returns></returns>
        public List<TACGIA> FindTacGia(string tenTacGia)
        {
            return QLTVDb.Instance.TACGIAs.Where(t => t.TenTacGia == tenTacGia).Select(t => t).ToList();
        }
        public bool AddTacGia (string tenTacGia)
        {
            try
            {
                TACGIA tacGia = new TACGIA { TenTacGia = tenTacGia };
                QLTVDb.Instance.TACGIAs.Add(tacGia);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdTacGia(int id, string tenTacGia)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                tacgia.TenTacGia = tenTacGia;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTacGia(int id)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                QLTVDb.Instance.TACGIAs.Remove(tacgia);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}