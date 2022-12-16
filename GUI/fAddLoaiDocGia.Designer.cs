namespace GUI
{
    partial class fAddLoaiDocGia
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butOK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTLDG = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.controlPanel.Controls.Add(this.miniControlBox);
            this.controlPanel.Controls.Add(this.closeControlBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(500, 54);
            this.controlPanel.TabIndex = 1;
            // 
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.miniControlBox.Location = new System.Drawing.Point(377, 0);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(60, 54);
            this.miniControlBox.TabIndex = 0;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.closeControlBox.Location = new System.Drawing.Point(439, 0);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(61, 54);
            this.closeControlBox.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.mainPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.mainPanel.BorderRadius = 1;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.butOK);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtTLDG);
            this.mainPanel.Controls.Add(this.labelTitle);
            this.mainPanel.Location = new System.Drawing.Point(75, 102);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(350, 350);
            this.mainPanel.TabIndex = 2;
            // 
            // butOK
            // 
            this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK.BorderRadius = 2;
            this.butOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOK.FillColor = System.Drawing.Color.SlateBlue;
            this.butOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(120, 245);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(111, 51);
            this.butOK.TabIndex = 4;
            this.butOK.Text = "Lưu";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(60, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Loại Độc Giả";
            // 
            // txtTLDG
            // 
            this.txtTLDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTLDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTLDG.DefaultText = "";
            this.txtTLDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTLDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTLDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTLDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTLDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTLDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTLDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTLDG.Location = new System.Drawing.Point(64, 152);
            this.txtTLDG.Name = "txtTLDG";
            this.txtTLDG.PasswordChar = '\0';
            this.txtTLDG.PlaceholderText = "";
            this.txtTLDG.SelectedText = "";
            this.txtTLDG.Size = new System.Drawing.Size(229, 36);
            this.txtTLDG.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(30, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(291, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "THÊM LOẠI ĐỘC GIẢ";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.controlPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.SuccDia.Text = null;
            // 
            // fAddLoaiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddLoaiDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddLoaiDocGia";
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTLDG;
        private System.Windows.Forms.Label labelTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butOK;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
    }
}