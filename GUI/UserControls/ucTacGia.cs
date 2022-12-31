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
namespace GUI.UserControls
{
    public partial class ucTacGia : UserControl
    {
        List<TACGIA> TacGiaList;
        public ucTacGia()
        {
            InitializeComponent();
            Binding();
        }
        public void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            TacGiaGrid.DataSource = TacGiaList;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            var tentg = txtHoTen.Text;
            if (tentg == "") return;
            var tglist = BUSTacGia.Instance.GetAllTacGia();
            foreach (var tg in tglist)
            {
                if (tg.TenTacGia == tentg)
                    if (MessageBox.Show("Tên tác giả này đã có, bạn có chắc muốn thêm?",
                        "Thêm tác giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) break;
                    else return;
            }    
            int id = BUSTacGia.Instance.AddTacGia(tentg);
            if (id == -1) MessageBox.Show("Có lỗi xảy ra. Không thể thêm tác giả. Vui lòng kiểm tra lại!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Thêm tác giả mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding();
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void TacGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
            var f = new fEditTacGia(Convert.ToInt32(TacGiaGrid.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();

        }

       
    }
}
