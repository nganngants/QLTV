namespace GUI
{
    partial class fAddNguoiDung
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNhomND = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.txtHoTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.txtUserpwd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChucVu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.BorderRadius = 3;
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.SlateBlue;
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(273, 571);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(150, 50);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÊM NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboNhomND
            // 
            this.comboNhomND.BackColor = System.Drawing.Color.Transparent;
            this.comboNhomND.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboNhomND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNhomND.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboNhomND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboNhomND.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNhomND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboNhomND.ItemHeight = 30;
            this.comboNhomND.Location = new System.Drawing.Point(137, 250);
            this.comboNhomND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboNhomND.Name = "comboNhomND";
            this.comboNhomND.Size = new System.Drawing.Size(210, 36);
            this.comboNhomND.TabIndex = 45;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Checked = true;
            this.dateNgaySinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dateNgaySinh.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.ForeColor = System.Drawing.Color.SlateBlue;
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(377, 250);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(187, 47);
            this.dateNgaySinh.TabIndex = 40;
            this.dateNgaySinh.Value = new System.DateTime(2022, 12, 2, 22, 44, 12, 275);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtHoTen.Location = new System.Drawing.Point(137, 156);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(427, 40);
            this.txtHoTen.TabIndex = 39;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(779, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(55, 45);
            this.siticoneControlBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(372, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(132, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nhóm Người Dùng*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(132, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Họ Tên*";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(839, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox1.TabIndex = 9;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.txtUserpwd);
            this.siticonePanel1.Controls.Add(this.txtUsername);
            this.siticonePanel1.Controls.Add(this.comboNhomND);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.dateNgaySinh);
            this.siticonePanel1.Controls.Add(this.txtChucVu);
            this.siticonePanel1.Controls.Add(this.txtHoTen);
            this.siticonePanel1.Controls.Add(this.label4);
            this.siticonePanel1.Controls.Add(this.label7);
            this.siticonePanel1.Controls.Add(this.label6);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Location = new System.Drawing.Point(99, 100);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(696, 661);
            this.siticonePanel1.TabIndex = 7;
            // 
            // txtUserpwd
            // 
            this.txtUserpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.DefaultText = "";
            this.txtUserpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtUserpwd.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserpwd.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUserpwd.Location = new System.Drawing.Point(137, 500);
            this.txtUserpwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserpwd.Name = "txtUserpwd";
            this.txtUserpwd.PasswordChar = '\0';
            this.txtUserpwd.PlaceholderText = "";
            this.txtUserpwd.SelectedText = "";
            this.txtUserpwd.Size = new System.Drawing.Size(427, 40);
            this.txtUserpwd.TabIndex = 52;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(137, 419);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(427, 40);
            this.txtUsername.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(132, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Chức Vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChucVu.DefaultText = "";
            this.txtChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtChucVu.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtChucVu.Location = new System.Drawing.Point(137, 339);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.PasswordChar = '\0';
            this.txtChucVu.PlaceholderText = "";
            this.txtChucVu.SelectedText = "";
            this.txtChucVu.Size = new System.Drawing.Size(427, 40);
            this.txtChucVu.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(132, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mật khẩu*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(132, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên Đăng Nhập*";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // fAddNguoiDung
            // 
            this.AcceptButton = this.butSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(894, 836);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddNguoiDung";
            this.Text = "BMQLNguoiDung";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboNhomND;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgaySinh;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHoTen;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserpwd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}