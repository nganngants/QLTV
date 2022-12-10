using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class BUSPhieuNhap
    {
        private static BUSPhieuNhap instance;
        public static BUSPhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUSPhieuNhap();
                return instance;
            }
            set => instance = value;
        }
        public List<PHIEUNHAPSACH> GetAllPhieuNhap()
        {
            return DALPhieuNhapSach.Instance.GetAllPhieuNhapSach();
        }
        public PHIEUNHAPSACH GetPhieuNhap(int MaPhieuNhap)
        {

            return DALPhieuNhapSach.Instance.GetPhieuById(MaPhieuNhap);
        }
    }
}
