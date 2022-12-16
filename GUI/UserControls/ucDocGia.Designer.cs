using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNoHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIDOCGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTHUsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.butDel);
            this.TopPanel.Controls.Add(this.butAdd);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1233, 119);
            this.TopPanel.TabIndex = 4;
            // 
            // butAdd
            // 
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.SlateBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(0, 54);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(131, 42);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Thêm Độc Giả";
            this.butAdd.TextOffset = new System.Drawing.Point(12, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeight = 18;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.maDocGiaDataGridViewTextBoxColumn,
            this.tenDocGiaDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ngayLapTheDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.idLoaiDocGiaDataGridViewTextBoxColumn,
            this.tongNoHienTaiDataGridViewTextBoxColumn,
            this.lOAIDOCGIADataGridViewTextBoxColumn,
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn,
            this.pHIEUTHUsDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.dOCGIABindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 119);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1233, 648);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid.ThemeStyle.ReadOnly = false;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            // 
            // tenDocGiaDataGridViewTextBoxColumn
            // 
            this.tenDocGiaDataGridViewTextBoxColumn.DataPropertyName = "TenDocGia";
            this.tenDocGiaDataGridViewTextBoxColumn.HeaderText = "TenDocGia";
            this.tenDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDocGiaDataGridViewTextBoxColumn.Name = "tenDocGiaDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ngayLapTheDataGridViewTextBoxColumn
            // 
            this.ngayLapTheDataGridViewTextBoxColumn.DataPropertyName = "NgayLapThe";
            this.ngayLapTheDataGridViewTextBoxColumn.HeaderText = "NgayLapThe";
            this.ngayLapTheDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapTheDataGridViewTextBoxColumn.Name = "ngayLapTheDataGridViewTextBoxColumn";
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            // 
            // idLoaiDocGiaDataGridViewTextBoxColumn
            // 
            this.idLoaiDocGiaDataGridViewTextBoxColumn.DataPropertyName = "idLoaiDocGia";
            this.idLoaiDocGiaDataGridViewTextBoxColumn.HeaderText = "idLoaiDocGia";
            this.idLoaiDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLoaiDocGiaDataGridViewTextBoxColumn.Name = "idLoaiDocGiaDataGridViewTextBoxColumn";
            // 
            // tongNoHienTaiDataGridViewTextBoxColumn
            // 
            this.tongNoHienTaiDataGridViewTextBoxColumn.DataPropertyName = "TongNoHienTai";
            this.tongNoHienTaiDataGridViewTextBoxColumn.HeaderText = "TongNoHienTai";
            this.tongNoHienTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongNoHienTaiDataGridViewTextBoxColumn.Name = "tongNoHienTaiDataGridViewTextBoxColumn";
            // 
            // lOAIDOCGIADataGridViewTextBoxColumn
            // 
            this.lOAIDOCGIADataGridViewTextBoxColumn.DataPropertyName = "LOAIDOCGIA";
            this.lOAIDOCGIADataGridViewTextBoxColumn.HeaderText = "LOAIDOCGIA";
            this.lOAIDOCGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOAIDOCGIADataGridViewTextBoxColumn.Name = "lOAIDOCGIADataGridViewTextBoxColumn";
            // 
            // pHIEUMUONTRAsDataGridViewTextBoxColumn
            // 
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.DataPropertyName = "PHIEUMUONTRAs";
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.HeaderText = "PHIEUMUONTRAs";
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.Name = "pHIEUMUONTRAsDataGridViewTextBoxColumn";
            // 
            // pHIEUTHUsDataGridViewTextBoxColumn
            // 
            this.pHIEUTHUsDataGridViewTextBoxColumn.DataPropertyName = "PHIEUTHUs";
            this.pHIEUTHUsDataGridViewTextBoxColumn.HeaderText = "PHIEUTHUs";
            this.pHIEUTHUsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHIEUTHUsDataGridViewTextBoxColumn.Name = "pHIEUTHUsDataGridViewTextBoxColumn";
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataSource = typeof(DTO.DOCGIA);
            // 
            // butDel
            // 
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.SlateBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Image = global::GUI.Properties.Resources.close_icon;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(137, 54);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(131, 42);
            this.butDel.TabIndex = 0;
            this.butDel.Text = "Xóa Độc Giả";
            this.butDel.TextOffset = new System.Drawing.Point(12, 0);
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // ucDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.TopPanel);
            this.Name = "ucDocGia";
            this.Size = new System.Drawing.Size(1233, 767);
            this.Load += new System.EventHandler(this.ucDocGia_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGrid;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapTheDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLoaiDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongNoHienTaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lOAIDOCGIADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pHIEUMUONTRAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pHIEUTHUsDataGridViewTextBoxColumn;
        private BindingSource dOCGIABindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
    }
}
