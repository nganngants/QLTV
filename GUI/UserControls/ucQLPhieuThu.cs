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
using BUS;
using DTO;
namespace GUI.UserControls
{
    public partial class ucQLPhieuThu : UserControl
    {
        public ucQLPhieuThu()
        {
            InitializeComponent();
            Binding();
            CustomGrid();
        }
        private List<PHIEUTHU> PHIEUTHUList;
        public void Binding()
        {
            PHIEUTHUList = BUSPhieuThu.Instance.GetAllPhieuThu();
            this.PhieuThuGrid.DataSource = PHIEUTHUList;
        }
        public void CustomGrid()
        {
            this.PhieuThuGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PhieuThuGrid.Columns.Add("DocGia", "Độc giả");
            int i = 0;
            foreach (DataGridViewRow row in PhieuThuGrid.Rows)
            {
                row.Cells["DocGia"].Value = PHIEUTHUList[i].DOCGIA.TenDocGia.ToString();
                i++;
                //More code here
            }
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var f = new BmPhieuThuTienPhat();
            f.Show();
        }

     
    }
}
