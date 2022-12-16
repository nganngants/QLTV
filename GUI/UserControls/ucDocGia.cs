using BUS;
using DTO;
using GUI.BM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.UserControls
{
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
            Binding();
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
            foreach (DataGridViewRow row in DocGiaGrid.Rows)
            {
                row.Cells["LoaiDocGia"].Value = DocGiaList[i].LOAIDOCGIA.TenLoaiDocGia;
                row.Cells["SoSachDangMuon"].Value = BUSDocGia.Instance.GetSoSachDangMuon(DocGiaList[i].ID);
                i++;
            }
        }
        private void ucDocGia_Load(object sender, EventArgs e)
        {


        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddDocGia();
            f.ShowDialog();
            Binding();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in DocGiaGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1") 
                {
                    idDel.Add((int)row.Cells["ID"].Value);
                }
            }
            if (AskDia.Show() == DialogResult.No) return;
            int cnt = 0;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSDocGia.Instance.DelDocGia(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }
            if(cnt!=0)
                SuccDia.Show("Đã xoá thành công " + cnt + " độc giả");
            Binding();
            
        }
    }
}
