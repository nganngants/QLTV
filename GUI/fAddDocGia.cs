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
using DTO;
namespace GUI
{
    public partial class fAddDocGia : Form
    {
        public fAddDocGia()
        {
            InitializeComponent();
        }

        private void fAddDocGia_Load(object sender, EventArgs e)
        {
            // Load combo Loai Doc Gia len
            List<LOAIDOCGIA> LoaiDocGiaList;
            LoaiDocGiaList = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            this.comboLoaiDG.DataSource = LoaiDocGiaList;
            comboLoaiDG.DisplayMember= "TenLoaiDocGia";
            comboLoaiDG.ValueMember = "id";
            comboLoaiDG.SelectedIndex =0  ;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            // Them doc gia
            string tenDG = txtHoTen.Text;
            int idLDG = (int)comboLoaiDG.SelectedValue;
           
            string email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            DateTime NgaySinh = dateNgaySinh.Value.Date;
            DateTime NgayLapThe = dateNgayLap.Value.Date;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
           
            DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);
            dateNgayHetHan.Text = NgayHetHan.Date.ToString();
            if(tenDG == "" || DiaChi == "" )
            {
                ErrorDia.Text = "Chưa điền đủ thông tin";
                ErrorDia.Show();
                return;
            }

            string messg = BUSDocGia.Instance.AddDocGia(tenDG, idLDG, NgayLapThe, email, DiaChi, NgaySinh, NgayHetHan);
            if (messg != "")
            {
                ErrorDia.Text = messg;
                ErrorDia.Show();

            }
            else
            {
                
                SuccDia.Text = "Thêm độc giả thành công";
                SuccDia.Show();
                this.Close();
            }

        }
        

        private void dateNgayLap_ValueChanged(object sender, EventArgs e)
        {
                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                DateTime NgayLapThe = dateNgayLap.Value.Date;
                DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);
                dateNgayHetHan.Text = NgayHetHan.Date.ToString();
            
        }

    }
}
