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
    public partial class frmCustomers : Form
    {

        #region Class Objects
        Client objclient = new Client();

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
            lstClients = objclient.GetAll();
            lstClients.Sort();
            PopulateClients();
            PopulateCBB();
        }
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

            cbGender.DataSource = Genders;
            cbTitle.DataSource = Titles;
            
        }

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
        private void tBSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }





        //////////////////////PNL NEW CUSTOMERS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




        #region Button Reset Methods
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region FirstName Methods

        private void tbFirstName_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbFirstName.Clear();
            pbFirstNameCheck.Hide();
        }

        private void tbFirstName_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
                tbFirstName.Text = "Username";
                pbFirstNameCheck.Image = Properties.Resources.DeleteMark;
                //CheckFirstName = false;
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

        }

      
        #endregion

        #region Surname Methods
        private void tbSurname_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbSurname.Clear();
            pbSurnameCheck.Hide();
        }

        private void tbSurname_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbSurname.Text))
            {
                tbSurname.Text = "Username";
                pbSurnameCheck.Image = Properties.Resources.DeleteMark;
                //CheckSurname = false;
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
                tbIDNumber.Text = "Username";
                pbIDNumberCheck.Image = Properties.Resources.DeleteMark;
                //CheckSIDNumber = false;
                pbIDNumberCheck.Hide();
            }
        }

        private void tbIDNumber_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckIDNumber.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblCheckIDNumber.Text = "";
                e.Handled = false;
            }
        }

        private void tbIDNumber_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {

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
            if (String.IsNullOrEmpty(tbPhone.Text))
            {
                tbPhone.Text = "Phone";
                pbPhoneCheck.Image = Properties.Resources.DeleteMark;
                //CheckPhone = false;
                pbPhoneCheck.Hide();
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckPhone.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblCheckPhone.Text = "";
                e.Handled = false;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {

        }

        #endregion
    }
}
