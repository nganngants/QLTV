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
            if(ngaysinh >DateTime.Now.Date) 
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Lỗi",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            string chucvu = txtChucVu.Text;
            string tendn = txtUsername.Text;
            string matkhau = txtUserpwd.Text;
            int idNhom = (int)comboNhomND.SelectedValue;
            var nhom = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(idNhom);
            bool isDG = false;
            if(ten == "" || matkhau == "" || tendn == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Lỗi",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var cn in nhom.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") isDG = true;
            }
            if (isDG)
            {
                DialogResult res;
                res = MessageBox.Show("Không thể thêm người dùng thuộc nhóm người dùng có chức năng độc giả!" +
                    " Bạn có muốn thêm thẻ độc giả?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    var f = new fAddDocGia();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            int id = BUSNguoiDung.Instance.AddNguoiDung(ten, ngaysinh, chucvu, tendn, matkhau, idNhom);
            if (id != -1)
            {
                
                MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại thông tin!", "Lỗi", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
