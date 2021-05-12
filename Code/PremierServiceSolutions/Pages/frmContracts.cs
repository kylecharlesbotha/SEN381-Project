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
        #endregion

        #region Variables
        List<Contract> lstContract = new List<Contract>();
        List<Contract> lstSearchContract = new List<Contract>();
        byte[] ContractPath;
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        private string FullPath;
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
            DateTime now = new DateTime();
            now = DateTime.Now;
            dtpConEndDate.Value = now.AddMonths(3);
        }
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
            PopulateTechnicians();
        }

        public void PopulateTechnicians()
        {
            foreach (Contract conitem in lstContract)
            {
                CreateEntry(conitem.ContractID, conitem.ClientID, conitem.ContractType, conitem.StartDate , conitem.EndDate, conitem.ContractStatus);
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
        protected void ShowContractDetails(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Contract newCont = objContract.GetContractDetails(lbl.Text);
            PopulateDetails(newCont);
            pnlContractDetails.Visible = true;
            tBSearch.Enabled = false;
        }

        private void PopulateDetails(Contract cont)
        {
            tbDetailsContractID.Text = cont.ContractID;
            tbDetailsClientID.Text = cont.ClientID;
            tbDetailsContractDescription.Text = cont.ContractDescription;
            tbDetailsConStart.Text = cont.StartDate.ToString("yyyy-MM-dd");
            tbDetailsConEnd.Text = cont.EndDate.ToString("yyyy-MM-dd");
            tbDetailsContractType.Text = cont.ContractType;
            ContractPath = cont.ContractFilePath;
        }

        #endregion



        #region Search for Employee Methods
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
                    PopulateTechnicians();
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
                PopulateTechnicians();
                flpContracts.Visible = true;
            }

        }


        #endregion

        #region Panel Contract Details
        private void btnDeleteContract_Click(object sender, EventArgs e)
        {

        }

        private void btnActiveContract_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlContractDetails.Visible = false;
        }

        private void btnSaveChanged_Click(object sender, EventArgs e)
        {

        }
        private void btnViewContractPDF_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(FullPath, ContractPath);
            pdfContractViewer.BringToFront();
            pdfContractViewer.Load(FullPath);
            pdfContractViewer.Visible = true;
            btnCloseContract.Visible = true;
            btnDeleteContract.Visible = false;
            btnClose.Visible = false;
            btnSaveChanged.Visible = false;
        }
        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            pdfContractViewer.Visible = false;
            btnCloseContract.Visible = false;
            btnDeleteContract.Visible = true;
            btnClose.Visible = true;
            btnSaveChanged.Visible = true;
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            pnlNewContract.Visible = true;
        }

        #endregion


        #region New Contract methods
        private void dtpConStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime setDate = dtpConStart.Value;
            setDate = setDate.AddMonths(3);
            dtpConEndDate.MinDate = setDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewContract.Visible = false;
        }
        #endregion
    }



}
