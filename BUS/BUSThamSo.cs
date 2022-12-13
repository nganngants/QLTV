using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSThamSo
    {
        private static BUSThamSo instance;
        public static BUSThamSo Instance
        {
            get
            {
                if (instance == null) instance = new BUSThamSo();
                return instance;
            }
            set => instance = value;
        }
        public THAMSO GetAllThamSo()
        {
            return DALThamSo.Instance.GetAllThamSo();
        }
        public string UpdThoiHanThe(int val)
        {
            if (DALThamSo.Instance.UpdThoiHanThe(val))
                return "";
            return "Lỗi";
        }
        public string UpdKCXB(int val)
        {
            if (DALThamSo.Instance.UpdKhoangCachXB(val))
                return "";
            return "Lỗi";
        }
        public string UpTuoiToiDa(int val)
        {
            if (DALThamSo.Instance.UpdTuoiToiDa(val))
                return "";
            return "Lỗi";
        }
        public string UpdTuoiToiThieu(int val)
        {
            if (DALThamSo.Instance.UpdTuoiToiThieu(val))
                return "";
            return "Lỗi";
        }
        public string UpdSoNgayMuon(int val)
        {
            if (DALThamSo.Instance.UpdSoNgayMuonToiDa(val))
                return "";
            return "Lỗi";
        }
        public string UpdSoSachToiDa(int val)
        {
            if (DALThamSo.Instance.UpdSoNgayMuonToiDa(val))
                return "";
            return "Lỗi";
        }
        public string UpdADQDTienPhat(int val)
        {
            if (DALThamSo.Instance.UpdSoNgayMuonToiDa(val))
                return "";
            return "Lỗi";
        }
        public string UpdDonGiaPhat(int val)
        {
            if (DALThamSo.Instance.UpdDonGiaPhat(val))
                return "";
            return "Lỗi";
        }
        
    }
}
