
namespace PremierServiceSolutions.Pages
{
    partial class frmTechnician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnician));
            this.pnlSearchHeadings = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCustomerHeading = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.flpTechnician = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopTechnician = new System.Windows.Forms.Panel();
            this.tBSearch = new PremierServiceSolutions.CustomComponents.Round_TextBox();
            this.iPBSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddTechnician = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pnlSearchHeadings.SuspendLayout();
            this.pnlTopTechnician.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchHeadings
            // 
            this.pnlSearchHeadings.BackColor = System.Drawing.Color.White;
            this.pnlSearchHeadings.Controls.Add(this.lblEmail);
            this.pnlSearchHeadings.Controls.Add(this.lblStatus);
            this.pnlSearchHeadings.Controls.Add(this.lblID);
            this.pnlSearchHeadings.Controls.Add(this.lblCustomerHeading);
            this.pnlSearchHeadings.Controls.Add(this.lblLevel);
            this.pnlSearchHeadings.Location = new System.Drawing.Point(5, 87);
            this.pnlSearchHeadings.Name = "pnlSearchHeadings";
            this.pnlSearchHeadings.Size = new System.Drawing.Size(883, 35);
            this.pnlSearchHeadings.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(678, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(455, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 19);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(7, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 19);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "Tech ID";
            // 
            // lblCustomerHeading
            // 
            this.lblCustomerHeading.AutoSize = true;
            this.lblCustomerHeading.BackColor = System.Drawing.Color.White;
            this.lblCustomerHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerHeading.Location = new System.Drawing.Point(115, 8);
            this.lblCustomerHeading.Name = "lblCustomerHeading";
            this.lblCustomerHeading.Size = new System.Drawing.Size(97, 19);
            this.lblCustomerHeading.TabIndex = 13;
            this.lblCustomerHeading.Text = "First Name";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.White;
            this.lblLevel.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLevel.Location = new System.Drawing.Point(315, 8);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(53, 19);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "Level";
            // 
            // flpTechnician
            // 
            this.flpTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpTechnician.AutoScroll = true;
            this.flpTechnician.BackColor = System.Drawing.Color.Transparent;
            this.flpTechnician.Location = new System.Drawing.Point(5, 132);
            this.flpTechnician.Name = "flpTechnician";
            this.flpTechnician.Size = new System.Drawing.Size(883, 607);
            this.flpTechnician.TabIndex = 28;
            // 
            // pnlTopTechnician
            // 
            this.pnlTopTechnician.BackColor = System.Drawing.Color.White;
            this.pnlTopTechnician.Controls.Add(this.tBSearch);
            this.pnlTopTechnician.Controls.Add(this.iPBSearch);
            this.pnlTopTechnician.Controls.Add(this.btnAddTechnician);
            this.pnlTopTechnician.Location = new System.Drawing.Point(5, 12);
            this.pnlTopTechnician.Name = "pnlTopTechnician";
            this.pnlTopTechnician.Size = new System.Drawing.Size(883, 69);
            this.pnlTopTechnician.TabIndex = 27;
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.tBSearch.Location = new System.Drawing.Point(54, 20);
            this.tBSearch.Multiline = true;
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(419, 31);
            this.tBSearch.TabIndex = 51;
            this.tBSearch.Text = "Start Typing TechnicianID/Technician Name";
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            this.tBSearch.Enter += new System.EventHandler(this.tBSearch_Enter);
            this.tBSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBSearch_KeyDown);
            this.tBSearch.Leave += new System.EventHandler(this.tBSearch_Leave);
            // 
            // iPBSearch
            // 
            this.iPBSearch.BackColor = System.Drawing.Color.White;
            this.iPBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.iPBSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iPBSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.iPBSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBSearch.Location = new System.Drawing.Point(16, 15);
            this.iPBSearch.Name = "iPBSearch";
            this.iPBSearch.Size = new System.Drawing.Size(32, 40);
            this.iPBSearch.TabIndex = 52;
            this.iPBSearch.TabStop = false;
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddTechnician.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddTechnician.FlatAppearance.BorderSize = 0;
            this.btnAddTechnician.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddTechnician.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTechnician.Location = new System.Drawing.Point(682, 14);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddTechnician.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddTechnician.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddTechnician.Size = new System.Drawing.Size(185, 40);
            this.btnAddTechnician.TabIndex = 53;
            this.btnAddTechnician.TabStop = false;
            this.btnAddTechnician.Text = "New Technician +";
            this.btnAddTechnician.TextColor = System.Drawing.Color.White;
            this.btnAddTechnician.UseVisualStyleBackColor = true;
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.pnlSearchHeadings);
            this.Controls.Add(this.flpTechnician);
            this.Controls.Add(this.pnlTopTechnician);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTechnician";
            this.Text = "frmTechnician";
            this.pnlSearchHeadings.ResumeLayout(false);
            this.pnlSearchHeadings.PerformLayout();
            this.pnlTopTechnician.ResumeLayout(false);
            this.pnlTopTechnician.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchHeadings;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCustomerHeading;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.FlowLayoutPanel flpTechnician;
        private System.Windows.Forms.Panel pnlTopTechnician;
        private CustomComponents.Round_TextBox tBSearch;
        private FontAwesome.Sharp.IconPictureBox iPBSearch;
        private CustomComponents.ButtonRound btnAddTechnician;
    }
}