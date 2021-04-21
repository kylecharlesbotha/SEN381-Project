using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateEntry();
        }

        private void CreateEntry()
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "TicketPanel" + (flpTickets.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpTickets.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTickets.ClientSize.Width, 50);
            flpTickets.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTickets.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ticketnumber
            Label lID = new Label();
            lID.Name = "lblTicketID" + flpTickets.Controls.Count;
            lID.Text = "128792";
            lID.AutoSize = false;
            lID.Size = new Size(120, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(218, 0, 0);
            lID.Click += new EventHandler(lblTicketIDClick);



            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerName" + flpTickets.Controls.Count;
            lCus.Text = "Customer Details";
            lCus.AutoSize = false;
            lCus.Size = new Size(160, 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = 150;
            lCus.ForeColor = Color.White;
            lCus.BackColor = Color.FromArgb(218, 0, 0);
            lCus.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Issue Type
            Label lIssue = new Label();
            lIssue.Name = "lblIssueType" + flpTickets.Controls.Count;
            lIssue.Text = "Remote Support";
            lIssue.AutoSize = false;
            lIssue.Size = new Size(90, 30);
            p.Controls.Add(lIssue);
            lIssue.Top = 10;
            lIssue.TextAlign = ContentAlignment.MiddleCenter;
            lIssue.Left = 322;
            lIssue.ForeColor = Color.White;
            lIssue.BackColor = Color.FromArgb(218, 0, 0);
            lIssue.Click += new EventHandler(lblTicketIDClick);

            //Creating Label for Priority
            Label lPriority = new Label();
            lPriority.Name = "lblPriority" + flpTickets.Controls.Count;
            lPriority.Text = "Low";
            lPriority.AutoSize = false;
            lPriority.Size = new Size(68, 30);
            p.Controls.Add(lPriority);
            lPriority.Top = 10;
            lPriority.TextAlign = ContentAlignment.MiddleCenter;
            lPriority.Left = 425;
            lPriority.ForeColor = Color.White;
            lPriority.BackColor = Color.FromArgb(218, 0, 0);
            lPriority.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Status
            Label lStatus = new Label();
            lStatus.Name = "lblStatus" + flpTickets.Controls.Count;
            lStatus.Text = "New";
            lStatus.AutoSize = false;
            lStatus.Size = new Size(80, 30);
            p.Controls.Add(lStatus);
            lStatus.Top = 10;
            lStatus.TextAlign = ContentAlignment.MiddleCenter;
            lStatus.Left = 502;
            lStatus.ForeColor = Color.White;
            lStatus.BackColor = Color.FromArgb(218, 0, 0);
            lStatus.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Time Created
            Label lTime = new Label();
            lTime.Name = "lblTimeCreated" + flpTickets.Controls.Count;
            lTime.Text = "2021/01/20 06:45";
            lTime.AutoSize = false;
            lTime.Size = new Size(150, 30);
            p.Controls.Add(lTime);
            lTime.Top = 10;
            lTime.TextAlign = ContentAlignment.MiddleCenter;
            lTime.Left = 600;
            lTime.ForeColor = Color.White;
            lTime.BackColor = Color.FromArgb(218, 0, 0);
            lTime.Click += new EventHandler(lblTicketIDClick);


            //Updating the Panel and forcing it to refresh its self
            flpTickets.Invalidate();
        }
        protected void btnTicketView(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }
        protected void lblTicketIDClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            MessageBox.Show(lbl.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
