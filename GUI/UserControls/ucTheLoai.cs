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
namespace GUI.UserControls
{
    public partial class ucTheLoai : UserControl
    {
        public ucTheLoai()
        {
            InitializeComponent();
            Binding();
           
        }
        List<THELOAI> TheLoaiList;
        public void Binding()
        {
            TheLoaiGrid.Rows.Clear();
            TheLoaiList = BUSTheLoai.Instance.GetAllTheLoai();
            foreach(THELOAI theLoai in TheLoaiList)
            {
                TheLoaiGrid.Rows.Add(theLoai.id,theLoai.MaTheLoai,theLoai.TenTheLoai,theLoai.TUASACHes.Count);
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var tentl = txtTenTL.Text;
            if (tentl == "") return;
            var tllist = BUSTheLoai.Instance.GetAllTheLoai();
            foreach (var theLoai in tllist)
            {
                if (theLoai.TenTheLoai == tentl)
                {
                    if (MessageBox.Show("Thể loại này đã có. Bạn có chắc muốn thêm?", "Thêm thể loại",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) break;
                    else return;
                }    
            }
            BUSTheLoai.Instance.AddTheLoai(tentl);
            MessageBox.Show("Thêm thể loại thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding();
        }

        private void TheLoaiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
            var f = new fEditTheLoai(Convert.ToInt32(TheLoaiGrid.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();
        }
    }
}
