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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIDUNGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUCNANGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(770, 120);
            this.topPanel.TabIndex = 0;
            // 
            // siticoneDataGridView1
            // 
            this.siticoneDataGridView1.AllowUserToAddRows = false;
            this.siticoneDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.siticoneDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maNhomNguoiDungDataGridViewTextBoxColumn,
            this.tenNhomNguoiDungDataGridViewTextBoxColumn,
            this.nGUOIDUNGsDataGridViewTextBoxColumn,
            this.cHUCNANGsDataGridViewTextBoxColumn});
            this.siticoneDataGridView1.DataSource = this.nHOMNGUOIDUNGBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle21;
            this.siticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(0, 120);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.ReadOnly = true;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 24;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(770, 504);
            this.siticoneDataGridView1.TabIndex = 1;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = true;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataSource = typeof(DTO.NHOMNGUOIDUNG);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNhomNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNhomNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNhomNguoiDung";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.HeaderText = "MaNhomNguoiDung";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomNguoiDungDataGridViewTextBoxColumn.Name = "maNhomNguoiDungDataGridViewTextBoxColumn";
            this.maNhomNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhomNguoiDungDataGridViewTextBoxColumn
            // 
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "TenNhomNguoiDung";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.HeaderText = "TenNhomNguoiDung";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.Name = "tenNhomNguoiDungDataGridViewTextBoxColumn";
            this.tenNhomNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGUOIDUNGsDataGridViewTextBoxColumn
            // 
            this.nGUOIDUNGsDataGridViewTextBoxColumn.DataPropertyName = "NGUOIDUNGs";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.HeaderText = "NGUOIDUNGs";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGUOIDUNGsDataGridViewTextBoxColumn.Name = "nGUOIDUNGsDataGridViewTextBoxColumn";
            this.nGUOIDUNGsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHUCNANGsDataGridViewTextBoxColumn
            // 
            this.cHUCNANGsDataGridViewTextBoxColumn.DataPropertyName = "CHUCNANGs";
            this.cHUCNANGsDataGridViewTextBoxColumn.HeaderText = "CHUCNANGs";
            this.cHUCNANGsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHUCNANGsDataGridViewTextBoxColumn.Name = "cHUCNANGsDataGridViewTextBoxColumn";
            this.cHUCNANGsDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.butDel.Location = new System.Drawing.Point(143, 76);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(134, 22);
            this.butDel.TabIndex = 7;
            this.butDel.Text = "Xóa Nhóm";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
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
            this.butAdd.Location = new System.Drawing.Point(3, 76);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(134, 22);
            this.butAdd.TabIndex = 8;
            this.butAdd.Text = "Thêm Nhóm";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // ucNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.topPanel);
            this.Name = "ucNhomND";
            this.Size = new System.Drawing.Size(770, 624);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGUOIDUNGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUCNANGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
    }
}
