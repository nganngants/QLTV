﻿using BUS;
using DTO;
using GUI.BM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.UserControls
{
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
        }
        private List<SACH> SachList;
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            var f = new BMTiepNhanSachMoi();
            f.Show();
        }
        public void Binding()
        {
            SachList = BUSSach.Instance.GetAllSach();

        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            int cnt = 0;
            if (AskDia.Show("Bạn có chắc muốn xoá " + idDel.Count + " sách?") == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = BUSSach.Instance.DelSach(id);
                if (error != "")
                {
                    if (ErrorDia.Show(error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            SuccDia.Show("Đã xoá thành công " + cnt + "sách");
            Binding();
        }
    }
}
