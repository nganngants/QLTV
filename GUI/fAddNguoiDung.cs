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
    public partial class fAddNguoiDung : Form
    {
        public fAddNguoiDung()
        {
            InitializeComponent();
            Bind();
        }

        private void Bind()
        {
            var dsNND = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach (var n in dsNND)
            {
                n.TenNhomNguoiDung = n.TenNhomNguoiDung + "(" + n.MaNhomNguoiDung + ")";
            }    
            comboNhomND.DataSource = dsNND;
            comboNhomND.ValueMember = "id";
            comboNhomND.DisplayMember = "TenNhomNguoiDung";
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            DateTime ngaysinh = dateNgaySinh.Value.Date;
            string chucvu = txtChucVu.Text;
            string tendn = txtUsername.Text;
            string matkhau = txtUserpwd.Text;
            int id = (int)comboNhomND.SelectedValue;

            string err = BUSNguoiDung.Instance.AddNguoiDung(ten, ngaysinh, chucvu, tendn, matkhau, id);
            if (err == "")
            {
                MessageBox.Show("Thêm người dùng thành công");
                this.Close();
            }
            else MessageBox.Show(err);

        }
    }
}
