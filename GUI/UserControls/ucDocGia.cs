using BUS;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace GUI.UserControls
{
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
            Binding(BUSDocGia.Instance.GetAllDocGia());
        }



        private void Binding(List<DOCGIA> DocGiaList)
        {
             
            DocGiaGrid.Rows.Clear();
            DocGiaGrid.Refresh();
            //this.DocGiaGrid.DataSource = DocGiaList;
            int i = 0;
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(25, 25)));
            foreach (DOCGIA docgia in DocGiaList)
            {
                int SachMuon = BUSDocGia.Instance.GetSoSachDangMuon(docgia.ID);
                DocGiaGrid.Rows.Add(docgia.ID,0, docgia.MaDocGia, docgia.TenDocGia, docgia.LOAIDOCGIA.TenLoaiDocGia, SachMuon, docgia.NgayHetHan.ToShortDateString(), docgia.TongNoHienTai,img);
            }
        }
        private void ucDocGia_Load(object sender, EventArgs e)
        {


        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddDocGia();
            f.ShowDialog();
            Binding(BUSDocGia.Instance.GetAllDocGia());
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
                    if (MessageBox.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }
            if(cnt!=0)
                MessageBox.Show("Đã xoá thành công " + cnt + " độc giả");
            Binding(BUSDocGia.Instance.GetAllDocGia());
            
        }
        private void Sorting(int idx)
        {
            this.DocGiaGrid.Sort(this.DocGiaGrid.Columns[idx], ListSortDirection.Ascending);
        }
        private void DocGiaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1)
            {
                Sorting(e.ColumnIndex);
                return;
            }
            if (e.ColumnIndex == 1) return;
            if (e.ColumnIndex == DocGiaGrid.Columns["Edit"].Index)
            {
                var f = new fEditDocGia((Convert.ToInt32(DocGiaGrid.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding(BUSDocGia.Instance.GetAllDocGia());
                return;
            }
            var fInfor = new fInfoDocGia(Convert.ToInt32(DocGiaGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSDocGia.Instance.GetAllDocGia());
            return;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSDocGia.Instance.GetAllDocGia());
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<DOCGIA> Res = new List<DOCGIA>();
            foreach(DOCGIA dg in BUSDocGia.Instance.GetAllDocGia())
            {
                if(dg.MaDocGia.ToLower().Contains(pat) || dg.TenDocGia.ToLower().Contains(pat))
                {
                    Res.Add(dg);
                }
            }
            Binding(Res);
        }
    }
}
