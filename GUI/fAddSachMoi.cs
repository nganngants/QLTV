using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class fAddSachMoi : Form
    {
        public fAddSachMoi()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            List<TUASACH> TuaSachList = BUSTuaSach.Instance.GetAllTuaSach();
            comboTuaSach.DataSource = TuaSachList;
            comboTuaSach.DisplayMember = "TenTuaSach"+"MaTuaSach";
            comboTuaSach.ValueMember= "id";
            if(comboTuaSach.SelectedValue==null || txtNamXB.Text=="" || txtNhaXB.Text=="" || txtDonGia.Text=="" || txtSoLuongNhap.Text=="")
            {
                ErrorDia.Show("Chưa nhập đủ dữ liệu");
                return;
            }
            int Nam = Convert.ToInt32(txtNamXB.Text);
            string NXB = txtNhaXB.Text.ToString();
            int DonGia = Convert.ToInt32(txtDonGia.Text);
            int soLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            DateTime NgayNhap = dateNgayNhap.Value.Date;
            int ThanhTien = soLuongNhap * DonGia;
            int id = (int)comboTuaSach.SelectedValue;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            string err = BUSSach.Instance.AddSach(id,soLuongNhap,DonGia,Nam,NXB);
            if(err != "")
            {
                ErrorDia.Show(err);
                return;
            }
            int MaPhieuNhap = BUSPhieuNhap.Instance.AddPhieuNhap(NgayNhap);
            if(MaPhieuNhap == -1)
            {
                ErrorDia.Show("Ngày nhập không hợp lệ");
                return;
            }
            err = BUSCT_PhieuNhap.Instance.AddCtPhieuNhap(MaPhieuNhap,id,DonGia,soLuongNhap);
            if(err!="")
            {
                ErrorDia.Show(err);
                return;
            }
            SuccDia.Show("Thêm sách mới thành công");
        }
    }
}
