using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucSachTraTre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dateBC = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.errDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.messDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayTre});
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
            this.dataGrid.Location = new System.Drawing.Point(0, 102);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(925, 580);
            this.dataGrid.TabIndex = 0;
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
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Controls.Add(this.dateBC);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(925, 102);
            this.topPanel.TabIndex = 1;
            // 
            // dateBC
            // 
            this.dateBC.Checked = true;
            this.dateBC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dateBC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateBC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBC.Location = new System.Drawing.Point(3, 59);
            this.dateBC.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBC.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBC.Name = "dateBC";
            this.dateBC.Size = new System.Drawing.Size(127, 23);
            this.dateBC.TabIndex = 0;
            this.dateBC.Value = new System.DateTime(2022, 12, 20, 13, 57, 7, 401);
            // 
            // butAdd
            // 
            this.butAdd.BorderRadius = 6;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(136, 59);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(117, 23);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Tạo Báo Cáo";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // errDia
            // 
            this.errDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errDia.Caption = null;
            this.errDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errDia.Parent = null;
            this.errDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errDia.Text = null;
            // 
            // messDia
            // 
            this.messDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.messDia.Caption = null;
            this.messDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.messDia.Parent = null;
            this.messDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.messDia.Text = null;
            // 
            // STT
            // 
            this.STT.HeaderText = "Số Thứ Tự";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Cuốn Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Cuốn Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // SoNgayTre
            // 
            this.SoNgayTre.HeaderText = "Số Ngày Trễ";
            this.SoNgayTre.MinimumWidth = 6;
            this.SoNgayTre.Name = "SoNgayTre";
            this.SoNgayTre.ReadOnly = true;
            // 
            // ucSachTraTre
            // 
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucSachTraTre";
            this.Size = new System.Drawing.Size(925, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView tableBCSachTraTre;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGrid;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateBC;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog messDia;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn SoNgayTre;
    }
}
