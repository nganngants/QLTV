using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.UserControls
{
    public partial class ucQLPhieuMuon : UserControl
    {
        public ucQLPhieuMuon()
        {
            InitializeComponent();
            Binding();
            CustGrid();
        }
        private List<PHIEUMUONTRA> PhieuMuontraList;
        public void Binding()
        {
            PhieuMuontraList = BUSPhieuMuonTra.Instance.GetAllPHIEUMUONTRA();   
            this.PhieuMuonTraGrid.DataSource= PhieuMuontraList; 
        }
        public void CustGrid()
        {
            int i = 0;
            foreach(DataGridViewRow row in PhieuMuonTraGrid.Rows)
            {
                if (row.Cells["NgayTra"].Value == null)
                    row.Cells["NgayTra"].Value = "Chưa trả";
                row.Cells["MaDocGia"].Value = PhieuMuontraList[i].DOCGIA.MaDocGia;
                i++;
            }
        }
    }
}
