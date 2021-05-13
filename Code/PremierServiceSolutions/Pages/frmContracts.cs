using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmContracts : Form
    {

        #region Class Objects
        Contract objContract = new Contract();
        ContractType objContractType = new ContractType();
        Service objService = new Service();
        ServiceLevelAgreement objSLA = new ServiceLevelAgreement();
        Client objClient = new Client();
        #endregion

        #region Variables
        public BindingSource TsDataSource;
        public BindingSource TslaDataSource;

        List<Contract> lstContract = new List<Contract>();
        List<ServiceLevelAgreement> lstSLA = new List<ServiceLevelAgreement>();
        List<Client> lstClient = new List<Client>();
        List<ContractType> lstNewContractType = new List<ContractType>();
        List<Service> lstService = new List<Service>();
        List<Service> lstContractService = new List<Service>();
        List<bool> BoolServices = new List<bool>();
        byte[] ContractPath;
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        private string FullPath;

        //Variables for frmNewContract
        bool CheckNewConCus = false;
        bool CheckContractType = false;
        bool CheckFile = false;
        bool CheckDescription = false;
        bool CheckDateStart = false;
        bool CheckDateEnd = false;

        #endregion

        public frmContracts()
        {
            InitializeComponent();
            LoadCon();
            pnlContractDetails.Left = 9;
            pnlContractDetails.Top = 126;
            FullPath = GetTemporaryDirectory();
            FullPath += @"\Temp.pdf";
            pdfContractViewer.Left = 9;
            pdfContractViewer.Top = 8;
            pnlNewContract.Left = 9;
            pnlNewContract.Top = 8;
            LoadNewContracts();
            lstClient = objClient.GetAll();
            flpSearchResults.BringToFront();
        }
        #region Loading Data for New Contracts
        private void LoadNewContracts()
        {
            lstService = objService.GetService();
            lstService.Sort();
            lstNewContractType = objContractType.GetAllContractTypes();
            cbContractType.DataSource = lstNewContractType;
            cbContractType.DisplayMember = "ContractName";
            DateTime now = new DateTime();
            now = DateTime.Now;
            dtpConEndDate.Value = now.AddMonths(3);
            foreach (Service seritem in lstService)
            {
                CreateService(seritem.ServiceDescription);
            }

        }

        private void CreateService(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "Service Panel" + (flpNewConServices.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpNewConServices.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpNewConServices.ClientSize.Width - 20, 50);
            flpNewConServices.Controls.Add(p);

            CheckBox CB = new CheckBox();
            CB.Name = flpNewConServices.Controls.Count.ToString();
            CB.Text = Text;
            CB.AutoSize = false;
            CB.Size = new Size(p.Width - 10, 30);
            p.Controls.Add(CB);
            CB.Top = 10;
            CB.TextAlign = ContentAlignment.MiddleLeft;
            CB.Left = 10;
            CB.Font = new Font("Arial", 10, FontStyle.Bold);
            CB.ForeColor = Color.White;
            CB.Click += new EventHandler(ServiceClick);

            BoolServices.Add(false);
            //Updating the Panel and forcing it to refresh its self
            flpNewConServices.Invalidate();
        }

        protected void ServiceClick(object sender, EventArgs e)
        {
            CheckBox CB = sender as CheckBox;
            int count = Convert.ToInt32(CB.Name);
            BoolServices[count - 1] = !BoolServices[count - 1];
        }

        #endregion
        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        #region Loading Contracts
        private void LoadCon()
        {
            lstContract = objContract.GetContractRecords();
            lstContract.Sort();
            PopulateContracts();
        }

        public void PopulateContracts()
        {
            foreach (Contract conitem in lstContract)
            {
                if (conitem.ContractState == 1)
                {
                    CreateEntry(conitem.ContractID, conitem.ClientID, conitem.ContractType, conitem.StartDate, conitem.EndDate, conitem.ContractStatus);
                }
            }
        }
        #endregion

        #region Asset Panel
        private void CreateEntry(string ID, string ClientID, string ContractType, DateTime StartDate, DateTime EndDate, string ContractStats)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpContracts.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpContracts.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpContracts.ClientSize.Width - 25, 50);
            flpContracts.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpContracts.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lAssName = new Label();
            lAssName.Name = "lblContractID" + flpContracts.Controls.Count;
            lAssName.Text = ID;
            lAssName.AutoSize = false;
            lAssName.Size = new Size(120, 30);
            p.Controls.Add(lAssName);
            lAssName.Top = 10;
            lAssName.TextAlign = ContentAlignment.MiddleCenter;
            lAssName.Left = 15;
            lAssName.Font = new Font("Arial", 10, FontStyle.Bold);
            lAssName.ForeColor = Color.White;
            lAssName.MouseEnter += new EventHandler(HoverEnter);
            lAssName.MouseLeave += new EventHandler(HoverLeave);
            lAssName.Click += new EventHandler(ShowContractDetails);
            //lAssName.BackColor = Color.Red;            


            //Creating Label for Name
            Label lCusName = new Label();
            lCusName.Name = "lblClientName" + flpContracts.Controls.Count;
            lCusName.Text = ClientID;
            lCusName.AutoSize = false;
            lCusName.Size = new Size(120, 30);
            p.Controls.Add(lCusName);
            lCusName.Top = 10;
            lCusName.TextAlign = ContentAlignment.MiddleLeft;
            lCusName.Left = (lAssName.Left + lAssName.Width + 20);
            lCusName.Font = new Font("Arial", 10, FontStyle.Bold);
            lCusName.ForeColor = Color.White;
            lCusName.MouseEnter += new EventHandler(HoverEnter);
            lCusName.MouseLeave += new EventHandler(HoverLeave);
            //lCusName.BackColor = Color.Green;

            //Creating Label for Surname
            Label LManu = new Label();
            LManu.Name = "lblType" + flpContracts.Controls.Count;
            LManu.Text = ContractType;
            LManu.AutoSize = false;
            LManu.Size = new Size(100, 30);
            p.Controls.Add(LManu);
            LManu.Top = 10;
            LManu.TextAlign = ContentAlignment.MiddleLeft;
            LManu.Left = (lCusName.Left + lCusName.Width + 20);
            LManu.Font = new Font("Arial", 10, FontStyle.Bold);
            LManu.ForeColor = Color.White;
            LManu.MouseEnter += new EventHandler(HoverEnter);
            LManu.MouseLeave += new EventHandler(HoverLeave);
            //LManu.BackColor = Color.Blue;


            //Creating Label for Role
            StartDate.ToString("yyyy-MM-dd HH:mm:ss");
            StartDate.ToString("yyyy-MM-dd");
            Label LMod = new Label();
            LMod.Name = "lblStartDate" + flpContracts.Controls.Count;
            LMod.Text = StartDate.ToString();
            LMod.AutoSize = false;
            LMod.Size = new Size(120, 30);
            p.Controls.Add(LMod);
            LMod.Top = 10;
            LMod.TextAlign = ContentAlignment.MiddleLeft;
            LMod.Left = (LManu.Left + LManu.Width + 20);
            LMod.Font = new Font("Arial", 10, FontStyle.Bold);
            LMod.ForeColor = Color.White;
            LMod.MouseEnter += new EventHandler(HoverEnter);
            LMod.MouseLeave += new EventHandler(HoverLeave);
            //LMod.BackColor = Color.Purple;


            //Creating Label for Email
            EndDate.ToString("yyyy-MM-dd HH:mm:ss");
            EndDate.ToString("yyyy-MM-dd");
            Label lSerial = new Label();
            lSerial.Name = "lblEndDate" + flpContracts.Controls.Count;
            lSerial.Text = EndDate.ToString();
            lSerial.AutoSize = false;
            lSerial.Size = new Size(120, 30);
            p.Controls.Add(lSerial);
            lSerial.Top = 10;
            lSerial.TextAlign = ContentAlignment.MiddleLeft;
            lSerial.Left = (LMod.Left + LMod.Width + 20);
            lSerial.Font = new Font("Arial", 10, FontStyle.Bold);
            lSerial.ForeColor = Color.White;
            lSerial.MouseEnter += new EventHandler(HoverEnter);
            lSerial.MouseLeave += new EventHandler(HoverLeave);
            //lSerial.BackColor = Color.Orange;

            //Creating Label for Email
            Label lStatus = new Label();
            lStatus.Name = "lblStatus" + flpContracts.Controls.Count;
            lStatus.Text = ContractStats;
            lStatus.AutoSize = false;
            lStatus.Size = new Size(100, 30);
            p.Controls.Add(lStatus);
            lStatus.Top = 10;
            lStatus.TextAlign = ContentAlignment.MiddleLeft;
            lStatus.Left = (lSerial.Left + lSerial.Width + 20);
            lStatus.Font = new Font("Arial", 10, FontStyle.Bold);
            lStatus.ForeColor = Color.White;
            lStatus.MouseEnter += new EventHandler(HoverEnter);
            lStatus.MouseLeave += new EventHandler(HoverLeave);



            //Updating the Panel and forcing it to refresh its self
            flpContracts.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpContracts.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpContracts.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpContracts.ClientSize.Width, 50);
            flpContracts.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpContracts.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpContracts.Controls.Count;
            lID.Text = Text;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width - 30, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.MouseEnter += new EventHandler(HoverEnter);
            lID.MouseLeave += new EventHandler(HoverLeave);
            //lID.BackColor = Color.Red;            


            //Updating the Panel and forcing it to refresh its self
            flpContracts.Invalidate();
        }
        protected void HoverEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(218, 0, 0);
        }
        protected void HoverLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.White;
        }


        #endregion

        #region Contract Details Methods
        protected void ShowContractDetails(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Contract newCont = new Contract();
            newCont = objContract.GetContractDetails(lbl.Text);
            lstContractService = objService.GetContractService(lbl.Text);
            lstSLA = objSLA.GetConSLA(lbl.Text);
            PopulateDetails(newCont);
            pnlContractDetails.Visible = true;
            tBSearch.Enabled = false;
            tBSearch.Text = "Start Typing ContractID/CustomerID";
            tbDetailsClientID.Focus();
        }

        private void PopulateDetails(Contract cont)
        {
            if (cont.ContractState == 1)
            {
                btnActiveContract.Visible = false;
                btnDeleteContract.Visible = true;
            }
            else
            {
                btnActiveContract.Visible = true;
                btnDeleteContract.Visible = false;
            }
            if (lstContractService.Count > 0)
            {
                //Binding Service CBB to TextBox
                TsDataSource = new BindingSource();
                TsDataSource.DataSource = lstContractService;
                sfContractServices.DataSource = TsDataSource;
                sfContractServices.DisplayMember = "ServiceName";
                sfContractServices.ValueMember = "ServiceID";
                sfContractServices.SelectedIndex = 0;
                tbDetailsServiceDes.DataBindings.Clear();
                tbDetailsServiceDes.DataBindings.Add(new Binding("Text", TsDataSource, "ServiceDescription"));
            }
            else
            {
                sfContractServices.Text = "No Service Found";
                tbDetailsServiceDes.Text = "No Description";
            }

            if (lstSLA.Count > 0)
            {
                //Binding SLA CBB to TextBox
                TslaDataSource = new BindingSource();
                TslaDataSource.DataSource = lstSLA;
                sfContractSLA.DataSource = TslaDataSource;
                sfContractSLA.DisplayMember = "SlaTitle";
                sfContractSLA.ValueMember = "SlaID";
                sfContractSLA.SelectedIndex = 0;
                tbDetailsSLADescription.DataBindings.Clear();
                tbDetailsSLADescription.DataBindings.Add(new Binding("Text", TslaDataSource, "SlaDescription"));
            }
            else
            {
                sfContractSLA.Text = "No SLA Found";
                tbDetailsSLADescription.Text = "No Description";
            }



            //Populating TextBoxes
            tbDetailsContractID.Text = cont.ContractID;
            tbDetailsClientID.Text = cont.ClientID;
            tbDetailsContractDescription.Text = cont.ContractDescription;
            tbDetailsConStart.Text = cont.StartDate.ToString("yyyy-MM-dd");
            tbDetailsConEnd.Text = cont.EndDate.ToString("yyyy-MM-dd");
            tbDetailsContractType.Text = cont.ContractType;
            ContractPath = cont.ContractFilePath;
        }
        #endregion



        #region Search for Contract Methods
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing ContractID/CustomerID")
            {

            }
            else
            {
                flpContracts.Visible = false;
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                    PopulateContracts();
                    flpContracts.Visible = true;
                }
                else
                {

                    ResetSearch();
                    flpContracts.Visible = false;
                    string Text = tBSearch.Text.ToLower();



                    foreach (Contract conitem in lstContract)
                    {
                        if ((conitem.ContractID.StartsWith(Text)) || (conitem.ClientID.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(conitem.ContractID, conitem.ClientID, conitem.ContractType, conitem.StartDate, conitem.EndDate, conitem.ContractStatus);
                            found = true;

                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("Contract Not Found! Please clear search and try again.");
                    }
                    flpContracts.Visible = true;
                }
            }
        }


        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tBSearch.Text == "Start Typing ContractID/CustomerID")
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
                    tBSearch.Text = "Start Typing ContractID/CustomerID";
                }
            }
            catch
            {

            }
        }
        private void ResetSearch()
        {
            for (int i = flpContracts.Controls.Count - 1; i >= 0; i--)
            {
                flpContracts.Controls[i].Dispose();
            }
            flpContracts.Visible = false;
        }


        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tBSearch.Text = "Start Typing ContractID/CustomerID";
                pnlTopContracts.Focus();
                flpContracts.Visible = false;
                ResetSearch();
                PopulateContracts();
                flpContracts.Visible = true;
            }

        }


        #endregion

        #region Panel Contract Details
        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            bool submitted = objContract.DeleteContract(tbDetailsContractID.Text);
            if (submitted == true)
            {
                MessageBox.Show(tbDetailsContractID.Text + " has been successfully de-activated");
                tbContractDescription.Focus();
                tBSearch.Text = "Start Typing ContractID/CustomerID";
                tBSearch.Enabled = true;
                ResetSearch();
                LoadCon();
                pnlContractDetails.Visible = false;
                flpContracts.Visible = true;
            }
            else
            {
                MessageBox.Show("Error occured! " + tbDetailsContractID.Text + "could not be de-activated");
            }
        }

        private void btnActiveContract_Click(object sender, EventArgs e)
        {
            bool submitted = objContract.ActivateContract(tbDetailsContractID.Text);
            if (submitted == true)
            {
                MessageBox.Show(tbDetailsContractID.Text + " has been successfully re-activated");
                tbContractDescription.Focus();
                tBSearch.Text = "Start Typing ContractID/CustomerID";
                tBSearch.Enabled = true;
                ResetSearch();
                LoadCon();
                pnlContractDetails.Visible = false;
                flpContracts.Visible = true;
            }
            else
            {
                MessageBox.Show("Error occured! " + tbDetailsContractID.Text + " could not be re-activated");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlContractDetails.Visible = false;
            tBSearch.Enabled = true;
        }

        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            pdfContractViewer.Visible = false;
            btnCloseContract.Visible = false;
            btnDeleteContract.Visible = true;
            btnClose.Visible = true;

        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            pnlNewContract.Visible = true;
            btnReset_Click(null,null);
        }

        #endregion


        #region New Contract methods
        private void btnViewContractPDF_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(FullPath, ContractPath);
            pdfContractViewer.BringToFront();
            pdfContractViewer.Load(FullPath);
            pdfContractViewer.Visible = true;
            btnCloseContract.Visible = true;
            btnDeleteContract.Visible = false;
            btnClose.Visible = false;

        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewContract.Visible = false;
        }

        private void btnUpLoadCont_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Pdf Files|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            tbNewContFile.Text = filePath;
        }

        #endregion


        #region Search Methods new Contract
        private void tbNewConCusSearc_TextChanged(object sender, EventArgs e)
        {
            if (tbNewConCusSearc.Text == "Start Typing CustomerID/Name")
            {

            }
            else
            {
                bool found = false;
                if (String.IsNullOrWhiteSpace(tbNewConCusSearc.Text))
                {
                    ResetSearchNew();
                }
                else
                {

                    ResetSearchNew();
                    flpSearchResults.Visible = true;
                    string Text = tbNewConCusSearc.Text.ToLower();



                    foreach (Client item in lstClient)
                    {
                        if ((item.ClientIDNumber.ToLower().StartsWith(Text)) || (item.PersonName.ToLower().StartsWith(Text)))
                        {
                            CreateSearchEntry(item.PersonName, item.ClientIDNumber);
                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntrySearch("CLIENT NOT FOUND! Please clear search and try again.");
                    }
                    flpSearchResults.Visible = true;

                }
            }
        }

        private void ResetSearchNew()
        {
            for (int i = flpSearchResults.Controls.Count - 1; i >= 0; i--)
            {
                flpSearchResults.Controls[i].Dispose();
            }
            flpSearchResults.Visible = false;
        }

        private void tbNewConCusSearc_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tbNewConCusSearc.Text == "Start Typing CustomerID/Name")
                {
                    tbNewConCusSearc.Clear();
                }
            }
            catch
            {

            }
        }

        private void tbNewConCusSearc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNewConCusSearc.Text))
                {
                    tbNewConCusSearc.Text = "Start Typing CustomerID/Name";
                }
            }
            catch
            {

            }
        }

        private void CreateSearchEntry(string CusName, string CusID)
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
            lID.MouseEnter += new EventHandler(HoverEnter);
            lID.MouseLeave += new EventHandler(HoverLeave);



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
            lCus.MouseEnter += new EventHandler(HoverEnter);
            lCus.MouseLeave += new EventHandler(HoverLeave);

            //Updating the Panel and forcing it to refresh its self
            flpSearchResults.Height = flpSearchResults.Controls.Count * p.Height + (8 * flpSearchResults.Controls.Count);
            flpSearchResults.Invalidate();
        }
        private void CreateNullEntrySearch(string CusName)
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
            string name = lbl.Text;
            tbNewContCus.Text = name;
            tbNewConCusSearc.Text = "Start Typing CustomerID/Name";
            flpSearchResults.Visible = false;
            ResetSearchNew();
            tbNewContCus.Focus();


        }


        #endregion new Co

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (bool item in BoolServices)
            {
                MessageBox.Show(item.ToString() + " " + lstService[count].ServiceDescription);
                count++;
            }
        }

        #region Customer Methods
        private void tbNewContCus_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbNewContCus.Text))//If valid information are given do following
            {
                lblNewConCusCheck.Text = "";
                pbNewConCusCheck.Show();
                pbNewConCusCheck.Image = Properties.Resources.checkmark;
                CheckNewConCus = true;
            }
            else
            {
                lblNewConCusCheck.Text = "Please choose customer from searchbar on left";
                pbNewConCusCheck.Image = Properties.Resources.DeleteMark;
                CheckNewConCus = false;
            }
        }


        #endregion

        #region ComboBoxList Contract Type Methods
        private void cbContractType_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbContractType.SelectedIndex > -1)//if something is selected
            {
                CheckContractType = true;
                lblContractTypeCheck.Text = "";
                pbContractTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckContractType = false;
                lblContractTypeCheck.Text = "Please select option below";
                pbContractTypeCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbContractType_SelectedIndexChanged(object sender, EventArgs e) //On combobox selection change
        {
            if (cbContractType.SelectedIndex > -1)//if something is selected
            {
                CheckContractType = true;
                lblContractTypeCheck.Text = "";
                pbContractTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckContractType = false;
                lblContractTypeCheck.Text = "Please select option below";
                pbContractTypeCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        #endregion

        #region File Methods
        private void tbNewContFile_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbNewContFile.Text))//If valid information are given do following
            {
                lblNewConFileCheck.Text = "";
                pbNewContFile.Show();
                pbNewContFile.Image = Properties.Resources.checkmark;
                CheckFile = true;
            }
            else
            {
                lblNewConFileCheck.Text = "Please upload a file below";
                pbNewContFile.Image = Properties.Resources.DeleteMark;
                CheckFile = false;
            }
        }

        #endregion

        #region Contract Description Methods
        private void tbContractDescription_Leave(object sender, EventArgs e)//On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbContractDescription.Text))
            {
                pbNewContDesc.Image = Properties.Resources.DeleteMark;
                CheckDescription = false;
                lblContractDescriptionCheck.Text = "Please enter description below";
            }
            else
            {
                pbNewContDesc.Image = Properties.Resources.checkmark;
                CheckDescription = true;
                pbNewContDesc.Show();
                lblContractDescriptionCheck.Text = "";

            }
        }

        private void tbContractDescription_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbContractDescription.Text))//If valid information are given do following
            {
                pbNewContDesc.Image = Properties.Resources.checkmark;
                CheckDescription = true;
                pbNewContDesc.Show();
                lblContractDescriptionCheck.Text = "";
            }
            else
            {
                pbNewContDesc.Image = Properties.Resources.DeleteMark;
                CheckDescription = false;
                pbNewContDesc.Hide();
                lblContractDescriptionCheck.Text = "Please enter description below";
            }
        }

        #endregion

        #region DateTimePickers Start/End Methods
        private void dtpConEndDate_ValueChanged(object sender, EventArgs e)
        {
            CheckDateEnd = true;
            lblNewContEndCheck.Text = "";
            pbNewContEndCheck.Image = Properties.Resources.checkmark;
        }

        private void dtpConStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime setDate = dtpConStart.Value;
            DateTime currentdate = new DateTime();
            currentdate = DateTime.Now;
            dtpConStart.MinDate = currentdate;
            setDate = setDate.AddMonths(3);
            dtpConEndDate.MinDate = setDate;

            CheckDateStart = true;
            lblNewContStartCheck.Text = "";
            pbNewContStartCheck.Image = Properties.Resources.checkmark;
        }

        #endregion

        #region Button Reset Methods
        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset fields to default state
            tbNewConCusSearc.Text = "Start Typing CustomerID/Name";
            tbNewContCus.Text = "";
            tbNewContFile.Text = "";
            tbContractDescription.Text = "";
            cbContractType.SelectedIndex = -1;

            //Reset labels to default states
            lblNewConCusCheck.Text = "Please choose customer from searchbar on left";
            lblContractTypeCheck.Text = "Please select option below";
            lblNewConFileCheck.Text = "Please upload a file below";
            lblContractDescriptionCheck.Text = "Please enter description below";
            lblNewContEndCheck.Text = "Please choose date below";
            lblNewContStartCheck.Text = "Please choose date below";

            //Reset all Validation images to incorrect
            pbNewConCusCheck.Image = Properties.Resources.DeleteMark;
            pbContractTypeCheck.Image = Properties.Resources.DeleteMark;
            pbNewContFile.Image = Properties.Resources.DeleteMark;
            pbNewContDesc.Image = Properties.Resources.DeleteMark;
            pbNewContStartCheck.Image = Properties.Resources.DeleteMark;
            pbNewContEndCheck.Image = Properties.Resources.DeleteMark;

            //reset datetimepickers value to default
            DateTime setDate = dtpConStart.Value;
            DateTime currentdate = new DateTime();
            currentdate = DateTime.Now;
            dtpConStart.MinDate = currentdate;
            setDate = setDate.AddMonths(3);
            dtpConEndDate.MinDate = setDate;

            //Reset Validation Variables for frmNewContract to default state
            bool CheckNewConCus = false;
            bool CheckContractType = false;
            bool CheckFile = false;
            bool CheckDescription = false;
            bool CheckDateStart = false;
            bool CheckDateEnd = false;
        }
        #endregion
    }
}
