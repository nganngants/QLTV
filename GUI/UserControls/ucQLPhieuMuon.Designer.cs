using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucQLPhieuMuon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butFil = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboTinhTrang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.butFind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtFind = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PhieuMuonGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.pHIEUMUONTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONTRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.butFil);
            this.siticonePanel1.Controls.Add(this.comboTinhTrang);
            this.siticonePanel1.Controls.Add(this.butFind);
            this.siticonePanel1.Controls.Add(this.txtFind);
            this.siticonePanel1.Controls.Add(this.butRefresh);
            this.siticonePanel1.Controls.Add(this.butAdd);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(997, 124);
            this.siticonePanel1.TabIndex = 0;
            // 
            // butFil
            // 
            this.butFil.AutoRoundedCorners = true;
            this.butFil.BorderRadius = 10;
            this.butFil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFil.FillColor = System.Drawing.Color.SlateBlue;
            this.butFil.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFil.ForeColor = System.Drawing.Color.White;
            this.butFil.Image = global::GUI.Properties.Resources.search_icon;
            this.butFil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFil.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFil.Location = new System.Drawing.Point(780, 77);
            this.butFil.Name = "butFil";
            this.butFil.Size = new System.Drawing.Size(142, 23);
            this.butFil.TabIndex = 23;
            this.butFil.Text = "Lọc tình trạng";
            this.butFil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFil.TextOffset = new System.Drawing.Point(3, 0);
            this.butFil.Click += new System.EventHandler(this.butFil_Click);
            // 
            // comboTinhTrang
            // 
            this.comboTinhTrang.AutoRoundedCorners = true;
            this.comboTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.comboTinhTrang.BorderRadius = 17;
            this.comboTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTinhTrang.ItemHeight = 30;
            this.comboTinhTrang.Location = new System.Drawing.Point(486, 75);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(288, 36);
            this.comboTinhTrang.TabIndex = 22;
            // 
            // butFind
            // 
            this.butFind.AutoRoundedCorners = true;
            this.butFind.BorderRadius = 10;
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.SlateBlue;
            this.butFind.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.Image = global::GUI.Properties.Resources.search_icon;
            this.butFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFind.Location = new System.Drawing.Point(780, 48);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(142, 23);
            this.butFind.TabIndex = 20;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.TextOffset = new System.Drawing.Point(3, 0);
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 10;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(486, 48);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFind.PlaceholderText = "Số phiếu, mã cuốn sách, mã độc giả";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(288, 23);
            this.txtFind.TabIndex = 21;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.phieumuontra;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(157, 59);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(78, 62);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderRadius = 14;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.SlateBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(5, 75);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(146, 30);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Thêm Phiếu";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // PhieuMuonGrid
            // 
            this.PhieuMuonGrid.AllowUserToAddRows = false;
            this.PhieuMuonGrid.AllowUserToDeleteRows = false;
            this.PhieuMuonGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuMuonGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhieuMuonGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhieuMuonGrid.ColumnHeadersHeight = 35;
            this.PhieuMuonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuMuonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.SoPhieuMuon,
            this.MaCuonSach,
            this.TenSach,
            this.MaDocGia,
            this.NgayMuon,
            this.HanTra,
            this.NgayTra,
            this.SoTienPhat,
            this.Edit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhieuMuonGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhieuMuonGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhieuMuonGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuMuonGrid.Location = new System.Drawing.Point(0, 124);
            this.PhieuMuonGrid.Name = "PhieuMuonGrid";
            this.PhieuMuonGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuMuonGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PhieuMuonGrid.RowHeadersVisible = false;
            this.PhieuMuonGrid.RowHeadersWidth = 51;
            this.PhieuMuonGrid.RowTemplate.Height = 30;
            this.PhieuMuonGrid.Size = new System.Drawing.Size(997, 472);
            this.PhieuMuonGrid.TabIndex = 1;
            this.PhieuMuonGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuMuonGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhieuMuonGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhieuMuonGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhieuMuonGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhieuMuonGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhieuMuonGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuMuonGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.PhieuMuonGrid.ThemeStyle.ReadOnly = false;
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.Height = 30;
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuMuonGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuMuonGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhieuMuonGrid_CellClick);
            this.PhieuMuonGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhieuMuonGrid_CellContentClick);
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.HeaderText = "";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.Visible = false;
            this.isChosen.Width = 6;
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.HeaderText = "Số phiếu mượn";
            this.SoPhieuMuon.MinimumWidth = 6;
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            this.SoPhieuMuon.ReadOnly = true;
            this.SoPhieuMuon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.HeaderText = "Mã cuốn sách";
            this.MaCuonSach.MinimumWidth = 6;
            this.MaCuonSach.Name = "MaCuonSach";
            this.MaCuonSach.ReadOnly = true;
            this.MaCuonSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            this.MaDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HanTra
            // 
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            this.HanTra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            this.NgayTra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SoTienPhat
            // 
            this.SoTienPhat.HeaderText = "Số tiền phạt";
            this.SoTienPhat.MinimumWidth = 6;
            this.SoTienPhat.Name = "SoTienPhat";
            this.SoTienPhat.ReadOnly = true;
            this.SoTienPhat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Visible = false;
            this.Edit.Width = 6;
            // 
            // pHIEUMUONTRABindingSource
            // 
            this.pHIEUMUONTRABindingSource.DataSource = typeof(DTO.PHIEUMUONTRA);
            // 
            // ucQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhieuMuonGrid);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucQLPhieuMuon";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONTRABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView PhieuMuonGrid;
        private BindingSource pHIEUMUONTRABindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private DataGridViewCheckBoxColumn isChosen;
        private DataGridViewTextBoxColumn SoPhieuMuon;
        private DataGridViewTextBoxColumn MaCuonSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn HanTra;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn SoTienPhat;
        private DataGridViewImageColumn Edit;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFind;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFind;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFil;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTinhTrang;
    }
}
