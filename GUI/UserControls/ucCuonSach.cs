using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DTO;
using BUS;
namespace GUI.UserControls
{

    public partial class ucCuonSach : UserControl
    {
        private List<CUONSACH> CuonSachList;
        public ucCuonSach()
        {
            InitializeComponent();
            Binding();
        }
        private void Binding()
        {
            CuonSachList = BUSCuonSach.Instance.GetAllCuonSach();
            this.CuonSachGrid.DataSource = CuonSachList;
            int i = 0;
            foreach(DataGridViewRow row in this.CuonSachGrid.Rows)
            {
                row.Cells["TenSach"].Value = CuonSachList[i].SACH.TUASACH.TenTuaSach;
                row.Cells["MaSach"].Value = CuonSachList[i].SACH.MaSach;
                row.Cells["TinhTrang"].Value = (CuonSachList[i].TinhTrang == 1) ? "Đã mượn" : "Còn";
                CuonSachGrid.UpdateCellValue(2, i);
                this.CuonSachGrid.NotifyCurrentCellDirty(true);
                i++;
            }
        }
    }
}
