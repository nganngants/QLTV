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
using BUS;
namespace GUI
{
    public partial class fAddTuaSach : Form
    {
        public fAddTuaSach()
        {
            InitializeComponent();
            
        }
        
        private void fAddTuaSach_Load(object sender, EventArgs e)
        {
            
        }
        private void Binding()
        {
            List<TACGIA> TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboTacGia.DataSource = TacGiaList;
            comboTacGia.DisplayMember = "Tên tác giả";
            comboTacGia.ValueMember = "id";
        }

        private void addNewTacGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
