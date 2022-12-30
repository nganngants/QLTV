namespace GUI
{
    partial class fChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtRMKM = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMKM = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMKHT = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneContainerControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.siticoneContainerControl1.BorderThickness = 2;
            this.siticoneContainerControl1.Controls.Add(this.label3);
            this.siticoneContainerControl1.Controls.Add(this.label2);
            this.siticoneContainerControl1.Controls.Add(this.butSave);
            this.siticoneContainerControl1.Controls.Add(this.txtRMKM);
            this.siticoneContainerControl1.Controls.Add(this.txtMKM);
            this.siticoneContainerControl1.Controls.Add(this.txtMKHT);
            this.siticoneContainerControl1.Controls.Add(this.label1);
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneContainerControl1.Location = new System.Drawing.Point(100, 100);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(600, 520);
            this.siticoneContainerControl1.TabIndex = 1;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(128, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập mật khẩu hiện tại*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(128, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập và xác nhận mật khẩu mới*";
            // 
            // butSave
            // 
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.SlateBlue;
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(132, 410);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(337, 50);
            this.butSave.TabIndex = 11;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // txtRMKM
            // 
            this.txtRMKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtRMKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.txtRMKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRMKM.DefaultText = "";
            this.txtRMKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRMKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRMKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRMKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRMKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtRMKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRMKM.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtRMKM.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtRMKM.Location = new System.Drawing.Point(132, 336);
            this.txtRMKM.Name = "txtRMKM";
            this.txtRMKM.PasswordChar = '*';
            this.txtRMKM.PlaceholderText = "Xác nhận mật khẩu mới";
            this.txtRMKM.SelectedText = "";
            this.txtRMKM.Size = new System.Drawing.Size(337, 50);
            this.txtRMKM.TabIndex = 10;
            this.txtRMKM.TextChanged += new System.EventHandler(this.txtRMKM_TextChanged);
            // 
            // txtMKM
            // 
            this.txtMKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtMKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.txtMKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKM.DefaultText = "";
            this.txtMKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtMKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMKM.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtMKM.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtMKM.Location = new System.Drawing.Point(132, 280);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.PlaceholderText = "Mật khẩu mới";
            this.txtMKM.SelectedText = "";
            this.txtMKM.Size = new System.Drawing.Size(337, 50);
            this.txtMKM.TabIndex = 7;
            // 
            // txtMKHT
            // 
            this.txtMKHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtMKHT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.txtMKHT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKHT.DefaultText = "";
            this.txtMKHT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKHT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKHT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKHT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKHT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtMKHT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMKHT.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtMKHT.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtMKHT.Location = new System.Drawing.Point(132, 182);
            this.txtMKHT.Name = "txtMKHT";
            this.txtMKHT.PasswordChar = '*';
            this.txtMKHT.PlaceholderText = "Mật khẩu hiện tại";
            this.txtMKHT.SelectedText = "";
            this.txtMKHT.Size = new System.Drawing.Size(337, 50);
            this.txtMKHT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(680, -1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 60);
            this.siticoneControlBox2.TabIndex = 5;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(741, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 60);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChangePassword";
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtRMKM;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMKM;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMKHT;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}