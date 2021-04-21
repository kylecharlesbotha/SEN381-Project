
namespace PremierServiceSolutions.Pages
{
    partial class frmCentre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBAnswerCall = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCallWaiting = new System.Windows.Forms.Panel();
            this.lblActiveCallers = new System.Windows.Forms.Label();
            this.lblCurrentlyActive = new System.Windows.Forms.Label();
            this.cPBCallWaiting = new CircularProgressBar.CircularProgressBar();
            this.iPBCallMute = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAnswerCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCallWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBCallMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox5);
            this.panel1.Controls.Add(this.iconPictureBox4);
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.iPBCallMute);
            this.panel1.Controls.Add(this.pBAnswerCall);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 264);
            this.panel1.TabIndex = 0;
            // 
            // pBAnswerCall
            // 
            this.pBAnswerCall.Image = global::PremierServiceSolutions.Properties.Resources.AnswerCall;
            this.pBAnswerCall.Location = new System.Drawing.Point(33, 20);
            this.pBAnswerCall.Name = "pBAnswerCall";
            this.pBAnswerCall.Size = new System.Drawing.Size(170, 170);
            this.pBAnswerCall.TabIndex = 1;
            this.pBAnswerCall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PremierServiceSolutions.Properties.Resources.DeclineCall;
            this.pictureBox1.Location = new System.Drawing.Point(441, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCallWaiting
            // 
            this.pnlCallWaiting.BackColor = System.Drawing.Color.White;
            this.pnlCallWaiting.Controls.Add(this.lblActiveCallers);
            this.pnlCallWaiting.Controls.Add(this.lblCurrentlyActive);
            this.pnlCallWaiting.Controls.Add(this.cPBCallWaiting);
            this.pnlCallWaiting.Location = new System.Drawing.Point(9, 462);
            this.pnlCallWaiting.Name = "pnlCallWaiting";
            this.pnlCallWaiting.Size = new System.Drawing.Size(252, 227);
            this.pnlCallWaiting.TabIndex = 1;
            // 
            // lblActiveCallers
            // 
            this.lblActiveCallers.AutoSize = true;
            this.lblActiveCallers.Font = new System.Drawing.Font("SF Pro Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCallers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActiveCallers.Location = new System.Drawing.Point(28, 191);
            this.lblActiveCallers.Name = "lblActiveCallers";
            this.lblActiveCallers.Size = new System.Drawing.Size(202, 25);
            this.lblActiveCallers.TabIndex = 2;
            this.lblActiveCallers.Text = "Active : 30 Callers";
            // 
            // lblCurrentlyActive
            // 
            this.lblCurrentlyActive.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentlyActive.Location = new System.Drawing.Point(0, 9);
            this.lblCurrentlyActive.Name = "lblCurrentlyActive";
            this.lblCurrentlyActive.Size = new System.Drawing.Size(252, 26);
            this.lblCurrentlyActive.TabIndex = 1;
            this.lblCurrentlyActive.Text = "Currently Active an Waiting";
            this.lblCurrentlyActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPBCallWaiting
            // 
            this.cPBCallWaiting.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cPBCallWaiting.AnimationSpeed = 500;
            this.cPBCallWaiting.BackColor = System.Drawing.Color.Transparent;
            this.cPBCallWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPBCallWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPBCallWaiting.InnerColor = System.Drawing.Color.White;
            this.cPBCallWaiting.InnerMargin = 2;
            this.cPBCallWaiting.InnerWidth = -1;
            this.cPBCallWaiting.Location = new System.Drawing.Point(47, 38);
            this.cPBCallWaiting.MarqueeAnimationSpeed = 2000;
            this.cPBCallWaiting.Name = "cPBCallWaiting";
            this.cPBCallWaiting.OuterColor = System.Drawing.Color.Gray;
            this.cPBCallWaiting.OuterMargin = -25;
            this.cPBCallWaiting.OuterWidth = 26;
            this.cPBCallWaiting.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cPBCallWaiting.ProgressWidth = 25;
            this.cPBCallWaiting.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPBCallWaiting.Size = new System.Drawing.Size(160, 150);
            this.cPBCallWaiting.StartAngle = 270;
            this.cPBCallWaiting.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cPBCallWaiting.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cPBCallWaiting.SubscriptText = "";
            this.cPBCallWaiting.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cPBCallWaiting.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cPBCallWaiting.SuperscriptText = "";
            this.cPBCallWaiting.TabIndex = 0;
            this.cPBCallWaiting.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cPBCallWaiting.Value = 68;
            // 
            // iPBCallMute
            // 
            this.iPBCallMute.BackColor = System.Drawing.SystemColors.Control;
            this.iPBCallMute.ForeColor = System.Drawing.Color.Black;
            this.iPBCallMute.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            this.iPBCallMute.IconColor = System.Drawing.Color.Black;
            this.iPBCallMute.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iPBCallMute.IconSize = 40;
            this.iPBCallMute.Location = new System.Drawing.Point(237, 100);
            this.iPBCallMute.Name = "iPBCallMute";
            this.iPBCallMute.Size = new System.Drawing.Size(43, 34);
            this.iPBCallMute.TabIndex = 2;
            this.iPBCallMute.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VolumeDown;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 34;
            this.iconPictureBox1.Location = new System.Drawing.Point(237, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 34);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 34;
            this.iconPictureBox2.Location = new System.Drawing.Point(237, 60);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 34);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PhoneSlash;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox3.IconSize = 34;
            this.iconPictureBox3.Location = new System.Drawing.Point(380, 20);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(43, 34);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox4.IconSize = 34;
            this.iconPictureBox4.Location = new System.Drawing.Point(380, 60);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(43, 34);
            this.iconPictureBox4.TabIndex = 6;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox5.IconSize = 34;
            this.iconPictureBox5.Location = new System.Drawing.Point(380, 100);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(43, 34);
            this.iconPictureBox5.TabIndex = 7;
            this.iconPictureBox5.TabStop = false;
            // 
            // frmCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 701);
            this.Controls.Add(this.pnlCallWaiting);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCentre";
            this.Text = "frmCentre";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBAnswerCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCallWaiting.ResumeLayout(false);
            this.pnlCallWaiting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBCallMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCallWaiting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblActiveCallers;
        private System.Windows.Forms.Label lblCurrentlyActive;
        private CircularProgressBar.CircularProgressBar cPBCallWaiting;
        private System.Windows.Forms.PictureBox pBAnswerCall;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iPBCallMute;
    }
}