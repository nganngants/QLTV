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
    public partial class fEditTuaSach : Form
    {
        TUASACH tuasach;
        List<TACGIA> TacGiaList;
        public fEditTuaSach(int id)
        {
            InitializeComponent();
            tuasach = BUSTuaSach.Instance.GetTuaSach(id);
            txtTenTuaSach.Text = tuasach.TenTuaSach;
            List<THELOAI> theloai = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.DataSource = theloai;
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember= "id";
            int idx = 0;
            foreach(THELOAI tl in theloai)
            {
                if (tl.TenTheLoai == tuasach.THELOAI.TenTheLoai)
                    comboTheLoai.SelectedIndex = idx ;
                idx++;
            }
            foreach(TACGIA tg in tuasach.TACGIAs)
            {
                TacGiaGrid.Rows.Add(tg.TenTacGia, tg.id);
            }
            Binding();
        }
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

        private void butOK_Click(object sender, EventArgs e)
        {

            List<TACGIA> TgList = new List<TACGIA>();
            string TenTuaSach = txtTenTuaSach.Text;
            int TheLoai = Convert.ToInt32(comboTheLoai.SelectedValue);
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai(TheLoai);
            foreach (DataGridViewRow row in TacGiaGrid.Rows)
            {
                TgList.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            string err = BUSTuaSach.Instance.UpdTuaSach(tuasach.id,TenTuaSach, tl, TgList);
            if (err != "")
            {
                ErrorDia.Show(err);
                return;
            }
            SuccDia.Show("Chỉnh sửa tựa sách thành công");
            this.Close();

        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check = false;
            int id = Convert.ToInt32(comboTacGia.SelectedValue);
            string newTg = comboTacGia.Text;
            foreach (TACGIA tg in TacGiaList)
                if (tg.TenTacGia == newTg)
                    check = true;
            if (check == false)
            {
                var ask = AskDia.Show("Tác giả chưa có, bạn có muốn thêm mới?");
                if (ask == DialogResult.Yes)
                {
                    id = BUSTacGia.Instance.AddTacGia(newTg);
                    Binding();
                }
                else return;
            }

            TacGiaGrid.Rows.Add(newTg, id);
        }
    }
}
