using GUI.UserControls;
using System.Windows.Forms;

namespace GUI
{
    partial class fMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.pageAccount = new System.Windows.Forms.TabPage();
            this.pageQLDG = new System.Windows.Forms.TabPage();
            this.pageQLS = new System.Windows.Forms.TabPage();
            this.pageQLMT = new System.Windows.Forms.TabPage();
            this.pageQLPT = new System.Windows.Forms.TabPage();
            this.pageBC = new System.Windows.Forms.TabPage();
            this.pageQLND = new System.Windows.Forms.TabPage();
            this.pageTDQD = new System.Windows.Forms.TabPage();
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
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitControlBox.IconColor = System.Drawing.Color.Gray;
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
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1089, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(75, 71);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.exitControlBox);
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.topPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1235, 74);
            this.topPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "UIT LIBRARY";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.pageAccount);
            this.tabControl.Controls.Add(this.pageQLDG);
            this.tabControl.Controls.Add(this.pageQLS);
            this.tabControl.Controls.Add(this.pageQLMT);
            this.tabControl.Controls.Add(this.pageQLPT);
            this.tabControl.Controls.Add(this.pageBC);
            this.tabControl.Controls.Add(this.pageQLND);
            this.tabControl.Controls.Add(this.pageTDQD);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.iconList;
            this.tabControl.ItemSize = new System.Drawing.Size(250, 80);
            this.tabControl.Location = new System.Drawing.Point(0, 74);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1235, 733);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.DarkSlateBlue;
            this.tabControl.TabButtonSize = new System.Drawing.Size(250, 80);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            // 
            // pageAccount
            // 
            this.pageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.pageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pageAccount.ImageIndex = 0;
            this.pageAccount.Location = new System.Drawing.Point(254, 4);
            this.pageAccount.Margin = new System.Windows.Forms.Padding(0);
            this.pageAccount.Name = "pageAccount";
            this.pageAccount.Size = new System.Drawing.Size(977, 725);
            this.pageAccount.TabIndex = 0;
            this.pageAccount.Text = "Tài khoản";
            // 
            // pageQLDG
            // 
            this.pageQLDG.ImageIndex = 1;
            this.pageQLDG.Location = new System.Drawing.Point(254, 4);
            this.pageQLDG.Margin = new System.Windows.Forms.Padding(0);
            this.pageQLDG.Name = "pageQLDG";
            this.pageQLDG.Size = new System.Drawing.Size(977, 725);
            this.pageQLDG.TabIndex = 1;
            this.pageQLDG.Text = "Độc giả";
            this.pageQLDG.UseVisualStyleBackColor = true;
            // 
            // pageQLS
            // 
            this.pageQLS.ImageIndex = 2;
            this.pageQLS.Location = new System.Drawing.Point(254, 4);
            this.pageQLS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLS.Name = "pageQLS";
            this.pageQLS.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLS.Size = new System.Drawing.Size(977, 725);
            this.pageQLS.TabIndex = 2;
            this.pageQLS.Text = "Sách";
            this.pageQLS.UseVisualStyleBackColor = true;
            // 
            // pageQLMT
            // 
            this.pageQLMT.ImageIndex = 3;
            this.pageQLMT.Location = new System.Drawing.Point(254, 4);
            this.pageQLMT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLMT.Name = "pageQLMT";
            this.pageQLMT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLMT.Size = new System.Drawing.Size(977, 725);
            this.pageQLMT.TabIndex = 3;
            this.pageQLMT.Text = "Phiếu mượn trả";
            this.pageQLMT.UseVisualStyleBackColor = true;
            // 
            // pageQLPT
            // 
            this.pageQLPT.ImageIndex = 4;
            this.pageQLPT.Location = new System.Drawing.Point(254, 4);
            this.pageQLPT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLPT.Name = "pageQLPT";
            this.pageQLPT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLPT.Size = new System.Drawing.Size(977, 725);
            this.pageQLPT.TabIndex = 4;
            this.pageQLPT.Text = "Phiếu thu";
            this.pageQLPT.UseVisualStyleBackColor = true;
            // 
            // pageBC
            // 
            this.pageBC.ImageIndex = 5;
            this.pageBC.Location = new System.Drawing.Point(254, 4);
            this.pageBC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageBC.Name = "pageBC";
            this.pageBC.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageBC.Size = new System.Drawing.Size(977, 725);
            this.pageBC.TabIndex = 5;
            this.pageBC.Text = "Báo cáo thống kê";
            this.pageBC.UseVisualStyleBackColor = true;
            // 
            // pageQLND
            // 
            this.pageQLND.ImageIndex = 6;
            this.pageQLND.Location = new System.Drawing.Point(254, 4);
            this.pageQLND.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLND.Name = "pageQLND";
            this.pageQLND.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageQLND.Size = new System.Drawing.Size(977, 725);
            this.pageQLND.TabIndex = 6;
            this.pageQLND.Text = "Người dùng";
            this.pageQLND.UseVisualStyleBackColor = true;
            // 
            // pageTDQD
            // 
            this.pageTDQD.ImageIndex = 8;
            this.pageTDQD.Location = new System.Drawing.Point(254, 4);
            this.pageTDQD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageTDQD.Name = "pageTDQD";
            this.pageTDQD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageTDQD.Size = new System.Drawing.Size(977, 725);
            this.pageTDQD.TabIndex = 7;
            this.pageTDQD.Text = "Thay đổi quy định";
            this.pageTDQD.UseVisualStyleBackColor = true;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "info_icon.png");
            this.iconList.Images.SetKeyName(1, "user_icon02.png");
            this.iconList.Images.SetKeyName(2, "book_icon03.png");
            this.iconList.Images.SetKeyName(3, "phieumuon_icon.png");
            this.iconList.Images.SetKeyName(4, "phieuthu_icon.png");
            this.iconList.Images.SetKeyName(5, "report_icon03.png");
            this.iconList.Images.SetKeyName(6, "user_icon03.png");
            this.iconList.Images.SetKeyName(7, "book_icon02.png");
            this.iconList.Images.SetKeyName(8, "user_icon.png");
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 807);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "fMainForm";
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
        private TabPage pageQLDG;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private TabPage pageQLS;
        private TabPage pageQLMT;
        private TabPage pageQLPT;
        private TabPage pageBC;
        private TabPage pageQLND;
        private static ucBanAccess ucBan;
        private static ucQLDG ucqldg;
        private static ucQLSach ucqlsach;
        private static ucHome uchome;
        private static ucQLPhieuMuon ucphieumuontra;
        private static ucQLPhieuThu ucphieuthu;
        private static ucBCTK ucbaocao;
        private static ucQLND ucnguoidung;
        private static ucThongTinTaiKhoan uctaikhoan;
        private static ucThayDoiQuiDinh ucquidinh;
        private Label label2;
        private ImageList iconList;
        private TabPage pageTDQD;
        private TabPage pageAccount;

        // test uc mới
        private static ucQLPhieuMuonTra uctheloai;
    }
}