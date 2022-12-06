using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucQLPhieuMuon
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
            this.tablePhieuMuonTra = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SoPhieuMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticonePanel1.SuspendLayout();
            this.dgTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuMuonTra)).BeginInit();
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
            // tablePhieuMuonTra
            // 
            this.tablePhieuMuonTra.AllowUserToAddRows = false;
            this.tablePhieuMuonTra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablePhieuMuonTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePhieuMuonTra.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePhieuMuonTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePhieuMuonTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePhieuMuonTra.ColumnHeadersHeight = 50;
            this.tablePhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablePhieuMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuMuonTra,
            this.MaDocGia,
            this.TenDocGia,
            this.MaCuonSach,
            this.TenCuonSach,
            this.NgayMuon,
            this.HanTra,
            this.NgayTra,
            this.SoTienPhat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePhieuMuonTra.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePhieuMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePhieuMuonTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePhieuMuonTra.Location = new System.Drawing.Point(0, 0);
            this.tablePhieuMuonTra.Name = "tablePhieuMuonTra";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePhieuMuonTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePhieuMuonTra.RowHeadersVisible = false;
            this.tablePhieuMuonTra.RowHeadersWidth = 53;
            this.tablePhieuMuonTra.RowTemplate.Height = 25;
            this.tablePhieuMuonTra.Size = new System.Drawing.Size(997, 410);
            this.tablePhieuMuonTra.TabIndex = 0;
            this.tablePhieuMuonTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePhieuMuonTra.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablePhieuMuonTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablePhieuMuonTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablePhieuMuonTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablePhieuMuonTra.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tablePhieuMuonTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablePhieuMuonTra.ThemeStyle.HeaderStyle.Height = 50;
            this.tablePhieuMuonTra.ThemeStyle.ReadOnly = false;
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.Height = 25;
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePhieuMuonTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.tablePhieuMuonTra);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 186);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(997, 410);
            this.siticonePanel2.TabIndex = 3;
            // 
            // SoPhieuMuonTra
            // 
            this.SoPhieuMuonTra.HeaderText = "Số Phiếu Mượn Trả";
            this.SoPhieuMuonTra.MinimumWidth = 7;
            this.SoPhieuMuonTra.Name = "SoPhieuMuonTra";
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.MinimumWidth = 7;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.HeaderText = "Tên Độc Giả";
            this.TenDocGia.MinimumWidth = 7;
            this.TenDocGia.Name = "TenDocGia";
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.HeaderText = "Mã Cuốn Sách";
            this.MaCuonSach.MinimumWidth = 7;
            this.MaCuonSach.Name = "MaCuonSach";
            // 
            // TenCuonSach
            // 
            this.TenCuonSach.HeaderText = "Tên Cuốn Sách";
            this.TenCuonSach.MinimumWidth = 7;
            this.TenCuonSach.Name = "TenCuonSach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 7;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // HanTra
            // 
            this.HanTra.HeaderText = "Hạn Trả";
            this.HanTra.MinimumWidth = 7;
            this.HanTra.Name = "HanTra";
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 7;
            this.NgayTra.Name = "NgayTra";
            // 
            // SoTienPhat
            // 
            this.SoTienPhat.HeaderText = "Số Tiền Phạt";
            this.SoTienPhat.MinimumWidth = 7;
            this.SoTienPhat.Name = "SoTienPhat";
            // 
            // ucQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucQLPhieuMuon";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticonePanel1.ResumeLayout(false);
            this.dgTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuMuonTra)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView tablePhieuMuonTra;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private TabControl dgTabControl;
        private TabPage pageThem;
        private TabPage pageSua;
        private TabPage pageXoa;
        private TabPage pageTim;
        private DataGridViewTextBoxColumn SoPhieuMuonTra;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn TenDocGia;
        private DataGridViewTextBoxColumn MaCuonSach;
        private DataGridViewTextBoxColumn TenCuonSach;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn HanTra;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn SoTienPhat;
    }
}
