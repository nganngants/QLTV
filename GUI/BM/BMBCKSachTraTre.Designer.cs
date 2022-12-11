namespace GUI.BM
{
    partial class BMBCKSachTraTre
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneDateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tableSachTraTre = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayTraTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSachTraTre)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneDateTimePicker1);
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Controls.Add(this.tableSachTraTre);
            this.siticonePanel1.Location = new System.Drawing.Point(100, 100);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1000, 550);
            this.siticonePanel1.TabIndex = 2;
            // 
            // siticoneDateTimePicker1
            // 
            this.siticoneDateTimePicker1.Checked = true;
            this.siticoneDateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.siticoneDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.siticoneDateTimePicker1.Location = new System.Drawing.Point(480, 38);
            this.siticoneDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.siticoneDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.siticoneDateTimePicker1.Name = "siticoneDateTimePicker1";
            this.siticoneDateTimePicker1.Size = new System.Drawing.Size(260, 21);
            this.siticoneDateTimePicker1.TabIndex = 68;
            this.siticoneDateTimePicker1.Value = new System.DateTime(2022, 12, 2, 22, 44, 12, 275);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ngày:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableSachTraTre
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tableSachTraTre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableSachTraTre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableSachTraTre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSachTraTre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableSachTraTre.ColumnHeadersHeight = 50;
            this.tableSachTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableSachTraTre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayTraTre});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableSachTraTre.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableSachTraTre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableSachTraTre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableSachTraTre.Location = new System.Drawing.Point(0, 98);
            this.tableSachTraTre.Name = "tableSachTraTre";
            this.tableSachTraTre.RowHeadersVisible = false;
            this.tableSachTraTre.RowHeadersWidth = 53;
            this.tableSachTraTre.RowTemplate.Height = 24;
            this.tableSachTraTre.Size = new System.Drawing.Size(1000, 452);
            this.tableSachTraTre.TabIndex = 1;
            this.tableSachTraTre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableSachTraTre.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableSachTraTre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableSachTraTre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableSachTraTre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableSachTraTre.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableSachTraTre.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableSachTraTre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableSachTraTre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableSachTraTre.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSachTraTre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableSachTraTre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableSachTraTre.ThemeStyle.HeaderStyle.Height = 50;
            this.tableSachTraTre.ThemeStyle.ReadOnly = false;
            this.tableSachTraTre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableSachTraTre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableSachTraTre.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSachTraTre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableSachTraTre.ThemeStyle.RowsStyle.Height = 24;
            this.tableSachTraTre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableSachTraTre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 7;
            this.STT.Name = "STT";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 7;
            this.TenSach.Name = "TenSach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 7;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // SoNgayTraTre
            // 
            this.SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ";
            this.SoNgayTraTre.MinimumWidth = 7;
            this.SoNgayTraTre.Name = "SoNgayTraTre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.224F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 57);
            this.label1.TabIndex = 76;
            this.label1.Text = "Báo cáo thống kê sách trả trễ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1140, 1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 60);
            this.siticoneControlBox1.TabIndex = 78;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1076, 1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 60);
            this.siticoneControlBox2.TabIndex = 77;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BMBCKSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMBCKSachTraTre";
            this.Text = "BMBCKSachTraTre";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSachTraTre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView tableSachTraTre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayTraTre;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker siticoneDateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}