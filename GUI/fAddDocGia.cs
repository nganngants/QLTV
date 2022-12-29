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
            dateNgayLap.Value = DateTime.Now;

            var nndList = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            List<NHOMNGUOIDUNG> dgList = new List<NHOMNGUOIDUNG>();
            foreach (var nnd in nndList)
            {
                bool isDG = false;
                foreach (CHUCNANG cn in nnd.CHUCNANGs)
                    if (cn.TenChucNang == "DG")
                    {
                        isDG = true;
                        break;
                    }
                if (isDG) dgList.Add(nnd);
            }
            comboNND.DataSource = dgList;
            comboNND.DisplayMember = "TenNhomNguoiDung";
            comboNND.ValueMember = "id";
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
            dateNgayHetHan.Text = NgayHetHan.Date.ToShortDateString();

            string username = txtUsername.Text;
            string userpwd = txtUserpwd.Text;
            string chucVu = txtChucVu.Text;
            if(tenDG == "" || username == "" || userpwd == "" || comboNND.SelectedItem == null)
            {
                MessageBox.Show("Chưa điền đủ thông tin");
                return;
            }
            int idNhom = (int)comboNND.SelectedValue;


            //Them account
            int idND = BUSNguoiDung.Instance.AddNguoiDung(tenDG, NgaySinh, chucVu ,username, userpwd, idNhom);


            string messg = BUSDocGia.Instance.AddDocGia(tenDG, idLDG, NgayLapThe, email, DiaChi, NgaySinh, NgayHetHan, idND);
            if (messg != "")
            {
                MessageBox.Show(messg);

            }
            else
            {
                
                MessageBox.Show("Thêm độc giả thành công");
                this.Close();
            }

        }
        

        private void dateNgayLap_ValueChanged(object sender, EventArgs e)
        {
                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                DateTime NgayLapThe = dateNgayLap.Value.Date;
                DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);
                dateNgayHetHan.Text = NgayHetHan.Date.ToShortDateString();
            
        }

    }
}
