﻿namespace GUI.UserControls
{
    partial class ucTheLoai
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
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.txtTenTL = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TheLoaiGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheLoaiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.txtTenTL);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1080, 121);
            this.topPanel.TabIndex = 0;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.phieumuontra;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(383, 73);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(73, 65);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // txtTenTL
            // 
            this.txtTenTL.BorderRadius = 4;
            this.txtTenTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTL.DefaultText = "";
            this.txtTenTL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTL.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTL.Location = new System.Drawing.Point(14, 89);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.PasswordChar = '\0';
            this.txtTenTL.PlaceholderText = "Tên Thể Loại";
            this.txtTenTL.SelectedText = "";
            this.txtTenTL.Size = new System.Drawing.Size(179, 28);
            this.txtTenTL.TabIndex = 10;
            // 
            // butAdd
            // 
            this.butAdd.BorderRadius = 6;
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
            this.butAdd.Location = new System.Drawing.Point(217, 89);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(160, 28);
            this.butAdd.TabIndex = 9;
            this.butAdd.Text = "Thêm Thể Loại";
            this.butAdd.TextOffset = new System.Drawing.Point(12, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // TheLoaiGrid
            // 
            this.TheLoaiGrid.AllowUserToAddRows = false;
            this.TheLoaiGrid.AllowUserToDeleteRows = false;
            this.TheLoaiGrid.AllowUserToResizeColumns = false;
            this.TheLoaiGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TheLoaiGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheLoaiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TheLoaiGrid.ColumnHeadersHeight = 35;
            this.TheLoaiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TheLoaiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaTheLoai,
            this.TenTheLoai,
            this.SoTuaSach});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TheLoaiGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TheLoaiGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheLoaiGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TheLoaiGrid.Location = new System.Drawing.Point(0, 121);
            this.TheLoaiGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheLoaiGrid.Name = "TheLoaiGrid";
            this.TheLoaiGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TheLoaiGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TheLoaiGrid.RowHeadersVisible = false;
            this.TheLoaiGrid.RowHeadersWidth = 51;
            this.TheLoaiGrid.RowTemplate.Height = 30;
            this.TheLoaiGrid.Size = new System.Drawing.Size(1080, 521);
            this.TheLoaiGrid.TabIndex = 1;
            this.TheLoaiGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TheLoaiGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TheLoaiGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TheLoaiGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TheLoaiGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TheLoaiGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TheLoaiGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TheLoaiGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.TheLoaiGrid.ThemeStyle.ReadOnly = false;
            this.TheLoaiGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TheLoaiGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TheLoaiGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoaiGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TheLoaiGrid.ThemeStyle.RowsStyle.Height = 30;
            this.TheLoaiGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TheLoaiGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.TrueValue = "1";
            this.isChosen.Visible = false;
            this.isChosen.Width = 6;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            this.TenTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SoTuaSach
            // 
            this.SoTuaSach.HeaderText = "Số tựa sách";
            this.SoTuaSach.MinimumWidth = 6;
            this.SoTuaSach.Name = "SoTuaSach";
            this.SoTuaSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tHELOAIBindingSource
            // 
            this.tHELOAIBindingSource.DataSource = typeof(DTO.THELOAI);
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Information;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.SuccDia.Text = null;
            // 
            // AskDia
            // 
            this.AskDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.AskDia.Caption = null;
            this.AskDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Question;
            this.AskDia.Parent = null;
            this.AskDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.AskDia.Text = null;
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.RetryCancel;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
            // 
            // ucTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheLoaiGrid);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTheLoai";
            this.Size = new System.Drawing.Size(1080, 642);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TheLoaiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView TheLoaiGrid;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenTL;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTuaSach;
    }
}
