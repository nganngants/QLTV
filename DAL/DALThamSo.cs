using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DALThamSo
    {
        private static DALThamSo instance;

        public static DALThamSo Instance
        {
            get
            {
                if (instance == null) instance = new DALThamSo();
                return instance;
            }
            set => instance = value;
        }
        public DALThamSo() { }
        public THAMSO GetAllThamSo()
        {
            return QLTVDb.Instance.ThamSo.ToList();
        }
        
    }
}
