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
using DTO;
using BUS;
using System.Security.Cryptography;

namespace GUI
{
    public partial class fInfoTuaSach : Form
    {
        TUASACH tuasach;
        private int id;
        public fInfoTuaSach(int _id)
        {
            InitializeComponent();
            id = _id;
            init();
            List<SACH> SachList = tuasach.SACHes.ToList();
            SachGrid.DataSource = SachList;
            
        }
        
        private void init()
        {
            tuasach = BUSTuaSach.Instance.GetTuaSach(id);
            
            labelMaTS.Text = tuasach.MaTuaSach;
            labelTenTS.Text = tuasach.TenTuaSach;
            labelTheLoai.Text = tuasach.THELOAI.TenTheLoai.ToString();
            string tacgia = "";
          
            foreach (TACGIA tg in tuasach.TACGIAs)
            {
                if (tg == null) continue;
                tacgia += tg.TenTacGia + ", ";
            }
            if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2,2);

            labelTacGia.Text = tacgia;
        }
        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditTuaSach(tuasach.id);
            f.ShowDialog();
            init();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableInfo_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
