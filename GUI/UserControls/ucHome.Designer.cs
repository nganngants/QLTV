namespace GUI.UserControls
{
    partial class ucHome
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
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.butSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.siticoneContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticoneContainerControl1.Controls.Add(this.butSearch);
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(1027, 623);
            this.siticoneContainerControl1.TabIndex = 0;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(937, 24);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(70, 70);
            this.siticoneCirclePictureBox1.TabIndex = 1;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // butSearch
            // 
            this.butSearch.BorderRadius = 25;
            this.butSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.butSearch.DefaultText = "";
            this.butSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.butSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.butSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.butSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.butSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.butSearch.IconRight = global::GUI.Properties.Resources._1200px_Search_Icon_svg;
            this.butSearch.IconRightSize = new System.Drawing.Size(40, 40);
            this.butSearch.Location = new System.Drawing.Point(223, 34);
            this.butSearch.Margin = new System.Windows.Forms.Padding(6);
            this.butSearch.Name = "butSearch";
            this.butSearch.PasswordChar = '\0';
            this.butSearch.PlaceholderText = "Tìm kiếm";
            this.butSearch.SelectedText = "";
            this.butSearch.Size = new System.Drawing.Size(600, 60);
            this.butSearch.TabIndex = 0;
            this.butSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1027, 623);
            this.siticoneContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox butSearch;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
    }
}
