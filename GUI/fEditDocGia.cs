using BUS;
using DTO;
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
    public partial class fEditDocGia : Form
    {
        private static int id;
        public fEditDocGia(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var dg = BUSDocGia.Instance.GetDocGia(id);
            labelMaDG.Text = "Mã Độc Giả: " + dg.MaDocGia;
            txtHoTen.Text = dg.TenDocGia;
            if (dg.NgaySinh != null) dateNgaySinh.Value = dg.NgaySinh;
            txtDiaChi.Text = dg.DiaChi;
            txtEmail.Text = dg.Email;
            labelNgayLap.Text = dg.NgayLapThe.Date.ToShortDateString();
            labelHan.Text = dg.NgayHetHan.ToShortDateString();

            List<LOAIDOCGIA> LoaiDocGiaList;
            LoaiDocGiaList = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            this.comboLoaiDG.DataSource = LoaiDocGiaList;
            comboLoaiDG.DisplayMember = "TenLoaiDocGia";
            comboLoaiDG.ValueMember = "id";

            comboLoaiDG.SelectedIndex = comboLoaiDG.FindString(dg.LOAIDOCGIA.TenLoaiDocGia);
        }
        private void fEditDocGia_Load(object sender, EventArgs e)
        {
            // Load combo Loai Doc Gia len
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string tenDG = txtHoTen.Text;
            int idLDG = (int)comboLoaiDG.SelectedValue;
            if(tenDG == "")
            {
                MessageBox.Show("Tên độc giả không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            DateTime NgaySinh = dateNgaySinh.Value.Date;

            string err = BUSDocGia.Instance.UpdDocGia(id, tenDG, idLDG, email, DiaChi, NgaySinh);
            if (err == "") MessageBox.Show("Sửa thông tin độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
