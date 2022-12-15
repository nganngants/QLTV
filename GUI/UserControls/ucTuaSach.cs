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
            Binding();
            CustGrid();
        }
        private List<TUASACH> TuaSachList;
        public void Binding()
        {
            TuaSachList = BUSTuaSach.Instance.GetAllTuaSach();
            this.TuaSachGrid.DataSource = TuaSachList;
        }
        public void CustGrid()
        {
            int i = 0;
            foreach (DataGridViewRow row in TuaSachGrid.Rows)
            {
                string Tg = "";
                int cnt = 0;
                foreach(TACGIA tg in TuaSachList[i].TACGIAs)
                {
                    cnt++;
                    Tg += tg.TenTacGia;
                }
                row.Cells["TacGia"].Value = Tg;
                row.Cells["TheLoai"].Value = (TuaSachList[i].THELOAI!=null)?TuaSachList[i].THELOAI.TenTheLoai.ToString() : "Null";
                i++;
            }
        }

        private void TuaSachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public static implicit operator ucTuaSach(ucCuonSach v)
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
