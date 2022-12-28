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
    public partial class ucHome_TTTK : UserControl
    {
        private static NGUOIDUNG user;

        public ucHome_TTTK(int id)
        {
            InitializeComponent();
            user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            Binding();
        }

        private void Binding()
        {
            labelMaDG.Text = user.MaNguoiDung;
        }
    }
}
