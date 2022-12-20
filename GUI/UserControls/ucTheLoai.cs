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
           
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }
    }
}
