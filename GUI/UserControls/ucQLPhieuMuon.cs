using BUS;
using DTO;
using GUI;
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
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
            List<string> comboList = new List<string> { "Chưa trả", "Đã trả"};
            comboTinhTrang.DataSource = comboList;
        }
        private void Binding(List<PHIEUMUONTRA> PhieuMuonList)
        {
            PhieuMuonGrid.Rows.Clear();
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));
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
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
        }

        private void PhieuMuonGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PhieuMuonGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (e.ColumnIndex == 0) return;
            if (idx == -1) return;
            var f = new fEditPhieuMuon((Convert.ToInt32(PhieuMuonGrid.Rows[idx].Cells["SoPhieuMuon"].Value)));
            f.ShowDialog();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());

            return;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
            txtFind.Text = "";
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<PHIEUMUONTRA> Res = new List<PHIEUMUONTRA>();
            foreach(PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuon())
            {
                if (pmt.CUONSACH.MaCuonSach.ToLower().Contains(pat) || pmt.DOCGIA.MaDocGia.ToLower().Contains(pat) || pmt.SoPhieuMuonTra.ToString().Contains(pat))
                    Res.Add(pmt);
            }
            Binding(Res);
        }


        private void butFil_Click(object sender, EventArgs e)
        {
            string pat = comboTinhTrang.SelectedValue.ToString();
          
            List<PHIEUMUONTRA> Res = new List<PHIEUMUONTRA>();
           
                foreach (PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuon())
                {

                    if (pmt.NgayTra != null && pat == "Đã trả")
                        Res.Add(pmt);
                   Console.Write(pmt.NgayTra.ToString());
                    if(pmt.NgayTra == null && pat == "Chưa trả") 
                        Res.Add(pmt);
                }
            Binding(Res);
        }

        private void butFindNgay_Click(object sender, EventArgs e)
        {

        }
    }
}
