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
            
            foreach(CUONSACH cs in CuonSachList)
            {
                string TinhTrang = (cs.TinhTrang == 1) ? ("Còn") : ("Đã được mượn");
                CuonSachGrid.Rows.Add(cs.MaCuonSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach, TinhTrang);
            }
            
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucCuonSach_Load(object sender, EventArgs e)
        {
            Binding();
        }
    }
}
