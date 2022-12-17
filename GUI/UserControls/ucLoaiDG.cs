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
                SuccDia.Text = "Thêm loại độc giả thành công";
                SuccDia.Show();

            }
            else
            {
                ErrorDia.Text = mss;
                ErrorDia.Show();
            }
            Binding();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in LoaiDocGiaGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);
                   
                }
            }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count+ " loại độc giả?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSLoaiDocGia.Instance.DelLoaiDocGia(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }
            
                SuccDia.Show("Đã xoá thành công " + cnt + " loại độc giả");
            Binding();
        }
    }
}
