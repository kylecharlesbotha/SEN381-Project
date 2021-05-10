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
        List<Ticket> lstFilterTicket;
        private int tech =-1;
        private string issue = "";
        private string priority = "";
        private string status ="";
        private int valid = 0;
        public frmTickets()
        {
            InitializeComponent();
            listTicket = objTicket.GetAllTicket();
            lstFilterTicket = objTicket.GetAllTicket();
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
        #endregion

        #region Ticket Entries
        private void CreateNullEntry(string CusName)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpTickets.Controls.Count);
           
            p.BackColor = Color.FromArgb(179, 179, 179);          

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTickets.ClientSize.Width - 6, 50);
            flpTickets.Controls.Add(p);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flpTickets.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width - 5, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 14, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(179, 179, 179);

            flpTickets.Invalidate();
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
        
        #region NewTickets
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
            ResetCBB();
        }
        #endregion

        #region Reset of Tickets
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTickets();
            flpTickets.Visible = true;
            foreach (Ticket ticket in listTicket)
            {
                    CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TechnicianID, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus, ticket.TicketLoggedTime); ; ;
            }
            CreateHeading("#", "Title", "Customer", "Technician", "Issue Type", "Priority", "Status", "Date Logged");
            ResetCBB();
        }

        private void ResetCBB()
        {
            cbPriority.SelectedIndex = -1;
            cBTechnician.SelectedIndex = -1;
            cBStatus.SelectedIndex = -1;
            cbIssueType.SelectedIndex = -1;
        }
        private void ResetTickets()
        {
            for (int i = flpTickets.Controls.Count - 1; i >= 0; i--)
            {
                flpTickets.Controls[i].Dispose();
            }
            flpTickets.Visible = false;

        }
        #endregion

        #region Assign CBB Values
        private void cBTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {
            tech = cBTechnician.SelectedIndex;
        }

        private void cBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cBStatus.Text;
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = cbPriority.Text;
        }

        private void cbIssueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            issue = cbIssueType.Text;
        }
        #endregion


        #region Filter Methods
        private void FilterTickets()
        {
            lstFilterTicket.Clear();
            if(issue=="") //If Issue is not selected
            {
                if(priority=="") //If Priority is not Selected
                {
                    if(tech.ToString()=="-1") //If Tech is not selected
                    {
                        if(status=="")//If Status Not Selected
                        {
                            MessageBox.Show("Please Select filters to filter against"); //Shows Error to show that no filters were choosen
                            valid = 0;
                        }
                        else //If everything besides Status is chosen
                        {
                            foreach (Ticket ticket in listTicket)
                            {
                                if (ticket.TicketStatus == status) //Display Filter matching Status
                                {
                                    lstFilterTicket.Add(ticket);
                                    MessageBox.Show("Stats");
                                    valid = 1;
                                }
                            }
                        }
                    }
                    else //If Technician is choosen
                    {
                        if(status=="")//Checks that only Tech is Selected
                        {
                            foreach (Ticket ticket in listTicket)
                            {
                                if (ticket.TechnicianID == tech)//Display Filter matching Technician
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                        else if(status!="") //if Technician and Status is choosen
                        {
                            foreach(Ticket ticket in listTicket)
                            {
                                if (ticket.TechnicianID == tech && ticket.TicketStatus == status)//Display Filter matching Technician and Status
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }

                    }
                }
                else//if Priority is choosen and Issue is Empty
                {
                    if (status == "")//If Status is not Selected
                    {
                        if (tech.ToString() == "-1")//Checks that only Priority is Selected
                        {

                            foreach (Ticket ticket in listTicket)
                            {
                                if (ticket.TicketPriority == priority)//Display Filter matching Priority
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }

                        if (tech.ToString() != "-1")//If Technician and Priority is choosen
                        {
                            foreach (Ticket ticket in listTicket)
                            {
                                if (ticket.TechnicianID == tech && ticket.TicketPriority == priority)//Display Filter matching Technician and Priority
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                    }
                    else//If only Priority and Status is choosen
                    {
                        if (tech.ToString() == "-1")//If Technician,Issue is not choosen and Priority and status is
                        {
                            foreach (Ticket ticket in listTicket)
                            {
                                if (ticket.TicketPriority == priority && ticket.TicketStatus == status)//Display Filter matching Priority and Status
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                        else //If Eveything but issue is choosen
                        {
                            foreach(Ticket ticket in listTicket)
                            {
                                if (ticket.TicketPriority == priority && ticket.TicketStatus == status && ticket.TechnicianID == tech)//Display Filter matching Priority and Status
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                    }
                    

                    


                }
            }
            else //If Issue has a selection
            {
                if (priority == "") //If Priority is Empty
                {
                    if(tech.ToString()=="-1")//Checks that Technician,Priority is empty
                    {
                        if(status!="")//Checks if only Issue and Status is Selected
                        {
                            foreach (Ticket ticket in listTicket)// Display Filter matching Issue and Status
                            {
                                if (ticket.TicketIssueType == issue && ticket.TicketStatus == status)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tech.ToString() != "-1" && status == "")//If Priority is Empty but Technician and Issue is selected
                        {
                            foreach (Ticket ticket in listTicket)// Display Filter matching Technician and Issue
                            {
                                if (ticket.TicketIssueType == issue && ticket.TechnicianID == tech)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }

                        if (tech.ToString() != "-1" && status != "")//If Issue, Technician and Status is Selected
                        {
                            foreach (Ticket ticket in listTicket)// Display Filter matching Technician and Issue
                            {
                                if (ticket.TicketIssueType == issue && ticket.TechnicianID == tech && ticket.TicketStatus == status)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }


                    }
                }
                else //Priority is choosen and Issue
                {
                    if (status == "") //If Status is not choosen
                    {
                        if (priority != "" && tech.ToString() == "-1") //If Priority,Issue is selected and no tech selected and status is not
                        {
                            foreach (Ticket ticket in listTicket)//Display Filter matching Issue and Priority
                            {
                                if (ticket.TicketIssueType == issue && ticket.TicketPriority == priority)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }


                        if (priority != "" && tech.ToString() != "-1" ) //if Priority ,Tech,Issue is selected and status is not
                        {
                            foreach (Ticket ticket in listTicket)//Display Filter matching Technician and Priority and Issue
                            {
                                if (ticket.TicketIssueType == issue && ticket.TicketPriority == priority && ticket.TechnicianID == tech)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                    }
                    else//Issue Priority and Status is choosen
                    {
                        if(tech.ToString()=="-1")//Making sure Tech is not selected
                        {
                            foreach (Ticket ticket in listTicket)//Display Filter matching Status and Priority and Issue
                            {
                                if (ticket.TicketIssueType == issue && ticket.TicketPriority == priority && ticket.TicketStatus == status)
                                {
                                    lstFilterTicket.Add(ticket);
                                    valid = 1;
                                }
                            }
                        }
                    }
                }
                

                if (tech.ToString() == "-1" && status == "" && priority=="") //If only Issue is selected
                {

                    foreach (Ticket ticket in listTicket)///Display Filter matching Issue
                    {
                        if (ticket.TicketIssueType == issue)
                        {
                            lstFilterTicket.Add(ticket);
                            valid = 1;
                        }
                    }
                }
                else //If all is selected
                {
                    foreach (Ticket ticket in listTicket)
                    {
                        if (ticket.TicketIssueType == issue && ticket.TicketPriority==priority && ticket.TicketStatus == status && ticket.TechnicianID==tech)
                        {
                            lstFilterTicket.Add(ticket);
                            valid = 1;
                        }
                    }
                }
            }


        }

        private void DisplayFilter()
        {
            foreach (Ticket ticket in lstFilterTicket)
            {

                CreateEntry(ticket.TicketID, ticket.TicketTitle, ticket.ClientName, ticket.TechnicianID, ticket.TicketIssueType, ticket.TicketPriority, ticket.TicketStatus, ticket.TicketLoggedTime); ; ;

            }
            
            CreateHeading("#", "Title", "Customer", "Technician", "Issue Type", "Priority", "Status", "Date Logged");
            if (flpTickets.Controls.Count == 1)
            {
                CreateNullEntry("No Search Results Found. Try changing Filters");
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTickets();
            if (valid == 1)
            {
                ResetTickets();
                flpTickets.Visible = true;
                
                DisplayFilter();
            }
        }
        #endregion
    }
}
