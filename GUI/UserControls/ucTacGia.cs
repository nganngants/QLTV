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
    }
}
