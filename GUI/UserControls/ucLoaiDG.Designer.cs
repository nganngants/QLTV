using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucLoaiDG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.botTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.infoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel10 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tableLoaiDocGia = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.MaLoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticonePanel9 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelSpace = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.featPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.feat02 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labFeat02 = new System.Windows.Forms.Label();
            this.feat01 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labFeat01 = new System.Windows.Forms.Label();
            this.siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butChangePass = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel8 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TopPanel.SuspendLayout();
            this.botTableLayout.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.siticonePanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLoaiDocGia)).BeginInit();
            this.siticonePanel9.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.featPanel.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.feat02.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.feat01.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.botTableLayout);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(997, 596);
            this.TopPanel.TabIndex = 2;
            // 
            // botTableLayout
            // 
            this.botTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.botTableLayout.ColumnCount = 2;
            this.botTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.botTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.botTableLayout.Controls.Add(this.infoPanel, 0, 0);
            this.botTableLayout.Controls.Add(this.featPanel, 1, 0);
            this.botTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botTableLayout.Location = new System.Drawing.Point(0, 0);
            this.botTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.botTableLayout.Name = "botTableLayout";
            this.botTableLayout.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.botTableLayout.RowCount = 1;
            this.botTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.botTableLayout.Size = new System.Drawing.Size(997, 596);
            this.botTableLayout.TabIndex = 15;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.infoPanel.BorderRadius = 5;
            this.infoPanel.BorderThickness = 2;
            this.infoPanel.Controls.Add(this.siticonePanel10);
            this.infoPanel.Controls.Add(this.siticonePanel9);
            this.infoPanel.Controls.Add(this.PanelSpace);
            this.infoPanel.Controls.Add(this.siticoneSeparator1);
            this.infoPanel.Controls.Add(this.siticonePanel4);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(24, 22);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(13, 12, 16, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.infoPanel.Size = new System.Drawing.Size(458, 552);
            this.infoPanel.TabIndex = 0;
            // 
            // siticonePanel10
            // 
            this.siticonePanel10.Controls.Add(this.tableLoaiDocGia);
            this.siticonePanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel10.Location = new System.Drawing.Point(11, 94);
            this.siticonePanel10.Name = "siticonePanel10";
            this.siticonePanel10.Size = new System.Drawing.Size(436, 394);
            this.siticonePanel10.TabIndex = 29;
            // 
            // tableLoaiDocGia
            // 
            this.tableLoaiDocGia.AllowUserToAddRows = false;
            this.tableLoaiDocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableLoaiDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLoaiDocGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLoaiDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableLoaiDocGia.ColumnHeadersHeight = 50;
            this.tableLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableLoaiDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDocGia,
            this.TenLoaiDocGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLoaiDocGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableLoaiDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLoaiDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.Location = new System.Drawing.Point(0, 0);
            this.tableLoaiDocGia.Name = "tableLoaiDocGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLoaiDocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableLoaiDocGia.RowHeadersVisible = false;
            this.tableLoaiDocGia.RowHeadersWidth = 53;
            this.tableLoaiDocGia.RowTemplate.Height = 25;
            this.tableLoaiDocGia.Size = new System.Drawing.Size(436, 394);
            this.tableLoaiDocGia.TabIndex = 29;
            this.tableLoaiDocGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLoaiDocGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableLoaiDocGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableLoaiDocGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableLoaiDocGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableLoaiDocGia.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableLoaiDocGia.ThemeStyle.HeaderStyle.Height = 50;
            this.tableLoaiDocGia.ThemeStyle.ReadOnly = false;
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.Height = 25;
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLoaiDocGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaLoaiDocGia
            // 
            this.MaLoaiDocGia.HeaderText = "Mã Loại Độc Giả";
            this.MaLoaiDocGia.MinimumWidth = 7;
            this.MaLoaiDocGia.Name = "MaLoaiDocGia";
            // 
            // TenLoaiDocGia
            // 
            this.TenLoaiDocGia.HeaderText = "Tên Loại Độc Giả";
            this.TenLoaiDocGia.MinimumWidth = 7;
            this.TenLoaiDocGia.Name = "TenLoaiDocGia";
            // 
            // siticonePanel9
            // 
            this.siticonePanel9.Controls.Add(this.butSave);
            this.siticonePanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel9.Location = new System.Drawing.Point(11, 488);
            this.siticonePanel9.Name = "siticonePanel9";
            this.siticonePanel9.Size = new System.Drawing.Size(436, 54);
            this.siticonePanel9.TabIndex = 28;
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSave.BorderRadius = 5;
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.SlateBlue;
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Image = global::GUI.Properties.Resources._69539;
            this.butSave.Location = new System.Drawing.Point(260, 4);
            this.butSave.Margin = new System.Windows.Forms.Padding(4);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(159, 38);
            this.butSave.TabIndex = 8;
            this.butSave.Text = "Lưu thay đổi";
            // 
            // PanelSpace
            // 
            this.PanelSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSpace.Location = new System.Drawing.Point(11, 83);
            this.PanelSpace.Name = "PanelSpace";
            this.PanelSpace.Size = new System.Drawing.Size(436, 11);
            this.PanelSpace.TabIndex = 17;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneSeparator1.Location = new System.Drawing.Point(11, 73);
            this.siticoneSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(436, 10);
            this.siticoneSeparator1.TabIndex = 16;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Controls.Add(this.label1);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel4.Location = new System.Drawing.Point(11, 10);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(436, 63);
            this.siticonePanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 36.288F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 84);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách loại độc giả";
            // 
            // featPanel
            // 
            this.featPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.featPanel.BorderRadius = 5;
            this.featPanel.BorderThickness = 2;
            this.featPanel.Controls.Add(this.siticonePanel6);
            this.featPanel.Controls.Add(this.feat02);
            this.featPanel.Controls.Add(this.feat01);
            this.featPanel.Controls.Add(this.siticoneSeparator2);
            this.featPanel.Controls.Add(this.siticonePanel1);
            this.featPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featPanel.Location = new System.Drawing.Point(514, 22);
            this.featPanel.Margin = new System.Windows.Forms.Padding(16, 12, 13, 12);
            this.featPanel.Name = "featPanel";
            this.featPanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.featPanel.Size = new System.Drawing.Size(459, 552);
            this.featPanel.TabIndex = 0;
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.Controls.Add(this.siticoneButton3);
            this.siticonePanel6.Controls.Add(this.siticoneButton2);
            this.siticonePanel6.Controls.Add(this.siticoneButton1);
            this.siticonePanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel6.Location = new System.Drawing.Point(11, 472);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Size = new System.Drawing.Size(437, 70);
            this.siticonePanel6.TabIndex = 18;
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneButton3.BorderRadius = 5;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.SlateBlue;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(308, 16);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(108, 38);
            this.siticoneButton3.TabIndex = 21;
            this.siticoneButton3.Text = "Sửa";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneButton2.BorderRadius = 5;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.SlateBlue;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(161, 16);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(108, 38);
            this.siticoneButton2.TabIndex = 20;
            this.siticoneButton2.Text = "Xóa";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneButton1.BorderRadius = 5;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.SlateBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(15, 16);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(108, 38);
            this.siticoneButton1.TabIndex = 19;
            this.siticoneButton1.Text = "Thêm";
            // 
            // feat02
            // 
            this.feat02.Controls.Add(this.siticonePanel2);
            this.feat02.Controls.Add(this.labFeat02);
            this.feat02.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.feat02.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.feat02.Dock = System.Windows.Forms.DockStyle.Top;
            this.feat02.Location = new System.Drawing.Point(11, 131);
            this.feat02.Margin = new System.Windows.Forms.Padding(4);
            this.feat02.Name = "feat02";
            this.feat02.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.feat02.Size = new System.Drawing.Size(437, 52);
            this.feat02.TabIndex = 17;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneTextBox1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(190, 15);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(247, 33);
            this.siticonePanel2.TabIndex = 1;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.siticoneTextBox1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(247, 33);
            this.siticoneTextBox1.TabIndex = 87;
            // 
            // labFeat02
            // 
            this.labFeat02.AutoSize = true;
            this.labFeat02.Dock = System.Windows.Forms.DockStyle.Left;
            this.labFeat02.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeat02.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labFeat02.Location = new System.Drawing.Point(0, 15);
            this.labFeat02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFeat02.Name = "labFeat02";
            this.labFeat02.Size = new System.Drawing.Size(190, 33);
            this.labFeat02.TabIndex = 0;
            this.labFeat02.Text = "Tên loại độc giả:";
            // 
            // feat01
            // 
            this.feat01.Controls.Add(this.labFeat01);
            this.feat01.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.feat01.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.feat01.Dock = System.Windows.Forms.DockStyle.Top;
            this.feat01.Location = new System.Drawing.Point(11, 83);
            this.feat01.Margin = new System.Windows.Forms.Padding(4);
            this.feat01.Name = "feat01";
            this.feat01.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.feat01.Size = new System.Drawing.Size(437, 48);
            this.feat01.TabIndex = 16;
            // 
            // labFeat01
            // 
            this.labFeat01.AutoSize = true;
            this.labFeat01.Dock = System.Windows.Forms.DockStyle.Left;
            this.labFeat01.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeat01.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labFeat01.Location = new System.Drawing.Point(0, 15);
            this.labFeat01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFeat01.Name = "labFeat01";
            this.labFeat01.Size = new System.Drawing.Size(186, 33);
            this.labFeat01.TabIndex = 0;
            this.labFeat01.Text = "Mã loại độc giả:";
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneSeparator2.Location = new System.Drawing.Point(11, 73);
            this.siticoneSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(437, 10);
            this.siticoneSeparator2.TabIndex = 15;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel5);
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Controls.Add(this.siticonePanel8);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(11, 10);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(437, 63);
            this.siticonePanel1.TabIndex = 14;
            // 
            // siticonePanel5
            // 
            this.siticonePanel5.Controls.Add(this.butChangePass);
            this.siticonePanel5.Controls.Add(this.siticoneTextBox2);
            this.siticonePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel5.Location = new System.Drawing.Point(75, 17);
            this.siticonePanel5.Name = "siticonePanel5";
            this.siticonePanel5.Size = new System.Drawing.Size(362, 40);
            this.siticonePanel5.TabIndex = 2;
            // 
            // butChangePass
            // 
            this.butChangePass.BorderRadius = 5;
            this.butChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butChangePass.Dock = System.Windows.Forms.DockStyle.Left;
            this.butChangePass.FillColor = System.Drawing.Color.SlateBlue;
            this.butChangePass.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChangePass.ForeColor = System.Drawing.Color.White;
            this.butChangePass.Image = global::GUI.Properties.Resources._1200px_Search_Icon_svg;
            this.butChangePass.ImageSize = new System.Drawing.Size(30, 30);
            this.butChangePass.Location = new System.Drawing.Point(257, 0);
            this.butChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.butChangePass.Name = "butChangePass";
            this.butChangePass.Size = new System.Drawing.Size(84, 40);
            this.butChangePass.TabIndex = 90;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Location = new System.Drawing.Point(0, 0);
            this.siticoneTextBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "Tìm kiếm";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.Size = new System.Drawing.Size(257, 40);
            this.siticoneTextBox2.TabIndex = 0;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel3.Location = new System.Drawing.Point(75, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(362, 17);
            this.siticonePanel3.TabIndex = 1;
            // 
            // siticonePanel8
            // 
            this.siticonePanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel8.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel8.Name = "siticonePanel8";
            this.siticonePanel8.Size = new System.Drawing.Size(75, 63);
            this.siticonePanel8.TabIndex = 0;
            // 
            // ucLoaiDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopPanel);
            this.Name = "ucLoaiDG";
            this.Size = new System.Drawing.Size(997, 596);
            this.TopPanel.ResumeLayout(false);
            this.botTableLayout.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.siticonePanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLoaiDocGia)).EndInit();
            this.siticonePanel9.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
            this.siticonePanel4.PerformLayout();
            this.featPanel.ResumeLayout(false);
            this.siticonePanel6.ResumeLayout(false);
            this.feat02.ResumeLayout(false);
            this.feat02.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.feat01.ResumeLayout(false);
            this.feat01.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private TableLayoutPanel botTableLayout;
        private Siticone.Desktop.UI.WinForms.SiticonePanel featPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel feat02;
        private Label labFeat02;
        private Siticone.Desktop.UI.WinForms.SiticonePanel feat01;
        private Label labFeat01;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butChangePass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel8;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel infoPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelSpace;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel10;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView tableLoaiDocGia;
        private DataGridViewTextBoxColumn MaLoaiDocGia;
        private DataGridViewTextBoxColumn TenLoaiDocGia;
    }
}
