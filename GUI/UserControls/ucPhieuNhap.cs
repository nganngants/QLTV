using BUS;
using DTO;
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
    public partial class ucPhieuNhap : UserControl
    {
        List<PHIEUNHAPSACH> PhieuNhapList;
        public ucPhieuNhap()
        {
            InitializeComponent();
            Binding();
        }
        private void Binding()
        {
            PhieuNhapList = BUSPhieuNhap.Instance.GetAllPhieuNhap();
            PhieuNhapgrid.DataSource = PhieuNhapList;   
        }

        private void PhieuNhapgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return;
            int idPhieu = (int)PhieuNhapgrid.Rows[stt].Cells["SoPhieuNhap"].Value;
            var f = new fInfoPhieuNhap(idPhieu);
            f.ShowDialog();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }
    }
}
