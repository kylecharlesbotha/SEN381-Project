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
        List<Technician> lstTechnician;
        List<Issue> lstIssue;
        List<Status> lstStatus;
        public frmTickets()
        {
            InitializeComponent();
            listTicket = objTicket.GetAllTicket();
            PopulateCbb();
            PopulateTickets();
            this.Width = 900;
            this.Height = 740;
            pnlTicketDetials.Left = 12;


        }


        #region Populating CBB
        private void PopulateCbb()
        {

            try
            {
                //CB Issue Types
                Issue objissue = new Issue();
                lstIssue = objissue.GetAllIssues();
                cbIssueType.DataSource = lstIssue;
                cbIssueType.DisplayMember = "IssueName";

                //CB Priority Types
                Priority objPriority = new Priority();
                List<Priority> lstPriority = objPriority.GetAllPriority();
                cbPriority.DataSource = lstPriority;
                cbPriority.DisplayMember = "Priorityname";

                //CB Technician Types
                Technician objTechnician = new Technician();
                lstTechnician = objTechnician.GetTechNames();
                cBTechnician.DataSource = lstTechnician;
                cBTechnician.DisplayMember = "TechNameList";


                Status objStatus = new Status();
                lstStatus = objStatus.GetAll();
                cBStatus.DataSource = lstStatus;
                cBStatus.DisplayMember = "StatusName";
                
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
            DateTime date = DateTime.Now;
            date.ToString("yyyy-MM-dd HH:mm:ss");
            date.ToString("yyyy-MM-dd");
            int TicketToday = 0;
            int TicketClosed = 0;
            int TicketNew = 0;
            foreach (Ticket ticket in listTicket)
            {
                ticket.TicketLoggedTime.ToString("yyyy-MM-dd");
                if(date==ticket.TicketLoggedTime)
                {
                    TicketToday++;
                }
                if(ticket.TicketStatus=="Resolved")
                {
                    TicketClosed++;
                }
                if (ticket.TicketStatus == "New")
                {
                    TicketNew++;
                }
                CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TechnicianID, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus, ticket.TicketLoggedTime) ; ;;
            }
            CreateHeading("#", "Title", "Customer", "Technician", "Issue Type", "Priority", "Status", "Date Logged");
            lblTicketsToday.Text = "Tickets Today : " + Convert.ToString(TicketToday);
            lblClosed.Text = "Tickets Closed : " + Convert.ToString(TicketClosed);
            lblNew.Text = "New Tickets : " + Convert.ToString(TicketNew);
        }



        private void CreateEntry(int TicketID, string TicketTitle, string CustomerName, int TechnicianID, string IssueType,string Priority,string Status,DateTime datecreated)
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
            p.Size = new Size(flpTickets.ClientSize.Width + 200, 50);
            flpTickets.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTickets.Controls.SetChildIndex(p, 0);


            //Creating Label for ticketnumber
            Label lID = new Label();
            lID.Name = "lblTicketID" + flpTickets.Controls.Count;
            lID.Text = Convert.ToString(TicketID);
            lID.AutoSize = false;
            lID.Size = new Size(40, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 5;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.Click += new EventHandler(DisplayTickDetails);

            //Creating Label for tickettitle
            Label lTi = new Label();
            lTi.Name = "lblTicketTitle" + flpTickets.Controls.Count;
            lTi.Text = TicketTitle;
            lTi.AutoSize = false;
            lTi.Size = new Size(150, 30);
            p.Controls.Add(lTi);
            lTi.Top = 10;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = (lID.Left + lID.Width  + 10);
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.White;


            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerName" + flpTickets.Controls.Count;
            lCus.Text = CustomerName;
            lCus.AutoSize = false;
            lCus.Size = new Size(120, 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = (lTi.Left + lTi.Width + 10);
            lCus.Font = new Font("Arial", 10, FontStyle.Bold);
            lCus.ForeColor = Color.White;


            string TechName = "";
            foreach (Technician tecitem in lstTechnician)
            {
                if(TechnicianID==tecitem.TechnicianID)
                {
                    TechName = tecitem.TechName;
                }
            }

            Label lTech = new Label();
            lTech.Name = "lTech" + flpTickets.Controls.Count;
            lTech.AutoSize = false;
            lTech.Text = TechName;
            lTech.Size = new Size(150, 30);
            p.Controls.Add(lTech);
            lTech.Top = 10;
            lTech.TextAlign = ContentAlignment.MiddleCenter;
            lTech.Left = (lCus.Left + lCus.Width + 10);
            lTech.Font = new Font("Arial", 10, FontStyle.Bold);
            lTech.ForeColor = Color.White;



            //Creating Label for Issue Type
            Label lIssue = new Label();
            lIssue.Name = "lblIssueType" + flpTickets.Controls.Count;
            lIssue.Text = IssueType;
            lIssue.AutoSize = false;
            lIssue.Size = new Size(90, 30);
            p.Controls.Add(lIssue);
            lIssue.Top = 10;
            lIssue.TextAlign = ContentAlignment.MiddleCenter;
            lIssue.Left = (lTech.Left + lTech.Width + 10);
            lIssue.Font = new Font("Arial", 10, FontStyle.Bold);
            lIssue.ForeColor = Color.White;


            //Creating Label for Priority
            Label lPriority = new Label();
            lPriority.Name = "lblPriority" + flpTickets.Controls.Count;
            lPriority.Text = Priority;
            lPriority.AutoSize = false;
            lPriority.Size = new Size(68, 30);
            p.Controls.Add(lPriority);
            lPriority.Top = 10;
            lPriority.TextAlign = ContentAlignment.MiddleCenter;
            lPriority.Left = (lIssue.Left + lIssue.Width + 10);
            lPriority.Font = new Font("Arial", 10, FontStyle.Bold);
            lPriority.ForeColor = Color.White;



            //Creating Label for Status
            Label lStatus = new Label();
            lStatus.Name = "lblStatus" + flpTickets.Controls.Count;
            lStatus.Text = Status;
            lStatus.AutoSize = false;
            lStatus.Size = new Size(180, 30);
            p.Controls.Add(lStatus);
            lStatus.Top = 10;
            lStatus.TextAlign = ContentAlignment.MiddleCenter;
            lStatus.Left = (lPriority.Left + lPriority.Width + 10);
            lStatus.Font = new Font("Arial", 10, FontStyle.Bold);
            lStatus.ForeColor = Color.White;



            //Creating Label for Time Created
            Label lTime = new Label();
            lTime.Name = "lblTimeCreated" + flpTickets.Controls.Count;
            lTime.Text = Convert.ToString(datecreated);
            lTime.AutoSize = false;
            lTime.Size = new Size(150, 30);
            p.Controls.Add(lTime);
            lTime.Top = 10;
            lTime.TextAlign = ContentAlignment.MiddleCenter;
            lTime.Left = (lStatus.Left + lStatus.Width + 10);
            lTime.Font = new Font("Arial", 10, FontStyle.Bold);
            lTime.ForeColor = Color.White;



            //Updating the Panel and forcing it to refresh its self
            flpTickets.Invalidate();
        }

        private void CreateHeading(string TicketID, string TicketTitle, string CustomerName, string Technician, string IssueType, string Priority, string Status, string datecreated)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "TicketPanel" + (flpTickets.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            p.BackColor = Color.White;

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTickets.ClientSize.Width + 200, 50);
            p.Left = 0;
            p.Top = 0;
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
            lID.Size = new Size(40, 50);
            p.Controls.Add(lID);
            lID.Top = 0;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 5;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.FromArgb(218,0,0);

            //Creating Label for tickettitle
            Label lTi = new Label();
            lTi.Name = "lblTicketTitle" + flpTickets.Controls.Count;
            lTi.Text = TicketTitle;
            lTi.AutoSize = false;
            lTi.Size = new Size(150, 50);
            p.Controls.Add(lTi);
            lTi.Top = 0;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = (lID.Left + lID.Width + 10);
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.FromArgb(218, 0, 0);

            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerName" + flpTickets.Controls.Count;
            lCus.Text = CustomerName;
            lCus.AutoSize = false;
            lCus.Size = new Size(120, 50);
            p.Controls.Add(lCus);
            lCus.Top = 0;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = (lTi.Left + lTi.Width + 10);
            lCus.Font = new Font("Arial", 10, FontStyle.Bold);
            lCus.ForeColor = Color.FromArgb(218, 0, 0);

            //Creating Label for CustomerDetails
            Label lTech = new Label();
            lTech.Name = "lblTecName" + flpTickets.Controls.Count;
            lTech.Text = Technician;
            lTech.AutoSize = false;
            lTech.Size = new Size(150, 50);
            p.Controls.Add(lTech);
            lTech.Top = 0;
            lTech.TextAlign = ContentAlignment.MiddleCenter;
            lTech.Left = (lCus.Left + lCus.Width + 10);
            lTech.Font = new Font("Arial", 10, FontStyle.Bold);
            lTech.ForeColor = Color.FromArgb(218, 0, 0);


            //Creating Label for Issue Type
            Label lIssue = new Label();
            lIssue.Name = "lblIssueType" + flpTickets.Controls.Count;
            lIssue.Text = IssueType;
            lIssue.AutoSize = false;
            lIssue.Size = new Size(90, 50);
            p.Controls.Add(lIssue);
            lIssue.Top = 0;
            lIssue.TextAlign = ContentAlignment.MiddleCenter;
            lIssue.Left = (lTech.Left + lTech.Width + 10);
            lIssue.Font = new Font("Arial", 10, FontStyle.Bold);
            lIssue.ForeColor = Color.FromArgb(218, 0, 0);


            //Creating Label for Priority
            Label lPriority = new Label();
            lPriority.Name = "lblPriority" + flpTickets.Controls.Count;
            lPriority.Text = Priority;
            lPriority.AutoSize = false;
            lPriority.Size = new Size(68, 50);
            p.Controls.Add(lPriority);
            lPriority.Top = 0;
            lPriority.TextAlign = ContentAlignment.MiddleCenter;
            lPriority.Left = (lIssue.Left + lIssue.Width + 10);
            lPriority.Font = new Font("Arial", 10, FontStyle.Bold);
            lPriority.ForeColor = Color.FromArgb(218, 0, 0);


            //Creating Label for Status
            Label lStatus = new Label();
            lStatus.Name = "lblStatus" + flpTickets.Controls.Count;
            lStatus.Text = Status;
            lStatus.AutoSize = false;
            lStatus.Size = new Size(180, 50);
            p.Controls.Add(lStatus);
            lStatus.Top = 0;
            lStatus.TextAlign = ContentAlignment.MiddleCenter;
            lStatus.Left = (lPriority.Left + lPriority.Width + 10);
            lStatus.Font = new Font("Arial", 10, FontStyle.Bold);
            lStatus.ForeColor = Color.FromArgb(218, 0, 0);


            //Creating Label for Time Created
            Label lTime = new Label();
            lTime.Name = "lblTimeCreated" + flpTickets.Controls.Count;
            lTime.Text = datecreated;
            lTime.AutoSize = false;
            lTime.Size = new Size(150, 50);
            p.Controls.Add(lTime);
            lTime.Top = 0;
            lTime.TextAlign = ContentAlignment.MiddleCenter;
            lTime.Left = (lStatus.Left + lStatus.Width + 10);
            lTime.Font = new Font("Arial", 10, FontStyle.Bold);
            lTime.ForeColor = Color.FromArgb(218, 0, 0);

            //Updating the Panel and forcing it to refresh its self
            flpTickets.Invalidate();
        }


        #endregion

        protected void btnTicketView(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }
        protected void DisplayTickDetails(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            int TechID = 0 ;
            string TechName;
            string Status;
            foreach (Ticket ticket in listTicket)
            {
                if(lbl.Text == ticket.TicketID.ToString())
                {
                    tbClientBusName.Text = ticket.ClientName;
                    rtbDesctiption.Text = ticket.TicketDescription;
                    tbTickPriority.Text = ticket.TicketPriority;
                    tbTickIssue.Text = ticket.TicketIssueType;
                    tbTicLogged.Text = ticket.TicketLoggedTime.ToString();
                    tbTickDateDue.Text = ticket.TicketDueDate.ToString();
                    tbTicketID.Text = ticket.TicketID.ToString();
                    tbTickTitle.Text = ticket.TicketTitle;
                    Status = ticket.TicketStatus;
                    TechID = ticket.TechnicianID;
                }
            }
            int icount = -1;
            int select = 0;
            foreach (Technician item in lstTechnician)
            {
                icount++;
                if(item.TechnicianID == TechID)
                {
                    select = icount;
                }

            }

            sfTechCombo.DataSource = lstTechnician;
            sfTechCombo.DisplayMember = "TechNameList";
            sfTechCombo.SelectedIndex = select;

            pnlTicketDetials.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlTicketDetials.Visible = false;
        }

        private void btnNewTickets_Click(object sender, EventArgs e)
        {
            ShowNewTicket();
        }
        private void ResetTickets()
        {
            for (int i = flpTickets.Controls.Count - 1; i >= 0; i--)
            {
                flpTickets.Controls[i].Dispose();
            }
            flpTickets.Visible = false;
        }

        private void ShowNewTicket()
        {

            ResetTickets();
            flpTickets.Visible = true;
            foreach (Ticket ticket in listTicket)
            {
                if (ticket.TicketStatus == "New")
                {
                    CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TechnicianID, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus, ticket.TicketLoggedTime); ; ;
                }
            }
            CreateHeading("#", "Title", "Customer", "Technician", "Issue Type", "Priority", "Status", "Date Logged");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTickets();
            flpTickets.Visible = true;
            foreach (Ticket ticket in listTicket)
            {
                    CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TechnicianID, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus, ticket.TicketLoggedTime); ; ;
            }
            CreateHeading("#", "Title", "Customer", "Technician", "Issue Type", "Priority", "Status", "Date Logged");
        }
    }
}
