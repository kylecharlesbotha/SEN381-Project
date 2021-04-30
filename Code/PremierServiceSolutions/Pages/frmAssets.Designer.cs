
namespace PremierServiceSolutions.Pages
{
    partial class frmAssets
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
            this.pnlSearchHeadings = new System.Windows.Forms.Panel();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerHeading = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.flpAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopAssets = new System.Windows.Forms.Panel();
            this.tBSearch = new PremierServiceSolutions.CustomComponents.Round_TextBox();
            this.iPBSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddAsset = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pnlSearchHeadings.SuspendLayout();
            this.pnlTopAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchHeadings
            // 
            this.pnlSearchHeadings.BackColor = System.Drawing.Color.White;
            this.pnlSearchHeadings.Controls.Add(this.lblSerial);
            this.pnlSearchHeadings.Controls.Add(this.lblModel);
            this.pnlSearchHeadings.Controls.Add(this.lblName);
            this.pnlSearchHeadings.Controls.Add(this.lblCustomerHeading);
            this.pnlSearchHeadings.Controls.Add(this.lblMan);
            this.pnlSearchHeadings.Location = new System.Drawing.Point(9, 83);
            this.pnlSearchHeadings.Name = "pnlSearchHeadings";
            this.pnlSearchHeadings.Size = new System.Drawing.Size(883, 35);
            this.pnlSearchHeadings.TabIndex = 23;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.BackColor = System.Drawing.Color.White;
            this.lblSerial.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSerial.Location = new System.Drawing.Point(755, 8);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(56, 19);
            this.lblSerial.TabIndex = 16;
            this.lblSerial.Text = "Serial";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModel.Location = new System.Drawing.Point(555, 8);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 19);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "Model";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(32, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblCustomerHeading
            // 
            this.lblCustomerHeading.AutoSize = true;
            this.lblCustomerHeading.BackColor = System.Drawing.Color.White;
            this.lblCustomerHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerHeading.Location = new System.Drawing.Point(170, 8);
            this.lblCustomerHeading.Name = "lblCustomerHeading";
            this.lblCustomerHeading.Size = new System.Drawing.Size(89, 19);
            this.lblCustomerHeading.TabIndex = 13;
            this.lblCustomerHeading.Text = "Customer";
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.BackColor = System.Drawing.Color.White;
            this.lblMan.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMan.Location = new System.Drawing.Point(344, 8);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(119, 19);
            this.lblMan.TabIndex = 14;
            this.lblMan.Text = "Manufacturer";
            // 
            // flpAssets
            // 
            this.flpAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpAssets.AutoScroll = true;
            this.flpAssets.BackColor = System.Drawing.Color.Transparent;
            this.flpAssets.Location = new System.Drawing.Point(9, 126);
            this.flpAssets.Name = "flpAssets";
            this.flpAssets.Size = new System.Drawing.Size(883, 607);
            this.flpAssets.TabIndex = 22;
            // 
            // pnlTopAssets
            // 
            this.pnlTopAssets.BackColor = System.Drawing.Color.White;
            this.pnlTopAssets.Controls.Add(this.tBSearch);
            this.pnlTopAssets.Controls.Add(this.iPBSearch);
            this.pnlTopAssets.Controls.Add(this.btnAddAsset);
            this.pnlTopAssets.Location = new System.Drawing.Point(9, 8);
            this.pnlTopAssets.Name = "pnlTopAssets";
            this.pnlTopAssets.Size = new System.Drawing.Size(883, 69);
            this.pnlTopAssets.TabIndex = 21;
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
            this.tBSearch.Text = "Start Typing Asset Name/Model or Serial";
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
            // btnAddAsset
            // 
            this.btnAddAsset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddAsset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddAsset.FlatAppearance.BorderSize = 0;
            this.btnAddAsset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAsset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAsset.Location = new System.Drawing.Point(682, 14);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddAsset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddAsset.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddAsset.Size = new System.Drawing.Size(185, 40);
            this.btnAddAsset.TabIndex = 53;
            this.btnAddAsset.TabStop = false;
            this.btnAddAsset.Text = "New Asset +";
            this.btnAddAsset.TextColor = System.Drawing.Color.White;
            this.btnAddAsset.UseVisualStyleBackColor = true;
            // 
            // frmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.pnlSearchHeadings);
            this.Controls.Add(this.flpAssets);
            this.Controls.Add(this.pnlTopAssets);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssets";
            this.Text = "frmAssets";
            this.pnlSearchHeadings.ResumeLayout(false);
            this.pnlSearchHeadings.PerformLayout();
            this.pnlTopAssets.ResumeLayout(false);
            this.pnlTopAssets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchHeadings;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerHeading;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.FlowLayoutPanel flpAssets;
        private System.Windows.Forms.Panel pnlTopAssets;
        private CustomComponents.Round_TextBox tBSearch;
        private FontAwesome.Sharp.IconPictureBox iPBSearch;
        private CustomComponents.ButtonRound btnAddAsset;
    }
}