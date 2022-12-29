using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBCSachTraTre
    {
        private static DALBCSachTraTre instance;

        public static DALBCSachTraTre Instance
        {
            get
            {
                if (instance == null) instance = new DALBCSachTraTre();
                return instance;
            }
            set => instance = value;
        }

        public List<BCSACHTRATRE> GetAllBaoCao ()
        {
            return QLTVDb.Instance.BCSACHTRATREs.AsNoTracking().ToList();
        }

        public BCSACHTRATRE GetBaoCao(DateTime ngayBaoCao, int idCuonSach)
        {
            return QLTVDb.Instance.BCSACHTRATREs.Find(new object[] {ngayBaoCao, idCuonSach});
        }

        public List<BCSACHTRATRE> FindBaoCaoByDate(DateTime ngayBC)
        {
            return QLTVDb.Instance.BCSACHTRATREs.AsNoTracking().Where(b => 
            b.Ngay.Day == ngayBC.Day && b.Ngay.Month == ngayBC.Month && b.Ngay.Year == ngayBC.Year).ToList();
        }

        public List<BCSACHTRATRE> FindBaoCaoByCuonSach (int idCuonSach)
        {
            return QLTVDb.Instance.BCSACHTRATREs.AsNoTracking().Where(b => b.idCuonSach == idCuonSach).ToList();   
        }

        public bool AddBaoCao(DateTime ngayBC, int idCuonSach, DateTime ngayMuon, int soNgayTre)
        {
            try
            {
                var bc = new BCSACHTRATRE
                {
                    Ngay = ngayBC,
                    idCuonSach = idCuonSach,
                    CUONSACH = DALCuonSach.Instance.GetCuonSachById(idCuonSach),
                    NgayMuon = ngayMuon,
                    SoNgayTre = soNgayTre
                };
                QLTVDb.Instance.BCSACHTRATREs.Add(bc);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelBaoCao (DateTime ngayBC, int idCuonSach)
        {
            try
            {
                var bc = GetBaoCao(ngayBC, idCuonSach);
                if (bc == null) return false;
                QLTVDb.Instance.BCSACHTRATREs.Remove(bc);
                QLTVDb.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
