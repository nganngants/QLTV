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
    public partial class fEditNhomND : Form
    {
        private static int id;
        public fEditNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            labelMaNND.Text += nnd.MaNhomNguoiDung;
            txtTenNhom.Text = nnd.TenNhomNguoiDung;
            var dscn = BUSChucNang.Instance.GetAllChucNang();
            dsChucNang.DataSource = dscn;
            //dsChucNang.VirtualMode = true;
            foreach (DataGridViewRow row in dsChucNang.Rows)
            {
                var cn = BUSChucNang.Instance.GetChucNangById(Convert.ToInt32(row.Cells["idCol"].Value));
                if (nnd.CHUCNANGs.Contains(cn))
                {
                    //Console.WriteLine(cn.TenChucNang);
                    row.Cells["isChoosen"].Value = "1";
                }
            }    
        }

    }
}
