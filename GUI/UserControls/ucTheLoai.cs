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
            TheLoaiGrid.DataSource = TheLoaiList;
            int i = 0;
            foreach (DataGridViewRow row in TheLoaiGrid.Rows)
            {
                row.Cells["SoTuaSach"].Value = "10";//TheLoaiList[i].TUASACHes.ToList().Count.ToString();
                Console.WriteLine(row.Cells["SoTuaSach"].Value = 10);
                i++;
            }
        }
    }
}
