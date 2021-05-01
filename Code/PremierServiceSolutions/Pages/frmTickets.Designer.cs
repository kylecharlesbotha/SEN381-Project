
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPriority = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cbIssueType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cBStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cBTechnician = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblIssueType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblClosed = new System.Windows.Forms.Label();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.lblTicketsToday = new System.Windows.Forms.Label();
            this.pnlTicketDetials = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCreated = new System.Windows.Forms.Label();
            this.tbTicLogged = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.tbTickDateDue = new System.Windows.Forms.TextBox();
            this.lblTickPriority = new System.Windows.Forms.Label();
            this.tbTickPriority = new System.Windows.Forms.TextBox();
            this.sfTickStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblTickStatus = new System.Windows.Forms.Label();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.lblTickTec = new System.Windows.Forms.Label();
            this.sfTechCombo = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.tbTicketID = new System.Windows.Forms.TextBox();
            this.rtbDesctiption = new System.Windows.Forms.RichTextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbClientBusName = new System.Windows.Forms.TextBox();
            this.lblTicTitle = new System.Windows.Forms.Label();
            this.tbTickTitle = new System.Windows.Forms.TextBox();
            this.lblTickIssue = new System.Windows.Forms.Label();
            this.tbTickIssue = new System.Windows.Forms.TextBox();
            this.btnSaveChanged = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.btnEsculate = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.btnClose = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.btnReset = new BrbVideoManager.Controls.RoundedButton();
            this.btnMyOpenTickets = new BrbVideoManager.Controls.RoundedButton();
            this.btnAllMyTickets = new BrbVideoManager.Controls.RoundedButton();
            this.btnNewTickets = new BrbVideoManager.Controls.RoundedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIssueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTechnician)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlTicketDetials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfTickStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfTechCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTickets
            // 
            this.flpTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpTickets.AutoScroll = true;
            this.flpTickets.BackColor = System.Drawing.Color.Transparent;
            this.flpTickets.Location = new System.Drawing.Point(12, 178);
            this.flpTickets.Name = "flpTickets";
            this.flpTickets.Size = new System.Drawing.Size(877, 550);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnMyOpenTickets);
            this.panel1.Controls.Add(this.btnAllMyTickets);
            this.panel1.Controls.Add(this.btnNewTickets);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 65);
            this.panel1.TabIndex = 9;
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
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 10;
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
            this.panel3.Location = new System.Drawing.Point(705, 12);
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
            // pnlTicketDetials
            // 
            this.pnlTicketDetials.AutoScroll = true;
            this.pnlTicketDetials.Controls.Add(this.lblTickIssue);
            this.pnlTicketDetials.Controls.Add(this.tbTickIssue);
            this.pnlTicketDetials.Controls.Add(this.lblTicTitle);
            this.pnlTicketDetials.Controls.Add(this.tbTickTitle);
            this.pnlTicketDetials.Controls.Add(this.btnSaveChanged);
            this.pnlTicketDetials.Controls.Add(this.btnEsculate);
            this.pnlTicketDetials.Controls.Add(this.btnClose);
            this.pnlTicketDetials.Controls.Add(this.panel4);
            this.pnlTicketDetials.Controls.Add(this.lblCreated);
            this.pnlTicketDetials.Controls.Add(this.tbTicLogged);
            this.pnlTicketDetials.Controls.Add(this.lblDueDate);
            this.pnlTicketDetials.Controls.Add(this.tbTickDateDue);
            this.pnlTicketDetials.Controls.Add(this.lblTickPriority);
            this.pnlTicketDetials.Controls.Add(this.tbTickPriority);
            this.pnlTicketDetials.Controls.Add(this.sfTickStatus);
            this.pnlTicketDetials.Controls.Add(this.lblTickStatus);
            this.pnlTicketDetials.Controls.Add(this.pnlDivider2);
            this.pnlTicketDetials.Controls.Add(this.pnlDivider);
            this.pnlTicketDetials.Controls.Add(this.lblTicketDetails);
            this.pnlTicketDetials.Controls.Add(this.lblTickTec);
            this.pnlTicketDetials.Controls.Add(this.sfTechCombo);
            this.pnlTicketDetials.Controls.Add(this.lblTicketID);
            this.pnlTicketDetials.Controls.Add(this.tbTicketID);
            this.pnlTicketDetials.Controls.Add(this.rtbDesctiption);
            this.pnlTicketDetials.Controls.Add(this.lblDes);
            this.pnlTicketDetials.Controls.Add(this.lblClient);
            this.pnlTicketDetials.Controls.Add(this.tbClientBusName);
            this.pnlTicketDetials.Location = new System.Drawing.Point(951, 178);
            this.pnlTicketDetials.Name = "pnlTicketDetials";
            this.pnlTicketDetials.Size = new System.Drawing.Size(877, 550);
            this.pnlTicketDetials.TabIndex = 13;
            this.pnlTicketDetials.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(15, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 2);
            this.panel4.TabIndex = 74;
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreated.Location = new System.Drawing.Point(412, 294);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(102, 25);
            this.lblCreated.TabIndex = 73;
            this.lblCreated.Text = "Logged  :";
            // 
            // tbTicLogged
            // 
            this.tbTicLogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTicLogged.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicLogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTicLogged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTicLogged.Location = new System.Drawing.Point(520, 293);
            this.tbTicLogged.Multiline = true;
            this.tbTicLogged.Name = "tbTicLogged";
            this.tbTicLogged.ReadOnly = true;
            this.tbTicLogged.Size = new System.Drawing.Size(306, 30);
            this.tbTicLogged.TabIndex = 72;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDueDate.Location = new System.Drawing.Point(61, 296);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(114, 25);
            this.lblDueDate.TabIndex = 71;
            this.lblDueDate.Text = "Due Date :";
            // 
            // tbTickDateDue
            // 
            this.tbTickDateDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTickDateDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTickDateDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTickDateDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTickDateDue.Location = new System.Drawing.Point(181, 295);
            this.tbTickDateDue.Multiline = true;
            this.tbTickDateDue.Name = "tbTickDateDue";
            this.tbTickDateDue.ReadOnly = true;
            this.tbTickDateDue.Size = new System.Drawing.Size(195, 30);
            this.tbTickDateDue.TabIndex = 70;
            // 
            // lblTickPriority
            // 
            this.lblTickPriority.AutoSize = true;
            this.lblTickPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickPriority.Location = new System.Drawing.Point(61, 237);
            this.lblTickPriority.Name = "lblTickPriority";
            this.lblTickPriority.Size = new System.Drawing.Size(91, 25);
            this.lblTickPriority.TabIndex = 67;
            this.lblTickPriority.Text = "Priority :";
            // 
            // tbTickPriority
            // 
            this.tbTickPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTickPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTickPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTickPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTickPriority.Location = new System.Drawing.Point(158, 236);
            this.tbTickPriority.Multiline = true;
            this.tbTickPriority.Name = "tbTickPriority";
            this.tbTickPriority.ReadOnly = true;
            this.tbTickPriority.Size = new System.Drawing.Size(218, 30);
            this.tbTickPriority.TabIndex = 66;
            // 
            // sfTickStatus
            // 
            this.sfTickStatus.AllowDropDownResize = false;
            this.sfTickStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sfTickStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfTickStatus.Location = new System.Drawing.Point(162, 384);
            this.sfTickStatus.Name = "sfTickStatus";
            this.sfTickStatus.ShowToolTip = true;
            this.sfTickStatus.Size = new System.Drawing.Size(214, 25);
            this.sfTickStatus.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTickStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTickStatus.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTickStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfTickStatus.TabIndex = 65;
            // 
            // lblTickStatus
            // 
            this.lblTickStatus.AutoSize = true;
            this.lblTickStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickStatus.Location = new System.Drawing.Point(61, 384);
            this.lblTickStatus.Name = "lblTickStatus";
            this.lblTickStatus.Size = new System.Drawing.Size(91, 25);
            this.lblTickStatus.TabIndex = 64;
            this.lblTickStatus.Text = "Status  :";
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDivider2.Location = new System.Drawing.Point(15, 460);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(847, 2);
            this.pnlDivider2.TabIndex = 62;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDivider.Location = new System.Drawing.Point(15, 55);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(847, 2);
            this.pnlDivider.TabIndex = 61;
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.AutoSize = true;
            this.lblTicketDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTicketDetails.Location = new System.Drawing.Point(60, 13);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(193, 31);
            this.lblTicketDetails.TabIndex = 60;
            this.lblTicketDetails.Text = "Ticket Details";
            // 
            // lblTickTec
            // 
            this.lblTickTec.AutoSize = true;
            this.lblTickTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickTec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickTec.Location = new System.Drawing.Point(385, 384);
            this.lblTickTec.Name = "lblTickTec";
            this.lblTickTec.Size = new System.Drawing.Size(129, 25);
            this.lblTickTec.TabIndex = 37;
            this.lblTickTec.Text = "Technician :";
            // 
            // sfTechCombo
            // 
            this.sfTechCombo.AllowDropDownResize = false;
            this.sfTechCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sfTechCombo.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfTechCombo.Location = new System.Drawing.Point(520, 384);
            this.sfTechCombo.Name = "sfTechCombo";
            this.sfTechCombo.ShowToolTip = true;
            this.sfTechCombo.Size = new System.Drawing.Size(306, 25);
            this.sfTechCombo.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTechCombo.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTechCombo.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfTechCombo.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfTechCombo.TabIndex = 36;
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTicketID.Location = new System.Drawing.Point(61, 79);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(163, 25);
            this.lblTicketID.TabIndex = 35;
            this.lblTicketID.Text = "Ticket Number :";
            // 
            // tbTicketID
            // 
            this.tbTicketID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTicketID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTicketID.Location = new System.Drawing.Point(230, 76);
            this.tbTicketID.Multiline = true;
            this.tbTicketID.Name = "tbTicketID";
            this.tbTicketID.ReadOnly = true;
            this.tbTicketID.Size = new System.Drawing.Size(146, 30);
            this.tbTicketID.TabIndex = 34;
            // 
            // rtbDesctiption
            // 
            this.rtbDesctiption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.rtbDesctiption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDesctiption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesctiption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtbDesctiption.Location = new System.Drawing.Point(523, 134);
            this.rtbDesctiption.Name = "rtbDesctiption";
            this.rtbDesctiption.ReadOnly = true;
            this.rtbDesctiption.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDesctiption.Size = new System.Drawing.Size(303, 132);
            this.rtbDesctiption.TabIndex = 33;
            this.rtbDesctiption.Text = "";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDes.Location = new System.Drawing.Point(385, 137);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(132, 25);
            this.lblDes.TabIndex = 32;
            this.lblDes.Text = "Description :";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClient.Location = new System.Drawing.Point(61, 137);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(79, 25);
            this.lblClient.TabIndex = 28;
            this.lblClient.Text = "Client :";
            // 
            // tbClientBusName
            // 
            this.tbClientBusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbClientBusName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClientBusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbClientBusName.Location = new System.Drawing.Point(146, 136);
            this.tbClientBusName.Multiline = true;
            this.tbClientBusName.Name = "tbClientBusName";
            this.tbClientBusName.ReadOnly = true;
            this.tbClientBusName.Size = new System.Drawing.Size(230, 30);
            this.tbClientBusName.TabIndex = 27;
            // 
            // lblTicTitle
            // 
            this.lblTicTitle.AutoSize = true;
            this.lblTicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTicTitle.Location = new System.Drawing.Point(449, 75);
            this.lblTicTitle.Name = "lblTicTitle";
            this.lblTicTitle.Size = new System.Drawing.Size(65, 25);
            this.lblTicTitle.TabIndex = 80;
            this.lblTicTitle.Text = "Title :";
            // 
            // tbTickTitle
            // 
            this.tbTickTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTickTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTickTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTickTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTickTitle.Location = new System.Drawing.Point(520, 74);
            this.tbTickTitle.Multiline = true;
            this.tbTickTitle.Name = "tbTickTitle";
            this.tbTickTitle.ReadOnly = true;
            this.tbTickTitle.Size = new System.Drawing.Size(306, 30);
            this.tbTickTitle.TabIndex = 79;
            // 
            // lblTickIssue
            // 
            this.lblTickIssue.AutoSize = true;
            this.lblTickIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickIssue.Location = new System.Drawing.Point(61, 185);
            this.lblTickIssue.Name = "lblTickIssue";
            this.lblTickIssue.Size = new System.Drawing.Size(129, 25);
            this.lblTickIssue.TabIndex = 82;
            this.lblTickIssue.Text = "Issue Type :";
            // 
            // tbTickIssue
            // 
            this.tbTickIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbTickIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTickIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTickIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbTickIssue.Location = new System.Drawing.Point(196, 184);
            this.tbTickIssue.Multiline = true;
            this.tbTickIssue.Name = "tbTickIssue";
            this.tbTickIssue.ReadOnly = true;
            this.tbTickIssue.Size = new System.Drawing.Size(180, 30);
            this.tbTickIssue.TabIndex = 81;
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnSaveChanged.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnSaveChanged.FlatAppearance.BorderSize = 0;
            this.btnSaveChanged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanged.Location = new System.Drawing.Point(708, 481);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveChanged.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveChanged.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveChanged.Size = new System.Drawing.Size(154, 36);
            this.btnSaveChanged.TabIndex = 78;
            this.btnSaveChanged.Text = "Save Changes";
            this.btnSaveChanged.TextColor = System.Drawing.Color.White;
            this.btnSaveChanged.UseVisualStyleBackColor = true;
            // 
            // btnEsculate
            // 
            this.btnEsculate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnEsculate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnEsculate.FlatAppearance.BorderSize = 0;
            this.btnEsculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsculate.Location = new System.Drawing.Point(363, 481);
            this.btnEsculate.Name = "btnEsculate";
            this.btnEsculate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEsculate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEsculate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEsculate.Size = new System.Drawing.Size(154, 36);
            this.btnEsculate.TabIndex = 77;
            this.btnEsculate.Text = "Esculate Ticket";
            this.btnEsculate.TextColor = System.Drawing.Color.White;
            this.btnEsculate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(15, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(154, 36);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Close";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1871, 740);
            this.Controls.Add(this.pnlTicketDetials);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTickets);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTickets";
            this.Text = "Tickets";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIssueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTechnician)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlTicketDetials.ResumeLayout(false);
            this.pnlTicketDetials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfTickStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfTechCombo)).EndInit();
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
        private Syncfusion.WinForms.ListView.SfComboBox cbPriority;
        private Syncfusion.WinForms.ListView.SfComboBox cbIssueType;
        private Syncfusion.WinForms.ListView.SfComboBox cBStatus;
        private Syncfusion.WinForms.ListView.SfComboBox cBTechnician;
        private System.Windows.Forms.Panel pnlTicketDetials;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.TextBox tbTicLogged;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox tbTickDateDue;
        private System.Windows.Forms.Label lblTickPriority;
        private System.Windows.Forms.TextBox tbTickPriority;
        private Syncfusion.WinForms.ListView.SfComboBox sfTickStatus;
        private System.Windows.Forms.Label lblTickStatus;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblTicketDetails;
        private System.Windows.Forms.Label lblTickTec;
        private Syncfusion.WinForms.ListView.SfComboBox sfTechCombo;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox tbTicketID;
        private System.Windows.Forms.RichTextBox rtbDesctiption;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbClientBusName;
        private System.Windows.Forms.Panel panel4;
        private CustomComponents.ButtonRound btnSaveChanged;
        private CustomComponents.ButtonRound btnEsculate;
        private CustomComponents.ButtonRound btnClose;
        private System.Windows.Forms.Label lblTicTitle;
        private System.Windows.Forms.TextBox tbTickTitle;
        private System.Windows.Forms.Label lblTickIssue;
        private System.Windows.Forms.TextBox tbTickIssue;
    }
}