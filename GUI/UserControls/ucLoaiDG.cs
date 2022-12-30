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
    public partial class ucLoaiDG : UserControl
    {
        public ucLoaiDG()
        {
            InitializeComponent();
        }
        private List<LOAIDOCGIA> LoaiDocGiaList;
        private void Binding()
        {
            LoaiDocGiaList = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            this.LoaiDocGiaGrid.DataSource = LoaiDocGiaList;
        }
        private void ucLoaiDG_Load(object sender, EventArgs e)
        {
            Binding();

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string ten = txtTenLoaiDG.Text;
            if (ten == "") return;
            string mss = BUSLoaiDocGia.Instance.AddLoaiDocGia(ten);
            if (mss == "")
            {
                
                MessageBox.Show("Thêm loại độc giả thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(mss);
            }
            Binding();
        }

       

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void LoaiDocGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if( idx < 0) return;
            var f = new fEditLoaiDG(Convert.ToInt32(LoaiDocGiaGrid.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();
        }
    }
}
