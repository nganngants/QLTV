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
            int i = 0;
            foreach(THELOAI theLoai in TheLoaiList)
            {
                TheLoaiGrid.Rows.Add(0,theLoai.MaTheLoai,theLoai.TenTheLoai,theLoai.TUASACHes.Count);
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
                    if (AskDia.Show("Thể loại này đã có. Bạn có chắc muốn thêm?") == DialogResult.Yes) break;
                    else return;
                }    
            }
            BUSTheLoai.Instance.AddTheLoai(tentl);
            SuccDia.Show("Thêm thể loại thành công!");
            Binding();
        }
    }
}
