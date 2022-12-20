using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace BUS
{
     public class BUSBCTheoTheLoai
    {
        private static BUSBCTheoTheLoai instance;
        public static BUSBCTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSBCTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }
        public List<BCLUOTMUONTHEOTHELOAI> GetAllBC()
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetAllBaoCao();
        }

        public BCLUOTMUONTHEOTHELOAI GetBC(int month, int year)
        {
            var ds = DALBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(month, year);
            if (!ds.Any()) return null;
            return ds.First();
        }

        public BCLUOTMUONTHEOTHELOAI GetBCById(int id)
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoById(id);
        }
        public string AddBC(int thang, int nam)
        {
            if (nam > DateTime.Today.Year || (nam == DateTime.Today.Year && thang > DateTime.Today.Month))
                return "Tháng, năm không hợp lệ";
            int id = DALBCLuotMuonTheoTheLoai.Instance.AddBaoCao(thang, nam);
            if (id != -1)
            {
                List<THELOAI> ltl = DALTheLoai.Instance.GetAllTheLoai();
                foreach (THELOAI tl in ltl)
                {
                    string err = BUSCT_BCLuotMuonTheoThang.Instance.AddCT_BCLuotMuon(id, tl.id, thang, nam);
                    if (err != "") return err;
                }

                DALBCLuotMuonTheoTheLoai.Instance.Compute(id);
                return "";
            }    
            else return "KHông thể lập báo cáo";
        }
        public string DelBC(string Mabc)
        {
            BCLUOTMUONTHEOTHELOAI bc = DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoByMa(Mabc);
            if(bc == null )
            {
                return "Mã báo cáo không hợp lệ";
            }
            if (DALBCLuotMuonTheoTheLoai.Instance.DelBaoCao(bc.id))
                return "";
            return "Lỗi khi xoá báo cáo ";
        }
        
    }
}
