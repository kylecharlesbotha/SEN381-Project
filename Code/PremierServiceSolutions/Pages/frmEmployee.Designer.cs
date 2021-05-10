
namespace PremierServiceSolutions.Pages
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pnlSearchHeadings = new System.Windows.Forms.Panel();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFistName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.flpEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopEmployee = new System.Windows.Forms.Panel();
            this.iPBSearch = new FontAwesome.Sharp.IconPictureBox();
            this.tBSearch = new PremierServiceSolutions.CustomComponents.Round_TextBox();
            this.btnAddEmployee = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pnlSearchHeadings.SuspendLayout();
            this.pnlTopEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchHeadings
            // 
            this.pnlSearchHeadings.BackColor = System.Drawing.Color.White;
            this.pnlSearchHeadings.Controls.Add(this.lblEmailAdd);
            this.pnlSearchHeadings.Controls.Add(this.lblRole);
            this.pnlSearchHeadings.Controls.Add(this.lblID);
            this.pnlSearchHeadings.Controls.Add(this.lblFistName);
            this.pnlSearchHeadings.Controls.Add(this.lblSecondName);
            this.pnlSearchHeadings.Location = new System.Drawing.Point(9, 83);
            this.pnlSearchHeadings.Name = "pnlSearchHeadings";
            this.pnlSearchHeadings.Size = new System.Drawing.Size(883, 35);
            this.pnlSearchHeadings.TabIndex = 29;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.BackColor = System.Drawing.Color.White;
            this.lblEmailAdd.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmailAdd.Location = new System.Drawing.Point(631, 8);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(124, 19);
            this.lblEmailAdd.TabIndex = 16;
            this.lblEmailAdd.Text = "Email Address";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.White;
            this.lblRole.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRole.Location = new System.Drawing.Point(458, 8);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(45, 19);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(12, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 19);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // lblFistName
            // 
            this.lblFistName.AutoSize = true;
            this.lblFistName.BackColor = System.Drawing.Color.White;
            this.lblFistName.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFistName.Location = new System.Drawing.Point(126, 8);
            this.lblFistName.Name = "lblFistName";
            this.lblFistName.Size = new System.Drawing.Size(97, 19);
            this.lblFistName.TabIndex = 13;
            this.lblFistName.Text = "First Name";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.BackColor = System.Drawing.Color.White;
            this.lblSecondName.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSecondName.Location = new System.Drawing.Point(286, 8);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(94, 19);
            this.lblSecondName.TabIndex = 14;
            this.lblSecondName.Text = "Last Name";
            // 
            // flpEmployee
            // 
            this.flpEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpEmployee.AutoScroll = true;
            this.flpEmployee.BackColor = System.Drawing.Color.Transparent;
            this.flpEmployee.Location = new System.Drawing.Point(9, 126);
            this.flpEmployee.Name = "flpEmployee";
            this.flpEmployee.Size = new System.Drawing.Size(883, 607);
            this.flpEmployee.TabIndex = 28;
            // 
            // pnlTopEmployee
            // 
            this.pnlTopEmployee.BackColor = System.Drawing.Color.White;
            this.pnlTopEmployee.Controls.Add(this.tBSearch);
            this.pnlTopEmployee.Controls.Add(this.iPBSearch);
            this.pnlTopEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlTopEmployee.Location = new System.Drawing.Point(9, 8);
            this.pnlTopEmployee.Name = "pnlTopEmployee";
            this.pnlTopEmployee.Size = new System.Drawing.Size(883, 69);
            this.pnlTopEmployee.TabIndex = 27;
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
            this.tBSearch.Text = "Start Typing EmployeeID/EmployeeName";
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            this.tBSearch.Enter += new System.EventHandler(this.tBSearch_Enter);
            this.tBSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBSearch_KeyDown);
            this.tBSearch.Leave += new System.EventHandler(this.tBSearch_Leave);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddEmployee.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(682, 14);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddEmployee.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddEmployee.Size = new System.Drawing.Size(185, 40);
            this.btnAddEmployee.TabIndex = 53;
            this.btnAddEmployee.TabStop = false;
            this.btnAddEmployee.Text = "New Employee +";
            this.btnAddEmployee.TextColor = System.Drawing.Color.White;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.pnlSearchHeadings);
            this.Controls.Add(this.flpEmployee);
            this.Controls.Add(this.pnlTopEmployee);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.pnlSearchHeadings.ResumeLayout(false);
            this.pnlSearchHeadings.PerformLayout();
            this.pnlTopEmployee.ResumeLayout(false);
            this.pnlTopEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchHeadings;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFistName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.FlowLayoutPanel flpEmployee;
        private System.Windows.Forms.Panel pnlTopEmployee;
        private CustomComponents.Round_TextBox tBSearch;
        private FontAwesome.Sharp.IconPictureBox iPBSearch;
        private CustomComponents.ButtonRound btnAddEmployee;
    }
}