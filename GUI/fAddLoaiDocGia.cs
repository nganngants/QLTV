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
namespace GUI
{
    public partial class fAddLoaiDocGia : Form
    {
        public fAddLoaiDocGia()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {


            string mss= BUSLoaiDocGia.Instance.AddLoaiDocGia(txtTLDG.Text);
            if(mss == "")
            {
                SuccDia.Text = "Thêm loại độc giả thành công";
                SuccDia.Show();
                return;
            }else
            {
                ErrorDia.Text = mss;
                ErrorDia.Show();
            }


        }
    }
}
