﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PremierServiceSolutions.Business_Logic_Layer;
using System.IO;

namespace PremierServiceSolutions.Pages
{
    public partial class frmCentre : Form
    {
        DateTime startTime = new DateTime();
        List<Client> lsAllClients = new List<Client>();
        List<Client> lsClientSearch = new List<Client>();
        Client objClient = new Client();
        Ticket objTicket = new Ticket();
        Technician objTechnician = new Technician();
        CallCentreContract objCallCenCon = new CallCentreContract();
        List<Technician> lstTechnician;
        List<CallCentreContract> lstCenContracts;
        Call objCall = new Call();
        Call objCall2 = new Call();
        private Thread ThreadTime;
        bool CallProgress=false;
        byte[] ContractPath;
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        private string FullPath;
        public frmCentre()
        {
            lstTechnician= objTechnician.GetTechNames();
            lstCenContracts = objCallCenCon.GetCallContract();
            lstCenContracts.Sort();
            InitializeComponent();
            TestList.Add("Darren");
            TestList.Add("Darlien");
            TestList.Add("Darwdwlien");
            TestList.Add("Darlwdwien");
            TestList.Add("Kyle");
            TestList.Add("Kyldwe");
            TestList.Add("Kysdasle");
            TestList.Add("Klazam");
            TestList.Add("Claude");
            TestList.Add("Cladawdude");
            TestList.Add("Claude");
            TestList.Add("Cris");
            TestList.Add("Brent");
            TestList.Add("Brwdent");
            TestList.Add("Brdent");
            TestList.Add("Bresdsant");
            TestList.Add("Zane");
            TestList.Add("Zack");
            TestList.Add("Zdwdack");
            TestList.Add("Zacwdk");
            flpSearchResults.Left = 9;


            FullPath = GetTemporaryDirectory();
            FullPath += @"\Temp.pdf";

            flpSearchResults.BringToFront();


        }
        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }


        List<string> TestList = new List<string>();
        List<string> PhoneNumbers = new List<string>();

