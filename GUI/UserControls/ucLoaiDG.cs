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
        private void ucLoaiDG_Load(object sender, EventArgs e)
        {
            LoaiDocGiaList= BUSLoaiDocGia.Instance.GetAllLoaiDocGia(); 
            this.LoaiDocGiaGrid.DataSource = LoaiDocGiaList;

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddLoaiDocGia();
            f.ShowDialog();
        }
    }
}
