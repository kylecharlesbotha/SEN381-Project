
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
            this.button1 = new System.Windows.Forms.Button();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnAssigned = new System.Windows.Forms.Button();
            this.pnlAssignedSub = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUnassigned = new System.Windows.Forms.Button();
            this.pnlUnassignedSub = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnProgressTickets = new System.Windows.Forms.Button();
            this.pnlProgressSub = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.sideMenu.SuspendLayout();
            this.pnlAssignedSub.SuspendLayout();
            this.pnlUnassignedSub.SuspendLayout();
            this.pnlProgressSub.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sideMenu
            // 
            this.sideMenu.AutoScroll = true;
            this.sideMenu.Controls.Add(this.pnlProgressSub);
            this.sideMenu.Controls.Add(this.btnProgressTickets);
            this.sideMenu.Controls.Add(this.pnlUnassignedSub);
            this.sideMenu.Controls.Add(this.btnUnassigned);
            this.sideMenu.Controls.Add(this.pnlAssignedSub);
            this.sideMenu.Controls.Add(this.btnAssigned);
            this.sideMenu.Location = new System.Drawing.Point(7, 384);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(197, 351);
            this.sideMenu.TabIndex = 2;
            // 
            // btnAssigned
            // 
            this.btnAssigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssigned.Location = new System.Drawing.Point(0, 0);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(180, 48);
            this.btnAssigned.TabIndex = 2;
            this.btnAssigned.Text = "Assigned Tickets";
            this.btnAssigned.UseVisualStyleBackColor = true;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click);
            // 
            // pnlAssignedSub
            // 
            this.pnlAssignedSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAssignedSub.Controls.Add(this.button4);
            this.pnlAssignedSub.Controls.Add(this.button3);
            this.pnlAssignedSub.Controls.Add(this.button2);
            this.pnlAssignedSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssignedSub.Location = new System.Drawing.Point(0, 48);
            this.pnlAssignedSub.Name = "pnlAssignedSub";
            this.pnlAssignedSub.Size = new System.Drawing.Size(180, 96);
            this.pnlAssignedSub.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnUnassigned
            // 
            this.btnUnassigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnassigned.Location = new System.Drawing.Point(0, 144);
            this.btnUnassigned.Name = "btnUnassigned";
            this.btnUnassigned.Size = new System.Drawing.Size(180, 48);
            this.btnUnassigned.TabIndex = 4;
            this.btnUnassigned.Text = "Unassigned Tickets";
            this.btnUnassigned.UseVisualStyleBackColor = true;
            this.btnUnassigned.Click += new System.EventHandler(this.btnUnassigned_Click);
            // 
            // pnlUnassignedSub
            // 
            this.pnlUnassignedSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUnassignedSub.Controls.Add(this.button5);
            this.pnlUnassignedSub.Controls.Add(this.button6);
            this.pnlUnassignedSub.Controls.Add(this.button7);
            this.pnlUnassignedSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUnassignedSub.Location = new System.Drawing.Point(0, 192);
            this.pnlUnassignedSub.Name = "pnlUnassignedSub";
            this.pnlUnassignedSub.Size = new System.Drawing.Size(180, 96);
            this.pnlUnassignedSub.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 49);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnProgressTickets
            // 
            this.btnProgressTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgressTickets.Location = new System.Drawing.Point(0, 288);
            this.btnProgressTickets.Name = "btnProgressTickets";
            this.btnProgressTickets.Size = new System.Drawing.Size(180, 48);
            this.btnProgressTickets.TabIndex = 6;
            this.btnProgressTickets.Text = "Progress Tickets";
            this.btnProgressTickets.UseVisualStyleBackColor = true;
            this.btnProgressTickets.Click += new System.EventHandler(this.btnProgressTickets_Click);
            // 
            // pnlProgressSub
            // 
            this.pnlProgressSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProgressSub.Controls.Add(this.button9);
            this.pnlProgressSub.Controls.Add(this.button10);
            this.pnlProgressSub.Controls.Add(this.button11);
            this.pnlProgressSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgressSub.Location = new System.Drawing.Point(0, 336);
            this.pnlProgressSub.Name = "pnlProgressSub";
            this.pnlProgressSub.Size = new System.Drawing.Size(180, 96);
            this.pnlProgressSub.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.Location = new System.Drawing.Point(0, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.Location = new System.Drawing.Point(0, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(180, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(180, 49);
            this.button11.TabIndex = 0;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.schedContCal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.sideMenu.ResumeLayout(false);
            this.pnlAssignedSub.ResumeLayout(false);
            this.pnlUnassignedSub.ResumeLayout(false);
            this.pnlProgressSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl schedContCal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel pnlProgressSub;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnProgressTickets;
        private System.Windows.Forms.Panel pnlUnassignedSub;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnUnassigned;
        private System.Windows.Forms.Panel pnlAssignedSub;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAssigned;
    }
}