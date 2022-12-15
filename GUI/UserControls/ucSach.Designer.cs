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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgTabControl = new System.Windows.Forms.TabControl();
            this.pageThem = new System.Windows.Forms.TabPage();
            this.pageSua = new System.Windows.Forms.TabPage();
            this.pageXoa = new System.Windows.Forms.TabPage();
            this.pageTim = new System.Windows.Forms.TabPage();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTuaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUONSACHesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel1.SuspendLayout();
            this.dgTabControl.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.dgTabControl);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(997, 186);
            this.siticonePanel1.TabIndex = 2;
            // 
            // dgTabControl
            // 
            this.dgTabControl.Controls.Add(this.pageThem);
            this.dgTabControl.Controls.Add(this.pageSua);
            this.dgTabControl.Controls.Add(this.pageXoa);
            this.dgTabControl.Controls.Add(this.pageTim);
            this.dgTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgTabControl.ItemSize = new System.Drawing.Size(60, 30);
            this.dgTabControl.Location = new System.Drawing.Point(0, 0);
            this.dgTabControl.Name = "dgTabControl";
            this.dgTabControl.SelectedIndex = 0;
            this.dgTabControl.Size = new System.Drawing.Size(997, 186);
            this.dgTabControl.TabIndex = 0;
            // 
            // pageThem
            // 
            this.pageThem.Location = new System.Drawing.Point(4, 34);
            this.pageThem.Name = "pageThem";
            this.pageThem.Padding = new System.Windows.Forms.Padding(3);
            this.pageThem.Size = new System.Drawing.Size(989, 148);
            this.pageThem.TabIndex = 0;
            this.pageThem.Text = "Thêm";
            this.pageThem.UseVisualStyleBackColor = true;
            // 
            // pageSua
            // 
            this.pageSua.Location = new System.Drawing.Point(4, 34);
            this.pageSua.Name = "pageSua";
            this.pageSua.Padding = new System.Windows.Forms.Padding(3);
            this.pageSua.Size = new System.Drawing.Size(989, 148);
            this.pageSua.TabIndex = 1;
            this.pageSua.Text = "Sửa";
            this.pageSua.UseVisualStyleBackColor = true;
            // 
            // pageXoa
            // 
            this.pageXoa.Location = new System.Drawing.Point(4, 34);
            this.pageXoa.Name = "pageXoa";
            this.pageXoa.Padding = new System.Windows.Forms.Padding(3);
            this.pageXoa.Size = new System.Drawing.Size(989, 148);
            this.pageXoa.TabIndex = 2;
            this.pageXoa.Text = "Xóa";
            this.pageXoa.UseVisualStyleBackColor = true;
            // 
            // pageTim
            // 
            this.pageTim.Location = new System.Drawing.Point(4, 34);
            this.pageTim.Name = "pageTim";
            this.pageTim.Padding = new System.Windows.Forms.Padding(3);
            this.pageTim.Size = new System.Drawing.Size(989, 148);
            this.pageTim.TabIndex = 3;
            this.pageTim.Text = "Tìm kiếm";
            this.pageTim.UseVisualStyleBackColor = true;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.SachGrid);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 186);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(997, 410);
            this.siticonePanel2.TabIndex = 3;
            // 
            // SachGrid
            // 
            this.SachGrid.AllowUserToAddRows = false;
            this.SachGrid.AllowUserToDeleteRows = false;
            this.SachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SachGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SachGrid.ColumnHeadersHeight = 35;
            this.SachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.idTuaSachDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.soLuongConLaiDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.nhaXBDataGridViewTextBoxColumn,
            this.cTPHIEUNHAPDataGridViewTextBoxColumn,
            this.cUONSACHesDataGridViewTextBoxColumn,
            this.tUASACHDataGridViewTextBoxColumn});
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
            this.SachGrid.Location = new System.Drawing.Point(0, 0);
            this.SachGrid.Name = "SachGrid";
            this.SachGrid.ReadOnly = true;
            this.SachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SachGrid.RowHeadersVisible = false;
            this.SachGrid.RowHeadersWidth = 51;
            this.SachGrid.RowTemplate.Height = 28;
            this.SachGrid.Size = new System.Drawing.Size(997, 410);
            this.SachGrid.TabIndex = 0;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.SachGrid.ThemeStyle.ReadOnly = true;
            this.SachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.ThemeStyle.RowsStyle.Height = 28;
            this.SachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idTuaSachDataGridViewTextBoxColumn
            // 
            this.idTuaSachDataGridViewTextBoxColumn.DataPropertyName = "idTuaSach";
            this.idTuaSachDataGridViewTextBoxColumn.HeaderText = "Mã tựa sách";
            this.idTuaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTuaSachDataGridViewTextBoxColumn.Name = "idTuaSachDataGridViewTextBoxColumn";
            this.idTuaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTuaSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // soLuongConLaiDataGridViewTextBoxColumn
            // 
            this.soLuongConLaiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongConLai";
            this.soLuongConLaiDataGridViewTextBoxColumn.HeaderText = "Còn";
            this.soLuongConLaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongConLaiDataGridViewTextBoxColumn.Name = "soLuongConLaiDataGridViewTextBoxColumn";
            this.soLuongConLaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongConLaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.donGiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "Năm XB";
            this.namXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.namXBDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nhaXBDataGridViewTextBoxColumn
            // 
            this.nhaXBDataGridViewTextBoxColumn.DataPropertyName = "NhaXB";
            this.nhaXBDataGridViewTextBoxColumn.HeaderText = "NXB";
            this.nhaXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaXBDataGridViewTextBoxColumn.Name = "nhaXBDataGridViewTextBoxColumn";
            this.nhaXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.nhaXBDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cTPHIEUNHAPDataGridViewTextBoxColumn
            // 
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.DataPropertyName = "CT_PHIEUNHAP";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.HeaderText = "CT_PHIEUNHAP";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Name = "cTPHIEUNHAPDataGridViewTextBoxColumn";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUONSACHesDataGridViewTextBoxColumn
            // 
            this.cUONSACHesDataGridViewTextBoxColumn.DataPropertyName = "CUONSACHes";
            this.cUONSACHesDataGridViewTextBoxColumn.HeaderText = "CUONSACHes";
            this.cUONSACHesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUONSACHesDataGridViewTextBoxColumn.Name = "cUONSACHesDataGridViewTextBoxColumn";
            this.cUONSACHesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUONSACHesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cUONSACHesDataGridViewTextBoxColumn.Visible = false;
            // 
            // tUASACHDataGridViewTextBoxColumn
            // 
            this.tUASACHDataGridViewTextBoxColumn.DataPropertyName = "TUASACH";
            this.tUASACHDataGridViewTextBoxColumn.HeaderText = "TUASACH";
            this.tUASACHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tUASACHDataGridViewTextBoxColumn.Name = "tUASACHDataGridViewTextBoxColumn";
            this.tUASACHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tUASACHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tUASACHDataGridViewTextBoxColumn.Visible = false;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataSource = typeof(DTO.SACH);
            // 
            // ucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticonePanel1.ResumeLayout(false);
            this.dgTabControl.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private TabControl dgTabControl;
        private TabPage pageThem;
        private TabPage pageSua;
        private TabPage pageXoa;
        private TabPage pageTim;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SachGrid;
        private BindingSource sACHBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTuaSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongConLaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhaXBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cTPHIEUNHAPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cUONSACHesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tUASACHDataGridViewTextBoxColumn;
    }
}
