
namespace PremierServiceSolutions.Pages
{
    partial class frmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            this.flpTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new BrbVideoManager.Controls.RoundedButton();
            this.btnMyOpenTickets = new BrbVideoManager.Controls.RoundedButton();
            this.btnAllMyTickets = new BrbVideoManager.Controls.RoundedButton();
            this.btnNewTickets = new BrbVideoManager.Controls.RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblIssueType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblClosed = new System.Windows.Forms.Label();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.lblTicketsToday = new System.Windows.Forms.Label();
            this.lblTickNumberHeading = new System.Windows.Forms.Label();
            this.lblCustomerHeading = new System.Windows.Forms.Label();
            this.lblIssueHeading = new System.Windows.Forms.Label();
            this.lblPriorityHeading = new System.Windows.Forms.Label();
            this.lblStatusHeading = new System.Windows.Forms.Label();
            this.lblTimeCreated = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cBTechnician = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cBStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cbIssueType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cbPriority = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBTechnician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIssueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTickets
            // 
            this.flpTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTickets.AutoScroll = true;
            this.flpTickets.BackColor = System.Drawing.Color.Transparent;
            this.flpTickets.Location = new System.Drawing.Point(12, 223);
            this.flpTickets.Name = "flpTickets";
            this.flpTickets.Size = new System.Drawing.Size(877, 505);
            this.flpTickets.TabIndex = 0;
            // 
            // lblTechnician
            // 
            this.lblTechnician.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTechnician.Location = new System.Drawing.Point(15, 14);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(108, 23);
            this.lblTechnician.TabIndex = 3;
            this.lblTechnician.Text = "Technician :";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(304, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnMyOpenTickets);
            this.panel1.Controls.Add(this.btnAllMyTickets);
            this.panel1.Controls.Add(this.btnNewTickets);
            this.panel1.Location = new System.Drawing.Point(13, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 65);
            this.panel1.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.BorderColor = System.Drawing.Color.Empty;
            this.btnReset.BorderDownColor = System.Drawing.Color.Empty;
            this.btnReset.BorderDownWidth = 0F;
            this.btnReset.BorderOverColor = System.Drawing.Color.Empty;
            this.btnReset.BorderOverWidth = 0F;
            this.btnReset.BorderRadius = 50;
            this.btnReset.BorderWidth = 1.75F;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(522, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnMyOpenTickets
            // 
            this.btnMyOpenTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMyOpenTickets.BorderColor = System.Drawing.Color.Empty;
            this.btnMyOpenTickets.BorderDownColor = System.Drawing.Color.Empty;
            this.btnMyOpenTickets.BorderDownWidth = 0F;
            this.btnMyOpenTickets.BorderOverColor = System.Drawing.Color.Empty;
            this.btnMyOpenTickets.BorderOverWidth = 0F;
            this.btnMyOpenTickets.BorderRadius = 50;
            this.btnMyOpenTickets.BorderWidth = 1.75F;
            this.btnMyOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOpenTickets.ForeColor = System.Drawing.Color.White;
            this.btnMyOpenTickets.Location = new System.Drawing.Point(359, 11);
            this.btnMyOpenTickets.Name = "btnMyOpenTickets";
            this.btnMyOpenTickets.Size = new System.Drawing.Size(135, 38);
            this.btnMyOpenTickets.TabIndex = 10;
            this.btnMyOpenTickets.Text = "My Open Tickets";
            this.btnMyOpenTickets.UseVisualStyleBackColor = false;
            // 
            // btnAllMyTickets
            // 
            this.btnAllMyTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAllMyTickets.BorderColor = System.Drawing.Color.Empty;
            this.btnAllMyTickets.BorderDownColor = System.Drawing.Color.Empty;
            this.btnAllMyTickets.BorderDownWidth = 0F;
            this.btnAllMyTickets.BorderOverColor = System.Drawing.Color.Empty;
            this.btnAllMyTickets.BorderOverWidth = 0F;
            this.btnAllMyTickets.BorderRadius = 50;
            this.btnAllMyTickets.BorderWidth = 1.75F;
            this.btnAllMyTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMyTickets.ForeColor = System.Drawing.Color.White;
            this.btnAllMyTickets.Location = new System.Drawing.Point(18, 11);
            this.btnAllMyTickets.Name = "btnAllMyTickets";
            this.btnAllMyTickets.Size = new System.Drawing.Size(135, 38);
            this.btnAllMyTickets.TabIndex = 9;
            this.btnAllMyTickets.Text = "All My Tickets";
            this.btnAllMyTickets.UseVisualStyleBackColor = false;
            // 
            // btnNewTickets
            // 
            this.btnNewTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTickets.BorderColor = System.Drawing.Color.Empty;
            this.btnNewTickets.BorderDownColor = System.Drawing.Color.Empty;
            this.btnNewTickets.BorderDownWidth = 0F;
            this.btnNewTickets.BorderOverColor = System.Drawing.Color.Empty;
            this.btnNewTickets.BorderOverWidth = 0F;
            this.btnNewTickets.BorderRadius = 50;
            this.btnNewTickets.BorderWidth = 1.75F;
            this.btnNewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTickets.ForeColor = System.Drawing.Color.White;
            this.btnNewTickets.Location = new System.Drawing.Point(184, 11);
            this.btnNewTickets.Name = "btnNewTickets";
            this.btnNewTickets.Size = new System.Drawing.Size(135, 38);
            this.btnNewTickets.TabIndex = 8;
            this.btnNewTickets.Text = "New Tickets";
            this.btnNewTickets.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbPriority);
            this.panel2.Controls.Add(this.cbIssueType);
            this.panel2.Controls.Add(this.cBStatus);
            this.panel2.Controls.Add(this.cBTechnician);
            this.panel2.Controls.Add(this.lblPriority);
            this.panel2.Controls.Add(this.lblIssueType);
            this.panel2.Controls.Add(this.lblTechnician);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 10;
            // 
            // lblPriority
            // 
            this.lblPriority.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPriority.Location = new System.Drawing.Point(15, 58);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(100, 23);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Priority :";
            // 
            // lblIssueType
            // 
            this.lblIssueType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIssueType.Location = new System.Drawing.Point(304, 58);
            this.lblIssueType.Name = "lblIssueType";
            this.lblIssueType.Size = new System.Drawing.Size(107, 23);
            this.lblIssueType.TabIndex = 11;
            this.lblIssueType.Text = "Issue Type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblClosed);
            this.panel3.Controls.Add(this.lblUnassigned);
            this.panel3.Controls.Add(this.lblTicketsToday);
            this.panel3.Location = new System.Drawing.Point(704, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 159);
            this.panel3.TabIndex = 11;
            // 
            // lblClosed
            // 
            this.lblClosed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClosed.Location = new System.Drawing.Point(3, 95);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(182, 23);
            this.lblClosed.TabIndex = 10;
            this.lblClosed.Text = "Tickets Closed : 00";
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnassigned.Location = new System.Drawing.Point(3, 56);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(182, 23);
            this.lblUnassigned.TabIndex = 9;
            this.lblUnassigned.Text = "Unassigned : 00";
            // 
            // lblTicketsToday
            // 
            this.lblTicketsToday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTicketsToday.Location = new System.Drawing.Point(3, 15);
            this.lblTicketsToday.Name = "lblTicketsToday";
            this.lblTicketsToday.Size = new System.Drawing.Size(182, 23);
            this.lblTicketsToday.TabIndex = 8;
            this.lblTicketsToday.Text = "Tickets Today : 00";
            // 
            // lblTickNumberHeading
            // 
            this.lblTickNumberHeading.AutoSize = true;
            this.lblTickNumberHeading.BackColor = System.Drawing.Color.White;
            this.lblTickNumberHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickNumberHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickNumberHeading.Location = new System.Drawing.Point(25, 4);
            this.lblTickNumberHeading.Name = "lblTickNumberHeading";
            this.lblTickNumberHeading.Size = new System.Drawing.Size(20, 19);
            this.lblTickNumberHeading.TabIndex = 12;
            this.lblTickNumberHeading.Text = "#";
            // 
            // lblCustomerHeading
            // 
            this.lblCustomerHeading.AutoSize = true;
            this.lblCustomerHeading.BackColor = System.Drawing.Color.White;
            this.lblCustomerHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerHeading.Location = new System.Drawing.Point(184, 4);
            this.lblCustomerHeading.Name = "lblCustomerHeading";
            this.lblCustomerHeading.Size = new System.Drawing.Size(89, 19);
            this.lblCustomerHeading.TabIndex = 13;
            this.lblCustomerHeading.Text = "Customer";
            // 
            // lblIssueHeading
            // 
            this.lblIssueHeading.AutoSize = true;
            this.lblIssueHeading.BackColor = System.Drawing.Color.White;
            this.lblIssueHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIssueHeading.Location = new System.Drawing.Point(315, 4);
            this.lblIssueHeading.Name = "lblIssueHeading";
            this.lblIssueHeading.Size = new System.Drawing.Size(96, 19);
            this.lblIssueHeading.TabIndex = 14;
            this.lblIssueHeading.Text = "Issue Type";
            // 
            // lblPriorityHeading
            // 
            this.lblPriorityHeading.AutoSize = true;
            this.lblPriorityHeading.BackColor = System.Drawing.Color.White;
            this.lblPriorityHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPriorityHeading.Location = new System.Drawing.Point(417, 4);
            this.lblPriorityHeading.Name = "lblPriorityHeading";
            this.lblPriorityHeading.Size = new System.Drawing.Size(71, 19);
            this.lblPriorityHeading.TabIndex = 15;
            this.lblPriorityHeading.Text = "Priority";
            // 
            // lblStatusHeading
            // 
            this.lblStatusHeading.AutoSize = true;
            this.lblStatusHeading.BackColor = System.Drawing.Color.White;
            this.lblStatusHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusHeading.Location = new System.Drawing.Point(551, 4);
            this.lblStatusHeading.Name = "lblStatusHeading";
            this.lblStatusHeading.Size = new System.Drawing.Size(62, 19);
            this.lblStatusHeading.TabIndex = 16;
            this.lblStatusHeading.Text = "Status";
            // 
            // lblTimeCreated
            // 
            this.lblTimeCreated.AutoSize = true;
            this.lblTimeCreated.BackColor = System.Drawing.Color.White;
            this.lblTimeCreated.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeCreated.Location = new System.Drawing.Point(702, 4);
            this.lblTimeCreated.Name = "lblTimeCreated";
            this.lblTimeCreated.Size = new System.Drawing.Size(119, 19);
            this.lblTimeCreated.TabIndex = 17;
            this.lblTimeCreated.Text = "Time Created";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(51, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 19);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Ticket Title";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.lblTimeCreated);
            this.panel4.Controls.Add(this.lblTickNumberHeading);
            this.panel4.Controls.Add(this.lblStatusHeading);
            this.panel4.Controls.Add(this.lblCustomerHeading);
            this.panel4.Controls.Add(this.lblPriorityHeading);
            this.panel4.Controls.Add(this.lblIssueHeading);
            this.panel4.Location = new System.Drawing.Point(13, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 35);
            this.panel4.TabIndex = 19;
            // 
            // cBTechnician
            // 
            this.cBTechnician.AllowDropDownResize = false;
            this.cBTechnician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cBTechnician.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cBTechnician.Location = new System.Drawing.Point(118, 14);
            this.cBTechnician.Name = "cBTechnician";
            this.cBTechnician.ShowToolTip = true;
            this.cBTechnician.Size = new System.Drawing.Size(180, 25);
            this.cBTechnician.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBTechnician.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBTechnician.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBTechnician.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cBTechnician.TabIndex = 12;
            // 
            // cBStatus
            // 
            this.cBStatus.AllowDropDownResize = false;
            this.cBStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cBStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cBStatus.Location = new System.Drawing.Point(382, 14);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.ShowToolTip = true;
            this.cBStatus.Size = new System.Drawing.Size(180, 25);
            this.cBStatus.Style.ClearButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBStatus.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBStatus.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cBStatus.TabIndex = 13;
            // 
            // cbIssueType
            // 
            this.cbIssueType.AllowDropDownResize = false;
            this.cbIssueType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbIssueType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbIssueType.Location = new System.Drawing.Point(407, 56);
            this.cbIssueType.Name = "cbIssueType";
            this.cbIssueType.ShowToolTip = true;
            this.cbIssueType.Size = new System.Drawing.Size(180, 25);
            this.cbIssueType.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIssueType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIssueType.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIssueType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbIssueType.TabIndex = 14;
            // 
            // cbPriority
            // 
            this.cbPriority.AllowDropDownResize = false;
            this.cbPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbPriority.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbPriority.Location = new System.Drawing.Point(94, 56);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.ShowToolTip = true;
            this.cbPriority.Size = new System.Drawing.Size(180, 25);
            this.cbPriority.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPriority.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPriority.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPriority.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPriority.TabIndex = 15;
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTickets);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTickets";
            this.Text = "Tickets";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBTechnician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIssueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTickets;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblStatus;
        private BrbVideoManager.Controls.RoundedButton btnNewTickets;
        private System.Windows.Forms.Panel panel1;
        private BrbVideoManager.Controls.RoundedButton btnAllMyTickets;
        private BrbVideoManager.Controls.RoundedButton btnReset;
        private BrbVideoManager.Controls.RoundedButton btnMyOpenTickets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClosed;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.Label lblTicketsToday;
        private System.Windows.Forms.Label lblTickNumberHeading;
        private System.Windows.Forms.Label lblCustomerHeading;
        private System.Windows.Forms.Label lblIssueHeading;
        private System.Windows.Forms.Label lblPriorityHeading;
        private System.Windows.Forms.Label lblStatusHeading;
        private System.Windows.Forms.Label lblTimeCreated;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.WinForms.ListView.SfComboBox cbPriority;
        private Syncfusion.WinForms.ListView.SfComboBox cbIssueType;
        private Syncfusion.WinForms.ListView.SfComboBox cBStatus;
        private Syncfusion.WinForms.ListView.SfComboBox cBTechnician;
    }
}