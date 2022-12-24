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

namespace GUI
{
    public partial class fInfoNhomND : Form
    {
        private static int id;
        public fInfoNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            this.dsChucNang.DataSource = nnd.CHUCNANGs.ToList();
            this.labelMaNhom.Text = "Mã Nhóm Người Dùng: " + nnd.MaNhomNguoiDung.ToString();
            this.labelTenNhom.Text = "Tên Nhóm Người Dùng: " + nnd.TenNhomNguoiDung;
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditNhomND(id);
            f.ShowDialog();
            Bind();
        }
    }
}
