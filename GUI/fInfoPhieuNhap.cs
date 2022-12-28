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
    public partial class fInfoPhieuNhap : Form
    {
        private static int id;
        public fInfoPhieuNhap(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var phieu = BUSPhieuNhap.Instance.GetPhieuNhap(id);
            var dsct = phieu.CT_PHIEUNHAP.ToList();
            labelNgayNhap.Text = phieu.NgayNhap.ToShortDateString();
            labelSoPhieu.Text = phieu.SoPhieuNhap.ToString();
            labelTongTien.Text = phieu.TongTien.ToString();
            foreach (var ct in dsct)
            {
                dataGrid.Rows.Add(ct.SACH.MaSach, ct.SACH.TUASACH.TenTuaSach, ct.SACH.DonGia, ct.SoLuongNhap, ct.ThanhTien);
            }
        }
    }
}
