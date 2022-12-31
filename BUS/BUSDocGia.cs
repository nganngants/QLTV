using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
     public class BUSDocGia
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
        public List<DOCGIA> GetDocGiaConHan()
        {
            var res = new List<DOCGIA>();
            foreach(DOCGIA docgia in DALDocGia.Instance.GetAllDocGia())
                if(docgia.NgayLapThe <= DateTime.Now.Date && docgia.NgayHetHan >= DateTime.Now.Date )
                    res.Add(docgia);
            return res;
        }
        public DOCGIA GetDocGia(int MaDocGia)
        {
            DOCGIA dg;
            try
            {
               dg =  DALDocGia.Instance.GetDocGiaById(MaDocGia);
                return dg;
            }
            catch
            {
                return null;
            }
        }

        public DOCGIA FindDocGiaByIdND(int idNguoiDung)
        {
            return DALDocGia.Instance.FindDocGiaByIdND(idNguoiDung);
        }
        public int GetSoSachDangMuon(int id)
        {
            int cnt = 0;
            DOCGIA dg = DALDocGia.Instance.GetDocGiaById(id);
            foreach (PHIEUMUONTRA pmt in dg.PHIEUMUONTRAs)
                if (pmt.NgayTra == null)
                    cnt++;
            return cnt;
        }
        public string DelDocGia(int id)
        {
            DOCGIA dg;
            try
            {
            dg = DALDocGia.Instance.GetDocGiaById(id);
            }
            catch
            {
                return "Mã độc giả không hợp lệ";
            }
            if(dg.PHIEUMUONTRAs != null)
            foreach( PHIEUMUONTRA PhieuMuon in dg.PHIEUMUONTRAs)
            {
                if(PhieuMuon.NgayTra==null)
                return "Độc giả" + dg.MaDocGia + "còn sách đang mượn";
            }
           
            DALDocGia.Instance.DelDocGia(dg.ID);
            return "";
        }
        public string AddDocGia(string ten, int idLDG,DateTime NgayLapThe,string Email,string DiaChi,DateTime NgaySinh,DateTime NgayHetHan,
            string username, string userpwd, string chucVu, int idNND)
        {
            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            int gap = NgayLapThe.Year - NgaySinh.Year;
            if(NgayLapThe.Month < NgaySinh.Month || (NgayLapThe.Month == NgaySinh.Month && NgayLapThe.Day <NgaySinh.Day))
                gap -=1;
                
            if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
                return "Tuổi không hợp lệ!";

            var ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById(idLDG);
            if (ldg == null) return "Loai Doc Gia khong hop le";

            int idND = DALNguoiDung.Instance.AddNguoiDung(ten, NgaySinh, chucVu, username, userpwd, idNND);
            if (idND == -1) return "Tên đăng nhập đã tồn tại";
            if (DALDocGia.Instance.AddDocGia(ten, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, idLDG, 0, idND))
                return "";
            DALNguoiDung.Instance.DelNguoiDung(idND);
            return "Lỗi khi thêm độc giả";
        }

        public string UpdDocGia(int id, string ten, int? idLDG, string Email, string diaChi, DateTime? NgaySinh)
        {
            var dg = GetDocGia(id);
            if (NgaySinh != null)
            {
                var NgayLapThe = dg.NgayLapThe;
                THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
                int gap = NgayLapThe.Year - NgaySinh.Value.Year;
                if (NgayLapThe.Month < NgaySinh.Value.Month || (NgayLapThe.Month == NgaySinh.Value.Month && NgayLapThe.Day < NgaySinh.Value.Day))
                    gap -= 1;

                if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
                    return "Tuổi không hợp lệ";
                if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
                    return "Tuổi không hợp lệ";
            }
            if (idLDG != null)
            {
                var ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById((int)idLDG);
                if (ldg == null) return "Loại độc giả không hợp lệ";
            }
            if(DALDocGia.Instance.UpdDocGia(id, ten, NgaySinh, diaChi, Email, null, idLDG))
                return "";
            return "Sửa thông tin thất bại";
        }
        public string UpdTongNo(int id,int TongNo)
        {
            DOCGIA dg = DALDocGia.Instance.GetDocGiaById(id);
            if (dg == null) return "Mã độc giả không hợp lệ";
            if (TongNo < 0)
                return "Nợ không hợp lệ";
            DALDocGia.Instance.UpdTongNoDocGia(id,TongNo);
            return "";

        }
    }
}
