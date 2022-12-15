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
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
            Binding();
            CustomGrid();
        }
        private List<SACH> SachList;
        public void Binding()
        {
            SachList = BUSSach.Instance.GetAllSach();
            this.SachGrid.DataSource = SachList;
        }
        public void CustomGrid()
        {
            int i = 0;
            /*foreach (DataGridViewRow row in SachGrid)
            {
                row.Cells[""].Value = SachList[i].DOCGIA.TenDocGia.ToString();
                i++;
            }*/
        }
    }
}
