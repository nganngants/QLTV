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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgTabControl = new System.Windows.Forms.TabControl();
            this.pageThem = new System.Windows.Forms.TabPage();
            this.pageSua = new System.Windows.Forms.TabPage();
            this.pageXoa = new System.Windows.Forms.TabPage();
            this.pageTim = new System.Windows.Forms.TabPage();
            this.tableCuonSach = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticonePanel1.SuspendLayout();
            this.dgTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCuonSach)).BeginInit();
            this.siticonePanel2.SuspendLayout();
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
            // tableCuonSach
            // 
            this.tableCuonSach.AllowUserToAddRows = false;
            this.tableCuonSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableCuonSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCuonSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableCuonSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCuonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCuonSach.ColumnHeadersHeight = 50;
            this.tableCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableCuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCuonSach,
            this.MaSach,
            this.TenTuaSach,
            this.TinhTrang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCuonSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableCuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCuonSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCuonSach.Location = new System.Drawing.Point(0, 0);
            this.tableCuonSach.Name = "tableCuonSach";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCuonSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableCuonSach.RowHeadersVisible = false;
            this.tableCuonSach.RowHeadersWidth = 53;
            this.tableCuonSach.RowTemplate.Height = 25;
            this.tableCuonSach.Size = new System.Drawing.Size(997, 410);
            this.tableCuonSach.TabIndex = 0;
            this.tableCuonSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCuonSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableCuonSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableCuonSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableCuonSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableCuonSach.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableCuonSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCuonSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableCuonSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableCuonSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tableCuonSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableCuonSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableCuonSach.ThemeStyle.HeaderStyle.Height = 50;
            this.tableCuonSach.ThemeStyle.ReadOnly = false;
            this.tableCuonSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCuonSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCuonSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tableCuonSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableCuonSach.ThemeStyle.RowsStyle.Height = 25;
            this.tableCuonSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCuonSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.tableCuonSach);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 186);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(997, 410);
            this.siticonePanel2.TabIndex = 3;
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.HeaderText = "Mã Cuốn Sách";
            this.MaCuonSach.MinimumWidth = 7;
            this.MaCuonSach.Name = "MaCuonSach";
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 7;
            this.MaSach.Name = "MaSach";
            // 
            // TenTuaSach
            // 
            this.TenTuaSach.HeaderText = "Tên Tựa Sách";
            this.TenTuaSach.MinimumWidth = 7;
            this.TenTuaSach.Name = "TenTuaSach";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 7;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // ucCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucCuonSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticonePanel1.ResumeLayout(false);
            this.dgTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCuonSach)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView tableCuonSach;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private TabControl dgTabControl;
        private TabPage pageThem;
        private TabPage pageSua;
        private TabPage pageXoa;
        private TabPage pageTim;
        private DataGridViewTextBoxColumn MaCuonSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenTuaSach;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}
