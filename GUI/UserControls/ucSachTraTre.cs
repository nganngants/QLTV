using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucSachTraTre : UserControl
    {
        public ucSachTraTre()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var date = dateBC.Value;
            var ds = BUSPhieuMuonTra.Instance.GetPhieuTraTre(date);
            foreach (var p in ds)
            {
                int soNgayTre = (date - p.HanTra).Value.Days;
                dataGrid.Rows.Add(p.SoPhieuMuonTra, p.CUONSACH.MaCuonSach, p.DOCGIA.MaDocGia, p.NgayMuon, p.HanTra, soNgayTre);
            }
        }
    }
}
