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
            if (e.ColumnIndex == 0)
                return;

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in TacGiaGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn xoá " + idDel.Count + " tác giả?", "Xóa tác giả",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSTacGia.Instance.DelTacGia(id);
                if (error !="")
                {
                    if (MessageBox.Show("Lỗi khi xoá tác giả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã xoá thành công " + cnt + " tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding();
        }
    }
}
