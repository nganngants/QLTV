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

        private void addNewTacGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check = false;
            int id = Convert.ToInt32(comboTacGia.SelectedValue);
            string newTg = comboTacGia.Text;
            foreach (TACGIA tg in TacGiaList)
                if (tg.TenTacGia == newTg)
                    check = true;
            if(check == false)
            {
                var ask = AskDia.Show("Tác giả chưa có, bạn có muốn thêm mới?");
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
                ErrorDia.Show("Chưa nhập đủ thông tin");
                return;
            }

            List<TACGIA> TgList =  new List<TACGIA>();
            string TenTuaSach = txtTenTuaSach.Text;
            int TheLoai = Convert.ToInt32(comboTheLoai.SelectedValue);
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai(TheLoai);
            foreach(DataGridViewRow row in TacGiaGrid.Rows)
            {
                TgList.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            string err = BUSTuaSach.Instance.AddTuaSach(TenTuaSach, tl, TgList);
            if(err !="")
            {
                ErrorDia.Show(err);
                return;
            }
            SuccDia.Show("Thêm tựa sách thành công");
            this.Close();
            
        }
    }
}
