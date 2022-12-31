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

namespace GUI.UserControls
{
    public partial class ucHome_TCS : UserControl
    {
        public ucHome_TCS()
        {
            InitializeComponent();
            Binding(BUSSach.Instance.GetAllSach());
            comboTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.ValueMember = "id";
            comboTheLoai.DisplayMember = "TenTheLoai";
            List<string> TinhTrangList = new List<string>{"Còn", "Hết"};
            comboTinhTrang.DataSource = TinhTrangList;
        }
        private void Binding(List<SACH> SachList)
        {
            SachGrid.Rows.Clear();
            foreach(SACH sach in SachList)
                if(sach.DaAn == 0)
            {
                    string tacgia = "";
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        tacgia += tg.TenTacGia + ", ";
                    if (tacgia != "")
                        tacgia = tacgia.Remove(tacgia.Length - 2,2);
                    string Con =(sach.SoLuongConLai>0) ? "Còn" : "Hết";
                    SachGrid.Rows.Add(sach.MaSach, sach.TUASACH.TenTuaSach,sach.TUASACH.THELOAI.TenTheLoai, sach.NamXB, sach.NhaXB, tacgia,Con);
            }
        }

        private void butFil_Click(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            foreach(SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.THELOAI.id == (int)comboTheLoai.SelectedValue)
                    Res.Add(sach);
            }
            Binding(Res);
        }

        private void butMaSach_Click(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            string pat = txtMaSach.Text.ToLower();

            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.TenTuaSach.ToLower().Contains(pat) ||
                     sach.MaSach.ToLower().Contains(pat) ||
                     sach.NhaXB.ToLower().Contains(pat) ||
                     sach.NamXB.ToString().Contains(pat))
                    Res.Add(sach);
                else
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        if (tg.TenTacGia.ToLower().Contains(pat))
                            Res.Add(sach);
            }
            Binding(Res);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtMaSach.Text = "";
        }

        private void SachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            int tt = comboTinhTrang.SelectedIndex;
            List<SACH> Res = new List<SACH>();
            foreach(SACH sach in BUSSach.Instance.GetAllSach())
                if(sach.DaAn == 0)
            {
                if(sach.SoLuongConLai > 0 && tt == 0)
                    {
                        Res.Add(sach);
                    }
                    if (sach.SoLuongConLai <= 0 && tt == 1)
                        Res.Add(sach);
            }
            Binding(Res);
        }
    }
}
