namespace GUI
{
    partial class fAddDocGia
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.comboNND = new System.Windows.Forms.ComboBox();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEmailError = new System.Windows.Forms.Label();
            this.dateNgayHetHan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butOK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboLoaiDG = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateNgayLap = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.dateNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUserpwd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtChucVu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtDiaChi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtHoTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.siticoneEmailValidatingTool1 = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.controlPanel.Controls.Add(this.miniControlBox);
            this.controlPanel.Controls.Add(this.closeControlBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(831, 54);
            this.controlPanel.TabIndex = 0;
            // 
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.miniControlBox.Location = new System.Drawing.Point(708, 0);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(60, 54);
            this.miniControlBox.TabIndex = 0;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.closeControlBox.Location = new System.Drawing.Point(770, 0);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(61, 54);
            this.closeControlBox.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.controlPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.mainPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.mainPanel.BorderRadius = 2;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.comboNND);
            this.mainPanel.Controls.Add(this.labelEmailError);
            this.mainPanel.Controls.Add(this.dateNgayHetHan);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.butOK);
            this.mainPanel.Controls.Add(this.comboLoaiDG);
            this.mainPanel.Controls.Add(this.dateNgayLap);
            this.mainPanel.Controls.Add(this.dateNgaySinh);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtEmail);
            this.mainPanel.Controls.Add(this.txtUserpwd);
            this.mainPanel.Controls.Add(this.txtChucVu);
            this.mainPanel.Controls.Add(this.txtUsername);
            this.mainPanel.Controls.Add(this.txtDiaChi);
            this.mainPanel.Controls.Add(this.txtHoTen);
            this.mainPanel.Controls.Add(this.labelTitle);
            this.mainPanel.Location = new System.Drawing.Point(91, 109);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Color = System.Drawing.Color.MediumSlateBlue;
            this.mainPanel.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.mainPanel.Size = new System.Drawing.Size(649, 721);
            this.mainPanel.TabIndex = 1;
            // 
            // comboNND
            // 
            this.comboNND.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.comboNND.DisplayMember = "TenNhomNguoiDung";
            this.comboNND.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNND.FormattingEnabled = true;
            this.comboNND.Location = new System.Drawing.Point(317, 494);
            this.comboNND.Name = "comboNND";
            this.comboNND.Size = new System.Drawing.Size(183, 30);
            this.comboNND.TabIndex = 9;
            this.comboNND.ValueMember = "id";
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataSource = typeof(DTO.NHOMNGUOIDUNG);
            // 
            // labelEmailError
            // 
            this.labelEmailError.AutoSize = true;
            this.labelEmailError.Location = new System.Drawing.Point(133, 394);
            this.labelEmailError.Name = "labelEmailError";
            this.labelEmailError.Size = new System.Drawing.Size(0, 16);
            this.labelEmailError.TabIndex = 8;
            // 
            // dateNgayHetHan
            // 
            this.dateNgayHetHan.AutoSize = true;
            this.dateNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayHetHan.Location = new System.Drawing.Point(343, 570);
            this.dateNgayHetHan.Name = "dateNgayHetHan";
            this.dateNgayHetHan.Size = new System.Drawing.Size(112, 25);
            this.dateNgayHetHan.TabIndex = 7;
            this.dateNgayHetHan.Text = "27/10/2003";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(339, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Hết Hạn";
            // 
            // butOK
            // 
            this.butOK.BorderRadius = 3;
            this.butOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOK.FillColor = System.Drawing.Color.SlateBlue;
            this.butOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(274, 636);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(101, 45);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "Thêm";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // comboLoaiDG
            // 
            this.comboLoaiDG.BackColor = System.Drawing.Color.Transparent;
            this.comboLoaiDG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiDG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiDG.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoaiDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboLoaiDG.ItemHeight = 30;
            this.comboLoaiDG.Location = new System.Drawing.Point(317, 202);
            this.comboLoaiDG.Name = "comboLoaiDG";
            this.comboLoaiDG.Size = new System.Drawing.Size(183, 36);
            this.comboLoaiDG.TabIndex = 4;
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Checked = true;
            this.dateNgayLap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dateNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLap.Location = new System.Drawing.Point(136, 567);
            this.dateNgayLap.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateNgayLap.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(160, 36);
            this.dateNgayLap.TabIndex = 3;
            this.dateNgayLap.Value = new System.DateTime(2022, 12, 16, 11, 48, 50, 797);
            this.dateNgayLap.ValueChanged += new System.EventHandler(this.dateNgayLap_ValueChanged);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Checked = true;
            this.dateNgaySinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dateNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(133, 202);
            this.dateNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(159, 40);
            this.dateNgaySinh.TabIndex = 3;
            this.dateNgaySinh.Value = new System.DateTime(2022, 12, 16, 12, 3, 14, 424);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(132, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày Lập Thẻ*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(313, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Độc Giả*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(129, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(313, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mật Khẩu*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(313, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nhóm Người Dùng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(132, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(132, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Đăng Nhập*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(129, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(129, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(129, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ Tên*";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(133, 348);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(367, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // txtUserpwd
            // 
            this.txtUserpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.DefaultText = "";
            this.txtUserpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserpwd.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserpwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserpwd.Location = new System.Drawing.Point(317, 422);
            this.txtUserpwd.Name = "txtUserpwd";
            this.txtUserpwd.PasswordChar = '\0';
            this.txtUserpwd.PlaceholderText = "";
            this.txtUserpwd.SelectedText = "";
            this.txtUserpwd.Size = new System.Drawing.Size(183, 36);
            this.txtUserpwd.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChucVu.DefaultText = "";
            this.txtChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChucVu.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChucVu.Location = new System.Drawing.Point(133, 494);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.PasswordChar = '\0';
            this.txtChucVu.PlaceholderText = "";
            this.txtChucVu.SelectedText = "";
            this.txtChucVu.Size = new System.Drawing.Size(159, 36);
            this.txtChucVu.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(133, 422);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(159, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(133, 276);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(367, 36);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(133, 130);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(367, 36);
            this.txtHoTen.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(119, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(393, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THÊM THẺ ĐỘC GIẢ";
            // 
            // siticoneEmailValidatingTool1
            // 
            this.siticoneEmailValidatingTool1.EmailTextbox = this.txtEmail;
            this.siticoneEmailValidatingTool1.MessageDescription = this.labelEmailError;
            // 
            // fAddDocGia
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(831, 888);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddDocGia";
            this.Load += new System.EventHandler(this.fAddDocGia_Load);
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHoTen;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboLoaiDG;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiaChi;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayLap;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool siticoneEmailValidatingTool1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateNgayHetHan;
        private System.Windows.Forms.Label labelEmailError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserpwd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        private System.Windows.Forms.ComboBox comboNND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtChucVu;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
    }
}