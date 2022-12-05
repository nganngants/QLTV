using GUI.UserControls;
using System.Windows.Forms;

namespace GUI
{
    partial class fMainForm
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
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.pageHome = new System.Windows.Forms.TabPage();
            this.pageQLDG = new System.Windows.Forms.TabPage();
            this.pageQLS = new System.Windows.Forms.TabPage();
            this.pageQLMT = new System.Windows.Forms.TabPage();
            this.pageQLPT = new System.Windows.Forms.TabPage();
            this.pageBC = new System.Windows.Forms.TabPage();
            this.pageQLND = new System.Windows.Forms.TabPage();
            this.topPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.LightGray;
            this.exitControlBox.CustomClick = true;
            this.exitControlBox.FillColor = System.Drawing.SystemColors.Control;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitControlBox.IconColor = System.Drawing.Color.Gray;
            this.exitControlBox.Location = new System.Drawing.Point(1179, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(56, 29);
            this.exitControlBox.TabIndex = 0;
            this.exitControlBox.Click += new System.EventHandler(this.exitControlBox_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.LightGray;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1127, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(56, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.exitControlBox);
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1235, 89);
            this.topPanel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.pageHome);
            this.tabControl.Controls.Add(this.pageQLDG);
            this.tabControl.Controls.Add(this.pageQLS);
            this.tabControl.Controls.Add(this.pageQLMT);
            this.tabControl.Controls.Add(this.pageQLPT);
            this.tabControl.Controls.Add(this.pageBC);
            this.tabControl.Controls.Add(this.pageQLND);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.ItemSize = new System.Drawing.Size(200, 80);
            this.tabControl.Location = new System.Drawing.Point(0, 89);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1235, 631);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.DarkGray;
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonSize = new System.Drawing.Size(200, 80);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.Transparent;
            // 
            // pageHome
            // 
            this.pageHome.Location = new System.Drawing.Point(204, 4);
            this.pageHome.Margin = new System.Windows.Forms.Padding(0);
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageHome.Size = new System.Drawing.Size(1027, 623);
            this.pageHome.TabIndex = 0;
            this.pageHome.Text = "Home";
            this.pageHome.UseVisualStyleBackColor = true;
            this.pageHome.Click += new System.EventHandler(this.pageHome_Click);
            // 
            // pageQLDG
            // 
            this.pageQLDG.Location = new System.Drawing.Point(204, 4);
            this.pageQLDG.Margin = new System.Windows.Forms.Padding(0);
            this.pageQLDG.Name = "pageQLDG";
            this.pageQLDG.Size = new System.Drawing.Size(1027, 623);
            this.pageQLDG.TabIndex = 1;
            this.pageQLDG.Text = "Quản lý độc giả";
            this.pageQLDG.UseVisualStyleBackColor = true;
            // 
            // pageQLS
            // 
            this.pageQLS.Location = new System.Drawing.Point(204, 4);
            this.pageQLS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLS.Name = "pageQLS";
            this.pageQLS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLS.Size = new System.Drawing.Size(1027, 623);
            this.pageQLS.TabIndex = 2;
            this.pageQLS.Text = "Quản lý sách";
            this.pageQLS.UseVisualStyleBackColor = true;
            // 
            // pageQLMT
            // 
            this.pageQLMT.Location = new System.Drawing.Point(204, 4);
            this.pageQLMT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLMT.Name = "pageQLMT";
            this.pageQLMT.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLMT.Size = new System.Drawing.Size(1027, 623);
            this.pageQLMT.TabIndex = 3;
            this.pageQLMT.Text = "Quản lý phiếu mượn";
            this.pageQLMT.UseVisualStyleBackColor = true;
            // 
            // pageQLPT
            // 
            this.pageQLPT.Location = new System.Drawing.Point(204, 4);
            this.pageQLPT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLPT.Name = "pageQLPT";
            this.pageQLPT.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLPT.Size = new System.Drawing.Size(1027, 623);
            this.pageQLPT.TabIndex = 4;
            this.pageQLPT.Text = "Quản lý phiếu thu";
            this.pageQLPT.UseVisualStyleBackColor = true;
            // 
            // pageBC
            // 
            this.pageBC.Location = new System.Drawing.Point(204, 4);
            this.pageBC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageBC.Name = "pageBC";
            this.pageBC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageBC.Size = new System.Drawing.Size(1027, 623);
            this.pageBC.TabIndex = 5;
            this.pageBC.Text = "Báo cáo thống kê";
            this.pageBC.UseVisualStyleBackColor = true;
            // 
            // pageQLND
            // 
            this.pageQLND.Location = new System.Drawing.Point(204, 4);
            this.pageQLND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLND.Name = "pageQLND";
            this.pageQLND.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageQLND.Size = new System.Drawing.Size(1027, 623);
            this.pageQLND.TabIndex = 6;
            this.pageQLND.Text = "Quản lý người dùng";
            this.pageQLND.UseVisualStyleBackColor = true;
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 720);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "fMainForm";
            this.Text = "fAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
        private TabPage pageHome;
        private TabPage pageQLDG;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private TabPage pageQLS;
        private TabPage pageQLMT;
        private TabPage pageQLPT;
        private TabPage pageBC;
        private TabPage pageQLND;
        private static ucBanAccess ucBan;
        private static ucQLDG ucqldg;
    }
}