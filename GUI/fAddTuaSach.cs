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
using BUS;
namespace GUI
{
    public partial class fAddTuaSach : Form
    {
        public fAddTuaSach()
        {
            InitializeComponent();
            
        }
        
        private void fAddTuaSach_Load(object sender, EventArgs e)
        {
            comboTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.ValueMember = "id";
            comboTheLoai.DisplayMember = "TenTheLoai";
            Binding();
        }
        private List<TACGIA> TacGiaList;

        private void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboTacGia.DataSource = TacGiaList;
            comboTacGia.DisplayMember = "TenTacGia";
            comboTacGia.ValueMember = "id";
        }


        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check = false;
            int id =  Convert.ToInt32(comboTacGia.SelectedValue);
            string newTg = comboTacGia.Text;
            foreach (TACGIA tg in TacGiaList)
                if (tg.TenTacGia == newTg)
                    check = true;
            if(check == false)
            {
                var ask = MessageBox.Show("Tác giả chưa có, bạn có muốn thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    id = BUSTacGia.Instance.AddTacGia(newTg);
                    Binding();
                }
                else return;
            }
           
            TacGiaGrid.Rows.Add(newTg,id);
           
        }

        private void comboTacGia_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if(txtTenTuaSach.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TACGIA> TgList =  new List<TACGIA>();
            string TenTuaSach = txtTenTuaSach.Text;
            int TheLoai = Convert.ToInt32(comboTheLoai.SelectedValue);
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai(TheLoai);
            foreach(DataGridViewRow row in TacGiaGrid.Rows)
            {
                if (TgList.Contains(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value))))
                    continue;
                TgList.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));       
            }
            string err = BUSTuaSach.Instance.AddTuaSach(TenTuaSach, tl, TgList);
            if(err !="")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm tựa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            
        }

        private void TacGiaGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }
    }
}
