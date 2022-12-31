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
    public partial class fEditTacGia : Form
    {
        private TACGIA tacgia;
        public fEditTacGia(int id)
        {
            InitializeComponent();
            tacgia = BUSTacGia.Instance.GetTacGia(id);
            labelMa.Text += tacgia.MATACGIA;
            txtTen.Text = tacgia.TenTacGia;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "")
            {
                MessageBox.Show("Tên tác giả không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BUSTacGia.Instance.UpdTacGia(tacgia.id, txtTen.Text))
            {
            
                 MessageBox.Show("Sửa thông tin tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
            }
            else
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
