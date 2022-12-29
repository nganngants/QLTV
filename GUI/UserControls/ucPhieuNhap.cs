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
       
        public ucPhieuNhap()
        {
            InitializeComponent();
            Binding();
        }
        public void Binding(List<PHIEUNHAPSACH> PhieuNhapList = BUSPhieuNhap.Instance.GetAllPhieuNhap())
        {
            PhieuNhapgrid.DataSource = PhieuNhapList;   
        }
        private void Sorting(int idx)
        {
            this.PhieuNhapgrid.Sort(this.PhieuNhapgrid.Columns[idx], ListSortDirection.Ascending);
        }

        private void PhieuNhapgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1)
            {
                Sorting(e.ColumnIndex);
                return;
            }
            int idPhieu = (int)PhieuNhapgrid.Rows[stt].Cells["SoPhieuNhap"].Value;
            var f = new fInfoPhieuNhap(idPhieu);
            f.ShowDialog();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void PhieuNhapgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<PHIEUNHAPSACH> Res = new List<PHIEUNHAPSACH>();
            foreach(PHIEUNHAPSACH pn in BUSPhieuNhap.Instance.GetAllPhieuNhap())
            {
                if (pn.SoPhieuNhap.ToString().Contains(pat) || pn.NgayNhap.ToShortTimeString().Contains(pat))
                    Res.Add(pn);
            }
            Binding(Res);

        }
    }
}
