using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTuaSach
    {
        private static DALTuaSach instance;

        public static DALTuaSach Instance
        {
            get
            {
                if (instance == null) instance = new DALTuaSach();
                return instance;
            }
            set => instance = value;
        }
        //public static List<TUASACH> Copy(List<TUASACH> item)
        //{
        //    List<TUASACH> res = new List<TUASACH>();
        //    foreach (var i in item)
        //    {
        //        res.Add(i.Copy());
        //    }
        //    return res;
        //}

        public List<TUASACH> GetAllTuaSach()
        {
            return QLTVDb.Instance.TUASACHes.AsNoTracking().ToList();
        }

        public TUASACH GetTuaSachById (int id)
        {
            return QLTVDb.Instance.TUASACHes.Find(id);
        }
        public bool UpdAnTuaSach(int id, int data)
        {
            
            try
            {
                TUASACH tuaSach = QLTVDb.Instance.TUASACHes.Find(id);
                tuaSach.DaAn = data;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        /// <summary>
        /// Get TUASACH by MaTuaSach
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public TUASACH GetTuaSachByMa(string maTuaSach)
        {
            var res = QLTVDb.Instance.TUASACHes.AsNoTracking().Where(t => t.MaTuaSach == maTuaSach);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        /// <summary>
        /// Find TUASACHs by filter
        /// </summary>
        /// <param name="tenTuaSach"></param>
        /// <param name="theloai"></param>
        /// <param name="tacgias"></param>
        /// <returns></returns>
        public List<TUASACH> FindTuaSach(string tenTuaSach, THELOAI theloai, List<TACGIA> tacgias)
        {
            List<TUASACH> res = QLTVDb.Instance.TUASACHes.AsNoTracking().ToList();
            if (tenTuaSach != null) res = res.Where(t => t.TenTuaSach == tenTuaSach).Select(t => t).ToList();
            if (theloai != null) res = res.Where(t => t.THELOAI == theloai).Select(t => t).ToList();
            if (tacgias != null) 
                foreach(var tacgia in tacgias)
                    res = res.Where(t => t.TACGIAs.Contains(tacgia)).Select(t => t).ToList();
            return res;
        }

        public bool AddTuaSach (string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = new TUASACH();
                tuaSach.TenTuaSach = tenTuaSach;
                tuaSach.idTheLoai = theLoai.id;
                tuaSach.THELOAI = theLoai;
                tuaSach.TACGIAs = dsTacGia;
                tuaSach.DaAn = 0;
                QLTVDb.Instance.TUASACHes.Add(tuaSach);
                QLTVDb.Instance.SaveChanges();

                return true;
            }
            catch
            {
                
                return false;
            }
        }

        public bool UpdTuaSach(int idTuaSach, string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = QLTVDb.Instance.TUASACHes.Find(idTuaSach);
                if (tuaSach == null) return false;
                if (tenTuaSach != null) tuaSach.TenTuaSach = tenTuaSach;
                if (theLoai != null)
                {
                    tuaSach.idTheLoai = theLoai.id;
                    tuaSach.THELOAI = theLoai;
                }
                if (dsTacGia != null) tuaSach.TACGIAs = dsTacGia;
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }


        /// <summary>
        /// Deleting a TUASACH also delete all SACH belonging to it
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public bool DelTuaSach(int id)
        {
            try
            {
                TUASACH tuaSach = GetTuaSachById(id);
                if (tuaSach == null) return false;
                //List<SACH> dsSach = DALSach.Instance.FindSach(tuaSach, null, null);
                //foreach (var sach in dsSach)
                //{
                //    DALSach.Instance.DelSach(sach.MaSach);
                //}
                QLTVDb.Instance.TUASACHes.Remove(tuaSach);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
