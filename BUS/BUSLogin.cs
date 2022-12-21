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
        public int checkValidLogin(string usrname, string usrpwd)
        {
            List<NGUOIDUNG> found = DALNguoiDung.Instance.GetAllNguoiDung();
            foreach (var user in found)
            {
                if (user.TenDangNhap == usrname)
                    if(user.MatKhau == usrpwd)
                    {
                        return user.id;
                    }
            }
            return -1;
        }
    }
}
