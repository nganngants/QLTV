using System.Windows.Forms;

namespace GUI
{
    partial class fPhieuThu
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
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.butLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneTextBox5 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayLap = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.topPanel = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.labelNoHienTai = new System.Windows.Forms.Label();
            this.labelNoMoi = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.siticoneControlBox2.Location = new System.Drawing.Point(683, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(55, 45);
            this.siticoneControlBox2.TabIndex = 71;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.siticoneControlBox1.Location = new System.Drawing.Point(736, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox1.TabIndex = 72;
            // 
            // butLogin
            // 
            this.butLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogin.FillColor = System.Drawing.Color.SlateBlue;
            this.butLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butLogin.Location = new System.Drawing.Point(307, 612);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(150, 50);
            this.butLogin.TabIndex = 70;
            this.butLogin.Text = "Lưu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(191, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 53);
            this.label1.TabIndex = 69;
            this.label1.Text = "PHIẾU THU TIỀN PHẠT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticonePanel1.Controls.Add(this.siticoneComboBox1);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.butLogin);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.siticoneTextBox5);
            this.siticonePanel1.Controls.Add(this.labelNoMoi);
            this.siticonePanel1.Controls.Add(this.labelNoHienTai);
            this.siticonePanel1.Controls.Add(this.label9);
            this.siticonePanel1.Controls.Add(this.label8);
            this.siticonePanel1.Controls.Add(this.dateNgayLap);
            this.siticonePanel1.Controls.Add(this.label12);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(793, 716);
            this.siticonePanel1.TabIndex = 68;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Location = new System.Drawing.Point(218, 191);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(368, 36);
            this.siticoneComboBox1.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(213, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "Tổng nợ mới:";
            // 
            // siticoneTextBox5
            // 
            this.siticoneTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox5.DefaultText = "";
            this.siticoneTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.siticoneTextBox5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneTextBox5.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.siticoneTextBox5.Location = new System.Drawing.Point(218, 355);
            this.siticoneTextBox5.Name = "siticoneTextBox5";
            this.siticoneTextBox5.PasswordChar = '\0';
            this.siticoneTextBox5.PlaceholderText = "";
            this.siticoneTextBox5.SelectedText = "";
            this.siticoneTextBox5.Size = new System.Drawing.Size(368, 51);
            this.siticoneTextBox5.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SlateBlue;
            this.label9.Location = new System.Drawing.Point(213, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 94;
            this.label9.Text = "Tổng nợ hiện tại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(213, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "Số tiền thu:";
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dateNgayLap.Checked = true;
            this.dateNgayLap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dateNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayLap.ForeColor = System.Drawing.Color.SlateBlue;
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLap.Location = new System.Drawing.Point(218, 525);
            this.dateNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(368, 51);
            this.dateNgayLap.TabIndex = 81;
            this.dateNgayLap.Value = new System.DateTime(2022, 12, 2, 22, 44, 12, 275);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(213, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 78;
            this.label12.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(213, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Độc giả:";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.Controls.Add(this.siticoneControlBox2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 68);
            this.topPanel.TabIndex = 73;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.topPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // labelNoHienTai
            // 
            this.labelNoHienTai.AutoSize = true;
            this.labelNoHienTai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoHienTai.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelNoHienTai.Location = new System.Drawing.Point(213, 283);
            this.labelNoHienTai.Name = "labelNoHienTai";
            this.labelNoHienTai.Size = new System.Drawing.Size(26, 31);
            this.labelNoHienTai.TabIndex = 94;
            this.labelNoHienTai.Text = "0";
            // 
            // labelNoMoi
            // 
            this.labelNoMoi.AutoSize = true;
            this.labelNoMoi.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMoi.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelNoMoi.Location = new System.Drawing.Point(213, 446);
            this.labelNoMoi.Name = "labelNoMoi";
            this.labelNoMoi.Size = new System.Drawing.Size(26, 31);
            this.labelNoMoi.TabIndex = 94;
            this.labelNoMoi.Text = "0";
            // 
            // fPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(793, 716);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmPhieuThuTienPhat";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butLogin;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox5;
        private Label label9;
        private Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayLap;
        private Label label12;
        private Label label2;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Label labelNoMoi;
        private Label labelNoHienTai;
    }
}