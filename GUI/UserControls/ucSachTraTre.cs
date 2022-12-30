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
    public partial class ucSachTraTre : UserControl
    {
        public ucSachTraTre()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
           

        }

        private void butAdd_Click_1(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            var ngayBC = dateBC.Value;
            var bc = BUSBCSachTraTre.Instance.GetBaoCao(ngayBC);
            if (bc == null)
            {
                string err = BUSBCSachTraTre.Instance.AddBaoCao(ngayBC);
                if (err != "")
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bc = BUSBCSachTraTre.Instance.GetBaoCao(ngayBC);
            }
            if (bc == null)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 1;
            dataGrid.Rows.Clear();
            foreach (var b in bc)
            {
                dataGrid.Rows.Add(i, b.CUONSACH.MaCuonSach, b.CUONSACH.SACH.TUASACH.TenTuaSach, b.NgayMuon.ToShortDateString(), b.SoNgayTre);
                i++;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