        #region Search Entry Creation
        private void CreateEntry(string CusName, string CusID)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpSearchResults.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpSearchResults.ClientSize.Width - 6, 50);
            flpSearchResults.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpSearchResults.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flpSearchResults.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width / 2 - 20, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleLeft;
            lID.Left = 10;
            lID.Font = new Font("Arial", 16, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(218, 0, 0);
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                lID.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                lID.BackColor = Color.FromArgb(179, 179, 179);
            }
            lID.Click += new EventHandler(lblSearchClicked);
            lID.MouseEnter += new EventHandler(lblMouseEnter);
            lID.MouseLeave += new EventHandler(lblMouseLeave);



            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerID" + flpSearchResults.Controls.Count;
            lCus.Text = CusID;
            lCus.AutoSize = false;
            lCus.Size = new Size(p.Width / 2 - 10, 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = p.Width / 2;
            lCus.Font = new Font("Arial", 16, FontStyle.Bold);
            lCus.ForeColor = Color.White;
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                lCus.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                lCus.BackColor = Color.FromArgb(179, 179, 179);
            }
            lCus.Click += new EventHandler(lblSearchClicked);
            lCus.MouseEnter += new EventHandler(lblMouseEnter);
            lCus.MouseLeave += new EventHandler(lblMouseLeave);

            //Updating the Panel and forcing it to refresh its self
            flpSearchResults.Height = flpSearchResults.Controls.Count * p.Height + (8 * flpSearchResults.Controls.Count);
            flpSearchResults.Invalidate();
        }

        private void CreateNullEntry(string CusName)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpSearchResults.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpSearchResults.ClientSize.Width - 6, 50);
            flpSearchResults.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpSearchResults.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flpSearchResults.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width - 5, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 12, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(179, 179, 179);

            //Updating the Panel and forcing it to refresh its self
            flpSearchResults.Height = (flpSearchResults.Controls.Count) * p.Height + 8;
            flpSearchResults.Invalidate();
        }

        protected void lblSearchClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            //MessageBox.Show(lbl.Name);

            //find int from name

            string name = lbl.Name;
            string id = name.Substring(name.Length - 1);
            int clientPosition = Convert.ToInt32(id);

            clientPosition--;
            //MessageBox.Show(Convert.ToString(clientPosition));
            //MessageBox.Show(Convert.ToString(lsClientSearch.Count));
            //MessageBox.Show(lsClientSearch[clientPosition].ClientIDNumber);

            Client objSelect = lsClientSearch[clientPosition];
            PopulateClient(objSelect);
            flpSearchResults.Visible = false;

            tBSearch.Text = "Start Typing Client or Client ID";
            pnlTicket.Enabled = true;
            tbTicketTitle.Focus();


        }

        protected void lblMouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.White;
        }
        protected void lblMouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(210, 4, 45);
        }

        #endregion


        #region SearchBar Methods
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing Client or Client ID")
            {

            }
            else
            {
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                }
                else
                {

                    ResetSearch();
                    flpSearchResults.Visible = true;
                    string Text = tBSearch.Text.ToLower();

                 

                    foreach (Client item in lsAllClients)
                    {
                        if ((item.ClientIDNumber.ToLower().StartsWith(Text)) || (item.PersonName.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(item.PersonName, item.ClientIDNumber) ;
                            lsClientSearch.Add(item);

                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("CLIENT NOT FOUND! Please clear search and try again.");
                    }
                    flpSearchResults.Visible = true;


                    //flpSearchResults.Visible = true;
                    //int value = Convert.ToInt32(tBSearchClient.Text);
                    //value = flpSearchResults.Controls.Count - value;
                    //flpSearchResults.Controls[value].Dispose();
                }
            }
        }

        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tBSearch.Text == "Start Typing Client or Client ID")
                {
                    tBSearch.Clear();
                }
            }
            catch
            {

            }
        }

        private void tBSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    tBSearch.Text = "Start Typing Client or Client ID";
                }
            }
            catch
            {

            }
        }

        private void ResetSearch()
        {
            for (int i = flpSearchResults.Controls.Count - 1; i >= 0; i--)
            {
                flpSearchResults.Controls[i].Dispose();
                lsClientSearch.Clear();
            }
            flpSearchResults.Visible = false;
        }
        #endregion


        private void lblContract_Click(object sender, EventArgs e)
        {

        }

       

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            pBAnswerCall.Image = Properties.Resources.AnswerActiveCall;
            pbDeclineCall.Image = Properties.Resources.DeclineActiveCall;

        }

        private void pBAnswerCall_Click(object sender, EventArgs e)
        {
            CallProgress = true;
            lblTimeStarted.Text = "Time Started :" + " " + DateTime.Now.ToString("h:mm:ss tt");
            Random r = new Random();
            int rInt = r.Next(0, 9);
            lblCellNumber.Text = "Phone Number :" + " " + PhoneNumbers[rInt];
            startTime = DateTime.Now;
           
            ThreadTime = new Thread(new ThreadStart(this.BackThread));
            ThreadTime.IsBackground = true;           
          
            ThreadTime.Start();
            pnlClientDetials.Enabled = true;
            AddCallLog();

        }

        private void BackThread()
        {
            while (CallProgress == true)
            {
                TimeSpan ts = DateTime.Now.Subtract(startTime);
                
                
                string b = ts.ToString(@"hh\:mm\:ss");
                if (this.lblTime.InvokeRequired)
                {
                    this.lblTime.BeginInvoke((MethodInvoker)delegate ()  { this.lblTime.Text = "Call Duration : " + b; ; });
                }

                Thread.Sleep(1000);
            }
           
        }

        private void ChooseNum()
        {
            PhoneNumbers.Add("0763400572");
            PhoneNumbers.Add("0119028045");
            PhoneNumbers.Add("0234562134");
            PhoneNumbers.Add("0714212455"); 
            PhoneNumbers.Add("0963632512");
            PhoneNumbers.Add("0521312312");
            PhoneNumbers.Add("0742323144");
            PhoneNumbers.Add("0832412144");
            PhoneNumbers.Add("0772272321");
            PhoneNumbers.Add("0783823218");
        }

        private void frmCentre_Load(object sender, EventArgs e)
        {
            ChooseNum();
            lsAllClients = objClient.GetAll();
            PopulateCbb();
            pnlTicket.Enabled = false;
            pnlClientDetials.Enabled = false;

        }

        private void TimerCallback(Object o)
        {
            TimeSpan ts = DateTime.Now.Subtract(startTime);
            string a = ts.Hours +":"+ ts.Minutes + ":" + ts.Seconds;
           
            
            lblTime.Invoke(new MethodInvoker(delegate { lblTime.Text = "Call Duration" + " " +a; }));
        }

        private void PopulateClient(Client ce)
        {
            bool foundcon = false;
            bool foundvalid = false;
            tbClientBusName.Text = ce.PersonName;
            tbContact.Text = ce.ClientCell;
            rtbAddress.Text = ce.ClientAddress;

            foreach (CallCentreContract callitem in lstCenContracts)
            {
                if(callitem.ClientID == ce.ClientID && callitem.ContractStatus == "In Progress")
                {
                    tbConStatus.Text = callitem.ContractStatus;
                    tbConType.Text = callitem.ContractType;
                    tbContract.Text = callitem.ContractID;
                    foundcon = true;
                    btnViewContract.Enabled = true;
                    foundvalid = true;
                    ContractPath = callitem.ContractPath;
                }
            }
            if(foundvalid==false)
            {
                foreach (CallCentreContract callitem in lstCenContracts)
                {

                    if (callitem.ClientID == ce.ClientID && callitem.ContractStatus == "Expired")
                    {
                        tbConStatus.Text = callitem.ContractStatus;
                        tbConType.Text = callitem.ContractType;
                        tbContract.Text = callitem.ContractID;
                        foundcon = true;
                        btnViewContract.Enabled = true;
                        foundvalid = true;
                        ContractPath = callitem.ContractPath;
                        break;
                    }
                }
            }

            if(foundcon==false)
            {
                btnViewContract.Enabled = false;
                tbConStatus.Text = "None";
                tbConType.Text = "None";
                tbContract.Text = "No Conctract found for Customer";
            }
                
        }

       

        private void PopulateCbb()
        {
            Issue objissue = new Issue();
            List<Issue> lstIssue = objissue.GetAllIssues();
            

            cbIssueType.DataSource = lstIssue;

            Priority objPriority = new Priority();
            List<Priority> lstPriority = objPriority.GetAllPriority();
            cbPriority.DataSource = lstPriority;

            
           
            cbTechnician.DataSource = lstTechnician;

            cbIssueType.DisplayMember = "IssueName";

            cbPriority.DisplayMember = "Priorityname";

            cbTechnician.DisplayMember = "TechNameList";

            


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            tbTicketTitle.Text = "";
            cbIssueType.TextBox.Clear();
            cbPriority.TextBox.Clear();
            cbTechnician.TextBox.Clear();
            
            rtbTicketDes.Text = "";
            tbTicketTitle.Focus();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            AddTicket();
        }

        public void AddTicket()
        {
            int TechID = 0 ;
            objTicket.ClientID = "A00967764";
            objTicket.EmployeeID = 1;
            objTicket.TicketTitle = tbTicketTitle.Text;
            objTicket.TicketIssueType = cbIssueType.Text;
            objTicket.TicketPriority = cbPriority.Text;
          

            foreach (Technician item in lstTechnician)
            {
                if (item.TechNameList==cbTechnician.Text)
                {
                     TechID= item.TechnicianID;
                }
            }

            objTicket.TechnicianID = TechID;
            DateTime dateAndTime = dtpDueDate.Value;
           
            //fix date
            objTicket.TicketDueDate =dateAndTime.ToShortDateString();
            objTicket.TicketDescription = rtbTicketDes.Text;

            



        }

        public void AddCallLog()
        {
            DateTime time = DateTime.Now;
            time.ToString("HH:mm:ss");

            objCall2.CallStartTime = time;
            objCall2.CallState = 1;
            objCall2.Callstatus = "In-Progress";

            

            objCall2.EmployeeID = 1;

            objCall.InsertCall(objCall2);
           // objCall.ReturnCall(1, time);
           

        }

        private void btnViewContract_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(FullPath, ContractPath);
            btnCloseContract.Visible = true;
            btnReset.Visible = false;
            btnCreateTicket.Visible = false;
            pdfContract.BringToFront();
            pdfContract.Load(FullPath);
            pdfContract.Visible = true;
            

        }

        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnCreateTicket.Visible = true;
            pdfContract.Visible = false;
            btnCloseContract.Visible = false;
        }
    }
}
