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
            this.labelMaNhom.Text += nnd.MaNhomNguoiDung.ToString();
            this.labelTenNhom.Text += nnd.TenNhomNguoiDung;
        }

    }
}
