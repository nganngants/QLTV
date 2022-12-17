using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucQLPhieuThu
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
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.soPhieuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 120);
            this.topPanel.TabIndex = 0;
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
            this.butAdd.Location = new System.Drawing.Point(3, 81);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(115, 22);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Thêm Phiếu";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // siticoneDataGridView1
            // 
            this.siticoneDataGridView1.AllowUserToAddRows = false;
            this.siticoneDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.siticoneDataGridView1.ColumnHeadersHeight = 18;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhieuThuDataGridViewTextBoxColumn,
            this.idDocGiaDataGridViewTextBoxColumn,
            this.soTienThuDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.dOCGIADataGridViewTextBoxColumn});
            this.siticoneDataGridView1.DataSource = this.pHIEUTHUBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.siticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(0, 120);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.ReadOnly = true;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 24;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(997, 476);
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
            // soPhieuThuDataGridViewTextBoxColumn
            // 
            this.soPhieuThuDataGridViewTextBoxColumn.DataPropertyName = "SoPhieuThu";
            this.soPhieuThuDataGridViewTextBoxColumn.HeaderText = "SoPhieuThu";
            this.soPhieuThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPhieuThuDataGridViewTextBoxColumn.Name = "soPhieuThuDataGridViewTextBoxColumn";
            this.soPhieuThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDocGiaDataGridViewTextBoxColumn
            // 
            this.idDocGiaDataGridViewTextBoxColumn.DataPropertyName = "idDocGia";
            this.idDocGiaDataGridViewTextBoxColumn.HeaderText = "idDocGia";
            this.idDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDocGiaDataGridViewTextBoxColumn.Name = "idDocGiaDataGridViewTextBoxColumn";
            this.idDocGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTienThuDataGridViewTextBoxColumn
            // 
            this.soTienThuDataGridViewTextBoxColumn.DataPropertyName = "SoTienThu";
            this.soTienThuDataGridViewTextBoxColumn.HeaderText = "SoTienThu";
            this.soTienThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienThuDataGridViewTextBoxColumn.Name = "soTienThuDataGridViewTextBoxColumn";
            this.soTienThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCGIADataGridViewTextBoxColumn
            // 
            this.dOCGIADataGridViewTextBoxColumn.DataPropertyName = "DOCGIA";
            this.dOCGIADataGridViewTextBoxColumn.HeaderText = "DOCGIA";
            this.dOCGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCGIADataGridViewTextBoxColumn.Name = "dOCGIADataGridViewTextBoxColumn";
            this.dOCGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHIEUTHUBindingSource
            // 
            this.pHIEUTHUBindingSource.DataSource = typeof(DTO.PHIEUTHU);
            // 
            // ucQLPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.topPanel);
            this.Name = "ucQLPhieuThu";
            this.Size = new System.Drawing.Size(997, 596);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn soPhieuThuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soTienThuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOCGIADataGridViewTextBoxColumn;
        private BindingSource pHIEUTHUBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
    }
}
