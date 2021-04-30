
namespace PremierServiceSolutions.Pages
{
    partial class frmDash
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
            this.pnlHelpDesk = new System.Windows.Forms.Panel();
            this.pieChartPriority = new LiveCharts.WinForms.PieChart();
            this.pieChartIssueType = new LiveCharts.WinForms.PieChart();
            this.pieChartStatus = new LiveCharts.WinForms.PieChart();
            this.lblHelpDesk = new System.Windows.Forms.Label();
            this.pnlTicketReports = new System.Windows.Forms.Panel();
            this.cartesianChartDailyTickets = new LiveCharts.WinForms.CartesianChart();
            this.lblNewTickets = new System.Windows.Forms.Label();
            this.lblTechnicianTickets = new System.Windows.Forms.Label();
            this.pnlYourTic = new System.Windows.Forms.Panel();
            this.pieChartTechnicianStats = new LiveCharts.WinForms.PieChart();
            this.lblStatusPieChart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHelpDesk.SuspendLayout();
            this.pnlTicketReports.SuspendLayout();
            this.pnlYourTic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHelpDesk
            // 
            this.pnlHelpDesk.BackColor = System.Drawing.Color.White;
            this.pnlHelpDesk.Controls.Add(this.label2);
            this.pnlHelpDesk.Controls.Add(this.label1);
            this.pnlHelpDesk.Controls.Add(this.lblStatusPieChart);
            this.pnlHelpDesk.Controls.Add(this.pieChartPriority);
            this.pnlHelpDesk.Controls.Add(this.pieChartIssueType);
            this.pnlHelpDesk.Controls.Add(this.pieChartStatus);
            this.pnlHelpDesk.Controls.Add(this.lblHelpDesk);
            this.pnlHelpDesk.Location = new System.Drawing.Point(7, 6);
            this.pnlHelpDesk.Name = "pnlHelpDesk";
            this.pnlHelpDesk.Size = new System.Drawing.Size(888, 365);
            this.pnlHelpDesk.TabIndex = 0;
            this.pnlHelpDesk.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHelpDesk_Paint);
            // 
            // pieChartPriority
            // 
            this.pieChartPriority.Location = new System.Drawing.Point(574, 83);
            this.pieChartPriority.Name = "pieChartPriority";
            this.pieChartPriority.Size = new System.Drawing.Size(225, 282);
            this.pieChartPriority.TabIndex = 3;
            this.pieChartPriority.Text = "pieChart1";
            // 
            // pieChartIssueType
            // 
            this.pieChartIssueType.Location = new System.Drawing.Point(284, 83);
            this.pieChartIssueType.Name = "pieChartIssueType";
            this.pieChartIssueType.Size = new System.Drawing.Size(225, 282);
            this.pieChartIssueType.TabIndex = 2;
            this.pieChartIssueType.Text = "pieChart1";
            // 
            // pieChartStatus
            // 
            this.pieChartStatus.Location = new System.Drawing.Point(0, 83);
            this.pieChartStatus.Name = "pieChartStatus";
            this.pieChartStatus.Size = new System.Drawing.Size(225, 282);
            this.pieChartStatus.TabIndex = 1;
            this.pieChartStatus.Text = "pieChart1";
            // 
            // lblHelpDesk
            // 
            this.lblHelpDesk.AutoSize = true;
            this.lblHelpDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpDesk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHelpDesk.Location = new System.Drawing.Point(13, 9);
            this.lblHelpDesk.Name = "lblHelpDesk";
            this.lblHelpDesk.Size = new System.Drawing.Size(120, 25);
            this.lblHelpDesk.TabIndex = 0;
            this.lblHelpDesk.Text = "Help Desk";
            // 
            // pnlTicketReports
            // 
            this.pnlTicketReports.BackColor = System.Drawing.Color.White;
            this.pnlTicketReports.Controls.Add(this.cartesianChartDailyTickets);
            this.pnlTicketReports.Controls.Add(this.lblNewTickets);
            this.pnlTicketReports.Location = new System.Drawing.Point(7, 378);
            this.pnlTicketReports.Name = "pnlTicketReports";
            this.pnlTicketReports.Size = new System.Drawing.Size(434, 350);
            this.pnlTicketReports.TabIndex = 1;
            // 
            // cartesianChartDailyTickets
            // 
            this.cartesianChartDailyTickets.Location = new System.Drawing.Point(18, 49);
            this.cartesianChartDailyTickets.Name = "cartesianChartDailyTickets";
            this.cartesianChartDailyTickets.Size = new System.Drawing.Size(398, 246);
            this.cartesianChartDailyTickets.TabIndex = 1;
            this.cartesianChartDailyTickets.Text = "cartesianChart1";
            this.cartesianChartDailyTickets.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChartDailyTickets_ChildChanged);
            // 
            // lblNewTickets
            // 
            this.lblNewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewTickets.Location = new System.Drawing.Point(0, 8);
            this.lblNewTickets.Name = "lblNewTickets";
            this.lblNewTickets.Size = new System.Drawing.Size(434, 38);
            this.lblNewTickets.TabIndex = 0;
            this.lblNewTickets.Text = "Ticket Reports";
            // 
            // lblTechnicianTickets
            // 
            this.lblTechnicianTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTechnicianTickets.Location = new System.Drawing.Point(0, 3);
            this.lblTechnicianTickets.Name = "lblTechnicianTickets";
            this.lblTechnicianTickets.Size = new System.Drawing.Size(436, 33);
            this.lblTechnicianTickets.TabIndex = 0;
            this.lblTechnicianTickets.Text = "Technicians Ticket Stats";
            this.lblTechnicianTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlYourTic
            // 
            this.pnlYourTic.BackColor = System.Drawing.Color.White;
            this.pnlYourTic.Controls.Add(this.pieChartTechnicianStats);
            this.pnlYourTic.Controls.Add(this.lblTechnicianTickets);
            this.pnlYourTic.Location = new System.Drawing.Point(452, 378);
            this.pnlYourTic.Name = "pnlYourTic";
            this.pnlYourTic.Size = new System.Drawing.Size(436, 350);
            this.pnlYourTic.TabIndex = 2;
            // 
            // pieChartTechnicianStats
            // 
            this.pieChartTechnicianStats.Location = new System.Drawing.Point(25, 39);
            this.pieChartTechnicianStats.Name = "pieChartTechnicianStats";
            this.pieChartTechnicianStats.Size = new System.Drawing.Size(386, 266);
            this.pieChartTechnicianStats.TabIndex = 2;
            // 
            // lblStatusPieChart
            // 
            this.lblStatusPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPieChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusPieChart.Location = new System.Drawing.Point(12, 42);
            this.lblStatusPieChart.Name = "lblStatusPieChart";
            this.lblStatusPieChart.Size = new System.Drawing.Size(213, 38);
            this.lblStatusPieChart.TabIndex = 4;
            this.lblStatusPieChart.Text = "Tickets Status";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(263, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tickets Issue Types";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(586, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tickets Priority";
            // 
            // frmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremierServiceSolutions.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.pnlYourTic);
            this.Controls.Add(this.pnlTicketReports);
            this.Controls.Add(this.pnlHelpDesk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDash";
            this.Text = "frmDash";
            this.Load += new System.EventHandler(this.frmDash_Load);
            this.pnlHelpDesk.ResumeLayout(false);
            this.pnlHelpDesk.PerformLayout();
            this.pnlTicketReports.ResumeLayout(false);
            this.pnlYourTic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHelpDesk;
        private System.Windows.Forms.Panel pnlTicketReports;
        private System.Windows.Forms.Label lblHelpDesk;
        private System.Windows.Forms.Label lblNewTickets;
        private LiveCharts.WinForms.CartesianChart cartesianChartDailyTickets;
        private LiveCharts.WinForms.PieChart pieChartStatus;
        private LiveCharts.WinForms.PieChart pieChartIssueType;
        private LiveCharts.WinForms.PieChart pieChartPriority;
        private System.Windows.Forms.Label lblTechnicianTickets;
        private System.Windows.Forms.Panel pnlYourTic;
        private LiveCharts.WinForms.PieChart pieChartTechnicianStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusPieChart;
    }
}