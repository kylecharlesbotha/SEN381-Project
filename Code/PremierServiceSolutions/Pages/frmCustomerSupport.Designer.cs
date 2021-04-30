
namespace PremierServiceSolutions.Pages
{
    partial class frmCustomerSupport
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
            this.wbSupport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbSupport
            // 
            this.wbSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSupport.Location = new System.Drawing.Point(0, 0);
            this.wbSupport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSupport.Name = "wbSupport";
            this.wbSupport.Size = new System.Drawing.Size(900, 740);
            this.wbSupport.TabIndex = 0;
            this.wbSupport.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // frmCustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.wbSupport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerSupport";
            this.Text = "frmCustomerSupport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbSupport;
    }
}