using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucSach
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
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.comboMaSach = new System.Windows.Forms.ComboBox();
            this.comboTenTuaSach = new System.Windows.Forms.ComboBox();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.butSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAddOld = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butSearch);
            this.topPanel.Controls.Add(this.comboTenTuaSach);
            this.topPanel.Controls.Add(this.comboMaSach);
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.butAddOld);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1264, 120);
            this.topPanel.TabIndex = 0;
            // 
            // SachGrid
            // 
            this.SachGrid.AllowUserToAddRows = false;
            this.SachGrid.AllowUserToDeleteRows = false;
            this.SachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SachGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SachGrid.ColumnHeadersHeight = 35;
            this.SachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.id,
            this.maSachDataGridViewTextBoxColumn,
            this.TuaSach,
            this.soLuongDataGridViewTextBoxColumn,
            this.soLuongConLaiDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.nhaXBDataGridViewTextBoxColumn});
            this.SachGrid.DataSource = this.sACHBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SachGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.SachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.Location = new System.Drawing.Point(0, 120);
            this.SachGrid.Name = "SachGrid";
            this.SachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SachGrid.RowHeadersVisible = false;
            this.SachGrid.RowHeadersWidth = 51;
            this.SachGrid.RowTemplate.Height = 30;
            this.SachGrid.Size = new System.Drawing.Size(1264, 476);
            this.SachGrid.TabIndex = 1;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.SachGrid.ThemeStyle.ReadOnly = false;
            this.SachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.ThemeStyle.RowsStyle.Height = 30;
            this.SachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.RetryCancel;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.SuccDia.Text = null;
            // 
            // AskDia
            // 
            this.AskDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.AskDia.Caption = null;
            this.AskDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Question;
            this.AskDia.Parent = null;
            this.AskDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.AskDia.Text = null;
            // 
            // comboMaSach
            // 
            this.comboMaSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaSach.FormattingEnabled = true;
            this.comboMaSach.Location = new System.Drawing.Point(570, 76);
            this.comboMaSach.Name = "comboMaSach";
            this.comboMaSach.Size = new System.Drawing.Size(139, 35);
            this.comboMaSach.TabIndex = 5;
            this.comboMaSach.Text = "Mã Sách";
            // 
            // comboTenTuaSach
            // 
            this.comboTenTuaSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTenTuaSach.FormattingEnabled = true;
            this.comboTenTuaSach.Location = new System.Drawing.Point(715, 76);
            this.comboTenTuaSach.Name = "comboTenTuaSach";
            this.comboTenTuaSach.Size = new System.Drawing.Size(140, 35);
            this.comboTenTuaSach.TabIndex = 6;
            this.comboTenTuaSach.Text = "Tên Tựa Sách";
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isChosen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 21;
            // 
            // TuaSach
            // 
            this.TuaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
            this.TuaSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TuaSach.Width = 118;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 56;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongConLaiDataGridViewTextBoxColumn
            // 
            this.soLuongConLaiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongConLai";
            this.soLuongConLaiDataGridViewTextBoxColumn.HeaderText = "Còn lại";
            this.soLuongConLaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongConLaiDataGridViewTextBoxColumn.Name = "soLuongConLaiDataGridViewTextBoxColumn";
            this.soLuongConLaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "Năm XB";
            this.namXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhaXBDataGridViewTextBoxColumn
            // 
            this.nhaXBDataGridViewTextBoxColumn.DataPropertyName = "NhaXB";
            this.nhaXBDataGridViewTextBoxColumn.HeaderText = "NXB";
            this.nhaXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaXBDataGridViewTextBoxColumn.Name = "nhaXBDataGridViewTextBoxColumn";
            this.nhaXBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataSource = typeof(DTO.SACH);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.phieumuontra;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(419, 63);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(64, 54);
            this.butRefresh.TabIndex = 8;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butSearch
            // 
            this.butSearch.BorderRadius = 4;
            this.butSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSearch.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butSearch.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.White;
            this.butSearch.Image = global::GUI.Properties.Resources.search_icon;
            this.butSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butSearch.ImageOffset = new System.Drawing.Point(3, 0);
            this.butSearch.Location = new System.Drawing.Point(861, 76);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(129, 22);
            this.butSearch.TabIndex = 7;
            this.butSearch.Text = "Tìm kiếm";
            this.butSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butSearch.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butDel
            // 
            this.butDel.BorderRadius = 6;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Image = global::GUI.Properties.Resources.close_icon;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(288, 78);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(134, 22);
            this.butDel.TabIndex = 3;
            this.butDel.Text = "Xóa Sách";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butAddOld
            // 
            this.butAddOld.BorderRadius = 6;
            this.butAddOld.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAddOld.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAddOld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAddOld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAddOld.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butAddOld.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddOld.ForeColor = System.Drawing.Color.White;
            this.butAddOld.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAddOld.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAddOld.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAddOld.Location = new System.Drawing.Point(143, 78);
            this.butAddOld.Name = "butAddOld";
            this.butAddOld.Size = new System.Drawing.Size(142, 22);
            this.butAddOld.TabIndex = 4;
            this.butAddOld.Text = "Nhập Sách Đã Có";
            this.butAddOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAddOld.TextOffset = new System.Drawing.Point(3, 0);
            this.butAddOld.Click += new System.EventHandler(this.butAddOld_Click);
            // 
            // butAdd
            // 
            this.butAdd.BorderRadius = 6;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(7, 78);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(134, 22);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Nhập Sách Mới";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // ucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SachGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucSach";
            this.Size = new System.Drawing.Size(1264, 596);
            this.Load += new System.EventHandler(this.ucSach_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SachGrid;
        private Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool siticoneCreditCardValidationTool1;
        private BindingSource sACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private DataGridViewTextBoxColumn cTPHIEUNHAPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cUONSACHesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tUASACHDataGridViewTextBoxColumn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAddOld;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSearch;
        private ComboBox comboTenTuaSach;
        private ComboBox comboMaSach;
        private DataGridViewCheckBoxColumn isChosen;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TuaSach;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongConLaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhaXBDataGridViewTextBoxColumn;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
    }
}
