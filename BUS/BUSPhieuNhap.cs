using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
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
        public List<PHIEUNHAP> GetAllPhieuNhap()
        {
            return DALPhieuNhap.Instance.GetAllPhieuNhap();
        }
        public PHIEUNHAPSACH GetPhieuNhap(string MaPhieuNhap)
        {
            return DALPhieuNhapSach.Instance.GetPhieuNhap(MaPhieuNhap); 
        }
    }
}
