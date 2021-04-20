
namespace PremierServiceSolutions.Presentation_Access_Layer
{
    partial class frmDashBoard
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnNewTicket = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlSideMenu.BackColor = System.Drawing.Color.White;
            this.pnlSideMenu.Controls.Add(this.btnNewTicket);
            this.pnlSideMenu.Controls.Add(this.pBLogo);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(297, 812);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTicket.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTicket.FlatAppearance.BorderSize = 0;
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(12, 140);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNewTicket.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnNewTicket.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTicket.Size = new System.Drawing.Size(264, 40);
            this.btnNewTicket.TabIndex = 1;
            this.btnNewTicket.Text = "NEW TICKET +";
            this.btnNewTicket.TextColor = System.Drawing.Color.White;
            this.btnNewTicket.UseVisualStyleBackColor = true;
            // 
            // pBLogo
            // 
            this.pBLogo.Image = global::PremierServiceSolutions.Properties.Resources.PSSLogo;
            this.pBLogo.Location = new System.Drawing.Point(41, 12);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(211, 107);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 813);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private CustomComponents.ButtonRound btnNewTicket;
        private System.Windows.Forms.PictureBox pBLogo;
    }
}