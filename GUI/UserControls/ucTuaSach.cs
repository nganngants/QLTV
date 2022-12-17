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
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
        }
        private List<TUASACH> TuaSachList;
        private void Binding()
        {
            TuaSachList = BUSTuaSach.Instance.GetAllTuaSach();
            this.TuaSachGrid.DataSource = TuaSachList;
            int i = 0;
            Image image = Image.FromFile("Resources/edit_icon.png");
            
            // Icon myIcon = new Icon("F:\\QLTV\\GUI\\Resources\\edit_icon.png");
            foreach (DataGridViewRow row in TuaSachGrid.Rows)
            {
                row.Cells["Edit"].Value = image;
                string tacgia = "";
                int cnt = 0;
                foreach (TACGIA tg in TuaSachList[i].TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                    cnt++;
                    if (cnt >= 2)
                    {
                        tacgia += "....";
                        break;
                    }
                }
                if(tacgia!="") tacgia = tacgia.Remove(tacgia.Length-1);
                row.Cells["TacGia"].Value = tacgia;
                row.Cells["TheLoai"].Value = (TuaSachList[i].THELOAI!=null)?TuaSachList[i].THELOAI.TenTheLoai : "";
            }
        }
        private void ucTuaSach_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddTuaSach();
            f.ShowDialog();
            Binding();
        }


    }
}
