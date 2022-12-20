using BUS;
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

namespace GUI.UserControls
{
    public partial class ucNguoiDung : UserControl
    {
        public ucNguoiDung()
        {
            InitializeComponent();
            Bind();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNguoiDung();
            f.ShowDialog();
            Bind();
        }

        private void Bind()
        {
            dataGrid.Rows.Clear();
            var dsND = BUSNguoiDung.Instance.GetAllNguoiDung();
            foreach (var nd in dsND)
                dataGrid.Rows.Add(nd.MaNguoiDung, 
                    nd.TenNguoiDung,  nd.ChucVu, nd.TenDangNhap, nd.NHOMNGUOIDUNG.TenNhomNguoiDung);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return;
            var f = new fInfoNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGrid.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
            f.Show();
            Bind();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
