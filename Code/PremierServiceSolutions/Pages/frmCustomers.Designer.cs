
namespace PremierServiceSolutions.Pages
{
    partial class frmCustomers
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
            this.pnlTopClient = new System.Windows.Forms.Panel();
            this.iPBSearch = new FontAwesome.Sharp.IconPictureBox();
            this.flpCustomers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchHeadings = new System.Windows.Forms.Panel();
            this.lblContacts = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblCustomerHeading = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlNewClient = new System.Windows.Forms.Panel();
            this.cbEmailonTick = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkSendEmail = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkSendSMS = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblNewCustomer = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbClientBusName = new System.Windows.Forms.TextBox();
            this.lblBasicInfo = new System.Windows.Forms.Label();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.cbTitle = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnCancel = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.btnReset = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.btnCreateCustomerandTicket = new BrbVideoManager.Controls.RoundedButton();
            this.btnCreateCustomer = new BrbVideoManager.Controls.RoundedButton();
            this.tBSearch = new PremierServiceSolutions.CustomComponents.Round_TextBox();
            this.btnRAddClient = new PremierServiceSolutions.CustomComponents.ButtonRound();
            this.pnlTopClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).BeginInit();
            this.pnlSearchHeadings.SuspendLayout();
            this.pnlNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmailonTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopClient
            // 
            this.pnlTopClient.BackColor = System.Drawing.Color.White;
            this.pnlTopClient.Controls.Add(this.tBSearch);
            this.pnlTopClient.Controls.Add(this.iPBSearch);
            this.pnlTopClient.Controls.Add(this.btnRAddClient);
            this.pnlTopClient.Location = new System.Drawing.Point(9, 11);
            this.pnlTopClient.Name = "pnlTopClient";
            this.pnlTopClient.Size = new System.Drawing.Size(883, 69);
            this.pnlTopClient.TabIndex = 1;
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
            // flpCustomers
            // 
            this.flpCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpCustomers.AutoScroll = true;
            this.flpCustomers.BackColor = System.Drawing.Color.Transparent;
            this.flpCustomers.Location = new System.Drawing.Point(9, 129);
            this.flpCustomers.Name = "flpCustomers";
            this.flpCustomers.Size = new System.Drawing.Size(883, 607);
            this.flpCustomers.TabIndex = 2;
            // 
            // pnlSearchHeadings
            // 
            this.pnlSearchHeadings.BackColor = System.Drawing.Color.White;
            this.pnlSearchHeadings.Controls.Add(this.lblContacts);
            this.pnlSearchHeadings.Controls.Add(this.lblDateCreated);
            this.pnlSearchHeadings.Controls.Add(this.lblClientID);
            this.pnlSearchHeadings.Controls.Add(this.lblCustomerHeading);
            this.pnlSearchHeadings.Controls.Add(this.lblEmail);
            this.pnlSearchHeadings.Location = new System.Drawing.Point(9, 86);
            this.pnlSearchHeadings.Name = "pnlSearchHeadings";
            this.pnlSearchHeadings.Size = new System.Drawing.Size(883, 35);
            this.pnlSearchHeadings.TabIndex = 20;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.BackColor = System.Drawing.Color.White;
            this.lblContacts.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContacts.Location = new System.Drawing.Point(369, 8);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(82, 19);
            this.lblContacts.TabIndex = 16;
            this.lblContacts.Text = "Contacts";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.BackColor = System.Drawing.Color.White;
            this.lblDateCreated.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateCreated.Location = new System.Drawing.Point(738, 8);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(116, 19);
            this.lblDateCreated.TabIndex = 15;
            this.lblDateCreated.Text = "Date Created";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.BackColor = System.Drawing.Color.White;
            this.lblClientID.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClientID.Location = new System.Drawing.Point(32, 8);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(75, 19);
            this.lblClientID.TabIndex = 12;
            this.lblClientID.Text = "ClientID";
            // 
            // lblCustomerHeading
            // 
            this.lblCustomerHeading.AutoSize = true;
            this.lblCustomerHeading.BackColor = System.Drawing.Color.White;
            this.lblCustomerHeading.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerHeading.Location = new System.Drawing.Point(172, 8);
            this.lblCustomerHeading.Name = "lblCustomerHeading";
            this.lblCustomerHeading.Size = new System.Drawing.Size(108, 19);
            this.lblCustomerHeading.TabIndex = 13;
            this.lblCustomerHeading.Text = "Client Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(553, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // pnlNewClient
            // 
            this.pnlNewClient.BackColor = System.Drawing.Color.White;
            this.pnlNewClient.Controls.Add(this.cbTitle);
            this.pnlNewClient.Controls.Add(this.lblAdditional);
            this.pnlNewClient.Controls.Add(this.lblBasicInfo);
            this.pnlNewClient.Controls.Add(this.cbEmailonTick);
            this.pnlNewClient.Controls.Add(this.chkSendEmail);
            this.pnlNewClient.Controls.Add(this.chkSendSMS);
            this.pnlNewClient.Controls.Add(this.panel2);
            this.pnlNewClient.Controls.Add(this.btnCancel);
            this.pnlNewClient.Controls.Add(this.btnReset);
            this.pnlNewClient.Controls.Add(this.btnCreateCustomerandTicket);
            this.pnlNewClient.Controls.Add(this.btnCreateCustomer);
            this.pnlNewClient.Controls.Add(this.panel1);
            this.pnlNewClient.Controls.Add(this.pnlDivider);
            this.pnlNewClient.Controls.Add(this.lblNewCustomer);
            this.pnlNewClient.Controls.Add(this.lblGender);
            this.pnlNewClient.Controls.Add(this.lblZip);
            this.pnlNewClient.Controls.Add(this.tbZip);
            this.pnlNewClient.Controls.Add(this.lblTitle);
            this.pnlNewClient.Controls.Add(this.lblCountry);
            this.pnlNewClient.Controls.Add(this.tbState);
            this.pnlNewClient.Controls.Add(this.lblCity);
            this.pnlNewClient.Controls.Add(this.tbCity);
            this.pnlNewClient.Controls.Add(this.lblAddress2);
            this.pnlNewClient.Controls.Add(this.tbAddress2);
            this.pnlNewClient.Controls.Add(this.lblAddress);
            this.pnlNewClient.Controls.Add(this.tbAddress);
            this.pnlNewClient.Controls.Add(this.lblPriority);
            this.pnlNewClient.Controls.Add(this.tbPriority);
            this.pnlNewClient.Controls.Add(this.lblPhone);
            this.pnlNewClient.Controls.Add(this.tbPhone);
            this.pnlNewClient.Controls.Add(this.lblAddEmail);
            this.pnlNewClient.Controls.Add(this.tbEmail);
            this.pnlNewClient.Controls.Add(this.lblIDNumber);
            this.pnlNewClient.Controls.Add(this.tbIDNumber);
            this.pnlNewClient.Controls.Add(this.lblSurname);
            this.pnlNewClient.Controls.Add(this.tbSurname);
            this.pnlNewClient.Controls.Add(this.lblClient);
            this.pnlNewClient.Controls.Add(this.tbClientBusName);
            this.pnlNewClient.Location = new System.Drawing.Point(938, 11);
            this.pnlNewClient.Name = "pnlNewClient";
            this.pnlNewClient.Size = new System.Drawing.Size(883, 725);
            this.pnlNewClient.TabIndex = 21;
            this.pnlNewClient.Visible = false;
            // 
            // cbEmailonTick
            // 
            this.cbEmailonTick.BeforeTouchSize = new System.Drawing.Size(217, 34);
            this.cbEmailonTick.Location = new System.Drawing.Point(508, 543);
            this.cbEmailonTick.Name = "cbEmailonTick";
            this.cbEmailonTick.Size = new System.Drawing.Size(217, 34);
            this.cbEmailonTick.TabIndex = 70;
            this.cbEmailonTick.Text = "Send Email on Ticket Creation";
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.BeforeTouchSize = new System.Drawing.Size(217, 34);
            this.chkSendEmail.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.chkSendEmail.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.chkSendEmail.Location = new System.Drawing.Point(52, 583);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(217, 34);
            this.chkSendEmail.TabIndex = 69;
            this.chkSendEmail.Text = "Send Email";
            // 
            // chkSendSMS
            // 
            this.chkSendSMS.BeforeTouchSize = new System.Drawing.Size(217, 34);
            this.chkSendSMS.Location = new System.Drawing.Point(52, 543);
            this.chkSendSMS.Name = "chkSendSMS";
            this.chkSendSMS.Size = new System.Drawing.Size(217, 34);
            this.chkSendSMS.TabIndex = 68;
            this.chkSendSMS.Text = "Send SMS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(10, 646);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 2);
            this.panel2.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(10, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 61;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDivider.Location = new System.Drawing.Point(10, 64);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(863, 2);
            this.pnlDivider.TabIndex = 60;
            // 
            // lblNewCustomer
            // 
            this.lblNewCustomer.AutoSize = true;
            this.lblNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewCustomer.Location = new System.Drawing.Point(28, 21);
            this.lblNewCustomer.Name = "lblNewCustomer";
            this.lblNewCustomer.Size = new System.Drawing.Size(206, 31);
            this.lblNewCustomer.TabIndex = 59;
            this.lblNewCustomer.Text = "New Customer";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(450, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(156, 25);
            this.lblGender.TabIndex = 58;
            this.lblGender.Text = "Client Gender :";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblZip.Location = new System.Drawing.Point(429, 386);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(177, 25);
            this.lblZip.TabIndex = 56;
            this.lblZip.Text = "Zip/Postal Code :";
            // 
            // tbZip
            // 
            this.tbZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbZip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbZip.Location = new System.Drawing.Point(612, 382);
            this.tbZip.Multiline = true;
            this.tbZip.Name = "tbZip";
            this.tbZip.ReadOnly = true;
            this.tbZip.Size = new System.Drawing.Size(250, 30);
            this.tbZip.TabIndex = 55;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(91, 440);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 25);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Title :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCountry.Location = new System.Drawing.Point(451, 329);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(155, 25);
            this.lblCountry.TabIndex = 50;
            this.lblCountry.Text = "State/Country :";
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbState.Location = new System.Drawing.Point(612, 328);
            this.tbState.Multiline = true;
            this.tbState.Name = "tbState";
            this.tbState.ReadOnly = true;
            this.tbState.Size = new System.Drawing.Size(250, 30);
            this.tbState.TabIndex = 49;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCity.Location = new System.Drawing.Point(545, 277);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 25);
            this.lblCity.TabIndex = 48;
            this.lblCity.Text = "City :";
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbCity.Location = new System.Drawing.Point(612, 275);
            this.tbCity.Multiline = true;
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(250, 30);
            this.tbCity.TabIndex = 47;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress2.Location = new System.Drawing.Point(485, 224);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(121, 25);
            this.lblAddress2.TabIndex = 46;
            this.lblAddress2.Text = "Address 2 :";
            // 
            // tbAddress2
            // 
            this.tbAddress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbAddress2.Location = new System.Drawing.Point(612, 221);
            this.tbAddress2.Multiline = true;
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.ReadOnly = true;
            this.tbAddress2.Size = new System.Drawing.Size(250, 30);
            this.tbAddress2.TabIndex = 45;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(503, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 25);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address :";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbAddress.Location = new System.Drawing.Point(612, 167);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(250, 30);
            this.tbAddress.TabIndex = 43;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPriority.Location = new System.Drawing.Point(66, 386);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(91, 25);
            this.lblPriority.TabIndex = 42;
            this.lblPriority.Text = "Priority :";
            // 
            // tbPriority
            // 
            this.tbPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbPriority.Location = new System.Drawing.Point(163, 384);
            this.tbPriority.Multiline = true;
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.ReadOnly = true;
            this.tbPriority.Size = new System.Drawing.Size(250, 30);
            this.tbPriority.TabIndex = 41;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhone.Location = new System.Drawing.Point(71, 329);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(86, 25);
            this.lblPhone.TabIndex = 36;
            this.lblPhone.Text = "Phone :";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbPhone.Location = new System.Drawing.Point(163, 328);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(250, 30);
            this.tbPhone.TabIndex = 35;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddEmail.Location = new System.Drawing.Point(80, 277);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(77, 25);
            this.lblAddEmail.TabIndex = 34;
            this.lblAddEmail.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbEmail.Location = new System.Drawing.Point(163, 275);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(250, 30);
            this.tbEmail.TabIndex = 33;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIDNumber.Location = new System.Drawing.Point(38, 224);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(119, 25);
            this.lblIDNumber.TabIndex = 32;
            this.lblIDNumber.Text = "ID Number:";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbIDNumber.Location = new System.Drawing.Point(163, 221);
            this.tbIDNumber.Multiline = true;
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.ReadOnly = true;
            this.tbIDNumber.Size = new System.Drawing.Size(250, 30);
            this.tbIDNumber.TabIndex = 31;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(47, 166);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(110, 25);
            this.lblSurname.TabIndex = 30;
            this.lblSurname.Text = "Surname :";
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbSurname.Location = new System.Drawing.Point(163, 167);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(250, 30);
            this.tbSurname.TabIndex = 29;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClient.Location = new System.Drawing.Point(35, 118);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(122, 25);
            this.lblClient.TabIndex = 28;
            this.lblClient.Text = "First Name:";
            // 
            // tbClientBusName
            // 
            this.tbClientBusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbClientBusName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClientBusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbClientBusName.Location = new System.Drawing.Point(163, 115);
            this.tbClientBusName.Multiline = true;
            this.tbClientBusName.Name = "tbClientBusName";
            this.tbClientBusName.ReadOnly = true;
            this.tbClientBusName.Size = new System.Drawing.Size(250, 30);
            this.tbClientBusName.TabIndex = 27;
            // 
            // lblBasicInfo
            // 
            this.lblBasicInfo.AutoSize = true;
            this.lblBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBasicInfo.Location = new System.Drawing.Point(27, 75);
            this.lblBasicInfo.Name = "lblBasicInfo";
            this.lblBasicInfo.Size = new System.Drawing.Size(214, 29);
            this.lblBasicInfo.TabIndex = 72;
            this.lblBasicInfo.Text = "Basic Information";
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdditional.Location = new System.Drawing.Point(27, 498);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(267, 29);
            this.lblAdditional.TabIndex = 73;
            this.lblAdditional.Text = "Additional Information";
            // 
            // cbTitle
            // 
            this.cbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.cbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbTitle.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbTitle.Location = new System.Drawing.Point(166, 440);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(247, 24);
            this.cbTitle.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbTitle.Style.ClearButtonStyle.BackColor = System.Drawing.Color.White;
            this.cbTitle.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbTitle.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.cbTitle.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTitle.TabIndex = 74;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(16, 669);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(155, 38);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnReset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(713, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(155, 38);
            this.btnReset.TabIndex = 65;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCreateCustomerandTicket
            // 
            this.btnCreateCustomerandTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateCustomerandTicket.BorderColor = System.Drawing.Color.Empty;
            this.btnCreateCustomerandTicket.BorderDownColor = System.Drawing.Color.Empty;
            this.btnCreateCustomerandTicket.BorderDownWidth = 0F;
            this.btnCreateCustomerandTicket.BorderOverColor = System.Drawing.Color.Empty;
            this.btnCreateCustomerandTicket.BorderOverWidth = 0F;
            this.btnCreateCustomerandTicket.BorderRadius = 50;
            this.btnCreateCustomerandTicket.BorderWidth = 1.75F;
            this.btnCreateCustomerandTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomerandTicket.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomerandTicket.Location = new System.Drawing.Point(629, 670);
            this.btnCreateCustomerandTicket.Name = "btnCreateCustomerandTicket";
            this.btnCreateCustomerandTicket.Size = new System.Drawing.Size(239, 38);
            this.btnCreateCustomerandTicket.TabIndex = 64;
            this.btnCreateCustomerandTicket.Text = "Create Customer and Ticket";
            this.btnCreateCustomerandTicket.UseVisualStyleBackColor = false;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateCustomer.BorderColor = System.Drawing.Color.Empty;
            this.btnCreateCustomer.BorderDownColor = System.Drawing.Color.Empty;
            this.btnCreateCustomer.BorderDownWidth = 0F;
            this.btnCreateCustomer.BorderOverColor = System.Drawing.Color.Empty;
            this.btnCreateCustomer.BorderOverWidth = 0F;
            this.btnCreateCustomer.BorderRadius = 50;
            this.btnCreateCustomer.BorderWidth = 1.75F;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomer.Location = new System.Drawing.Point(432, 670);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(172, 38);
            this.btnCreateCustomer.TabIndex = 63;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
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
            this.tBSearch.Size = new System.Drawing.Size(380, 31);
            this.tBSearch.TabIndex = 51;
            this.tBSearch.Text = "Start Typing Client or Client ID";
            // 
            // btnRAddClient
            // 
            this.btnRAddClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRAddClient.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRAddClient.FlatAppearance.BorderSize = 0;
            this.btnRAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAddClient.Location = new System.Drawing.Point(682, 14);
            this.btnRAddClient.Name = "btnRAddClient";
            this.btnRAddClient.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnRAddClient.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnRAddClient.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRAddClient.Size = new System.Drawing.Size(185, 40);
            this.btnRAddClient.TabIndex = 53;
            this.btnRAddClient.TabStop = false;
            this.btnRAddClient.Text = "New Client +";
            this.btnRAddClient.TextColor = System.Drawing.Color.White;
            this.btnRAddClient.UseVisualStyleBackColor = true;
            this.btnRAddClient.Click += new System.EventHandler(this.btnRAddClient_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1850, 740);
            this.Controls.Add(this.pnlNewClient);
            this.Controls.Add(this.pnlSearchHeadings);
            this.Controls.Add(this.flpCustomers);
            this.Controls.Add(this.pnlTopClient);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            this.pnlTopClient.ResumeLayout(false);
            this.pnlTopClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBSearch)).EndInit();
            this.pnlSearchHeadings.ResumeLayout(false);
            this.pnlSearchHeadings.PerformLayout();
            this.pnlNewClient.ResumeLayout(false);
            this.pnlNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmailonTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopClient;
        private CustomComponents.Round_TextBox tBSearch;
        private FontAwesome.Sharp.IconPictureBox iPBSearch;
        private CustomComponents.ButtonRound btnRAddClient;
        private System.Windows.Forms.FlowLayoutPanel flpCustomers;
        private System.Windows.Forms.Panel pnlSearchHeadings;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblCustomerHeading;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Panel pnlNewClient;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbClientBusName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblNewCustomer;
        private BrbVideoManager.Controls.RoundedButton btnCreateCustomerandTicket;
        private BrbVideoManager.Controls.RoundedButton btnCreateCustomer;
        private System.Windows.Forms.Panel panel2;
        private CustomComponents.ButtonRound btnCancel;
        private CustomComponents.ButtonRound btnReset;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbEmailonTick;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSendEmail;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSendSMS;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Label lblBasicInfo;
        private Syncfusion.WinForms.ListView.SfComboBox cbTitle;
    }
}