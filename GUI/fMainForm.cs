using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
            InitializeUCs();
        }

        /// <summary>
        /// ham khoi tao cac User Control
        /// </summary>
        private void InitializeUCs()
        {
            // ucBan la de hien thi khi cac tab khong duoc su dung
            /* //just for test:
            ucBan = new UserControls.ucBanAccess();
            ucBan.Dock = DockStyle.Fill;
            this.pageHome.Controls.Add(ucBan);
            */

            uctaikhoan = new UserControls.ucThongTinTaiKhoan();
            uctaikhoan.Dock = DockStyle.Fill;
            this.pageAccount.Controls.Add(uctaikhoan);

            // tao UC QLDG moi va add no vao page QLDG
            ucqldg = new UserControls.ucQLDG();
            ucqldg.Dock = DockStyle.Fill;
            this.pageQLDG.Controls.Add(ucqldg);

            ucqlsach = new UserControls.ucQLSach();
            ucqlsach.Dock = DockStyle.Fill;
            this.pageQLS.Controls.Add(ucqlsach);

            ucphieumuontra = new UserControls.ucQLPhieuMuon();
            ucphieumuontra.Dock = DockStyle.Fill;
            this.pageQLMT.Controls.Add(ucphieumuontra);

            ucphieuthu = new UserControls.ucQLPhieuThu();
            ucphieuthu.Dock = DockStyle.Fill;
            this.pageQLPT.Controls.Add(ucphieuthu);

            ucbaocao = new UserControls.ucBCTK();
            ucbaocao.Dock = DockStyle.Fill;
            this.pageBC.Controls.Add(ucbaocao);

            ucnguoidung = new UserControls.ucQLND();
            ucnguoidung.Dock = DockStyle.Fill;
            this.pageQLND.Controls.Add(ucnguoidung);

            ucquidinh = new UserControls.ucThayDoiQuiDinh();
            ucquidinh.Dock = DockStyle.Fill;
            this.pageTDQD.Controls.Add(ucquidinh);

        }
        /// <summary>
        /// viet lai event nhan nut thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitControlBox_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) this.Close();
        }

    }
}
