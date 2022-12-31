using BUS;
using DTO;

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

      
       
        private void DocGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1)
            {
                return;
            }
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
            txtFind.Text = "";
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
