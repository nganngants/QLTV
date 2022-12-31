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
    public partial class fPhieuThu : Form
    {
        public fPhieuThu()
        {
            InitializeComponent();
            init();
        }
        private DOCGIA DocGia;
        private void init()
        {
            TienThu = 0;
            dateNgayLap.Value = DateTime.Now.Date;
            comboDocGia.DataSource = BUSDocGia.Instance.GetAllDocGia();
            comboDocGia.ValueMember= "ID";
            comboDocGia.DisplayMember= "MaDocGia";
            comboDocGia.SelectedIndex = 0;
            DocGia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            labelNoHienTai.Text = DocGia.TongNoHienTai.ToString();
        }
        private int TienThu;
        private void siticoneTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textTienThu.Text == "")
            {
                labelNoMoi.Text = "";
                return;
            }
            try 
            {
                TienThu = Convert.ToInt32(textTienThu.Text);
                Console.WriteLine("TienThu");
                Console.WriteLine(TienThu);
            }
            catch
            {
                textTienThu.Text = "";
                MessageBox.Show("Số tiền thu sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            if(thamso.AD_QDKTTienThu == 1 && TienThu > DocGia.TongNoHienTai)
            {
                textTienThu.Text = "";
                MessageBox.Show("Số tiền thu vượt quá quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelNoMoi.Text = labelNoHienTai.Text;
                return;
            }
            labelNoMoi.Text = ((int)DocGia.TongNoHienTai - (int)TienThu).ToString();
            
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if(textTienThu.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
                return;
            }
            TienThu = Convert.ToInt32(textTienThu.Text);
            //Console.WriteLine("Bf: ",TienThu);
            if (dateNgayLap.Value > DateTime.Now.Date || dateNgayLap.Value.Date < DocGia.NgayLapThe)
            {
                MessageBox.Show("Ngày lập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            Console.WriteLine(TienThu);
            string err = BUSPhieuThu.Instance.AddPhieuThu(DocGia.ID, TienThu, dateNgayLap.Value.Date);
            //Console.WriteLine("Tien thu: ");
            //Console.WriteLine((int)TienThu);
            if(err !="")
            {
                MessageBox.Show(err);
                return;
            }
            /*err = BUSDocGia.Instance.UpdTongNo((int)DocGia.ID, (int)DocGia.TongNoHienTai - TienThu);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }*/
            MessageBox.Show("Thêm phiếu thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocGia = BUSDocGia.Instance.GetDocGia(Convert.ToInt32(comboDocGia.SelectedValue));
            labelNoHienTai.Text = DocGia.TongNoHienTai.ToString();
            TienThu = 0;
            labelNoMoi.Text = "";
            textTienThu.Text = "";
        }
    }
}
