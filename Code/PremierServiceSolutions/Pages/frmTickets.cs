using PremierServiceSolutions.Business_Logic_Layer;
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
        Ticket objTicket = new Ticket();
        List<Ticket> listTicket = new List<Ticket>();
        public frmTickets()
        {
            InitializeComponent();
            listTicket = objTicket.GetAllTicket();
            PopulateTickets();
            PopulateCbb();
        }


        #region Populating CBB
        private void PopulateCbb()
        {

            try
            {
                Issue objissue = new Issue();
                List<Issue> lstIssue = objissue.GetAllIssues();
                cbIssueType.DataSource = lstIssue;

                Priority objPriority = new Priority();
                List<Priority> lstPriority = objPriority.GetAllPriority();
                cbPriority.DataSource = lstPriority;

                Technician objTechnician = new Technician();
                List<Technician> lstTechnician = objTechnician.GetTechNames();

                cBStatus.DataSource = listTicket;
                cBStatus.DisplayMember = "TicketStatus";
                cBTechnician.DataSource = lstTechnician;

                cbIssueType.DisplayMember = "IssueName";

                cbPriority.DisplayMember = "Priorityname";

                cBTechnician.DisplayMember = "TechNameList";
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }

        }
        #endregion


        #region Creating of Tickets
        private void PopulateTickets()
        {
            foreach (Ticket ticket in listTicket)
            {
                CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus,ticket.TicketLoggedTime);
            }
        }



        private void CreateEntry(int TicketID,string TicketTitle, string CustomerName,string IssueType,string Priority,string Status,DateTime datecreated)
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
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ticketnumber
            Label lID = new Label();
            lID.Name = "lblTicketID" + flpTickets.Controls.Count;
            lID.Text = Convert.ToString(TicketID);
            lID.AutoSize = false;
            lID.Size = new Size(40, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            //lID.BackColor = Color.White;
            lID.Click += new EventHandler(lblTicketIDClick);

            //Creating Label for tickettitle
            Label lTi = new Label();
            lTi.Name = "lblTicketTitle" + flpTickets.Controls.Count;
            lTi.Text = TicketTitle;
            lTi.AutoSize = false;
            lTi.Size = new Size(100, 30);
            p.Controls.Add(lTi);
            lTi.Top = 10;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = 60;
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.White;
            //lTi.BackColor = Color.White;
            lTi.Click += new EventHandler(lblTicketIDClick);

            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerName" + flpTickets.Controls.Count;
            lCus.Text = CustomerName;
            lCus.AutoSize = false;
            lCus.Size = new Size(160, 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = 150;
            lCus.Font = new Font("Arial", 10, FontStyle.Bold);
            lCus.ForeColor = Color.White;
            //lCus.BackColor = Color.White;
            lCus.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Issue Type
            Label lIssue = new Label();
            lIssue.Name = "lblIssueType" + flpTickets.Controls.Count;
            lIssue.Text = IssueType;
            lIssue.AutoSize = false;
            lIssue.Size = new Size(90, 30);
            p.Controls.Add(lIssue);
            lIssue.Top = 10;
            lIssue.TextAlign = ContentAlignment.MiddleCenter;
            lIssue.Left = 322;
            lIssue.Font = new Font("Arial", 10, FontStyle.Bold);
            lIssue.ForeColor = Color.White;
            //lIssue.BackColor = Color.White;
            lIssue.Click += new EventHandler(lblTicketIDClick);

            //Creating Label for Priority
            Label lPriority = new Label();
            lPriority.Name = "lblPriority" + flpTickets.Controls.Count;
            lPriority.Text = Priority;
            lPriority.AutoSize = false;
            lPriority.Size = new Size(68, 30);
            p.Controls.Add(lPriority);
            lPriority.Top = 10;
            lPriority.TextAlign = ContentAlignment.MiddleCenter;
            lPriority.Left = 425;
            lPriority.Font = new Font("Arial", 10, FontStyle.Bold);
            lPriority.ForeColor = Color.White;
            //lPriority.BackColor = Color.White;
            lPriority.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Status
            Label lStatus = new Label();
            lStatus.Name = "lblStatus" + flpTickets.Controls.Count;
            lStatus.Text = Status;
            lStatus.AutoSize = false;
            lStatus.Size = new Size(180, 30);
            p.Controls.Add(lStatus);
            lStatus.Top = 10;
            lStatus.TextAlign = ContentAlignment.MiddleCenter;
            lStatus.Left = 502;
            lStatus.Font = new Font("Arial", 10, FontStyle.Bold);
            lStatus.ForeColor = Color.White;
            //lStatus.BackColor = Color.White;
            lStatus.Click += new EventHandler(lblTicketIDClick);


            //Creating Label for Time Created
            Label lTime = new Label();
            lTime.Name = "lblTimeCreated" + flpTickets.Controls.Count;
            lTime.Text = Convert.ToString(datecreated);
            lTime.AutoSize = false;
            lTime.Size = new Size(150, 30);
            p.Controls.Add(lTime);
            lTime.Top = 10;
            lTime.TextAlign = ContentAlignment.MiddleCenter;
            lTime.Left = 700;
            lTime.Font = new Font("Arial", 10, FontStyle.Bold);
            lTime.ForeColor = Color.White;
            //lTime.BackColor = Color.White;
            lTime.Click += new EventHandler(lblTicketIDClick);


            //Updating the Panel and forcing it to refresh its self
            flpTickets.Invalidate();
        }

        #endregion

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


        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
