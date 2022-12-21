using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucQLND
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
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butNhomND = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butNguoiDung = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.container = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Controls.Add(this.siticoneContainerControl1);
            this.siticoneGradientPanel1.Controls.Add(this.butNhomND);
            this.siticoneGradientPanel1.Controls.Add(this.butNguoiDung);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(997, 50);
            this.siticoneGradientPanel1.TabIndex = 1;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Location = new System.Drawing.Point(3, 62);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(229, 200);
            this.siticoneContainerControl1.TabIndex = 1;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // butNhomND
            // 
            this.butNhomND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butNhomND.BorderColor = System.Drawing.Color.Transparent;
            this.butNhomND.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butNhomND.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butNhomND.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butNhomND.CheckedState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butNhomND.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butNhomND.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNhomND.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNhomND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNhomND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNhomND.Dock = System.Windows.Forms.DockStyle.Left;
            this.butNhomND.FillColor = System.Drawing.Color.Transparent;
            this.butNhomND.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNhomND.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butNhomND.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butNhomND.Location = new System.Drawing.Point(180, 0);
            this.butNhomND.Name = "butNhomND";
            this.butNhomND.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butNhomND.Size = new System.Drawing.Size(180, 50);
            this.butNhomND.TabIndex = 1;
            this.butNhomND.Text = "Nhóm người dùng";
            this.butNhomND.Click += new System.EventHandler(this.butNhomND_Click);
            // 
            // butNguoiDung
            // 
            this.butNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butNguoiDung.BorderColor = System.Drawing.Color.Transparent;
            this.butNguoiDung.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butNguoiDung.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butNguoiDung.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butNguoiDung.CheckedState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butNguoiDung.CustomBorderColor = System.Drawing.Color.Transparent;
            this.butNguoiDung.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.butNguoiDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNguoiDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNguoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNguoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.butNguoiDung.FillColor = System.Drawing.Color.Transparent;
            this.butNguoiDung.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNguoiDung.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butNguoiDung.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.butNguoiDung.Name = "butNguoiDung";
            this.butNguoiDung.PressedColor = System.Drawing.Color.Transparent;
            this.butNguoiDung.Size = new System.Drawing.Size(180, 50);
            this.butNguoiDung.TabIndex = 0;
            this.butNguoiDung.Text = "Người dùng";
            this.butNguoiDung.Click += new System.EventHandler(this.butNguoiDung_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(997, 546);
            this.container.TabIndex = 2;
            // 
            // ucQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucQLND";
            this.Size = new System.Drawing.Size(997, 596);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butNhomND;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butNguoiDung;
        private Siticone.Desktop.UI.WinForms.SiticonePanel container;
    }
}
