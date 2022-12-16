using GUI.BM;
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
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            var f = new BMLapTheDocGia();
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private List<DOCGIA> DocGiaList;
        private void Binding()
        {
            DocGiaList = BUSDocGia.Instance.GetAllDocGia();
            this.DocGiaGrid.DataSource = DocGiaList;
            int i = 0;
            foreach(DataGridViewRow row in DocGiaGrid.Rows)
            {
                row.Cells["LoaiDocGia"].Value = DocGiaList[i].LOAIDOCGIA.TenLoaiDocGia;
                row.Cells["SoSachDangMuon"].Value = BUSDocGia.Instance.GetSoSachDangMuon(DocGiaList[i].ID);
                i++;
            }
        }
        private void ucDocGia_Load(object sender, EventArgs e)
        {
            Binding();

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddDocGia();
            f.ShowDialog();
        }

        private void butDel_Click(object sender, EventArgs e)
        {

        }
    }
}
