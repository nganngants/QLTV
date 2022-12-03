using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNguoiDung
    {
        private static DALNguoiDung instance;

        public static DALNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new DALNguoiDung();
                return instance;
            }
            set => instance = value;
        }

        public List<NGUOIDUNG> getAllNguoiDung()
        {
            using (var db = new QLTVDb())
            {
                return db.NGUOIDUNGs.ToList();
            }
        }
    }
}
