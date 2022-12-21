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
           
        }
        private void Binding(List<TUASACH> TuaSachList)
        {
            
            this.TuaSachGrid.DataSource = TuaSachList;
            int i = 0;
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));

            // Icon myIcon = new Icon("F:\\QLTV\\GUI\\Resources\\edit_icon.png");
            foreach (DataGridViewRow row in TuaSachGrid.Rows)
            {
                row.Cells["Edit"].Value = img;
                string tacgia = "";
                int cnt = 0;
                foreach (TACGIA tg in TuaSachList[i].TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                    cnt++;
                    /*if (cnt >= 2)
                    {
                        tacgia += "....";
                        break;
                    }*/
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 1);
                if (tacgia!="") tacgia = tacgia.Remove(tacgia.Length-1);
                row.Cells["TacGia"].Value = tacgia;
                row.Cells["TheLoai"].Value = (TuaSachList[i].THELOAI!=null)?TuaSachList[i].THELOAI.TenTheLoai : "";
                i++;
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

        private void TuaSachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
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
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " tựa sách?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSTuaSach.Instance.DelTuaSach(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }


            SuccDia.Show("Đã xoá thành công " + cnt + " tựa sách");
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
    }
}
