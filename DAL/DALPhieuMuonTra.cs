using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuMuonTra
    {
        public QLTVDb db;

        public DALPhieuMuonTra(QLTVDb dbContext)
        {
            this.db = dbContext;
        }

        public DALPhieuMuonTra()
        {
            db = new QLTVDb();
        }
        private static DALPhieuMuonTra instance;

        public static DALPhieuMuonTra Instance 
        { 
            get
            {
                if (instance == null) instance = new DALPhieuMuonTra();
                return instance;
            }
            set => instance = value; 
        }

        public List<PHIEUMUONTRA> GetAllPhieuMuonTra()
        {
            return db.PHIEUMUONTRAs.ToList();
        }

        public PHIEUMUONTRA GetPhieuMuonTraById(int id)
        {
            return db.PHIEUMUONTRAs.Find(id);
        }

        public List<PHIEUMUONTRA> FindTheoNgayMuon (int? ngay, int? thang, int? nam)
        {
            return db.PHIEUMUONTRAs.Where(i => i.NgayMuon.Day == ngay && i.NgayMuon.Month == thang && i.NgayMuon.Year == nam).ToList();

        }


        public List<PHIEUMUONTRA> FindTheoNgayTra(int? ngay, int? thang, int? nam)
        {
            return db.PHIEUMUONTRAs
            .Where(i => i.NgayTra.HasValue && i.NgayTra.Value.Day == ngay && i.NgayTra.Value.Month == thang && i.NgayTra.Value.Year == nam)
            .ToList();
        }
        public List<PHIEUMUONTRA> FindPhieuMuonTre(DateTime today)
        {
            return db.PHIEUMUONTRAs.Where(p => p.NgayTra == null && p.HanTra < today).ToList();
        }


        public List<PHIEUMUONTRA> FindPhieuMuonByDocGia (int idDocGia)
        {
            return db.PHIEUMUONTRAs.Where(p => p.idDocGia == idDocGia).ToList();
        }
        public bool AddPhieuMuonTra(PHIEUMUONTRA phieuMuonTra)
        {
            db.PHIEUMUONTRAs.Add(phieuMuonTra);
            db.SaveChanges();
            return true;
        }

        public bool UpdPhieuMuonTra(int soPhieu, DateTime? ngayMuon, DateTime? hanTra, DateTime? ngayTra, int? soTienPhat)
        {
            try
            {
                var phieu = GetPhieuMuonTraById(soPhieu);
                if (phieu == null) return false;
                if (ngayMuon != null) phieu.NgayMuon = ngayMuon.Value;
                if (hanTra != null) phieu.HanTra = hanTra.Value;
                if (ngayTra != null)
                {
                    phieu.NgayTra = ngayTra;
                    // mark cuonsach as unborrowed
                   // DALCuonSach.Instance.UpdCuonSach((int)phieu.idCuonSach, 1);
                }
                if (soTienPhat != null) phieu.SoTienPhat = soTienPhat;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DelPhieuMuonTra(int soPhieu)
        {
            try
            {
                var phieu = GetPhieuMuonTraById(soPhieu);
                if (phieu == null) return false;
                db.PHIEUMUONTRAs.Remove(phieu);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
    }
}
