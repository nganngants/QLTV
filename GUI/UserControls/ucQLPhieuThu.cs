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
using DTO;
using BUS;
namespace GUI.UserControls
{
    public partial class ucQLPhieuThu : UserControl
    {
        public ucQLPhieuThu()
        {
            InitializeComponent();
            Binding();
        }
        List<PHIEUTHU> PhieuThuList;
        private void Binding()
        {
            PhieuThuGrid.Rows.Clear();
            PhieuThuList = BUSPhieuThu.Instance.GetAllPhieuThu();
            foreach(PHIEUTHU pt in PhieuThuList)
            {
                if (pt.SoTienThu == null) pt.SoTienThu = 0;
                PhieuThuGrid.Rows.Add(pt.SoPhieuThu, pt.DOCGIA.MaDocGia, pt.SoTienThu, ((DateTime)pt.NgayLap).ToShortDateString());
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuThu();
            f.ShowDialog();
            Binding();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void PhieuThuGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
