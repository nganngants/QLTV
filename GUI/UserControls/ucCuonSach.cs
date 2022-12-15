using BUS;
using DTO;
using GUI.Tab;
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

namespace GUI.UserControls
{
    public partial class ucCuonSach : UserControl
    {
        public ucCuonSach()
        {
            InitializeComponent();
            Binding();
        }
        List<CUONSACH> CuonSachList;
        public void Binding()
        {
            CuonSachList = BUSCuonSach.Instance.GetAllCuonSach();
            this.CuonSachGrid.DataSource = CuonSachList;
        }
        public void CustGrid()
        {
            int i = 0;
            foreach (DataGridViewRow row in CuonSachGrid.Rows)
            {
                row.Cells["MaSach"].Value = CuonSachList[i].SACH.MaSach;
                i++;
            }
        }
    }
}
