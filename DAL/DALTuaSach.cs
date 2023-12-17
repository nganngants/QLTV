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
        public QLTVDb db;

        public DALTuaSach(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALTuaSach()
        {
            db = new QLTVDb();
        }
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
            return db.TUASACHes.ToList();
        }

        public TUASACH GetTuaSachById (int id)
        {
            return db.TUASACHes.Find(id);
        }
       
        /// <summary>
        /// Get TUASACH by MaTuaSach
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public TUASACH GetTuaSachByMa(string maTuaSach)
        {
            TUASACH tuaSach = db.TUASACHes.FirstOrDefault(p => p.MaTuaSach == maTuaSach);
            return tuaSach;
        }

        /// <summary>
        /// Find TUASACHs by filter
        /// </summary>
        /// <param name="tenTuaSach"></param>
        /// <param name="theloai"></param>
        /// <param name="tacgias"></param>
        /// <returns></returns>
      

       

      


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
                db.TUASACHes.Remove(tuaSach);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
