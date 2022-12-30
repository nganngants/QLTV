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
using DTO;
using BUS;
namespace GUI.UserControls
{
    public partial class ucQLPhieuThu : UserControl
    {
        public ucQLPhieuThu()
        {
            InitializeComponent();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }
       
        public void Binding(List<PHIEUTHU> PhieuThuList)
        {
            PhieuThuGrid.Rows.Clear();
            foreach(PHIEUTHU pt in PhieuThuList)
            {
                PhieuThuGrid.Rows.Add(pt.SoPhieuThu, pt.DOCGIA.MaDocGia, pt.SoTienThu, ((DateTime)pt.NgayLap).ToShortDateString());
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuThu();
            f.ShowDialog();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }


        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<PHIEUTHU> Res = new List<PHIEUTHU>();
            foreach(PHIEUTHU pt in BUSPhieuThu.Instance.GetAllPhieuThu())
            {
                if (pt.DOCGIA.MaDocGia.ToLower().Contains(pat)
                    || pt.SoPhieuThu.ToString().Contains(pat)
                    || pt.NgayLap.ToShortDateString().Contains(pat))
                    Res.Add(pt);
            }
            Binding(Res);
        }
    }
}
