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
            //get info docgia
            string tenDG = txtHoTen.Text;
            int idLDG = (int)comboLoaiDG.SelectedValue;
            string email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            DateTime NgaySinh = dateNgaySinh.Value.Date;
            DateTime NgayLapThe = dateNgayLap.Value.Date;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);
            dateNgayHetHan.Text = NgayHetHan.Date.ToShortDateString();

            //get info nguoidung
            string username = txtUsername.Text;
            string userpwd = txtUserpwd.Text;
            string chucVu = txtChucVu.Text;

            if(tenDG == "" || username == "" || userpwd == "" || comboNND.SelectedItem == null)
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idNhom = (int)comboNND.SelectedValue;
            Console.WriteLine("Nhom: {0}", idNhom);

            string messg = BUSDocGia.Instance.AddDocGia(tenDG, idLDG, NgayLapThe, email, DiaChi, NgaySinh, NgayHetHan, 
                username, userpwd, chucVu, idNhom);
            if (messg != "")
            {
                MessageBox.Show(messg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
