using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucBanAccess
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
            this.UIText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UIText
            // 
            this.UIText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UIText.AutoSize = true;
            this.UIText.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UIText.Location = new System.Drawing.Point(197, 410);
            this.UIText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIText.Name = "UIText";
            this.UIText.Size = new System.Drawing.Size(743, 37);
            this.UIText.TabIndex = 0;
            this.UIText.Text = "BẠN KHÔNG CÓ QUYỀN TRUY CẬP VÀO CHỨC NĂNG NÀY";
            // 
            // ucBanAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.UIText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucBanAccess";
            this.Size = new System.Drawing.Size(1121, 856);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UIText;
    }
}
