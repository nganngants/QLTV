﻿using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucDocGia
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
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DocGiaGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachDangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNoHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticoneDataGridViewStyler1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.butDel);
            this.TopPanel.Controls.Add(this.butAdd);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1233, 119);
            this.TopPanel.TabIndex = 4;
            // 
            // butDel
            // 
            this.butDel.BorderRadius = 6;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Image = global::GUI.Properties.Resources.close_icon;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(137, 54);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(131, 42);
            this.butDel.TabIndex = 0;
            this.butDel.Text = "Xóa Độc Giả";
            this.butDel.TextOffset = new System.Drawing.Point(12, 0);
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
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
            this.butAdd.Location = new System.Drawing.Point(0, 54);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(131, 42);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Thêm Độc Giả";
            this.butAdd.TextOffset = new System.Drawing.Point(12, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // DocGiaGrid
            // 
            this.DocGiaGrid.AllowUserToAddRows = false;
            this.DocGiaGrid.AllowUserToDeleteRows = false;
            this.DocGiaGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DocGiaGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DocGiaGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(126)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(126)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DocGiaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DocGiaGrid.ColumnHeadersHeight = 35;
            this.DocGiaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DocGiaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.maDocGiaDataGridViewTextBoxColumn,
            this.tenDocGiaDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.LoaiDocGia,
            this.ngayLapTheDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.SoSachDangMuon,
            this.tongNoHienTaiDataGridViewTextBoxColumn});
            this.DocGiaGrid.DataSource = this.dOCGIABindingSource;
            this.DocGiaGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DocGiaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocGiaGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DocGiaGrid.Location = new System.Drawing.Point(0, 119);
            this.DocGiaGrid.Name = "DocGiaGrid";
            this.DocGiaGrid.ReadOnly = true;
            this.DocGiaGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DocGiaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DocGiaGrid.RowHeadersVisible = false;
            this.DocGiaGrid.RowHeadersWidth = 51;
            this.DocGiaGrid.RowTemplate.Height = 28;
            this.DocGiaGrid.Size = new System.Drawing.Size(1233, 648);
            this.DocGiaGrid.TabIndex = 5;
            this.DocGiaGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DocGiaGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DocGiaGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DocGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DocGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DocGiaGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DocGiaGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DocGiaGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DocGiaGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DocGiaGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocGiaGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DocGiaGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DocGiaGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.DocGiaGrid.ThemeStyle.ReadOnly = true;
            this.DocGiaGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DocGiaGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DocGiaGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocGiaGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DocGiaGrid.ThemeStyle.RowsStyle.Height = 28;
            this.DocGiaGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DocGiaGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã độc giả";
            this.maDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            this.maDocGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDocGiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenDocGiaDataGridViewTextBoxColumn
            // 
            this.tenDocGiaDataGridViewTextBoxColumn.DataPropertyName = "TenDocGia";
            this.tenDocGiaDataGridViewTextBoxColumn.HeaderText = "Tên độc giả";
            this.tenDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDocGiaDataGridViewTextBoxColumn.Name = "tenDocGiaDataGridViewTextBoxColumn";
            this.tenDocGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDocGiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // LoaiDocGia
            // 
            this.LoaiDocGia.HeaderText = "Loại độc giả";
            this.LoaiDocGia.MinimumWidth = 6;
            this.LoaiDocGia.Name = "LoaiDocGia";
            this.LoaiDocGia.ReadOnly = true;
            // 
            // ngayLapTheDataGridViewTextBoxColumn
            // 
            this.ngayLapTheDataGridViewTextBoxColumn.DataPropertyName = "NgayLapThe";
            this.ngayLapTheDataGridViewTextBoxColumn.HeaderText = "Ngày lập thẻ";
            this.ngayLapTheDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapTheDataGridViewTextBoxColumn.Name = "ngayLapTheDataGridViewTextBoxColumn";
            this.ngayLapTheDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapTheDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ngayLapTheDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn ";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SoSachDangMuon
            // 
            this.SoSachDangMuon.HeaderText = "Sách đang mượn";
            this.SoSachDangMuon.MinimumWidth = 6;
            this.SoSachDangMuon.Name = "SoSachDangMuon";
            this.SoSachDangMuon.ReadOnly = true;
            // 
            // tongNoHienTaiDataGridViewTextBoxColumn
            // 
            this.tongNoHienTaiDataGridViewTextBoxColumn.DataPropertyName = "TongNoHienTai";
            this.tongNoHienTaiDataGridViewTextBoxColumn.HeaderText = "Tổng nợ";
            this.tongNoHienTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongNoHienTaiDataGridViewTextBoxColumn.Name = "tongNoHienTaiDataGridViewTextBoxColumn";
            this.tongNoHienTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataSource = typeof(DTO.DOCGIA);
            // 
            // ucDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocGiaGrid);
            this.Controls.Add(this.TopPanel);
            this.Name = "ucDocGia";
            this.Size = new System.Drawing.Size(1233, 767);
            this.Load += new System.EventHandler(this.ucDocGia_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView DocGiaGrid;
        private BindingSource dOCGIABindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LoaiDocGia;
        private DataGridViewTextBoxColumn ngayLapTheDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SoSachDangMuon;
        private DataGridViewTextBoxColumn tongNoHienTaiDataGridViewTextBoxColumn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler siticoneDataGridViewStyler1;
    }
}
