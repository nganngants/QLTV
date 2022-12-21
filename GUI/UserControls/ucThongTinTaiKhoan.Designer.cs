namespace GUI.UserControls
{
    partial class ucThongTinTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Quản Lý Độc Giả");
            this.tableLayoutTen = new System.Windows.Forms.TableLayoutPanel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.BotPanel = new System.Windows.Forms.Panel();
            this.botTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.infoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butChangePass = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelUsrName = new System.Windows.Forms.Label();
            this.siticonePanel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelMaND = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.featPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.parentPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tableLayoutTen.SuspendLayout();
            this.BotPanel.SuspendLayout();
            this.botTableLayout.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel5.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.featPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.parentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutTen
            // 
            this.tableLayoutTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tableLayoutTen.ColumnCount = 1;
            this.tableLayoutTen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutTen.Controls.Add(this.labelRole, 0, 2);
            this.tableLayoutTen.Controls.Add(this.labelName, 0, 3);
            this.tableLayoutTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTen.Location = new System.Drawing.Point(210, 5);
            this.tableLayoutTen.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutTen.Name = "tableLayoutTen";
            this.tableLayoutTen.RowCount = 6;
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTen.Size = new System.Drawing.Size(764, 193);
            this.tableLayoutTen.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelRole.Location = new System.Drawing.Point(3, 54);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(758, 32);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "Vai trò";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Variable Display", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelName.Location = new System.Drawing.Point(3, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(489, 66);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Họ Tên Người Dùng";
            // 
            // BotPanel
            // 
            this.BotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.BotPanel.Controls.Add(this.botTableLayout);
            this.BotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotPanel.Location = new System.Drawing.Point(5, 208);
            this.BotPanel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.BotPanel.Name = "BotPanel";
            this.BotPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotPanel.Size = new System.Drawing.Size(979, 582);
            this.BotPanel.TabIndex = 1;
            // 
            // botTableLayout
            // 
            this.botTableLayout.ColumnCount = 2;
            this.botTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.botTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.botTableLayout.Controls.Add(this.infoPanel, 0, 0);
            this.botTableLayout.Controls.Add(this.featPanel, 1, 0);
            this.botTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botTableLayout.Location = new System.Drawing.Point(3, 2);
            this.botTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.botTableLayout.Name = "botTableLayout";
            this.botTableLayout.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.botTableLayout.RowCount = 1;
            this.botTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.botTableLayout.Size = new System.Drawing.Size(973, 578);
            this.botTableLayout.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.infoPanel.BorderRadius = 5;
            this.infoPanel.BorderThickness = 2;
            this.infoPanel.Controls.Add(this.butChangePass);
            this.infoPanel.Controls.Add(this.siticonePanel6);
            this.infoPanel.Controls.Add(this.siticonePanel5);
            this.infoPanel.Controls.Add(this.siticonePanel4);
            this.infoPanel.Controls.Add(this.siticonePanel3);
            this.infoPanel.Controls.Add(this.siticoneSeparator1);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(24, 22);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(13, 12, 16, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.infoPanel.Size = new System.Drawing.Size(446, 534);
            this.infoPanel.TabIndex = 0;
            // 
            // butChangePass
            // 
            this.butChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butChangePass.BorderRadius = 5;
            this.butChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butChangePass.FillColor = System.Drawing.Color.SlateBlue;
            this.butChangePass.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChangePass.ForeColor = System.Drawing.Color.White;
            this.butChangePass.Image = global::GUI.Properties.Resources.white_key_icon;
            this.butChangePass.Location = new System.Drawing.Point(11, 486);
            this.butChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.butChangePass.Name = "butChangePass";
            this.butChangePass.Size = new System.Drawing.Size(124, 38);
            this.butChangePass.TabIndex = 6;
            this.butChangePass.Text = "Đổi mật khẩu";
            this.butChangePass.Click += new System.EventHandler(this.butChangePass_Click);
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.Controls.Add(this.labelUsrName);
            this.siticonePanel6.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.siticonePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel6.Location = new System.Drawing.Point(11, 176);
            this.siticonePanel6.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel6.Size = new System.Drawing.Size(424, 37);
            this.siticonePanel6.TabIndex = 5;
            // 
            // labelUsrName
            // 
            this.labelUsrName.AutoSize = true;
            this.labelUsrName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUsrName.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsrName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelUsrName.Location = new System.Drawing.Point(0, 12);
            this.labelUsrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsrName.Name = "labelUsrName";
            this.labelUsrName.Size = new System.Drawing.Size(178, 32);
            this.labelUsrName.TabIndex = 1;
            this.labelUsrName.Text = "Tên đăng nhập: ";
            // 
            // siticonePanel5
            // 
            this.siticonePanel5.Controls.Add(this.labelChucVu);
            this.siticonePanel5.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.siticonePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel5.Location = new System.Drawing.Point(11, 140);
            this.siticonePanel5.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.siticonePanel5.Name = "siticonePanel5";
            this.siticonePanel5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel5.Size = new System.Drawing.Size(424, 36);
            this.siticonePanel5.TabIndex = 4;
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChucVu.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChucVu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelChucVu.Location = new System.Drawing.Point(0, 12);
            this.labelChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(106, 32);
            this.labelChucVu.TabIndex = 1;
            this.labelChucVu.Text = "Chức vụ:";
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Controls.Add(this.labelNgaySinh);
            this.siticonePanel4.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel4.Location = new System.Drawing.Point(11, 104);
            this.siticonePanel4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel4.Size = new System.Drawing.Size(424, 36);
            this.siticonePanel4.TabIndex = 3;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelNgaySinh.Location = new System.Drawing.Point(0, 12);
            this.labelNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(124, 32);
            this.labelNgaySinh.TabIndex = 1;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.labelMaND);
            this.siticonePanel3.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel3.Location = new System.Drawing.Point(11, 68);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel3.Size = new System.Drawing.Size(424, 36);
            this.siticonePanel3.TabIndex = 2;
            // 
            // labelMaND
            // 
            this.labelMaND.AutoSize = true;
            this.labelMaND.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaND.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaND.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMaND.Location = new System.Drawing.Point(0, 12);
            this.labelMaND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaND.Name = "labelMaND";
            this.labelMaND.Size = new System.Drawing.Size(185, 32);
            this.labelMaND.TabIndex = 0;
            this.labelMaND.Text = "Mã người dùng: ";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneSeparator1.Location = new System.Drawing.Point(11, 56);
            this.siticoneSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(424, 12);
            this.siticoneSeparator1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết người dùng";
            // 
            // featPanel
            // 
            this.featPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.featPanel.BorderRadius = 5;
            this.featPanel.BorderThickness = 2;
            this.featPanel.Controls.Add(this.listView1);
            this.featPanel.Controls.Add(this.siticoneSeparator2);
            this.featPanel.Controls.Add(this.label2);
            this.featPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featPanel.Location = new System.Drawing.Point(502, 22);
            this.featPanel.Margin = new System.Windows.Forms.Padding(16, 12, 13, 12);
            this.featPanel.Name = "featPanel";
            this.featPanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.featPanel.Size = new System.Drawing.Size(447, 534);
            this.featPanel.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(11, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 456);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneSeparator2.Location = new System.Drawing.Point(11, 56);
            this.siticoneSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(425, 12);
            this.siticoneSeparator2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các chức năng";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.topPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.topPanel.BorderRadius = 5;
            this.topPanel.BorderThickness = 2;
            this.topPanel.Controls.Add(this.tableLayoutTen);
            this.topPanel.Controls.Add(this.siticoneCirclePictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(5, 5);
            this.topPanel.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(5);
            this.topPanel.Size = new System.Drawing.Size(979, 203);
            this.topPanel.TabIndex = 2;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneCirclePictureBox1.Image = global::GUI.Properties.Resources.user;
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(5, 5);
            this.siticoneCirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(205, 193);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox1.TabIndex = 2;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.BotPanel);
            this.parentPanel.Controls.Add(this.topPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.parentPanel.Size = new System.Drawing.Size(989, 795);
            this.parentPanel.TabIndex = 3;
            // 
            // ucThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucThongTinTaiKhoan";
            this.Size = new System.Drawing.Size(989, 795);
            this.tableLayoutTen.ResumeLayout(false);
            this.tableLayoutTen.PerformLayout();
            this.BotPanel.ResumeLayout(false);
            this.botTableLayout.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.siticonePanel6.ResumeLayout(false);
            this.siticonePanel6.PerformLayout();
            this.siticonePanel5.ResumeLayout(false);
            this.siticonePanel5.PerformLayout();
            this.siticonePanel4.ResumeLayout(false);
            this.siticonePanel4.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel3.PerformLayout();
            this.featPanel.ResumeLayout(false);
            this.featPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.parentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTen;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Panel BotPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel parentPanel;
        private System.Windows.Forms.TableLayoutPanel botTableLayout;
        private Siticone.Desktop.UI.WinForms.SiticonePanel infoPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel featPanel;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel5;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label labelMaND;

        private System.Windows.Forms.Label labelUsrName;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelNgaySinh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butChangePass;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.ListView listView1;
    }
}
