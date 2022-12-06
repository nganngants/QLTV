using DAL;
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
        public List<SACH> GetAllSach(string id)
        {
            return DALSach.Instance.GetAllSach(id);
        }
        public bool AddSach(string TuaSachid, )
    }
}
