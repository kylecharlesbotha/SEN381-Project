using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmCustomers : Form
    {

        #region Class Objects
        Client objclient = new Client();
        Client objInsertClient = new Client();

        #endregion

        #region Variables
        List<Client> lstClients = new List<Client>();
        List<Client> lstSearchClients = new List<Client>();
        #endregion
        public frmCustomers()
        {
            this.Width = 740;
            this.Height = 900;
            InitializeComponent();

            pnlNewClient.Left = 9;
            pnlNewClient.Top = 11;
            LoadCus();
        }
        private void LoadCus()
        {
            lstClients = objclient.GetAll();
            lstClients.Sort();
            PopulateClients();
            PopulateCBB();
        }

        #region Populate Methods
        public void PopulateClients()
        {
            foreach (Client clitem in lstClients)
            {
                CreateEntry(clitem.ClientID,clitem.PersonName,clitem.ClientCell,clitem.ClientEmail,clitem.ClientCreationDate);
            }
        }

        public void PopulateCBB()
        {
            List<string> Genders = new List<string>();
            Genders.Add("Male");
            Genders.Add("Female");

            List<string> Titles = new List<string>();
            Titles.Add("Dr");
            Titles.Add("Mr");
            Titles.Add("Mrs");
            Titles.Add("Ms");
            Titles.Add("Prof");
            Titles.Add("Rev");

            List<int> Priorities = new List<int>();
            Priorities.Add(0);
            Priorities.Add(1);
            Priorities.Add(2);
            Priorities.Add(3);
            Priorities.Add(4);

            cbGender.DataSource = Genders;
            cbTitle.DataSource = Titles;
            cbPriority.DataSource = Priorities;
            
        }

        #endregion

        #region Textbox Search Methods
        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tBSearch.Text = "Start Typing Client or Client ID";
                pnlTopClient.Focus();
                flpCustomers.Visible = false;
                ResetSearch();
                PopulateClients();
                flpCustomers.Visible = true;
            }
        }
        private void tBSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion

        #region Client Panel
        private void CreateEntry(string ID, string Name, string Contacts,string Email,DateTime DateCreated)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpCustomers.Controls.Count + 1);
            
            //Statement to alternate the colors of the panels
            if (flpCustomers.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpCustomers.ClientSize.Width-25, 50);
            flpCustomers.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpCustomers.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblID" + flpCustomers.Controls.Count;
            lID.Text = ID;
            lID.AutoSize = false;
            lID.Size = new Size(130, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.MouseEnter += new EventHandler(HoverEnter);
            lID.MouseLeave += new EventHandler(HoverLeave);
            //lID.BackColor = Color.Red;            
            
            
            //Creating Label for Name
            Label lTi = new Label();
            lTi.Name = "lblName" + flpCustomers.Controls.Count;
            lTi.Text = Name;
            lTi.AutoSize = false;
            lTi.Size = new Size(150, 30);
            p.Controls.Add(lTi);
            lTi.Top = 10;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = (lID.Left + lID.Width + 20);
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.White;
            lTi.MouseEnter += new EventHandler(HoverEnter);
            lTi.MouseLeave += new EventHandler(HoverLeave);
            //lTi.BackColor = Color.Green;

            //Creating Label for Contact
            Label LCon = new Label();
            LCon.Name = "lblContact" + flpCustomers.Controls.Count;
            LCon.Text = Contacts;
            LCon.AutoSize = false;
            LCon.Size = new Size(150, 30);
            p.Controls.Add(LCon);
            LCon.Top = 10;
            LCon.TextAlign = ContentAlignment.MiddleCenter;
            LCon.Left =(lTi.Left + lTi.Width + 20);
            LCon.Font = new Font("Arial", 10, FontStyle.Bold);
            LCon.ForeColor = Color.White;
            LCon.MouseEnter += new EventHandler(HoverEnter);
            LCon.MouseLeave += new EventHandler(HoverLeave);
            //LCon.BackColor = Color.Blue;


            //Creating Label for Email
            Label lEm = new Label();
            lEm.Name = "lblEmail" + flpCustomers.Controls.Count;
            lEm.Text = Email;
            lEm.AutoSize = false;
            lEm.Size = new Size(200, 30);
            p.Controls.Add(lEm);
            lEm.Top = 10;
            lEm.TextAlign = ContentAlignment.MiddleLeft;
            lEm.Left = (LCon.Left + LCon.Width + 20);
            lEm.Font = new Font("Arial", 10, FontStyle.Bold);
            lEm.ForeColor = Color.White;
            lEm.Click += new EventHandler(EmailClicked);
            lEm.MouseEnter += new EventHandler(HoverEnter);
            lEm.MouseLeave += new EventHandler(HoverLeave);
            //lEm.BackColor = Color.Purple;

            //Creating Label for DateCreated
            DateCreated.ToString("yyyy-MM-dd HH:mm:ss");
            DateCreated.ToString("yyyy-MM-dd");
            Label lDate = new Label();
            lDate.Name = "lblDateCreated" + flpCustomers.Controls.Count;
            lDate.Text = Convert.ToString(DateCreated);
            lDate.AutoSize = false;
            lDate.Size = new Size(130, 30);
            p.Controls.Add(lDate);
            lDate.Top = 10;
            lDate.TextAlign = ContentAlignment.MiddleLeft;
            lDate.Left = (lEm.Left + lEm.Width + 20);
            lDate.Font = new Font("Arial", 10, FontStyle.Bold);
            lDate.ForeColor = Color.White;
            lDate.MouseEnter += new EventHandler(HoverEnter);
            lDate.MouseLeave += new EventHandler(HoverLeave);
            //lDate.BackColor = Color.Orange;



            //Updating the Panel and forcing it to refresh its self
            flpCustomers.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpCustomers.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpCustomers.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpCustomers.ClientSize.Width , 50);
            flpCustomers.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpCustomers.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpCustomers.Controls.Count;
            lID.Text = Text;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width-30, 30);
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
            flpCustomers.Invalidate();
        }
        protected void EmailClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            System.Diagnostics.Process.Start("mailto:" + lbl.Text);
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

        #region Adding New Client
        private void btnRAddClient_Click(object sender, EventArgs e)
        {
            pnlNewClient.Visible = true;
            btnReset_Click(null,null);//resets entry form to default state. Acts as a form load
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewClient.Visible = false;
        }
        #endregion

        #region Search for Client
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing Client or Client ID")
            {

            }
            else
            {
                flpCustomers.Visible = false;
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                    PopulateClients();
                    flpCustomers.Visible = true;
                }
                else
                {

                    ResetSearch();
                    flpCustomers.Visible = false;
                    string Text = tBSearch.Text.ToLower();



                    foreach (Client clitem in lstClients)
                    {
                        if ((clitem.ClientIDNumber.ToLower().StartsWith(Text)) || (clitem.PersonName.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(clitem.ClientID, clitem.PersonName, clitem.ClientCell, clitem.ClientEmail, clitem.ClientCreationDate);
                            lstSearchClients.Add(clitem);

                            found = true;
                            
                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("CLIENT NOT FOUND! Please clear search and try again.");
                    }
                    flpCustomers.Visible = true;


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
            for (int i = flpCustomers.Controls.Count - 1; i >= 0; i--)
            {
                flpCustomers.Controls[i].Dispose();
                lstSearchClients.Clear();
            }
            flpCustomers.Visible = false;
        }

        #endregion


        //////////////////////PNL NEW CUSTOMERS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        #region Variables
        //Bool Functions to check if respective information are filled in (Live validation).
        bool CheckFirstName = false;
        bool CheckSurname = false;
        bool CheckIdNumber = false;
        bool CheckEmail = false;
        bool CheckPhone = false;
        bool CheckPriority = false;
        bool CheckTitle = false;
        bool CheckGender = false;
        bool CheckAddress = false;
        bool CheckAddress2 = false;
        bool CheckCity = false;
        bool CheckCountry = false;
        bool CheckZip = false;

        #endregion

        #region Button Reset Methods (pnl load)
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Boolean variables used for live Validation statuses.(Used to check if all information required are correct and filled in before commencing)
            //CheckEmpNum = false;
            //CheckUsername = false;
            //CheckPassword = false;
            //CheckConfirmPassword = false;
            //CheckAdminCode = false;
            //CheckUserType = false;

            //Clear all content in textboxes
            tbFirstName.Text = "";
            tbSurname.Text = "";
            tbIDNumber.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            tbAddress2.Text = "";
            tbState.Text = "";
            tbCity.Text = "";
            tbZip.Text = "";



            //Show and Hide checkboxes.(Used to show live validation status of input controls)
            pbFirstNameCheck.Hide();
            pbFirstNameCheck.Image = Properties.Resources.DeleteMark;
            pbSurnameCheck.Hide();
            pbSurnameCheck.Image = Properties.Resources.DeleteMark;
            pbIDNumberCheck.Hide();
            pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
            pbEmailCheck.Hide();
            pbEmailCheck.Image = Properties.Resources.DeleteMark;
            pbPhoneCheck.Hide();
            pbPhoneCheck.Image = Properties.Resources.DeleteMark;
            pbPriorityCheck.Show();
            pbPriorityCheck.Image = Properties.Resources.DeleteMark;
            cbPriority.SelectedIndex = -1;
            pbTitleCheck.Show();
            pbTitleCheck.Image = Properties.Resources.DeleteMark;
            cbTitle.SelectedIndex = -1;
            pbClientGenderCheck.Show();
            pbClientGenderCheck.Image = Properties.Resources.DeleteMark;
            cbGender.SelectedIndex = -1;
            pbAddressCheck.Hide();
            pbAddressCheck.Image = Properties.Resources.DeleteMark;
            pbAddress2Check.Hide();
            pbAddress2Check.Image = Properties.Resources.DeleteMark;
            pbCityCheck.Hide();
            pbCityCheck.Image = Properties.Resources.DeleteMark;
            pbCountryCheck.Hide();
            pbCountryCheck.Image = Properties.Resources.DeleteMark;
            pbZipCheck.Hide();
            pbZipCheck.Image = Properties.Resources.DeleteMark;

            //Sets relevant label messages(Used for validation) for respective input controls
            lblFirstNameCheck.Text = "";
            lblSurnameCheck.Text = "";
            lblIDNumberCheck.Text = "";
            lblPhoneCheck.Text = "";
            lblPriorityCheck.Text = "Please select option below";
            lblTitleCheck.Text = "Please select option below";
            lblClientGenderCheck.Text = "Please select option below";
            lblCityCheck.Text = "";
            lblCountryCheck.Text = "";
            lblZipCheck.Text = "";
        }
        #endregion

        #region FirstName Methods

        private void tbFirstName_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbFirstName.Clear();
            pbFirstNameCheck.Hide();
            lblFirstNameCheck.Text = "";
        }

        private void tbFirstName_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblFirstNameCheck.Text = "";
            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
               
                tbFirstName.Text = "";
                pbFirstNameCheck.Image = Properties.Resources.DeleteMark;
                CheckFirstName = false;
                pbFirstNameCheck.Hide();
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblFirstNameCheck.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblFirstNameCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbFirstName.Text))//If valid information are given do following
            {
                pbFirstNameCheck.Show();
                pbFirstNameCheck.Image = Properties.Resources.checkmark;
                CheckFirstName = true;
            }
            else
            {
                pbFirstNameCheck.Image = Properties.Resources.DeleteMark;
                CheckFirstName = false;
            }
        }

      
        #endregion

        #region Surname Methods
        private void tbSurname_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {

            tbSurname.Clear();
            pbSurnameCheck.Hide();
            lblSurnameCheck.Text = "";
        }

        private void tbSurname_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblSurnameCheck.Text = "";
            if (String.IsNullOrEmpty(tbSurname.Text))
            {
                tbSurname.Text = "";
                pbSurnameCheck.Image = Properties.Resources.DeleteMark;
                CheckSurname = false;
                pbSurnameCheck.Hide();
            }
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblSurnameCheck.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblSurnameCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbSurname_TextChanged(object sender, EventArgs e) //If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbSurname.Text))//If valid information are given do following
            {
                pbSurnameCheck.Show();
                pbSurnameCheck.Image = Properties.Resources.checkmark;
                CheckSurname = true;
            }
            else
            {
                pbSurnameCheck.Image = Properties.Resources.DeleteMark;
                CheckSurname = false;
            }

        }




        #endregion

        #region IDNumber Methods
        private void tbIDNumber_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbIDNumber.Clear();
            pbIDNumberCheck.Hide();
        }

        private void tbIDNumber_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbIDNumber.Text))
            {
                tbIDNumber.Text = "";
                pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
                CheckIdNumber = false;
                pbIDNumberCheck.Hide();
            }
        }

        private void tbIDNumber_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete  )
            {
                lblIDNumberCheck.Text = "Please enter only numbers";
                e.Handled = true;
            }
            else
            {
                lblIDNumberCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbIDNumber_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            pbIDNumberCheck.Show();
            
            if (!String.IsNullOrEmpty(tbIDNumber.Text))//If valid information are given do following
            {

                if (tbIDNumber.Text.Length != 13)
                {
                    lblIDNumberCheck.Text = "Must be 13 characters long";
                    pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
                    CheckIdNumber = false;
                }
                else
                {
                    lblIDNumberCheck.Text = "";
                    pbIDNumberCheck.Image = Properties.Resources.checkmark;
                    CheckIdNumber = true;
                }
            }
            else
            {
                pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
                CheckIdNumber = false;
            }

            foreach (Client clitem in lstClients)
            {
                if (tbIDNumber.Text == clitem.ClientIDNumber)
                {
                    lblIDNumberCheck.Text = "Client already exsisting";
                    pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
                    CheckIdNumber = false;
                }
            }


        }


        #endregion

        #region Email Methods
        private void tbEmail_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbEmail.Clear();
            pbEmailCheck.Hide();
        }

        private void tbEmail_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                tbEmail.Text = "";
                pbSurnameCheck.Image = Properties.Resources.DeleteMark;
                CheckEmail = false;
                pbSurnameCheck.Hide();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            pbEmailCheck.Show();
            if (!String.IsNullOrEmpty(tbEmail.Text))//If valid information are given do following
            {
                if (tbEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(tbEmail.Text.Trim()))
                    {
                        pbEmailCheck.Image = Properties.Resources.DeleteMark;
                        CheckEmail = false;
                    }
                    else
                    {
                        pbEmailCheck.Image = Properties.Resources.checkmark;
                        CheckEmail = true;
                    }
                }
            }
            else
            {
                pbEmailCheck.Image = Properties.Resources.DeleteMark;
                CheckEmail = false;
            }


        }

        #endregion
   
        #region Phone Methods
        private void tbPhone_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbPhone.Clear();
            pbPhoneCheck.Hide();
        }

        private void tbPhone_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblPhoneCheck.Text = "";
            if (String.IsNullOrEmpty(tbPhone.Text))
            {
                tbPhone.Text = "";
                pbPhoneCheck.Image = Properties.Resources.DeleteMark;
                CheckPhone = false;
                pbPhoneCheck.Hide();
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblPhoneCheck.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblPhoneCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            pbPhoneCheck.Show();
            if (!String.IsNullOrEmpty(tbPhone.Text))//If valid information are given do following
            {

                if (tbPhone.Text.Length != 10)
                {
                    lblPhoneCheck.Text = "Must be 10 characters long";
                    pbPhoneCheck.Image = Properties.Resources.DeleteMark;
                    CheckPhone = false;
                }
                else
                {
                    lblPhoneCheck.Text = "";
                    pbPhoneCheck.Image = Properties.Resources.checkmark;
                    CheckPhone = true;
                }
            }
            else
            {
                pbPhoneCheck.Image = Properties.Resources.DeleteMark;
                CheckPhone = false;
            }
        }




        #endregion

        #region ComboBoxList Priority Methods
        private void cbPriority_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbPriority.SelectedIndex > -1)//if something is selected
            {
                CheckPriority = true;
                lblPriorityCheck.Text = "";
                pbPriorityCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckPriority = false;
                lblPriorityCheck.Text = "Please select option below";
                pbPriorityCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e) //On combobox selection change
        {
            if (cbPriority.SelectedIndex > -1)//if something is selected do following
            {
                CheckPriority = true;
                lblPriorityCheck.Text = "";
                pbPriorityCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckPriority = false;
                lblPriorityCheck.Text = "Please select option below";
                pbPriorityCheck.Image = Properties.Resources.DeleteMark;

            }
        }
        #endregion

        #region ComboBoxList Title Methods
        private void cbTitle_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbTitle.SelectedIndex > -1)//if something is selected
            {
                CheckTitle = true;
                lblTitleCheck.Text = "";
                pbTitleCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckTitle = false;
                lblTitleCheck.Text = "Please select option below";
                pbTitleCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e) //On combobox selection change
        {
            if (cbTitle.SelectedIndex > -1)//if something is selected
            {
                CheckTitle = true;
                lblTitleCheck.Text = "";
                pbTitleCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckTitle = false;
                lblTitleCheck.Text = "Please select option below";
                pbTitleCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        #endregion

        #region ComboBoxList Gender Methods
        private void cbGender_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbGender.SelectedIndex > -1)//if something is selected
            {
                CheckGender = true;
                lblClientGenderCheck.Text = "";
                pbClientGenderCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckGender = false;
                lblClientGenderCheck.Text = "Please select option below";
                pbClientGenderCheck.Image = Properties.Resources.DeleteMark;

            }
        }


        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex > -1)//if something is selected
            {
                CheckGender = true;
                lblClientGenderCheck.Text = "";
                pbClientGenderCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckGender = false;
                lblClientGenderCheck.Text = "Please select option below";
                pbClientGenderCheck.Image = Properties.Resources.DeleteMark;

            }
        }
        #endregion

        #region Address Methods
        private void tbAddress_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbAddress.Clear();
            pbAddressCheck.Hide();
        }

        private void tbAddress_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbAddress.Text))
            {
                tbAddress.Text = "";
                pbAddressCheck.Image = Properties.Resources.DeleteMark;
                CheckAddress = false;
                pbAddressCheck.Hide();
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            Regex mRegxExpression;
            pbAddressCheck.Show();
            if (!String.IsNullOrEmpty(tbAddress.Text))//If valid information are given do following
            {
                if (tbAddress.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"\d+[ ](?:[A-Za-z0-9.-]+[ ]?)+(?:Avenue|Lane|Road|Boulevard|Drive|Street|Ave|Dr|Rd|Blvd|Ln|St)\.?");

                    if (!mRegxExpression.IsMatch(tbAddress.Text.Trim()))
                    {
                        pbAddressCheck.Image = Properties.Resources.DeleteMark;
                        CheckAddress = false;
                    }
                    else
                    {
                        pbAddressCheck.Image = Properties.Resources.checkmark;
                        CheckAddress = true;
                    }
                }
            }
            else
            {
                pbAddressCheck.Image = Properties.Resources.DeleteMark;
                CheckAddress = false;
            }
        }
        #endregion

        #region Address2 Methods
        private void tbAddress2_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbAddress2.Clear();
            pbAddress2Check.Hide();
        }

        private void tbAddress2_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbAddress2.Text))
            {
                tbAddress2.Text = "";
                pbAddress2Check.Image = Properties.Resources.DeleteMark;
                CheckAddress2 = false;
                pbAddress2Check.Hide();
            }
        }

        private void tbAddress2_TextChanged(object sender, EventArgs e)
        {
            pbAddress2Check.Show();
            if (!String.IsNullOrEmpty(tbAddress2.Text))//If valid information are given do following
            {
                pbAddress2Check.Image = Properties.Resources.checkmark;
                CheckAddress2 = true;
            }
            else
            {
                pbAddress2Check.Image = Properties.Resources.DeleteMark;
                CheckAddress2 = false;
            }
        }
        #endregion

        #region City Methods
        private void tbCity_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbCity.Clear();
            pbCityCheck.Hide();
            lblCityCheck.Text = "";
        }

        private void tbCity_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblCityCheck.Text = "";
            if (String.IsNullOrEmpty(tbCity.Text))
            {

                tbCity.Text = "";
                pbCityCheck.Image = Properties.Resources.DeleteMark;
                CheckCity = false;
                pbCityCheck.Hide();
            }
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCityCheck.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblCityCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbCity_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbCity.Text))//If valid information are given do following
            {
                pbCityCheck.Show();
                pbCityCheck.Image = Properties.Resources.checkmark;
                CheckCity = true;
            }
            else
            {
                pbCityCheck.Image = Properties.Resources.DeleteMark;
                CheckCity = false;
            }
        }

        #endregion

        #region Country/State Methods
        private void tbState_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbState.Clear();
            pbCountryCheck.Hide();
            lblCountryCheck.Text = "";
        }

        private void tbState_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblCountryCheck.Text = "";
            if (String.IsNullOrEmpty(tbState.Text))
            {

                tbState.Text = "";
                pbCountryCheck.Image = Properties.Resources.DeleteMark;
                CheckCountry = false;
                pbCountryCheck.Hide();
            }
        }

        private void tbState_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCountryCheck.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblCountryCheck.Text = "";
                e.Handled = false;
            }
        }
        private void tbState_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbState.Text))//If valid information are given do following
            {
                pbCountryCheck.Show();
                pbCountryCheck.Image = Properties.Resources.checkmark;
                CheckCountry = true;
            }
            else
            {
                pbCountryCheck.Image = Properties.Resources.DeleteMark;
                CheckCountry = false;
            }
        }

        #endregion

        #region Zip/Postal code Methods
        private void tbZip_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbZip.Clear();
            pbZipCheck.Hide();
        }


        private void tbZip_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblZipCheck.Text = "";
            if (String.IsNullOrEmpty(tbZip.Text))
            {
                tbZip.Text = "";
                pbZipCheck.Image = Properties.Resources.DeleteMark;
                CheckZip = false;
                pbZipCheck.Hide();
            }
        }

        private void tbZip_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblZipCheck.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblZipCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbZip_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            pbZipCheck.Show();
            if (!String.IsNullOrEmpty(tbZip.Text))//If valid information are given do following
            {

                if (tbZip.Text.Length != 4)
                {
                    lblZipCheck.Text = "Must be 4 characters long";
                    pbZipCheck.Image = Properties.Resources.DeleteMark;
                    CheckZip = false;
                }
                else
                {
                    lblZipCheck.Text = "";
                    pbZipCheck.Image = Properties.Resources.checkmark;
                    CheckZip = true;
                }
            }
            else
            {
                pbPhoneCheck.Image = Properties.Resources.DeleteMark;
                CheckPhone = false;
            }
        }
        #endregion


        private bool CheckValidEntry()
        {
            try
            {
                if((CheckFirstName==true)&& (CheckSurname == true) && (CheckIdNumber == true) && (CheckEmail == true) && (CheckPhone == true) && (CheckPriority == true) && (CheckTitle == true) && (CheckGender == true) && (CheckAddress == true) && (CheckAddress2 == true) && (CheckCity == true) && (CheckCountry == true) && (CheckZip == true))
                {
                    objInsertClient.ClientCell = tbPhone.Text;
                    objInsertClient.PersonName = tbFirstName.Text;
                    objInsertClient.PersonSurname = tbSurname.Text;
                    objInsertClient.ClientIDNumber = tbIDNumber.Text;
                    objInsertClient.ClientEmail = tbEmail.Text;
                    objInsertClient.ClientPriority = Convert.ToInt16(cbPriority.Text);
                    objInsertClient.ClientGender = cbGender.Text;
                    objInsertClient.ClientAddress = tbAddress.Text + " " + tbAddress2.Text + " " + tbCity.Text + " " + tbState.Text + " " + tbZip.Text;
                    objInsertClient.ClientTitle = cbTitle.Text;
                    DateTime date = DateTime.Now;

                    date.ToString("yyyy-MM-dd HH:mm:ss");
                    date.ToString("yyyy-MM-dd");

                    objInsertClient.ClientCreationDate = date;
                    objInsertClient.ClientState = 1;


                    return true;
                }
            }
            catch(Exception E)
            {
                return false;
            }

            return false;
        }

        private void btnCreateCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidEntry() == true)
                {
                    bool worked = objInsertClient.InsertClient(objInsertClient);

                    if (worked == true)
                    {
                        MessageBox.Show("Client Successfuly Added!");
                        pnlNewClient.Visible = false;
                        ResetSearch();
                        flpCustomers.Visible = true;
                        LoadCus();
                       
                    }
                    else
                    {
                        MessageBox.Show("Client was not added to the System");
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete all Fields");

                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

    }
}
