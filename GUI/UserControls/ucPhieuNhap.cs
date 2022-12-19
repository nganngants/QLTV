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
    public partial class ucPhieuNhap : UserControl
    {
        List<PHIEUNHAPSACH> PhieuNhapList;
        public ucPhieuNhap()
        {
            InitializeComponent();
            Binding();
        }
        private void Binding()
        {
            PhieuNhapList = BUSPhieuNhap.Instance.GetAllPhieuNhap();
            PhieuNhapgrid.DataSource = PhieuNhapList;   
        }
    }
}
