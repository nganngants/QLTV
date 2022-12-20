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
        private void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            TacGiaGrid.DataSource = TacGiaList;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {

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
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " tác giả?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSTacGia.Instance.DelTacGia(id);
                if (error !="")
                {
                    if (ErrorDia.Show("Lỗi khi xoá tác giả") == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            SuccDia.Show("Đã xoá thành công " + cnt + " tác giả");
            Binding();
        }
    }
}
