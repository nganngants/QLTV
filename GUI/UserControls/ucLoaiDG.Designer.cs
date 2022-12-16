using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucLoaiDG
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
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.topPanel.Size = new System.Drawing.Size(1017, 119);
            this.topPanel.TabIndex = 3;
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
            this.butDel.Location = new System.Drawing.Point(174, 54);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(156, 42);
            this.butDel.TabIndex = 1;
            this.butDel.Text = "Xóa Loại Độc Giả";
            this.butDel.TextOffset = new System.Drawing.Point(12, 0);
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
            this.butAdd.Location = new System.Drawing.Point(5, 54);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(156, 42);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Thêm Loại Độc Giả";
            this.butAdd.TextOffset = new System.Drawing.Point(12, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siticoneDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 18;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maLoaiDocGiaDataGridViewTextBoxColumn,
            this.tenLoaiDocGiaDataGridViewTextBoxColumn,
            this.dOCGIAsDataGridViewTextBoxColumn});
            this.siticoneDataGridView1.DataSource = this.lOAIDOCGIABindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(0, 119);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 24;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(1017, 508);
            this.siticoneDataGridView1.TabIndex = 4;
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
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maLoaiDocGiaDataGridViewTextBoxColumn
            // 
            this.maLoaiDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiDocGia";
            this.maLoaiDocGiaDataGridViewTextBoxColumn.HeaderText = "MaLoaiDocGia";
            this.maLoaiDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiDocGiaDataGridViewTextBoxColumn.Name = "maLoaiDocGiaDataGridViewTextBoxColumn";
            // 
            // tenLoaiDocGiaDataGridViewTextBoxColumn
            // 
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiDocGia";
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.HeaderText = "TenLoaiDocGia";
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.Name = "tenLoaiDocGiaDataGridViewTextBoxColumn";
            // 
            // dOCGIAsDataGridViewTextBoxColumn
            // 
            this.dOCGIAsDataGridViewTextBoxColumn.DataPropertyName = "DOCGIAs";
            this.dOCGIAsDataGridViewTextBoxColumn.HeaderText = "DOCGIAs";
            this.dOCGIAsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCGIAsDataGridViewTextBoxColumn.Name = "dOCGIAsDataGridViewTextBoxColumn";
            // 
            // lOAIDOCGIABindingSource
            // 
            this.lOAIDOCGIABindingSource.DataSource = typeof(DTO.LOAIDOCGIA);
            // 
            // ucLoaiDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.topPanel);
            this.Name = "ucLoaiDG";
            this.Size = new System.Drawing.Size(1017, 627);
            this.Load += new System.EventHandler(this.ucLoaiDG_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maLoaiDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiDocGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOCGIAsDataGridViewTextBoxColumn;
        private BindingSource lOAIDOCGIABindingSource;
    }
}
