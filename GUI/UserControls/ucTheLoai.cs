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
            TheLoaiList = BUSTheLoai.Instance.GetAllTheLoai();
            int i = 0;
            foreach(THELOAI theLoai in TheLoaiList)
            {
                TheLoaiGrid.Rows.Add(0,theLoai.MaTheLoai,theLoai.TenTheLoai,theLoai.TUASACHes.Count);
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in TheLoaiGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " thể loại?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                bool error = BUSTheLoai.Instance.DelTheLoai(id);
                if (error == false)
                {
                    if (ErrorDia.Show("Lỗi khi xoá thể loại") == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            SuccDia.Show("Đã xoá thành công " + cnt + " thể loại");
            Binding();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }
    }
}
