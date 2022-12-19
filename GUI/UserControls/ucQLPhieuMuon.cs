using BUS;
using DTO;
using GUI.BM;
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
    public partial class ucQLPhieuMuon : UserControl
    {
        List<PHIEUMUONTRA> PhieuMuonList;
        public ucQLPhieuMuon()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));
            PhieuMuonList = BUSPhieuMuonTra.Instance.GetAllPhieuMuon();
            foreach(PHIEUMUONTRA pmt in PhieuMuonList)
            {
                string NgayTra = (pmt.NgayTra != null) ? (((DateTime)pmt.NgayTra).ToShortDateString()) : ("Chưa trả");
                PhieuMuonGrid.Rows.Add(0,pmt.SoPhieuMuonTra, pmt.CUONSACH.MaCuonSach, pmt.CUONSACH.SACH.TUASACH.TenTuaSach, pmt.DOCGIA.MaDocGia, ((DateTime)pmt.NgayMuon).ToShortDateString(), ((DateTime)pmt.HanTra).ToShortDateString(), NgayTra, pmt.SoTienPhat, img);
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuMuonSach();
            f.ShowDialog();
            Binding();
        }

        private void PhieuMuonGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (e.RowIndex == 0) return;
            if (e.ColumnIndex == 0) return;
            
            var f = new fEditPhieuMuon((Convert.ToInt32(PhieuMuonGrid.Rows[idx].Cells["SoPhieuMuon"].Value)));
            f.ShowDialog();
            Binding();
               
            return;
        }
    }
}
