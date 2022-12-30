﻿using BUS;
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
    public partial class fEditNguoiDung : Form
    {
        private static int id;
        public fEditNguoiDung(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nd = BUSNguoiDung.Instance.GetNguoiDungById(id);
            labelMaNd.Text += nd.MaNguoiDung;
            txtHoTen.Text = nd.TenNguoiDung;
            txtChucVu.Text = nd.ChucVu;
            txtUsername.Text = nd.TenDangNhap;
            txtUserpwd.Text = nd.MatKhau;
            var dsNND = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach (var n in dsNND)
            {
                n.TenNhomNguoiDung = n.TenNhomNguoiDung + "(" + n.MaNhomNguoiDung + ")";
            }
            labelNhomNND.Text = nd.NHOMNGUOIDUNG.TenNhomNguoiDung;
            //comboNhomND.SelectedValue = nd.id;

            if (nd.NgaySinh != null) dateNgaySinh.Value = (DateTime) nd.NgaySinh;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string chucvu = txtChucVu.Text;
            string tendn = txtUsername.Text;
            string matkhau = txtUserpwd.Text;
            var nd = BUSNguoiDung.Instance.GetNguoiDungById(id);
            string err = BUSNguoiDung.Instance.UpdNguoiDung(id, ten, ngaysinh, chucvu, nd.NHOMNGUOIDUNG.id);

            if (err == "")
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
