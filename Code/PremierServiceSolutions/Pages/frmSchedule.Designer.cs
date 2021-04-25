
namespace PremierServiceSolutions.Pages
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.schedContCal = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.flpNewTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTickets = new System.Windows.Forms.Button();
            this.flpUnassigned = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUnassigned = new System.Windows.Forms.Button();
            this.flpAssigned = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssigned = new System.Windows.Forms.Button();
            this.flpProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProgressTickets = new System.Windows.Forms.Button();
            this.bgwUploadFile = new System.ComponentModel.BackgroundWorker();
            this.pbUploadProgress = new System.Windows.Forms.ProgressBar();
            this.sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedContCal
            // 
            this.schedContCal.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.schedContCal.Appearance.WeekHeaderFormat = "MMMM dd";
            this.schedContCal.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            this.schedContCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.schedContCal.Culture = new System.Globalization.CultureInfo("");
            this.schedContCal.DataSource = null;
            this.schedContCal.ISO8601CalenderFormat = false;
            this.schedContCal.Location = new System.Drawing.Point(4, 3);
            this.schedContCal.Name = "schedContCal";
            this.schedContCal.Size = new System.Drawing.Size(892, 733);
            this.schedContCal.TabIndex = 0;
            // 
            // sideMenu
            // 
            this.sideMenu.AutoScroll = true;
            this.sideMenu.Controls.Add(this.flpNewTickets);
            this.sideMenu.Controls.Add(this.btnNewTickets);
            this.sideMenu.Controls.Add(this.flpUnassigned);
            this.sideMenu.Controls.Add(this.btnUnassigned);
            this.sideMenu.Controls.Add(this.flpAssigned);
            this.sideMenu.Controls.Add(this.btnAssigned);
            this.sideMenu.Controls.Add(this.flpProgress);
            this.sideMenu.Controls.Add(this.btnProgressTickets);
            this.sideMenu.Location = new System.Drawing.Point(7, 384);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(197, 351);
            this.sideMenu.TabIndex = 2;
            // 
            // flpNewTickets
            // 
            this.flpNewTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpNewTickets.Location = new System.Drawing.Point(0, 359);
            this.flpNewTickets.Name = "flpNewTickets";
            this.flpNewTickets.Size = new System.Drawing.Size(180, 64);
            this.flpNewTickets.TabIndex = 17;
            // 
            // btnNewTickets
            // 
            this.btnNewTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewTickets.Location = new System.Drawing.Point(0, 311);
            this.btnNewTickets.Name = "btnNewTickets";
            this.btnNewTickets.Size = new System.Drawing.Size(180, 48);
            this.btnNewTickets.TabIndex = 16;
            this.btnNewTickets.Text = "New Tickets";
            this.btnNewTickets.UseVisualStyleBackColor = true;
            this.btnNewTickets.Click += new System.EventHandler(this.btnNewTickets_Click);
            // 
            // flpUnassigned
            // 
            this.flpUnassigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpUnassigned.Location = new System.Drawing.Point(0, 271);
            this.flpUnassigned.Name = "flpUnassigned";
            this.flpUnassigned.Size = new System.Drawing.Size(180, 40);
            this.flpUnassigned.TabIndex = 15;
            // 
            // btnUnassigned
            // 
            this.btnUnassigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnassigned.Location = new System.Drawing.Point(0, 223);
            this.btnUnassigned.Name = "btnUnassigned";
            this.btnUnassigned.Size = new System.Drawing.Size(180, 48);
            this.btnUnassigned.TabIndex = 14;
            this.btnUnassigned.Text = "Unassigned Tickets";
            this.btnUnassigned.UseVisualStyleBackColor = true;
            this.btnUnassigned.Click += new System.EventHandler(this.btnUnassigned_Click);
            // 
            // flpAssigned
            // 
            this.flpAssigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpAssigned.Location = new System.Drawing.Point(0, 160);
            this.flpAssigned.Name = "flpAssigned";
            this.flpAssigned.Size = new System.Drawing.Size(180, 63);
            this.flpAssigned.TabIndex = 13;
            // 
            // btnAssigned
            // 
            this.btnAssigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssigned.Location = new System.Drawing.Point(0, 112);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(180, 48);
            this.btnAssigned.TabIndex = 12;
            this.btnAssigned.Text = "Assigned Tickets";
            this.btnAssigned.UseVisualStyleBackColor = true;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click);
            // 
            // flpProgress
            // 
            this.flpProgress.BackColor = System.Drawing.SystemColors.Control;
            this.flpProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpProgress.Location = new System.Drawing.Point(0, 48);
            this.flpProgress.Name = "flpProgress";
            this.flpProgress.Size = new System.Drawing.Size(180, 64);
            this.flpProgress.TabIndex = 11;
            // 
            // btnProgressTickets
            // 
            this.btnProgressTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgressTickets.Location = new System.Drawing.Point(0, 0);
            this.btnProgressTickets.Name = "btnProgressTickets";
            this.btnProgressTickets.Size = new System.Drawing.Size(180, 48);
            this.btnProgressTickets.TabIndex = 6;
            this.btnProgressTickets.Text = "Progress Tickets";
            this.btnProgressTickets.UseVisualStyleBackColor = true;
            this.btnProgressTickets.Click += new System.EventHandler(this.btnProgressTickets_Click);
            // 
            // bgwUploadFile
            // 
            this.bgwUploadFile.WorkerReportsProgress = true;
            this.bgwUploadFile.WorkerSupportsCancellation = true;
            this.bgwUploadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUploadFile_DoWork);
            this.bgwUploadFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwUploadFile_ProgressChanged);
            // 
            // pbUploadProgress
            // 
            this.pbUploadProgress.Location = new System.Drawing.Point(651, 5);
            this.pbUploadProgress.Name = "pbUploadProgress";
            this.pbUploadProgress.Size = new System.Drawing.Size(195, 23);
            this.pbUploadProgress.TabIndex = 3;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.pbUploadProgress);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.schedContCal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl schedContCal;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button btnProgressTickets;
        private System.ComponentModel.BackgroundWorker bgwUploadFile;
        private System.Windows.Forms.ProgressBar pbUploadProgress;
        private System.Windows.Forms.Button btnAssigned;
        private System.Windows.Forms.FlowLayoutPanel flpProgress;
        private System.Windows.Forms.FlowLayoutPanel flpUnassigned;
        private System.Windows.Forms.Button btnUnassigned;
        private System.Windows.Forms.FlowLayoutPanel flpAssigned;
        private System.Windows.Forms.FlowLayoutPanel flpNewTickets;
        private System.Windows.Forms.Button btnNewTickets;
    }
}