using GUI.UserControls;
using System.Windows.Forms;

namespace GUI
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabQLDG = new System.Windows.Forms.TabPage();
            this.tabQLS = new System.Windows.Forms.TabPage();
            this.tabQLMT = new System.Windows.Forms.TabPage();
            this.tabQLPT = new System.Windows.Forms.TabPage();
            this.tabBC = new System.Windows.Forms.TabPage();
            this.tabQLND = new System.Windows.Forms.TabPage();
            this.tabTDQD = new System.Windows.Forms.TabPage();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.topPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.CustomClick = true;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(1163, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(73, 71);
            this.exitControlBox.TabIndex = 0;
            this.exitControlBox.Click += new System.EventHandler(this.exitControlBox_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1089, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(75, 71);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.exitControlBox);
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.topPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.FillColor = System.Drawing.Color.SlateBlue;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1235, 70);
            this.topPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "UIT LIBRARY";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabQLDG);
            this.tabControl.Controls.Add(this.tabQLS);
            this.tabControl.Controls.Add(this.tabQLMT);
            this.tabControl.Controls.Add(this.tabQLPT);
            this.tabControl.Controls.Add(this.tabBC);
            this.tabControl.Controls.Add(this.tabQLND);
            this.tabControl.Controls.Add(this.tabTDQD);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.iconList;
            this.tabControl.ItemSize = new System.Drawing.Size(270, 110);
            this.tabControl.Location = new System.Drawing.Point(0, 70);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1235, 737);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSize = new System.Drawing.Size(270, 110);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabAccount.ImageIndex = 6;
            this.tabAccount.Location = new System.Drawing.Point(544, 4);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(687, 729);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Tài khoản";
            // 
            // tabQLDG
            // 
            this.tabQLDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLDG.ImageIndex = 0;
            this.tabQLDG.Location = new System.Drawing.Point(274, 4);
            this.tabQLDG.Margin = new System.Windows.Forms.Padding(0);
            this.tabQLDG.Name = "tabQLDG";
            this.tabQLDG.Size = new System.Drawing.Size(957, 729);
            this.tabQLDG.TabIndex = 1;
            this.tabQLDG.Text = "Độc giả";
            // 
            // tabQLS
            // 
            this.tabQLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLS.ImageIndex = 5;
            this.tabQLS.Location = new System.Drawing.Point(274, 4);
            this.tabQLS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLS.Name = "tabQLS";
            this.tabQLS.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLS.Size = new System.Drawing.Size(957, 729);
            this.tabQLS.TabIndex = 2;
            this.tabQLS.Text = "Sách";
            // 
            // tabQLMT
            // 
            this.tabQLMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLMT.ImageIndex = 2;
            this.tabQLMT.Location = new System.Drawing.Point(274, 4);
            this.tabQLMT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLMT.Name = "tabQLMT";
            this.tabQLMT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLMT.Size = new System.Drawing.Size(957, 729);
            this.tabQLMT.TabIndex = 3;
            this.tabQLMT.Text = "Phiếu mượn trả";
            // 
            // tabQLPT
            // 
            this.tabQLPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLPT.ImageIndex = 3;
            this.tabQLPT.Location = new System.Drawing.Point(274, 4);
            this.tabQLPT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLPT.Name = "tabQLPT";
            this.tabQLPT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLPT.Size = new System.Drawing.Size(957, 729);
            this.tabQLPT.TabIndex = 4;
            this.tabQLPT.Text = "Phiếu thu";
            // 
            // tabBC
            // 
            this.tabBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabBC.ImageIndex = 4;
            this.tabBC.Location = new System.Drawing.Point(274, 4);
            this.tabBC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabBC.Name = "tabBC";
            this.tabBC.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabBC.Size = new System.Drawing.Size(957, 729);
            this.tabBC.TabIndex = 5;
            this.tabBC.Text = "Báo cáo thống kê";
            // 
            // tabQLND
            // 
            this.tabQLND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLND.ImageIndex = 1;
            this.tabQLND.Location = new System.Drawing.Point(274, 4);
            this.tabQLND.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLND.Name = "tabQLND";
            this.tabQLND.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLND.Size = new System.Drawing.Size(957, 729);
            this.tabQLND.TabIndex = 6;
            this.tabQLND.Text = "Người dùng";
            // 
            // tabTDQD
            // 
            this.tabTDQD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabTDQD.ImageIndex = 7;
            this.tabTDQD.Location = new System.Drawing.Point(274, 4);
            this.tabTDQD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTDQD.Name = "tabTDQD";
            this.tabTDQD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTDQD.Size = new System.Drawing.Size(957, 729);
            this.tabTDQD.TabIndex = 7;
            this.tabTDQD.Text = "Thay đổi quy định";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.SlateBlue;
            this.iconList.Images.SetKeyName(0, "docgia.png");
            this.iconList.Images.SetKeyName(1, "nguoidung.png");
            this.iconList.Images.SetKeyName(2, "phieumuontra.png");
            this.iconList.Images.SetKeyName(3, "phieuthu.png");
            this.iconList.Images.SetKeyName(4, "report_icon.png");
            this.iconList.Images.SetKeyName(5, "sach.png");
            this.iconList.Images.SetKeyName(6, "taikhoan.png");
            this.iconList.Images.SetKeyName(7, "thaydoiquydinh.png");
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 807);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "fManager";
            this.Text = "fAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
        private TabPage tabQLDG;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private TabPage tabQLS;
        private TabPage tabQLMT;
        private TabPage tabQLPT;
        private TabPage tabBC;
        private TabPage tabQLND;
        private static ucBanAccess ucBan;
        private static ucQLDG ucqldg;
        private static ucQLSach ucqlsach;
       // private static ucHome uchome;
        private static ucQLPhieuMuon ucphieumuontra;
        private static ucQLPhieuThu ucphieuthu;
        private static ucBCTK ucbaocao;
        private static ucQLND ucnguoidung;
        private static ucThongTinTaiKhoan uctaikhoan;
        private static ucThayDoiQuiDinh ucquidinh;
        private Label label2;
        private ImageList iconList;
        private TabPage tabTDQD;
        private TabPage tabAccount;
    }
}