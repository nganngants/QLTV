using BUS;
using DTO;
using GUI.BM;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            DocGiaGrid.Rows.Clear();
            DocGiaGrid.Refresh();
            //this.DocGiaGrid.DataSource = DocGiaList;
            int i = 0;
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(25, 25)));
            foreach (DOCGIA docgia in DocGiaList)
            {
                int SachMuon = BUSDocGia.Instance.GetSoSachDangMuon(docgia.ID);
                DocGiaGrid.Rows.Add(docgia.ID,0, docgia.MaDocGia, docgia.TenDocGia, docgia.LOAIDOCGIA.TenLoaiDocGia, SachMuon, docgia.NgayHetHan.Date, docgia.TongNoHienTai,img);
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
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1") 
                {
                    idDel.Add((int)row.Cells["ID"].Value);
                }
            }
            if(idDel.Count == 0) { return; }
            if (AskDia.Show("Bạn có chắc muốn xoá "+ idDel.Count + " độc giả?") == DialogResult.No) return;
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

        private void DocGiaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            if (e.ColumnIndex == 1) return;
            if (e.ColumnIndex == DocGiaGrid.Columns["Edit"].Index)
            {
                var f = new fEditDocGia((Convert.ToInt32(DocGiaGrid.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding();
                return;
            }
            var fInfor = new fInfoDocGia(Convert.ToInt32(DocGiaGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding();
            return;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }
    }
}
