﻿using GUI.BM;
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
    public partial class ucQLPhieuThu : UserControl
    {
        public ucQLPhieuThu()
        {
            InitializeComponent();
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuThu();
            f.ShowDialog();
        }
    }
}
