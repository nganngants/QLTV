using Siticone.Desktop.UI.WinForms;

namespace GUI.UserControls
{
    partial class ucQLSach
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
            this.butCuonsach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butTuaSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.butCuonsach);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneContainerControl1);
            this.siticoneGradientPanel1.Controls.Add(this.butTuaSach);
            this.siticoneGradientPanel1.Controls.Add(this.butSach);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(997, 56);
            this.siticoneGradientPanel1.TabIndex = 0;
            // 
            // butCuonsach
            // 
            this.butCuonsach.BorderColor = System.Drawing.Color.Transparent;
            this.butCuonsach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butCuonsach.CheckedState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.butCuonsach.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.butCuonsach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butCuonsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCuonsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCuonsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butCuonsach.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.butCuonsach.ForeColor = System.Drawing.Color.DimGray;
            this.butCuonsach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Location = new System.Drawing.Point(360, 0);
            this.butCuonsach.Name = "butCuonsach";
            this.butCuonsach.Size = new System.Drawing.Size(180, 56);
            this.butCuonsach.TabIndex = 2;
            this.butCuonsach.Text = "Cuốn sách";
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Location = new System.Drawing.Point(3, 62);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(229, 200);
            this.siticoneContainerControl1.TabIndex = 1;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // butTuaSach
            // 
            this.butTuaSach.BorderColor = System.Drawing.Color.Transparent;
            this.butTuaSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTuaSach.CheckedState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.butTuaSach.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.butTuaSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTuaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTuaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTuaSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTuaSach.FillColor = System.Drawing.Color.Transparent;
            this.butTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.butTuaSach.ForeColor = System.Drawing.Color.DimGray;
            this.butTuaSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTuaSach.Location = new System.Drawing.Point(180, 0);
            this.butTuaSach.Name = "butTuaSach";
            this.butTuaSach.Size = new System.Drawing.Size(180, 56);
            this.butTuaSach.TabIndex = 1;
            this.butTuaSach.Text = "Tựa sách";
            this.butTuaSach.Click += new System.EventHandler(this.butTuaSach_Click);
            // 
            // butSach
            // 
            this.butSach.BorderColor = System.Drawing.Color.Transparent;
            this.butSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butSach.CheckedState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.butSach.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.butSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butSach.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.butSach.ForeColor = System.Drawing.Color.DimGray;
            this.butSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Location = new System.Drawing.Point(0, 0);
            this.butSach.Name = "butSach";
            this.butSach.Size = new System.Drawing.Size(180, 56);
            this.butSach.TabIndex = 0;
            this.butSach.Text = "Sách";
            this.butSach.Click += new System.EventHandler(this.butSach_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 56);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(997, 596);
            this.container.TabIndex = 1;
            this.container.Text = "siticoneContainerControl2";
            // 
            // ucQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucQLSach";
            this.Size = new System.Drawing.Size(997, 652);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTuaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSach; 
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private static ucSach ucsach;
        private static ucTuaSach uctuasach;
        private static ucTuaSach uccuonsach;
        private SiticoneButton butCuonsach;
        //public SiticoneContainerControl Container1 { get => container; set => container = value; }
    }
}
