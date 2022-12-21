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
            this.butPhieuNhap = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTheLoai = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTacGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butCuonsach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butTuaSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Controls.Add(this.butPhieuNhap);
            this.siticoneGradientPanel1.Controls.Add(this.butTheLoai);
            this.siticoneGradientPanel1.Controls.Add(this.butTacGia);
            this.siticoneGradientPanel1.Controls.Add(this.butCuonsach);
            this.siticoneGradientPanel1.Controls.Add(this.butSach);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneContainerControl1);
            this.siticoneGradientPanel1.Controls.Add(this.butTuaSach);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1121, 50);
            this.siticoneGradientPanel1.TabIndex = 0;
            // 
            // butPhieuNhap
            // 
            this.butPhieuNhap.BorderColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butPhieuNhap.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butPhieuNhap.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butPhieuNhap.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butPhieuNhap.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butPhieuNhap.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butPhieuNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butPhieuNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butPhieuNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butPhieuNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.butPhieuNhap.FillColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPhieuNhap.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butPhieuNhap.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.Location = new System.Drawing.Point(845, 0);
            this.butPhieuNhap.Name = "butPhieuNhap";
            this.butPhieuNhap.PressedColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.Size = new System.Drawing.Size(169, 50);
            this.butPhieuNhap.TabIndex = 5;
            this.butPhieuNhap.Text = "Phiếu Nhập Sách";
            this.butPhieuNhap.Click += new System.EventHandler(this.butPhieuNhap_Click);
            // 
            // butTheLoai
            // 
            this.butTheLoai.BorderColor = System.Drawing.Color.Transparent;
            this.butTheLoai.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTheLoai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTheLoai.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTheLoai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTheLoai.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTheLoai.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTheLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTheLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTheLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTheLoai.FillColor = System.Drawing.Color.Transparent;
            this.butTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTheLoai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTheLoai.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTheLoai.Location = new System.Drawing.Point(676, 0);
            this.butTheLoai.Name = "butTheLoai";
            this.butTheLoai.PressedColor = System.Drawing.Color.Transparent;
            this.butTheLoai.Size = new System.Drawing.Size(169, 50);
            this.butTheLoai.TabIndex = 4;
            this.butTheLoai.Text = "Thể Loại";
            this.butTheLoai.Click += new System.EventHandler(this.butTheLoai_Click);
            // 
            // butTacGia
            // 
            this.butTacGia.BorderColor = System.Drawing.Color.Transparent;
            this.butTacGia.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTacGia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTacGia.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTacGia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTacGia.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTacGia.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTacGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTacGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTacGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTacGia.FillColor = System.Drawing.Color.Transparent;
            this.butTacGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTacGia.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTacGia.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTacGia.Location = new System.Drawing.Point(507, 0);
            this.butTacGia.Name = "butTacGia";
            this.butTacGia.PressedColor = System.Drawing.Color.Transparent;
            this.butTacGia.Size = new System.Drawing.Size(169, 50);
            this.butTacGia.TabIndex = 3;
            this.butTacGia.Text = "Tác Giả";
            this.butTacGia.Click += new System.EventHandler(this.butTacGia_Click);
            // 
            // butCuonsach
            // 
            this.butCuonsach.BorderColor = System.Drawing.Color.Transparent;
            this.butCuonsach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butCuonsach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butCuonsach.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butCuonsach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butCuonsach.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butCuonsach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butCuonsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCuonsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCuonsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butCuonsach.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCuonsach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butCuonsach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Location = new System.Drawing.Point(338, 0);
            this.butCuonsach.Name = "butCuonsach";
            this.butCuonsach.PressedColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Size = new System.Drawing.Size(169, 50);
            this.butCuonsach.TabIndex = 2;
            this.butCuonsach.Text = "Cuốn sách";
            this.butCuonsach.Click += new System.EventHandler(this.butCuonsach_Click_1);
            // 
            // butSach
            // 
            this.butSach.BorderColor = System.Drawing.Color.Transparent;
            this.butSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butSach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butSach.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butSach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butSach.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butSach.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Location = new System.Drawing.Point(169, 0);
            this.butSach.Name = "butSach";
            this.butSach.PressedColor = System.Drawing.Color.Transparent;
            this.butSach.Size = new System.Drawing.Size(169, 50);
            this.butSach.TabIndex = 0;
            this.butSach.Text = "Sách";
            this.butSach.Click += new System.EventHandler(this.butSach_Click);
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
            this.butTuaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butTuaSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTuaSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTuaSach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTuaSach.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTuaSach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTuaSach.CheckedState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTuaSach.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butTuaSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTuaSach.DisabledState.BorderColor = System.Drawing.Color.White;
            this.butTuaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTuaSach.DisabledState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTuaSach.Dock = System.Windows.Forms.DockStyle.Left;

            this.butTuaSach.FillColor = System.Drawing.Color.Transparent;

            this.butTuaSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butTuaSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTuaSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTuaSach.Location = new System.Drawing.Point(0, 0);
            this.butTuaSach.Name = "butTuaSach";
            this.butTuaSach.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTuaSach.Size = new System.Drawing.Size(169, 50);
            this.butTuaSach.TabIndex = 1;
            this.butTuaSach.Text = "Tựa sách";
            this.butTuaSach.Click += new System.EventHandler(this.butTuaSach_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1121, 643);
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
            this.Size = new System.Drawing.Size(1121, 693);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTuaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSach; 
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butCuonsach;
        private SiticoneButton butTheLoai;
        private SiticoneButton butTacGia;
        private SiticoneButton butPhieuNhap;
        //public SiticoneContainerControl Container1 { get => container; set => container = value; }
    }
}
