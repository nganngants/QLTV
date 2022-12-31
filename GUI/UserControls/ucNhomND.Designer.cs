namespace GUI.UserControls
{
    partial class ucNhomND
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
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.NDGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIDUNGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUCNANGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(770, 76);
            this.topPanel.TabIndex = 0;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.phieumuontra;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(326, 10);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(82, 66);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butDel
            // 
            this.butDel.AutoRoundedCorners = true;
            this.butDel.BorderRadius = 13;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.SlateBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Image = global::GUI.Properties.Resources.close_icon;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(174, 29);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(146, 28);
            this.butDel.TabIndex = 7;
            this.butDel.Text = "Xóa Nhóm";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderRadius = 13;
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
            this.butAdd.Location = new System.Drawing.Point(6, 29);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(146, 28);
            this.butAdd.TabIndex = 8;
            this.butAdd.Text = "Thêm Nhóm";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // NDGrid
            // 
            this.NDGrid.AllowUserToAddRows = false;
            this.NDGrid.AllowUserToDeleteRows = false;
            this.NDGrid.AllowUserToResizeColumns = false;
            this.NDGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NDGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NDGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NDGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NDGrid.ColumnHeadersHeight = 35;
            this.NDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.NDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.id,
            this.maNhomNguoiDungDataGridViewTextBoxColumn,
            this.tenNhomNguoiDungDataGridViewTextBoxColumn,
            this.nGUOIDUNGsDataGridViewTextBoxColumn,
            this.cHUCNANGsDataGridViewTextBoxColumn,
            this.Edit});
            this.NDGrid.DataSource = this.nHOMNGUOIDUNGBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NDGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.NDGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NDGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NDGrid.Location = new System.Drawing.Point(0, 76);
            this.NDGrid.Name = "NDGrid";
            this.NDGrid.ReadOnly = true;
            this.NDGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NDGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NDGrid.RowHeadersVisible = false;
            this.NDGrid.RowHeadersWidth = 70;
            this.NDGrid.RowTemplate.Height = 31;
            this.NDGrid.Size = new System.Drawing.Size(770, 548);
            this.NDGrid.TabIndex = 1;
            this.NDGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.NDGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NDGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.NDGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NDGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NDGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.NDGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NDGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NDGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NDGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NDGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.NDGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.NDGrid.ThemeStyle.ReadOnly = true;
            this.NDGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.NDGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NDGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NDGrid.ThemeStyle.RowsStyle.Height = 31;
            this.NDGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NDGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NDGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.ReadOnly = true;
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // maNhomNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNhomNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNhomNguoiDung";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã Nhóm Người Dùng";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomNguoiDungDataGridViewTextBoxColumn.Name = "maNhomNguoiDungDataGridViewTextBoxColumn";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNhomNguoiDungDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenNhomNguoiDungDataGridViewTextBoxColumn
            // 
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "TenNhomNguoiDung";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.HeaderText = "Tên Nhóm Người Dùng";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.Name = "tenNhomNguoiDungDataGridViewTextBoxColumn";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nGUOIDUNGsDataGridViewTextBoxColumn
            // 
            this.nGUOIDUNGsDataGridViewTextBoxColumn.DataPropertyName = "NGUOIDUNGs";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.HeaderText = "NGUOIDUNGs";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGUOIDUNGsDataGridViewTextBoxColumn.Name = "nGUOIDUNGsDataGridViewTextBoxColumn";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nGUOIDUNGsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHUCNANGsDataGridViewTextBoxColumn
            // 
            this.cHUCNANGsDataGridViewTextBoxColumn.DataPropertyName = "CHUCNANGs";
            this.cHUCNANGsDataGridViewTextBoxColumn.HeaderText = "CHUCNANGs";
            this.cHUCNANGsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHUCNANGsDataGridViewTextBoxColumn.Name = "cHUCNANGsDataGridViewTextBoxColumn";
            this.cHUCNANGsDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHUCNANGsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 6;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataSource = typeof(DTO.NHOMNGUOIDUNG);
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
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.RetryCancel;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
            // 
            // AskDia
            // 
            this.AskDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.AskDia.Caption = null;
            this.AskDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Question;
            this.AskDia.Parent = null;
            this.AskDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.AskDia.Text = "Bạn có chắc chắn xoá?";
            // 
            // ucNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NDGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucNhomND";
            this.Size = new System.Drawing.Size(770, 624);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView NDGrid;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGUOIDUNGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUCNANGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
