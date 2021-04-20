
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cBTechnician = new System.Windows.Forms.ComboBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.btnNewTickets = new BrbVideoManager.Controls.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllMyTickets = new BrbVideoManager.Controls.RoundedButton();
            this.btnMyOpenTickets = new BrbVideoManager.Controls.RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblIssueType = new System.Windows.Forms.Label();
            this.btnReset = new BrbVideoManager.Controls.RoundedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTicketsToday = new System.Windows.Forms.Label();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.lblClosed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(877, 551);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBTechnician
            // 
            this.cBTechnician.FormattingEnabled = true;
            this.cBTechnician.Location = new System.Drawing.Point(121, 14);
            this.cBTechnician.Name = "cBTechnician";
            this.cBTechnician.Size = new System.Drawing.Size(143, 21);
            this.cBTechnician.TabIndex = 2;
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
            // cBStatus
            // 
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Location = new System.Drawing.Point(372, 14);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(142, 21);
            this.cBStatus.TabIndex = 6;
            this.cBStatus.SelectedIndexChanged += new System.EventHandler(this.cBStatus_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnMyOpenTickets);
            this.panel1.Controls.Add(this.btnAllMyTickets);
            this.panel1.Controls.Add(this.btnNewTickets);
            this.panel1.Location = new System.Drawing.Point(13, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 65);
            this.panel1.TabIndex = 9;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblPriority);
            this.panel2.Controls.Add(this.lblIssueType);
            this.panel2.Controls.Add(this.cBStatus);
            this.panel2.Controls.Add(this.cBTechnician);
            this.panel2.Controls.Add(this.lblTechnician);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 21);
            this.comboBox2.TabIndex = 8;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblClosed);
            this.panel3.Controls.Add(this.lblUnassigned);
            this.panel3.Controls.Add(this.lblTicketsToday);
            this.panel3.Location = new System.Drawing.Point(704, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 159);
            this.panel3.TabIndex = 11;
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
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTickets";
            this.Text = "Tickets";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBTechnician;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cBStatus;
        private BrbVideoManager.Controls.RoundedButton btnNewTickets;
        private System.Windows.Forms.Panel panel1;
        private BrbVideoManager.Controls.RoundedButton btnAllMyTickets;
        private BrbVideoManager.Controls.RoundedButton btnReset;
        private BrbVideoManager.Controls.RoundedButton btnMyOpenTickets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClosed;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.Label lblTicketsToday;
    }
}