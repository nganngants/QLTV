using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucTuaSach
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
            this.tUASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgTabControl = new System.Windows.Forms.TabControl();
            this.pageThem = new System.Windows.Forms.TabPage();
            this.pageSua = new System.Windows.Forms.TabPage();
            this.pageXoa = new System.Windows.Forms.TabPage();
            this.pageTim = new System.Windows.Forms.TabPage();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TuaSachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTuaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHELOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tACGIAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.dgTabControl.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tUASACHBindingSource
            // 
            this.tUASACHBindingSource.DataSource = typeof(DTO.TUASACH);
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
            this.siticonePanel2.Controls.Add(this.TuaSachGrid);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 186);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(997, 410);
            this.siticonePanel2.TabIndex = 3;
            // 
            // TuaSachGrid
            // 
            this.TuaSachGrid.AccessibleName = "TuaSachGrid";
            this.TuaSachGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TuaSachGrid.AllowUserToAddRows = false;
            this.TuaSachGrid.AllowUserToDeleteRows = false;
            this.TuaSachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TuaSachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TuaSachGrid.AutoGenerateColumns = false;
            this.TuaSachGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TuaSachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TuaSachGrid.ColumnHeadersHeight = 35;
            this.TuaSachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maTuaSachDataGridViewTextBoxColumn,
            this.tenTuaSachDataGridViewTextBoxColumn,
            this.idTheLoaiDataGridViewTextBoxColumn,
            this.sACHesDataGridViewTextBoxColumn,
            this.tHELOAIDataGridViewTextBoxColumn,
            this.tACGIAsDataGridViewTextBoxColumn,
            this.TheLoai,
            this.TacGia});
            this.TuaSachGrid.DataSource = this.tUASACHBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TuaSachGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TuaSachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuaSachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.Location = new System.Drawing.Point(0, 0);
            this.TuaSachGrid.Name = "TuaSachGrid";
            this.TuaSachGrid.ReadOnly = true;
            this.TuaSachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TuaSachGrid.RowHeadersVisible = false;
            this.TuaSachGrid.RowHeadersWidth = 51;
            this.TuaSachGrid.Size = new System.Drawing.Size(997, 410);
            this.TuaSachGrid.TabIndex = 0;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.TuaSachGrid.ThemeStyle.ReadOnly = true;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TuaSachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.Height = 22;
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maTuaSachDataGridViewTextBoxColumn
            // 
            this.maTuaSachDataGridViewTextBoxColumn.DataPropertyName = "MaTuaSach";
            this.maTuaSachDataGridViewTextBoxColumn.HeaderText = "Mã tựa sách";
            this.maTuaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTuaSachDataGridViewTextBoxColumn.Name = "maTuaSachDataGridViewTextBoxColumn";
            this.maTuaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTuaSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenTuaSachDataGridViewTextBoxColumn
            // 
            this.tenTuaSachDataGridViewTextBoxColumn.DataPropertyName = "TenTuaSach";
            this.tenTuaSachDataGridViewTextBoxColumn.HeaderText = "Tên tựa sách";
            this.tenTuaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTuaSachDataGridViewTextBoxColumn.Name = "tenTuaSachDataGridViewTextBoxColumn";
            this.tenTuaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTuaSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idTheLoaiDataGridViewTextBoxColumn
            // 
            this.idTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "idTheLoai";
            this.idTheLoaiDataGridViewTextBoxColumn.HeaderText = "idTheLoai";
            this.idTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTheLoaiDataGridViewTextBoxColumn.Name = "idTheLoaiDataGridViewTextBoxColumn";
            this.idTheLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTheLoaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // sACHesDataGridViewTextBoxColumn
            // 
            this.sACHesDataGridViewTextBoxColumn.DataPropertyName = "SACHes";
            this.sACHesDataGridViewTextBoxColumn.HeaderText = "SACHes";
            this.sACHesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sACHesDataGridViewTextBoxColumn.Name = "sACHesDataGridViewTextBoxColumn";
            this.sACHesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sACHesDataGridViewTextBoxColumn.Visible = false;
            // 
            // tHELOAIDataGridViewTextBoxColumn
            // 
            this.tHELOAIDataGridViewTextBoxColumn.DataPropertyName = "THELOAI";
            this.tHELOAIDataGridViewTextBoxColumn.HeaderText = "THELOAI";
            this.tHELOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHELOAIDataGridViewTextBoxColumn.Name = "tHELOAIDataGridViewTextBoxColumn";
            this.tHELOAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHELOAIDataGridViewTextBoxColumn.Visible = false;
            // 
            // tACGIAsDataGridViewTextBoxColumn
            // 
            this.tACGIAsDataGridViewTextBoxColumn.DataPropertyName = "TACGIAs";
            this.tACGIAsDataGridViewTextBoxColumn.HeaderText = "TACGIAs";
            this.tACGIAsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tACGIAsDataGridViewTextBoxColumn.Name = "tACGIAsDataGridViewTextBoxColumn";
            this.tACGIAsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tACGIAsDataGridViewTextBoxColumn.Visible = false;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // ucTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucTuaSach";
            this.Size = new System.Drawing.Size(997, 596);
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.dgTabControl.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).EndInit();
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
        private BindingSource tUASACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView TuaSachGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maTuaSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTuaSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTheLoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sACHesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tHELOAIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tACGIAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn TacGia;
        private Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool siticoneCreditCardValidationTool1;
    }
}
