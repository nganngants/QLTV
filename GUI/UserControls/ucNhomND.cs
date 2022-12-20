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
    public partial class ucNhomND : UserControl
    {
        public ucNhomND()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            this.gridView.DataSource = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNhomND();
            f.ShowDialog();
            Bind();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return;
            var fInfor = new fInfoNhomND(Convert.ToInt32(gridView.Rows[stt].Cells["id"].Value));
            fInfor.ShowDialog();
            Bind();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
