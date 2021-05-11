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
    public partial class frmTechnician : Form
    {
        #region Class Objects
        Technician objTechnician = new Technician();
        Employee objEmployee = new Employee();
        User objUser = new User();
        #endregion

        #region Variables
        bool CheckEmployee = false;
        bool CheckLevel = false;
        bool CheckUsername = false;
        bool CheckAccessCode = false;
        bool CheckUserType = false;
        bool CheckPassword = false;
        bool CheckConfirmPassword = false;

        int AdminCode = 1234;
        List<Technician> lstTechnician = new List<Technician>();
        List<Technician> lstSearchTechnician = new List<Technician>();

        List<Employee> lstEmployee = new List<Employee>();
        #endregion

        public frmTechnician()
        {
            InitializeComponent();
            LoadTech();
            this.Width = 900;
            this.Height = 740;
            pnlNewTech.Left = 5;
            pnlTechnicianDetials.Left = 5;
            pnlTechnicianDetials.Top = 132;
        }

        #region Populate Methods
        private void PopulateCBB()
        {
            lstEmployee = objEmployee.GetEmployees().ToList();
            cbEmployee.DataSource = lstEmployee;
            cbEmployee.DisplayMember = "EmployeeName";

            List<int> Levels = new List<int>();
            Levels.Add(1);
            Levels.Add(2);
            Levels.Add(3);
            Levels.Add(4);

            List<string> UserTypes = new List<string>();
            UserTypes.Add("Standard");
            UserTypes.Add("Administrator");


            cbbUserTypeCheck.DataSource = UserTypes;
            cbLevel.DataSource = Levels;
        }
        #endregion

        private void LoadTech()
        {
            lstTechnician = objTechnician.GetTechRecords();
            lstTechnician.Sort();
            PopulateTechnicians();
            PopulateCBB();
        }

        public void PopulateTechnicians()
        {
            foreach(Technician tecitem in lstTechnician)
            {
                CreateEntry(tecitem.TechnicianID.ToString(), tecitem.TechNameList, tecitem.TechnicianLevel.ToString(), tecitem.TechnicianStatus, tecitem.TechEmail);
            }
        }

        #region Technician Panel
        private void CreateEntry(string ID, string TecName, string TecLevel, string TechStatus, string TecEmail)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpTechnician.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpTechnician.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTechnician.ClientSize.Width - 25, 50);
            flpTechnician.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTechnician.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lAssName = new Label();
            lAssName.Name = "lblTecID" + flpTechnician.Controls.Count;
            lAssName.Text = ID;
            lAssName.AutoSize = false;
            lAssName.Size = new Size(80, 30);
            p.Controls.Add(lAssName);
            lAssName.Top = 10;
            lAssName.TextAlign = ContentAlignment.MiddleCenter;
            lAssName.Left = 15;
            lAssName.Font = new Font("Arial", 10, FontStyle.Bold);
            lAssName.ForeColor = Color.White;
            lAssName.MouseEnter += new EventHandler(HoverEnter);
            lAssName.MouseLeave += new EventHandler(HoverLeave);
            lAssName.Click += new EventHandler(TechDetails);
            //lAssName.BackColor = Color.Red;            


            //Creating Label for Name
            Label lCusName = new Label();
            lCusName.Name = "lblTecName" + flpTechnician.Controls.Count;
            lCusName.Text = TecName;
            lCusName.AutoSize = false;
            lCusName.Size = new Size(200, 30);
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
            LManu.Name = "lblLevel" + flpTechnician.Controls.Count;
            LManu.Text = TecLevel;
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
            Label LMod = new Label();
            LMod.Name = "lblStatus" + flpTechnician.Controls.Count;
            LMod.Text = TechStatus;
            LMod.AutoSize = false;
            LMod.Size = new Size(150, 30);
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
            Label lSerial = new Label();
            lSerial.Name = "lblEmail" + flpTechnician.Controls.Count;
            lSerial.Text = TecEmail;
            lSerial.AutoSize = false;
            lSerial.Size = new Size(200, 30);
            p.Controls.Add(lSerial);
            lSerial.Top = 10;
            lSerial.TextAlign = ContentAlignment.MiddleLeft;
            lSerial.Left = (LMod.Left + LMod.Width + 20);
            lSerial.Font = new Font("Arial", 10, FontStyle.Bold);
            lSerial.ForeColor = Color.White;
            lSerial.MouseEnter += new EventHandler(HoverEnter);
            lSerial.MouseLeave += new EventHandler(HoverLeave);
            lSerial.Click += new EventHandler(EmailClicked);
            //lSerial.BackColor = Color.Orange;



            //Updating the Panel and forcing it to refresh its self
            flpTechnician.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpTechnician.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpTechnician.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTechnician.ClientSize.Width, 50);
            flpTechnician.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTechnician.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpTechnician.Controls.Count;
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
            flpTechnician.Invalidate();
        }
        protected void EmailClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            System.Diagnostics.Process.Start("mailto:" + lbl.Text);
        }

        protected void TechDetails(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            int Techid = Convert.ToInt32(lbl.Text);         
            GetTechDetails(Techid);
            pnlTechnicianDetials.Visible = true;
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

        private void GetTechDetails(int TechID)
        {
            try
            {
                Technician newObject = objTechnician.GetTechDetails(TechID);
                tbDetailsEmpID.Text = newObject.EmployeeID.ToString();
                tbDetailsTechID.Text = newObject.TechnicianID.ToString();
                tbDetailsTechName.Text = newObject.TechName;
                tbDetailsTechEmail.Text = newObject.TechEmail;
                tbDetailsTechRole.Text = newObject.EmployeeRole;
                tbDetailsTechStatus.Text = newObject.TechnicianStatus;
                sfTechLevel.Text = newObject.TechnicianLevel.ToString();
            }
            catch(Exception E)
            {

            }
        }
        #endregion



        #region Search for Employee Methods
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing TechnicianID/Technician Name")
            {

            }
            else
            {
                flpTechnician.Visible = false;
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                    PopulateTechnicians();
                    flpTechnician.Visible = true;
                }
                else
                {

                    ResetSearch();
                    flpTechnician.Visible = false;
                    string Text = tBSearch.Text.ToLower();



                    foreach (Technician tecitem in lstTechnician)
                    {
                        if ((tecitem.TechnicianID.ToString().StartsWith(Text)) || (tecitem.TechName.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(tecitem.TechnicianID.ToString(), tecitem.TechNameList, tecitem.TechnicianLevel.ToString(), tecitem.TechnicianStatus, tecitem.TechEmail);
                            found = true;

                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("Technician Not Found! Please clear search and try again.");
                    }
                    flpTechnician.Visible = true;
                }
            }
        }


        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tBSearch.Text == "Start Typing TechnicianID/Technician Name")
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
                    tBSearch.Text = "Start Typing TechnicianID/Technician Name";
                }
            }
            catch
            {

            }
        }
        private void ResetSearch()
        {
            for (int i = flpTechnician.Controls.Count - 1; i >= 0; i--)
            {
                flpTechnician.Controls[i].Dispose();
            }
            flpTechnician.Visible = false;
        }


        #endregion

        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Escape)
                {
                    tBSearch.Text = "Start Typing TechnicianID/Technician Name";
                    pnlTopTechnician.Focus();
                    flpTechnician.Visible = false;
                    ResetSearch();
                    PopulateTechnicians();
                    flpTechnician.Visible = true;
                }

        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            pnlNewTech.Visible = true;
            btnReset_Click(null,null);//resets upcoming panel(form) to default state
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewTech.Visible = false;
        }

        #region ComboBoxList Employee Methods
        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool found = false;
            //if true you can create 
            //if false meanse there is already tech linked to that employee
            if (cbEmployee.SelectedIndex > -1)//if something is selected
            {
                found = objTechnician.GetTechEmpID(cbEmployee.SelectedIndex);
                if (found==true)
                {
                    CheckEmployee = true;
                    lblEmployeeCheck.Text = "";
                    pbEmployeeCheck.Image = Properties.Resources.checkmark;
                }
                else
                {
                    CheckEmployee = false;
                    lblEmployeeCheck.Text = "Already a technician linked to employee";
                    pbEmployeeCheck.Image = Properties.Resources.DeleteMark;
                }
                
            }
            else
            {
                CheckEmployee = false;
                lblEmployeeCheck.Text = "Please select option below";
                pbEmployeeCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbEmployee_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbEmployee.SelectedIndex > -1)//if something is selected
            {
                CheckEmployee = true;
                lblEmployeeCheck.Text = "";
                pbEmployeeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckEmployee = false;
                lblEmployeeCheck.Text = "Please select option below";
                pbEmployeeCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        #endregion

        #region ComboBoxList Level Methods
        private void cbLevel_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbLevel.SelectedIndex > -1)//if something is selected
            {
                CheckLevel = true;
                lblLevelCheck.Text = "";
                pbLevelCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckLevel = false;
                lblLevelCheck.Text = "Please select option below";
                pbLevelCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex > -1)//if something is selected
            {
                CheckLevel = true;
                lblLevelCheck.Text = "";
                pbLevelCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckLevel = false;
                lblLevelCheck.Text = "Please select option below";
                pbLevelCheck.Image = Properties.Resources.DeleteMark;

            }
        }
        #endregion

        #region Checkbox Create User Methods
        private void chkCreateAccount_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkCreateAccount.Checked==true)
            {
                tbUsername.Enabled = true;
                tbAccessCode.Enabled = true;
                cbbUserTypeCheck.Enabled = true;
                tbPassword.Enabled = true;
                tbConPassword.Enabled = true;
            }
            else
            {
                tbUsername.Enabled = false;
                tbAccessCode.Enabled = false;
                cbbUserTypeCheck.Enabled = false;
                tbPassword.Enabled = false;
                tbConPassword.Enabled = false;
            }
        }

        #endregion

        #region Button Reset Methods
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Boolean variables used for live Validation statuses.(Used to check if all information required are correct and filled in before commencing)
            //CheckFirstName = false;
            //CheckSurname = false;
            //CheckIdNumber = false;
            //CheckEmail = false;
            //CheckPhone = false;
            //CheckPriority = false;
            //CheckTitle = false;
            //CheckGender = false;
            //CheckAddress = false;
            //CheckAddress2 = false;
            //CheckCity = false;
            //CheckCountry = false;
            //CheckZip = false;

            //Clear all content in textboxes
            tbUsername.Text = "";
            tbAccessCode.Text = "";
            tbPassword.Text = "";
            tbConPassword.Text = "";

            //Show and Hide checkboxes.(Used to show live validation status of input controls)
            pbUsernameCheck.Hide();
            pbUsernameCheck.Image = Properties.Resources.DeleteMark;
            pbAccessCodeCheck.Hide();
            pbAccessCodeCheck.Image = Properties.Resources.DeleteMark;
            pbPasswordCheck.Hide();
            pbPasswordCheck.Image = Properties.Resources.DeleteMark;
            pbConPasswordCheck.Hide();
            pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
            pbEmployeeCheck.Show();
            pbEmployeeCheck.Image = Properties.Resources.DeleteMark;
            cbEmployee.SelectedIndex = -1;
            pbLevelCheck.Show();
            pbLevelCheck.Image = Properties.Resources.DeleteMark;
            cbLevel.SelectedIndex = -1;
            pbUserTypeCheck.Show();
            pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
            cbbUserTypeCheck.SelectedIndex = -1;

            //Sets relevant label messages(Used for validation) for respective input controls
            lblEmployeeCheck.Text = "Please select option below";
            lblLevelCheck.Text = "Please select option below";
            lblUsernameCheck.Text = "";
            lblAccessCodeCheck.Text = "";
            lblUserTypeCheck.Text = "Please select option below";
            lblPasswordCheck.Text = "";
            lblConPasswordCheck.Text = "";
        }
        #endregion

        #region Username Methods
        private void tbUsername_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbUsername.Clear();
            pbUsernameCheck.Hide();
        }

        private void tbUsername_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblUsernameCheck.Text = "";
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "";
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
                CheckUsername = false;
                pbUsernameCheck.Hide();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblUsernameCheck.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblUsernameCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            List<User> listUsers = new List<User>();
            listUsers = objUser.GetAllUsers();

            if (!String.IsNullOrEmpty(tbUsername.Text))//If valid information are given check for following
            {
                pbUsernameCheck.Show();
                string username = tbUsername.Text.ToLower();
                foreach (var uservalue in listUsers)//Runs through list of Users and validates if user already exists or not
                {
                    if (uservalue.UserName.ToLower() == username)
                    {
                        pbUsernameCheck.Image = Properties.Resources.DeleteMark;
                       CheckUsername = false;
                    }
                    else
                    {
                        pbUsernameCheck.Image = Properties.Resources.checkmark;
                       CheckUsername = true;
                    }
                }
            }
            else
            {
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
               CheckUsername = false;
            }
        }

        #endregion

        #region Administrator Code Methods
        private void tbAccessCode_Enter(object sender, EventArgs e) //On being active form control, clear textbox for user to enter required information
        {
            tbAccessCode.Clear();
            pbAccessCodeCheck.Hide();
        }

        private void tbAccessCode_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            lblAccessCodeCheck.Text = "";
            if (String.IsNullOrEmpty(tbAccessCode.Text))
            {
                pbAccessCodeCheck.Hide();
                tbAccessCode.Text = "";
                pbAccessCodeCheck.Image = Properties.Resources.DeleteMark;
                CheckAccessCode = false;
            }
        }

        private void tbAccessCode_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblAccessCodeCheck.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblAccessCodeCheck.Text = "";
                e.Handled = false;
            }
        }

        private void tbAccessCode_TextChanged(object sender, EventArgs e) //If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbAccessCode.Text)) //If correct administrator code given then create account access = true, else false
            {
                pbAccessCodeCheck.Show();
                if (AdminCode == Convert.ToInt32(tbAccessCode.Text))
                {
                    pbAccessCodeCheck.Image = Properties.Resources.checkmark;
                    CheckAccessCode = true;
                }
                else
                {
                    pbAccessCodeCheck.Image = Properties.Resources.DeleteMark;
                    CheckAccessCode = false;
                }

            }
            else
            {
                pbAccessCodeCheck.Image = Properties.Resources.DeleteMark;
                CheckAccessCode = false;
            }
        }
        #endregion

        #region ComboBoxList UserType Methods

        private void cbbUserTypeCheck_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbbUserTypeCheck.SelectedIndex > -1)//if something is selected
            {
                CheckUserType = true;
                lblUserTypeCheck.Text = "";
                pbUserTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckUserType = false;
                lblUserTypeCheck.Text = "Please select option below";
                pbUserTypeCheck.Image = Properties.Resources.DeleteMark;

            }
        }

        private void cbbUserTypeCheck_SelectedIndexChanged(object sender, EventArgs e) //On combobox selection change
        {
            if (cbbUserTypeCheck.SelectedIndex > -1)//if something is selected do following
            {
                CheckUserType = true;
                lblUserTypeCheck.Text = "";
                pbUserTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckUserType = false;
                lblUserTypeCheck.Text = "Please select option below";
                pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
            }
        }
        #endregion

        #region Password Methods
        private void tbPassword_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbPassword.Clear();
            tbPassword.PasswordChar = '*';
        }

        private void tbPassword_Leave(object sender, EventArgs e)//On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '\0';
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
                CheckPassword = false;
                pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
                pbPasswordCheck.Hide();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tbPassword.Text))//If valid information are given do following
            {
                pbPasswordCheck.Show();
                pbPasswordCheck.Image = Properties.Resources.checkmark;
                CheckPassword = true;
            }
            else
            {
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
                CheckPassword = false;
            }
            //code to update confirm password if it contains edited information
            if (!String.IsNullOrEmpty(tbConPassword.Text))//If valid information are given do following
            {
                pbConPasswordCheck.Show();
                if (tbPassword.Text == tbConPassword.Text)
                {
                    lblConPasswordCheck.Text = "";
                    pbConPasswordCheck.Image = Properties.Resources.checkmark;
                    CheckConfirmPassword = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(tbPassword.Text))
                    {
                        lblConPasswordCheck.Text = "Passwords not matching";
                        pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }
                    else
                    {
                        lblConPasswordCheck.Text = "Please fill in password above";
                        pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }
                }
            }
            else
            {
                lblConPasswordCheck.Text = "";
                pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
            }
        }


        #endregion

        #region Confirm Password Methods
        private void tbConPassword_Enter(object sender, EventArgs e)
        {
            tbConPassword.Clear();
            tbConPassword.PasswordChar = '*';
        }
        private void tbConPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbConPassword.Text))
            {
                tbConPassword.Text = "";
                tbConPassword.PasswordChar = '\0';
                pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                //CheckConfirmPassword = false;
                pbConPasswordCheck.Hide();
            }
        }

        private void tbConPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbConPassword.Text))
            {
                pbConPasswordCheck.Show();
                if (tbPassword.Text == tbConPassword.Text)
                {
                    lblConPasswordCheck.Text = "";
                    pbConPasswordCheck.Image = Properties.Resources.checkmark;
                    //CheckConfirmPassword = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(tbPassword.Text))
                    {
                        lblConPasswordCheck.Text = "Passwords not matching";
                        pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                        //CheckConfirmPassword = false;
                    }
                    else
                    {
                        lblConPasswordCheck.Text = "Please fill in password above";
                        pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                        //CheckConfirmPassword = false;
                    }

                }
            }
            else
            {
                lblConPasswordCheck.Text = "";
                pbConPasswordCheck.Image = Properties.Resources.DeleteMark;
                //CheckConfirmPassword = false;
            }

        }

        #endregion

        #region Button Create Technician / Account Methods
        private void btnCreateTechnician_Click(object sender, EventArgs e)
        {
            if (chkCreateAccount.Checked==true)
            {
                bool JustAvariable = true;
                //If all information check == true then enter else display message saying fill in all info correctly
                if (JustAvariable==true)
                {
                    //Create user AND assign technician to employee
                }
                else
                {
                    //display message enter all info please
                }
            }
            else
            {
                bool AnotherRandomVariable = true;
                //If all information check == true then enter else display message saying fill in all info correctly
                if (AnotherRandomVariable == true)
                {
                    //assign technician to employee
                }
                else
                {
                    //display message enter all info please
                }

            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlTechnicianDetials.Visible = false;
        }
    }
}
