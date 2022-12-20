using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAddNhomND : Form
    {
        public fAddNhomND()
        {
            InitializeComponent();
            Bind();
        }

        private void Bind()
        {
            var dsCn = BUSChucNang.Instance.GetAllChucNang();
            this.dsChucNang.DataSource = dsCn;

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtTenNhom.Text;
            int id = BUSNhomNguoiDung.Instance.AddNhomNguoiDung(ten);
            if (id == -1)
            {
                return;
            }
            List<String> dsCn = new List<String>();
            foreach (DataGridViewRow row in this.dsChucNang.Rows )
            {
                //Console.WriteLine(row.Cells["isChoosen"].Value);
                if (row.Cells["isChoosen"].Value.ToString() == "1")
                {
                    //Console.WriteLine(row.Cells["MaChucNang"].Value.ToString());
                    dsCn.Add(row.Cells["MaChucNang"].Value.ToString());
                }
            }
            string res = BUSNhomNguoiDung.Instance.AddChucNangForNhom(id, dsCn);
            if (res == "") messageDia.Show("Thêm nhóm người dùng thành công!");
            else ErrorDia.Show(res);
        }
    }
}
