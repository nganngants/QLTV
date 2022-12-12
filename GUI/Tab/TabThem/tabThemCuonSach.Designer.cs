namespace GUI.Tab
{
    partial class tabThemCuonSach
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label15 = new System.Windows.Forms.Label();
            this.siticoneNumericUpDown2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown2)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(747, 530);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.label15);
            this.siticonePanel3.Controls.Add(this.siticoneNumericUpDown2);
            this.siticonePanel3.Controls.Add(this.label4);
            this.siticonePanel3.Controls.Add(this.txtUsername);
            this.siticonePanel3.Controls.Add(this.label5);
            this.siticonePanel3.Controls.Add(this.label3);
            this.siticonePanel3.Controls.Add(this.label2);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 86);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(747, 444);
            this.siticonePanel3.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(48, 210);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(337, 16);
            this.label15.TabIndex = 113;
            this.label15.Text = "*Tình trạng sách: (1) Đã được mượn, (0) Chưa được mượn";
            // 
            // siticoneNumericUpDown2
            // 
            this.siticoneNumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneNumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneNumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneNumericUpDown2.Location = new System.Drawing.Point(216, 153);
            this.siticoneNumericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneNumericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.siticoneNumericUpDown2.Name = "siticoneNumericUpDown2";
            this.siticoneNumericUpDown2.Size = new System.Drawing.Size(75, 41);
            this.siticoneNumericUpDown2.TabIndex = 78;
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
            this.label4.Location = new System.Drawing.Point(46, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 59;
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
            this.txtUsername.Location = new System.Drawing.Point(216, 81);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(216, 41);
            this.txtUsername.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label5.Location = new System.Drawing.Point(46, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 49;
            this.label5.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label3.Location = new System.Drawing.Point(211, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 48;
            this.label3.Text = "CS1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.856F);
            this.label2.Location = new System.Drawing.Point(46, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã cuốn sách:";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.label1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(747, 81);
            this.siticonePanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.label1.Location = new System.Drawing.Point(127, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm cuốn sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabThemCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tabThemCuonSach";
            this.Size = new System.Drawing.Size(747, 530);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown2)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2;
        private System.Windows.Forms.Label label15;
    }
}
