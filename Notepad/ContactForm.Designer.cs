namespace Notepad
{
    partial class contactForm
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
            this.linkLblEmail = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLblEmail
            // 
            this.linkLblEmail.AutoSize = true;
            this.linkLblEmail.Location = new System.Drawing.Point(81, 62);
            this.linkLblEmail.Name = "linkLblEmail";
            this.linkLblEmail.Size = new System.Drawing.Size(138, 13);
            this.linkLblEmail.TabIndex = 0;
            this.linkLblEmail.TabStop = true;
            this.linkLblEmail.Text = "somemail@someserver.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(48, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 141);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.linkLblEmail);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 180);
            this.Name = "contactForm";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}