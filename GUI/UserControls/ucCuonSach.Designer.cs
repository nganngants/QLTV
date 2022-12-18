using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucCuonSach
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
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.CuonSachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCSACHTRATREsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuonSachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 121);
            this.topPanel.TabIndex = 0;
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
            this.butDel.Location = new System.Drawing.Point(3, 78);
            this.butDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(135, 23);
            this.butDel.TabIndex = 7;
            this.butDel.Text = "Xóa Cuốn Sách";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // CuonSachGrid
            // 
            this.CuonSachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CuonSachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CuonSachGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CuonSachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CuonSachGrid.ColumnHeadersHeight = 35;
            this.CuonSachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CuonSachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maCuonSachDataGridViewTextBoxColumn,
            this.MaSach,
            this.TenSach,
            this.idSachDataGridViewTextBoxColumn,
            this.bCSACHTRATREsDataGridViewTextBoxColumn,
            this.TinhTrang,
            this.sACHDataGridViewTextBoxColumn,
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn});
            this.CuonSachGrid.DataSource = this.cUONSACHBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CuonSachGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CuonSachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuonSachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.Location = new System.Drawing.Point(0, 121);
            this.CuonSachGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CuonSachGrid.Name = "CuonSachGrid";
            this.CuonSachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CuonSachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CuonSachGrid.RowHeadersVisible = false;
            this.CuonSachGrid.RowHeadersWidth = 51;
            this.CuonSachGrid.RowTemplate.Height = 28;
            this.CuonSachGrid.Size = new System.Drawing.Size(997, 475);
            this.CuonSachGrid.TabIndex = 1;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CuonSachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.CuonSachGrid.ThemeStyle.ReadOnly = false;
            this.CuonSachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CuonSachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuonSachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CuonSachGrid.ThemeStyle.RowsStyle.Height = 28;
            this.CuonSachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maCuonSachDataGridViewTextBoxColumn
            // 
            this.maCuonSachDataGridViewTextBoxColumn.DataPropertyName = "MaCuonSach";
            this.maCuonSachDataGridViewTextBoxColumn.HeaderText = "Mã cuốn sách";
            this.maCuonSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCuonSachDataGridViewTextBoxColumn.Name = "maCuonSachDataGridViewTextBoxColumn";
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idSachDataGridViewTextBoxColumn
            // 
            this.idSachDataGridViewTextBoxColumn.DataPropertyName = "idSach";
            this.idSachDataGridViewTextBoxColumn.HeaderText = "idSach";
            this.idSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSachDataGridViewTextBoxColumn.Name = "idSachDataGridViewTextBoxColumn";
            this.idSachDataGridViewTextBoxColumn.Visible = false;
            // 
            // bCSACHTRATREsDataGridViewTextBoxColumn
            // 
            this.bCSACHTRATREsDataGridViewTextBoxColumn.DataPropertyName = "BCSACHTRATREs";
            this.bCSACHTRATREsDataGridViewTextBoxColumn.HeaderText = "BCSACHTRATREs";
            this.bCSACHTRATREsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bCSACHTRATREsDataGridViewTextBoxColumn.Name = "bCSACHTRATREsDataGridViewTextBoxColumn";
            this.bCSACHTRATREsDataGridViewTextBoxColumn.Visible = false;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // sACHDataGridViewTextBoxColumn
            // 
            this.sACHDataGridViewTextBoxColumn.DataPropertyName = "SACH";
            this.sACHDataGridViewTextBoxColumn.HeaderText = "SACH";
            this.sACHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sACHDataGridViewTextBoxColumn.Name = "sACHDataGridViewTextBoxColumn";
            this.sACHDataGridViewTextBoxColumn.Visible = false;
            // 
            // pHIEUMUONTRAsDataGridViewTextBoxColumn
            // 
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.DataPropertyName = "PHIEUMUONTRAs";
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.HeaderText = "PHIEUMUONTRAs";
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.Name = "pHIEUMUONTRAsDataGridViewTextBoxColumn";
            this.pHIEUMUONTRAsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataSource = typeof(DTO.CUONSACH);
            // 
            // ucCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CuonSachGrid);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCuonSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CuonSachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView CuonSachGrid;
        private BindingSource cUONSACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maCuonSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn idSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bCSACHTRATREsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn sACHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pHIEUMUONTRAsDataGridViewTextBoxColumn;
    }
}
