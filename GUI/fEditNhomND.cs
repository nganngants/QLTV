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

namespace GUI
{
    public partial class fEditNhomND : Form
    {
        private static int id;
        public fEditNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            labelMaNND.Text += nnd.MaNhomNguoiDung;
            txtTenNhom.Text = nnd.TenNhomNguoiDung;
            var dscn = BUSChucNang.Instance.GetAllChucNang();
            //dsChucNang.DataSource = dscn;
            //dsChucNang.VirtualMode = true;
            foreach (var cn in dscn)
            {
                if (nnd.CHUCNANGs.Contains(cn))
                {
                    dsChucNang.Rows.Add("1", cn.id, cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
                }
                else
                    dsChucNang.Rows.Add("0", cn.id, cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
            }    
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtTenNhom.Text;

            List<String> dsCn = new List<String>();
            foreach (DataGridViewRow row in this.dsChucNang.Rows)
            {
                //Console.WriteLine(row.Cells["isChoosen"].Value);
                if (row.Cells["isChoosen"].Value.ToString() == "1")
                {
                    //Console.WriteLine(row.Cells["MaChucNang"].Value.ToString());
                    dsCn.Add(row.Cells["MaChucNang"].Value.ToString());
                }
            }
            string res = BUSNhomNguoiDung.Instance.DelChucNangForNhom(id, dsCn);

            res = BUSNhomNguoiDung.Instance.AddChucNangForNhom(id, dsCn);
            if (res == "") messageDia.Show("Cập nhật nhóm người dùng thành công!");
            else ErrorDia.Show(res);
            this.Close();
        }
    }
}
