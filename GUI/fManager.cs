using BUS;
using DTO;
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
    public partial class fManager : Form
    {
        private NGUOIDUNG user;
        public fManager(int id)
        {
            InitializeComponent();
            user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            InitializeUCs();
        }

        /// <summary>
        /// ham khoi tao cac User Control
        /// </summary>
        private void InitializeUCs()
        {
            // ucBan la de hien thi khi cac tab khong duoc su dung
            /* //just for test:
            ucBan.Dock = DockStyle.Fill;
            this.pageHome.Controls.Add(ucBan);
            */
            foreach (TabPage page in this.tabControl.TabPages)
            {
                page.Controls.Add(new ucBanAccess() { Dock = DockStyle.Fill, Name = "Ban" });
            }

            uctaikhoan = new UserControls.ucThongTinTaiKhoan(user.id);
            uctaikhoan.Dock = DockStyle.Fill;
            this.pageAccount.Controls.Clear();
            this.pageAccount.Controls.Add(uctaikhoan);

            //Console.WriteLine("qlpt");
            //ucphieuthu = new UserControls.ucQLPhieuThu();
            //ucphieuthu.Dock = DockStyle.Fill;
            //ucphieuthu.Visible = true;
            //this.pageQLPT.Controls.Add(ucphieuthu);

            foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
            {
                if (cn.TenChucNang == "QLDG")
                {
                    ucqldg = new UserControls.ucQLDG();
                    ucqldg.Dock = DockStyle.Fill;
                    this.pageQLDG.Controls.Clear();
                    this.pageQLDG.Controls.Add(ucqldg);
                }
                if (cn.TenChucNang == "QLS")
                {
                    ucqlsach = new UserControls.ucQLSach();
                    ucqlsach.Dock = DockStyle.Fill;
                    this.pageQLS.Controls.Clear();
                    this.pageQLS.Controls.Add(ucqlsach);
                }
                if (cn.TenChucNang == "QLPM")
                {
                    ucphieumuontra = new UserControls.ucQLPhieuMuon();
                    ucphieumuontra.Dock = DockStyle.Fill;
                    this.pageQLMT.Controls.Clear();
                    this.pageQLMT.Controls.Add(ucphieumuontra);
                }
                if (cn.TenChucNang == "QLPT")
                {
                    ucphieuthu = new UserControls.ucQLPhieuThu();
                    ucphieuthu.Dock = DockStyle.Fill;
                    ucphieuthu.Visible = true;
                    this.pageQLPT.Controls.Clear();
                    this.pageQLPT.Controls.Add(ucphieuthu);
                }
                if (cn.TenChucNang == "BCTK")
                {
                    ucbaocao = new UserControls.ucBCTK();
                    ucbaocao.Dock = DockStyle.Fill;
                    this.pageBC.Controls.Clear();
                    this.pageBC.Controls.Add(ucbaocao);
                }
                if (cn.TenChucNang == "QLND")
                {
                    ucnguoidung = new UserControls.ucQLND();
                    ucnguoidung.Dock = DockStyle.Fill;
                    this.pageQLND.Controls.Clear();
                    this.pageQLND.Controls.Add(ucnguoidung);
                }
                if (cn.TenChucNang == "TDQD")
                {
                    ucquidinh = new UserControls.ucThayDoiQuiDinh();
                    ucquidinh.Dock = DockStyle.Fill;
                    this.pageTDQD.Controls.Clear();
                    this.pageTDQD.Controls.Add(ucquidinh);
                }
            }

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
