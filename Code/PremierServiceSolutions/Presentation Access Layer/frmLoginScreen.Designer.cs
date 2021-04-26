
namespace PremierServiceSolutions.Presentation_Access_Layer
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.pBPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblDontHaveAccount = new System.Windows.Forms.Label();
            this.cBRemeberMe = new System.Windows.Forms.CheckBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.iPBMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iPBExit = new FontAwesome.Sharp.IconPictureBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTaskBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignIn = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBExit)).BeginInit();
            this.ContextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tBUsername);
            this.pnlMain.Controls.Add(this.tBPassword);
            this.pnlMain.Controls.Add(this.pBPass);
            this.pnlMain.Controls.Add(this.pbUser);
            this.pnlMain.Controls.Add(this.lblSignUp);
            this.pnlMain.Controls.Add(this.lblDontHaveAccount);
            this.pnlMain.Controls.Add(this.cBRemeberMe);
            this.pnlMain.Controls.Add(this.btnSignIn);
            this.pnlMain.Controls.Add(this.lblUserLogin);
            this.pnlMain.Location = new System.Drawing.Point(200, 125);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 350);
            this.pnlMain.TabIndex = 0;
            // 
            // tBUsername
            // 
            this.tBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.tBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsername.ForeColor = System.Drawing.Color.White;
            this.tBUsername.HideSelection = false;
            this.tBUsername.Location = new System.Drawing.Point(121, 98);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(193, 24);
            this.tBUsername.TabIndex = 0;
            this.tBUsername.TabStop = false;
            this.tBUsername.Text = "Username";
            this.tBUsername.Click += new System.EventHandler(this.tBUsername_Click);
            this.tBUsername.TextChanged += new System.EventHandler(this.tBUsername_TextChanged);
            this.tBUsername.Leave += new System.EventHandler(this.tBUsername_Leave);
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.tBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.ForeColor = System.Drawing.Color.White;
            this.tBPassword.HideSelection = false;
            this.tBPassword.Location = new System.Drawing.Point(90, 154);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(188, 24);
            this.tBPassword.TabIndex = 1;
            this.tBPassword.TabStop = false;
            this.tBPassword.Text = "Password";
            this.tBPassword.Click += new System.EventHandler(this.tBPassword_Click);
            this.tBPassword.Enter += new System.EventHandler(this.tBPassword_Enter);
            this.tBPassword.Leave += new System.EventHandler(this.tBPassword_Leave);
            // 
            // pBPass
            // 
            this.pBPass.BackColor = System.Drawing.Color.Transparent;
            this.pBPass.Image = global::PremierServiceSolutions.Properties.Resources.PassBackground;
            this.pBPass.Location = new System.Drawing.Point(0, 142);
            this.pBPass.Name = "pBPass";
            this.pBPass.Size = new System.Drawing.Size(400, 50);
            this.pBPass.TabIndex = 11;
            this.pBPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.UserBackground;
            this.pbUser.Location = new System.Drawing.Point(0, 86);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(400, 50);
            this.pbUser.TabIndex = 10;
            this.pbUser.TabStop = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignUp.Location = new System.Drawing.Point(249, 324);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(56, 16);
            this.lblSignUp.TabIndex = 6;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseEnter += new System.EventHandler(this.lblSignUp_MouseEnter);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            // 
            // lblDontHaveAccount
            // 
            this.lblDontHaveAccount.AutoSize = true;
            this.lblDontHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.lblDontHaveAccount.Location = new System.Drawing.Point(99, 324);
            this.lblDontHaveAccount.Name = "lblDontHaveAccount";
            this.lblDontHaveAccount.Size = new System.Drawing.Size(147, 16);
            this.lblDontHaveAccount.TabIndex = 8;
            this.lblDontHaveAccount.Text = "Don\'t have an account?";
            // 
            // cBRemeberMe
            // 
            this.cBRemeberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRemeberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBRemeberMe.Location = new System.Drawing.Point(147, 248);
            this.cBRemeberMe.Name = "cBRemeberMe";
            this.cBRemeberMe.Size = new System.Drawing.Size(105, 21);
            this.cBRemeberMe.TabIndex = 3;
            this.cBRemeberMe.TabStop = false;
            this.cBRemeberMe.Text = "Remember Me";
            this.cBRemeberMe.UseVisualStyleBackColor = true;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserLogin.Location = new System.Drawing.Point(0, 33);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(400, 35);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "USER LOGIN";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iPBMinimize
            // 
            this.iPBMinimize.BackColor = System.Drawing.Color.Transparent;
            this.iPBMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iPBMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iPBMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iPBMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBMinimize.IconSize = 29;
            this.iPBMinimize.Location = new System.Drawing.Point(741, 0);
            this.iPBMinimize.Name = "iPBMinimize";
            this.iPBMinimize.Size = new System.Drawing.Size(29, 29);
            this.iPBMinimize.TabIndex = 21;
            this.iPBMinimize.TabStop = false;
            this.iPBMinimize.Click += new System.EventHandler(this.iPBMinimize_Click);
            this.iPBMinimize.MouseEnter += new System.EventHandler(this.iPBMinimize_MouseEnter);
            this.iPBMinimize.MouseLeave += new System.EventHandler(this.iPBMinimize_MouseLeave);
            // 
            // iPBExit
            // 
            this.iPBExit.BackColor = System.Drawing.Color.Transparent;
            this.iPBExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iPBExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iPBExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iPBExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBExit.IconSize = 29;
            this.iPBExit.Location = new System.Drawing.Point(771, 0);
            this.iPBExit.Name = "iPBExit";
            this.iPBExit.Size = new System.Drawing.Size(29, 29);
            this.iPBExit.TabIndex = 20;
            this.iPBExit.TabStop = false;
            this.iPBExit.Click += new System.EventHandler(this.iPBExit_Click);
            this.iPBExit.MouseEnter += new System.EventHandler(this.iPBExit_MouseEnter);
            this.iPBExit.MouseLeave += new System.EventHandler(this.iPBExit_MouseLeave);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.BalloonTipText = "Don\'t worry the application is still running in system tray. Double click icon to" +
    " reopen!";
            this.NotifyIcon.BalloonTipTitle = "PSS Minimized";
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuNotify;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Primier Service Solutions";
            // 
            // ContextMenuNotify
            // 
            this.ContextMenuNotify.BackColor = System.Drawing.Color.White;
            this.ContextMenuNotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PSSToolStripMenuItem,
            this.toolStripSeparator4,
            this.openWindowToolStripMenuItem,
            this.minimizeToTaskBarToolStripMenuItem,
            this.aboutUpdateToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.ContextMenuNotify.Name = "ContextMenuNotify";
            this.ContextMenuNotify.ShowImageMargin = false;
            this.ContextMenuNotify.ShowItemToolTips = false;
            this.ContextMenuNotify.Size = new System.Drawing.Size(183, 124);
            // 
            // PSSToolStripMenuItem
            // 
            this.PSSToolStripMenuItem.Enabled = false;
            this.PSSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PSSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.PSSToolStripMenuItem.Name = "PSSToolStripMenuItem";
            this.PSSToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PSSToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.PSSToolStripMenuItem.Text = "Premier Service Solutions";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.openWindowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openWindowToolStripMenuItem.Image")));
            this.openWindowToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(182, 20);
            this.openWindowToolStripMenuItem.Text = "Open Window";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // minimizeToTaskBarToolStripMenuItem
            // 
            this.minimizeToTaskBarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimizeToTaskBarToolStripMenuItem.Name = "minimizeToTaskBarToolStripMenuItem";
            this.minimizeToTaskBarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.minimizeToTaskBarToolStripMenuItem.Text = "Minimize to TaskBar";
            // 
            // aboutUpdateToolStripMenuItem
            // 
            this.aboutUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutUpdateToolStripMenuItem.Name = "aboutUpdateToolStripMenuItem";
            this.aboutUpdateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutUpdateToolStripMenuItem.Text = "About/Update";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSignIn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(74, 202);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignIn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignIn.Size = new System.Drawing.Size(250, 40);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.TabStop = false;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextColor = System.Drawing.Color.White;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.iPBMinimize);
            this.Controls.Add(this.iPBExit);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreen_MouseUp);
            this.Resize += new System.EventHandler(this.frmLoginScreen_Resize);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBExit)).EndInit();
            this.ContextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblUserLogin;
        private CustomComponents.ButtonRound btnSignIn;
        private System.Windows.Forms.CheckBox cBRemeberMe;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblDontHaveAccount;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pBPass;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.TextBox tBPassword;
        private FontAwesome.Sharp.IconPictureBox iPBMinimize;
        private FontAwesome.Sharp.IconPictureBox iPBExit;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem PSSToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTaskBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}