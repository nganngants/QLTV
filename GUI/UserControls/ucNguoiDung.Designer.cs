namespace GUI.UserControls
{
    partial class ucNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhomNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.butDel);
            this.siticonePanel1.Controls.Add(this.butAdd);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(897, 120);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticoneDataGridView1
            // 
            this.siticoneDataGridView1.AllowUserToAddRows = false;
            this.siticoneDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siticoneDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 18;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.tenNguoiDungDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.idNhomNguoiDungDataGridViewTextBoxColumn,
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn});
            this.siticoneDataGridView1.DataSource = this.nGUOIDUNGBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(0, 120);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 24;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(897, 513);
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
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            this.maNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNguoiDungDataGridViewTextBoxColumn
            // 
            this.tenNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiDung";
            this.tenNguoiDungDataGridViewTextBoxColumn.HeaderText = "TenNguoiDung";
            this.tenNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNguoiDungDataGridViewTextBoxColumn.Name = "tenNguoiDungDataGridViewTextBoxColumn";
            this.tenNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNhomNguoiDungDataGridViewTextBoxColumn
            // 
            this.idNhomNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "idNhomNguoiDung";
            this.idNhomNguoiDungDataGridViewTextBoxColumn.HeaderText = "idNhomNguoiDung";
            this.idNhomNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idNhomNguoiDungDataGridViewTextBoxColumn.Name = "idNhomNguoiDungDataGridViewTextBoxColumn";
            this.idNhomNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHOMNGUOIDUNGDataGridViewTextBoxColumn
            // 
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn.DataPropertyName = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn.HeaderText = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn.Name = "nHOMNGUOIDUNGDataGridViewTextBoxColumn";
            this.nHOMNGUOIDUNGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataSource = typeof(DTO.NGUOIDUNG);
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
            this.butDel.Location = new System.Drawing.Point(155, 76);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(138, 22);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa Người Dùng";
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
            this.butAdd.Size = new System.Drawing.Size(146, 22);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Thêm Người Dùng";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // ucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucNguoiDung";
            this.Size = new System.Drawing.Size(897, 633);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhomNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHOMNGUOIDUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
    }
}
