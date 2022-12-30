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
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.comboDocGia = new System.Windows.Forms.ComboBox();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textTienThu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelNoMoi = new System.Windows.Forms.Label();
            this.labelNoHienTai = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayLap = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.topPanel = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
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
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(736, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox1.TabIndex = 72;
            // 
            // butSave
            // 
            this.butSave.BorderRadius = 4;
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.SlateBlue;
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(307, 612);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(150, 50);
            this.butSave.TabIndex = 70;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butLogin_Click);
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
            this.siticonePanel1.Controls.Add(this.comboDocGia);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.textTienThu);
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
            // comboDocGia
            // 
            this.comboDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDocGia.DataSource = this.dOCGIABindingSource;
            this.comboDocGia.DisplayMember = "MaDocGia";
            this.comboDocGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocGia.FormattingEnabled = true;
            this.comboDocGia.Location = new System.Drawing.Point(218, 192);
            this.comboDocGia.Name = "comboDocGia";
            this.comboDocGia.Size = new System.Drawing.Size(368, 35);
            this.comboDocGia.TabIndex = 99;
            this.comboDocGia.ValueMember = "ID";
            this.comboDocGia.SelectedIndexChanged += new System.EventHandler(this.comboDocGia_SelectedIndexChanged);
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataSource = typeof(DTO.DOCGIA);
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
            // textTienThu
            // 
            this.textTienThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTienThu.DefaultText = "";
            this.textTienThu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTienThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTienThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTienThu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTienThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.textTienThu.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTienThu.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.textTienThu.Location = new System.Drawing.Point(218, 355);
            this.textTienThu.Margin = new System.Windows.Forms.Padding(4);
            this.textTienThu.Name = "textTienThu";
            this.textTienThu.PasswordChar = '\0';
            this.textTienThu.PlaceholderText = "";
            this.textTienThu.SelectedText = "";
            this.textTienThu.Size = new System.Drawing.Size(368, 37);
            this.textTienThu.TabIndex = 96;
            this.textTienThu.TextChanged += new System.EventHandler(this.siticoneTextBox5_TextChanged);
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
            this.dateNgayLap.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.topPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.Controls.Add(this.siticoneControlBox2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 54);
            this.topPanel.TabIndex = 73;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.topPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // fPhieuThu
            // 
            this.AcceptButton = this.butSave;
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
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textTienThu;
        private Label label9;
        private Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayLap;
        private Label label12;
        private Label label2;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Label labelNoMoi;
        private Label labelNoHienTai;
        private ComboBox comboDocGia;
        private BindingSource dOCGIABindingSource;
    }
}