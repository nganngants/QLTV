using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    internal class BUSDocGia
    {
        private static BUSDocGia instance;
        public static BUSDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSDocGia();
                return instance;
            }
            set => instance = value;     
        }
        public List<DOCGIA> GetAllDocGia()
        {
            return DALDocGia.Instance.GetAllDocGia();
        }
        public DOCGIA GetDocGia(string id)
        {
            return DALDocGia.Instance.GetDocGiaById(id);
        }
        public bool DelDocGia(string id)
        {
            DOCGIA dg = DALDocGia.Instance.GetDocGiaById(id);
            foreach(PHIEUMUONTRA PhieuMuon in dg.PHIEUMUONTRAs)
            {
                //
                return false;
            }
            DALDocGia.Instance.DelDocGia(id);
            return true;
        }
    }
}
