using BUS;
using GUI;
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
    public partial class ucThayDoiQuiDinh : UserControl
    {
        public ucThayDoiQuiDinh()
        {
            InitializeComponent();
            Bind();
        }

        private void Bind()
        {
            var ts = BUSThamSo.Instance.GetAllThamSo();
            numTuoiMin.Value = (int)ts.TuoiToiThieu;
            numTuoiMax.Value = (int)ts.TuoiToiDa;
            numNgayMuon.Value = (int)ts.SoNgayMuonToiDa;
            numKcNam.Value = (int)ts.KhoangCachXuatBan;
            numSoSach.Value = (int)ts.SoSachMuonToiDa;
            numThoiHan.Value = (int)ts.ThoiHanThe;
            txtDonGia.PlaceholderText = ts.DonGiaPhat.ToString();
            txtDonGia.Text = ts.DonGiaPhat.ToString();
            if(ts.AD_QDKTTienThu == 1) checkQDThu.Checked = true;
            else checkQDThu.Checked = false;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            int tuoiMin = (int)numTuoiMin.Value;
            string err = BUSThamSo.Instance.UpdTuoiToiThieu(tuoiMin);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            int tuoiMax = (int)numTuoiMax.Value;
            err = BUSThamSo.Instance.UpTuoiToiDa(tuoiMax);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            int soNgayMuon = (int)numNgayMuon.Value;
            err = BUSThamSo.Instance.UpdSoNgayMuon(soNgayMuon);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }
            int kc = (int)numKcNam.Value;
            err = BUSThamSo.Instance.UpdKCXB(kc);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            int soSach = (int)numSoSach.Value;
            err = BUSThamSo.Instance.UpdSoSachToiDa(soSach);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            int thoiHan = (int)numThoiHan.Value;
            err = BUSThamSo.Instance.UpdThoiHanThe(thoiHan);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            int donGia = Convert.ToInt32(txtDonGia.Text);
            err = BUSThamSo.Instance.UpdDonGiaPhat(donGia);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            if (checkQDThu.Checked) BUSThamSo.Instance.UpdADQDTienPhat(1);
            else BUSThamSo.Instance.UpdADQDTienPhat(0);

            MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bind();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == null || txtDonGia.Text == "") return;
            try
            {
                var dongia = Convert.ToInt32(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Text = null;
                return;

            }
        }
    }
}
