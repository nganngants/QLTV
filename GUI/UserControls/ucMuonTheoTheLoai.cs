using BUS;
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
    public partial class ucMuonTheoTheLoai : UserControl
    {
        public ucMuonTheoTheLoai()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            int month = dateBC.Value.Month;
            int year = dateBC.Value.Year;
            
            var bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            if (bc == null)
            {
                string err = BUSBCTheoTheLoai.Instance.AddBC(month, year);
                if (err != "")
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            }
            labelTongLM.Text = "Tổng số lượt mượn: " + bc.TongSoLuotMuon.ToString();
            var ctbc = bc.CT_BCLUOTMUONTHEOTHELOAI;
            dataGrid.Rows.Clear();  
            foreach (var c in ctbc )
            {
                dataGrid.Rows.Add(c.THELOAI.MaTheLoai, c.THELOAI.TenTheLoai, c.SoLuotMuon, c.TiLe);
            }
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            int month = dateBC.Value.Month;
            int year = dateBC.Value.Year;

            var bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            if (bc == null)
            {
                MessageBox.Show("Chưa có báo cáo trong tháng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show("Bạn có chắc muốn xóa báo cáo của tháng" + month.ToString() + "/" + year.ToString() + "?",
                "Xóa báo cáo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            BUSBCTheoTheLoai.Instance.DelBC(bc.MaBaoCao);
            MessageBox.Show("Đã xóa báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGrid.Rows.Clear();
        }
    }
}
