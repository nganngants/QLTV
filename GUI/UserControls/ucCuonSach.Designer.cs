using GUI.Tab;
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
            this.label15 = new System.Windows.Forms.Label();
            this.siticoneNumericUpDown2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSua = new System.Windows.Forms.TabPage();
            this.pageXoa = new System.Windows.Forms.TabPage();
            this.pageTim = new System.Windows.Forms.TabPage();
            this.tableCuonSach = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1.SuspendLayout();
            this.dgTabControl.SuspendLayout();
            this.pageThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCuonSach)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.dgTabControl);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(997, 255);
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
            this.dgTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTabControl.Name = "dgTabControl";
            this.dgTabControl.SelectedIndex = 0;
            this.dgTabControl.Size = new System.Drawing.Size(997, 255);
            this.dgTabControl.TabIndex = 0;
            // 
            // pageThem
            // 
            this.pageThem.Controls.Add(this.label15);
            this.pageThem.Controls.Add(this.siticoneNumericUpDown2);
            this.pageThem.Controls.Add(this.label4);
            this.pageThem.Controls.Add(this.txtUsername);
            this.pageThem.Controls.Add(this.label5);
            this.pageThem.Controls.Add(this.label3);
            this.pageThem.Controls.Add(this.label2);
            this.pageThem.Location = new System.Drawing.Point(4, 34);
            this.pageThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageThem.Name = "pageThem";
            this.pageThem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageThem.Size = new System.Drawing.Size(989, 217);
            this.pageThem.TabIndex = 0;
            this.pageThem.Text = "Thêm";
            this.pageThem.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(548, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(411, 20);
            this.label15.TabIndex = 116;
            this.label15.Text = "*Tình trạng sách: (1) Đã được mượn, (0) Chưa được mượn";
            // 
            // siticoneNumericUpDown2
            // 
            this.siticoneNumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneNumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneNumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneNumericUpDown2.Location = new System.Drawing.Point(736, 27);
            this.siticoneNumericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneNumericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.siticoneNumericUpDown2.Name = "siticoneNumericUpDown2";
            this.siticoneNumericUpDown2.Size = new System.Drawing.Size(100, 50);
            this.siticoneNumericUpDown2.TabIndex = 115;
            this.siticoneNumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label4.Location = new System.Drawing.Point(545, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 42);
            this.label4.TabIndex = 114;
            this.label4.Text = "Tình trạng:";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(149, 82);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(288, 50);
            this.txtUsername.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label5.Location = new System.Drawing.Point(5, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 42);
            this.label5.TabIndex = 59;
            this.label5.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label3.Location = new System.Drawing.Point(227, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 42);
            this.label3.TabIndex = 50;
            this.label3.Text = "CS1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 42);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã cuốn sách:";
            // 
            // pageSua
            // 
            this.pageSua.Location = new System.Drawing.Point(4, 34);
            this.pageSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageSua.Name = "pageSua";
            this.pageSua.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageSua.Size = new System.Drawing.Size(989, 148);
            this.pageSua.TabIndex = 1;
            this.pageSua.Text = "Sửa";
            this.pageSua.UseVisualStyleBackColor = true;
            // 
            // pageXoa
            // 
            this.pageXoa.Location = new System.Drawing.Point(4, 34);
            this.pageXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageXoa.Name = "pageXoa";
            this.pageXoa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageXoa.Size = new System.Drawing.Size(989, 148);
            this.pageXoa.TabIndex = 2;
            this.pageXoa.Text = "Xóa";
            this.pageXoa.UseVisualStyleBackColor = true;
            // 
            // pageTim
            // 
            this.pageTim.Location = new System.Drawing.Point(4, 34);
            this.pageTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageTim.Name = "pageTim";
            this.pageTim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tableCuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tableCuonSach.Size = new System.Drawing.Size(997, 341);
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
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.tableCuonSach);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 255);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(997, 341);
            this.siticonePanel2.TabIndex = 3;
            // 
            // ucCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCuonSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticonePanel1.ResumeLayout(false);
            this.dgTabControl.ResumeLayout(false);
            this.pageThem.ResumeLayout(false);
            this.pageThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown2)).EndInit();
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
        private static tabThemCuonSach tabthemcuonsach;
        private DataGridViewTextBoxColumn MaCuonSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenTuaSach;
        private DataGridViewTextBoxColumn TinhTrang;
        private Label label3;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        private Label label5;
        private Label label15;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2;
        private Label label4;
    }
}
