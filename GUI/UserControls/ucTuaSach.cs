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
namespace GUI.UserControls
{
    public partial class ucTuaSach : UserControl
    {
        public ucTuaSach()
        {
            InitializeComponent();
            comboTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember = "id";
           
        }
        public void Binding(List<TUASACH> TuaSachList)
        {
            
            int i = 0;
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));
            TuaSachGrid.Rows.Clear();
            // Icon myIcon = new Icon("F:\\QLTV\\GUI\\Resources\\edit_icon.png");
           foreach(TUASACH tuasach in  TuaSachList)
            {
                string tacgia = "";
                foreach (TACGIA tg in tuasach.TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);
                TuaSachGrid.Rows.Add(0,tuasach.id, tuasach.MaTuaSach, tuasach.TenTuaSach, tuasach.THELOAI.TenTheLoai, tacgia, tuasach.DaAn, img);
            }
        }
        private void ucTuaSach_Load(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddTuaSach();
            f.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }
        private void Sorting(int idx)
        {
            //this.TuaSachGrid.Sort(this.TuaSachGrid.Columns[idx], ListSortDirection.Ascending);
        }

        private void TuaSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == 0) return ;
            if(e.ColumnIndex == TuaSachGrid.Columns["Edit"].Index)
            {
                var f = new fEditTuaSach((Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding(BUSTuaSach.Instance.GetAllTuaSach());
                return;
            }
            var fInfor = new fInfoTuaSach(Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
            return;
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in TuaSachGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
           }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn ẩn " + idDel.Count + " tựa sách?","", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
                TUASACH tuasach = BUSTuaSach.Instance.GetTuaSach(id);
                if (tuasach.DaAn == 1) continue;
                Retry:
                
                string error = BUSTuaSach.Instance.UpdAnTuaSach(id,1);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }


            MessageBox.Show("Đã ẩn thành công " + cnt + " tựa sách","Thông báo",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

        private void tUASACHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void butFind_Click(object sender, EventArgs e)
        {
            List<TUASACH> Res = new List<TUASACH>();
            string pat = txtFind.Text.ToLower();
            foreach(TUASACH ts in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (ts.TenTuaSach.ToLower().Contains(pat) || ts.MaTuaSach.ToLower().Contains(pat))
                    Res.Add(ts);
                else
                {
                    foreach(TACGIA tg in ts.TACGIAs)
                        if(tg.TenTacGia.ToLower().Contains(pat))
                        {
                            Res.Add(ts);
                            break;
                        }
                }
            }
            Binding(Res);

        }

        private void comboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butFil_Click(object sender, EventArgs e)
        {
            List<TUASACH> Res = new List<TUASACH>();
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai((int)comboTheLoai.SelectedValue);
            foreach (TUASACH ts in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (ts.THELOAI.id == tl.id)
                    Res.Add(ts);
            }
            Binding(Res);
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in TuaSachGrid.Rows)
            {
                //Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn hiện " + idDel.Count + " tựa sách?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
                TUASACH tuasach = BUSTuaSach.Instance.GetTuaSach(id);
                if (tuasach.DaAn == 0) continue;
                Retry:
                string error = BUSTuaSach.Instance.UpdAnTuaSach(id, 0);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }


            MessageBox.Show("Đã hiện thành công " + cnt + " tựa sách", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

       
    }
}
