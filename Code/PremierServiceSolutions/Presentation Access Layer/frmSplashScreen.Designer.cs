
namespace PremierServiceSolutions
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.cPBLoading = new CircularProgressBar.CircularProgressBar();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.lblPSS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cPBLoading
            // 
            this.cPBLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cPBLoading.AnimationSpeed = 500;
            this.cPBLoading.BackColor = System.Drawing.Color.Transparent;
            this.cPBLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cPBLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPBLoading.InnerColor = System.Drawing.Color.White;
            this.cPBLoading.InnerMargin = 2;
            this.cPBLoading.InnerWidth = -1;
            this.cPBLoading.Location = new System.Drawing.Point(390, 311);
            this.cPBLoading.MarqueeAnimationSpeed = 2000;
            this.cPBLoading.Name = "cPBLoading";
            this.cPBLoading.OuterColor = System.Drawing.Color.White;
            this.cPBLoading.OuterMargin = -25;
            this.cPBLoading.OuterWidth = 26;
            this.cPBLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cPBLoading.ProgressWidth = 8;
            this.cPBLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cPBLoading.Size = new System.Drawing.Size(50, 50);
            this.cPBLoading.StartAngle = 270;
            this.cPBLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cPBLoading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cPBLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cPBLoading.SubscriptText = ".23";
            this.cPBLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cPBLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cPBLoading.SuperscriptText = "°C";
            this.cPBLoading.TabIndex = 2;
            this.cPBLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cPBLoading.Value = 30;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.AutoSize = true;
            this.lblLoadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingText.Location = new System.Drawing.Point(446, 326);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(144, 17);
            this.lblLoadingText.TabIndex = 5;
            this.lblLoadingText.Text = "Checking for Updates";
            // 
            // lblPSS
            // 
            this.lblPSS.AutoSize = true;
            this.lblPSS.BackColor = System.Drawing.Color.Transparent;
            this.lblPSS.Font = new System.Drawing.Font("SF Pro Display", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPSS.Location = new System.Drawing.Point(233, 128);
            this.lblPSS.Name = "lblPSS";
            this.lblPSS.Size = new System.Drawing.Size(567, 56);
            this.lblPSS.TabIndex = 6;
            this.lblPSS.Text = "Premier Service Solutions";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblPSS);
            this.Controls.Add(this.lblLoadingText);
            this.Controls.Add(this.cPBLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premier Service Solutions";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cPBLoading;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.Label lblPSS;
    }
}

