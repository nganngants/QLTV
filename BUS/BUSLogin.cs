using DAL;
using DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSLogin
    {
        private static NGUOIDUNG usr{ get; set; }
        private static BUSLogin instance;
        public static BUSLogin Instance
        {
            get
            {
                if (instance == null) instance = new BUSLogin();
                return instance;
            }
            set => instance = value;
        }
        public bool checkValidLogin(string usrname, string usrpwd)
        {
            List<NGUOIDUNG> found = DALNguoiDung.Instance.GetAllNguoiDung();
            foreach (var user in found)
            {
                if (user.TenDangNhap == usrname)
                    if(user.MatKhau == usrpwd)
                    {
                        usr = user;
                        return true;
                    }
            }
            return false;
        }
    }
}
