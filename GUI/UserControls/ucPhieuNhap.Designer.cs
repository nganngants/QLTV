namespace GUI.UserControls
{
    partial class ucPhieuNhap
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
            this.PhieuNhapgrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.SoPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUNHAPSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butFind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtFind = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPSACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butFind);
            this.topPanel.Controls.Add(this.txtFind);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(932, 100);
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
            this.butRefresh.Location = new System.Drawing.Point(0, 31);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(82, 66);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // PhieuNhapgrid
            // 
            this.PhieuNhapgrid.AllowUserToAddRows = false;
            this.PhieuNhapgrid.AllowUserToDeleteRows = false;
            this.PhieuNhapgrid.AllowUserToResizeColumns = false;
            this.PhieuNhapgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PhieuNhapgrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhieuNhapgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhieuNhapgrid.ColumnHeadersHeight = 35;
            this.PhieuNhapgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuNhapgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuNhap,
            this.TongTien,
            this.NgayNhap});
            this.PhieuNhapgrid.DataSource = this.pHIEUNHAPSACHBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhieuNhapgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhieuNhapgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhieuNhapgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.Location = new System.Drawing.Point(0, 100);
            this.PhieuNhapgrid.Name = "PhieuNhapgrid";
            this.PhieuNhapgrid.ReadOnly = true;
            this.PhieuNhapgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuNhapgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PhieuNhapgrid.RowHeadersVisible = false;
            this.PhieuNhapgrid.RowHeadersWidth = 51;
            this.PhieuNhapgrid.RowTemplate.Height = 30;
            this.PhieuNhapgrid.Size = new System.Drawing.Size(932, 562);
            this.PhieuNhapgrid.TabIndex = 1;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.Height = 35;
            this.PhieuNhapgrid.ThemeStyle.ReadOnly = true;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.Height = 30;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhieuNhapgrid_CellClick);
            this.PhieuNhapgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhieuNhapgrid_CellContentClick);
            // 
            // SoPhieuNhap
            // 
            this.SoPhieuNhap.DataPropertyName = "SoPhieuNhap";
            this.SoPhieuNhap.HeaderText = "Số phiếu nhập ";
            this.SoPhieuNhap.MinimumWidth = 6;
            this.SoPhieuNhap.Name = "SoPhieuNhap";
            this.SoPhieuNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập ";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // pHIEUNHAPSACHBindingSource
            // 
            this.pHIEUNHAPSACHBindingSource.DataSource = typeof(DTO.PHIEUNHAPSACH);
            // 
            // butFind
            // 
            this.butFind.AutoRoundedCorners = true;
            this.butFind.BorderRadius = 13;
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.SlateBlue;
            this.butFind.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.Image = global::GUI.Properties.Resources.search_icon;
            this.butFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFind.Location = new System.Drawing.Point(679, 31);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(140, 28);
            this.butFind.TabIndex = 16;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.TextOffset = new System.Drawing.Point(3, 0);
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 13;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtFind.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(472, 31);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFind.PlaceholderText = "Số phiếu, ngày nhập";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(201, 28);
            this.txtFind.TabIndex = 17;
            // 
            // ucPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhieuNhapgrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucPhieuNhap";
            this.Size = new System.Drawing.Size(932, 662);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPSACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView PhieuNhapgrid;
        private System.Windows.Forms.BindingSource pHIEUNHAPSACHBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFind;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFind;
    }
}
