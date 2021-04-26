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

namespace PremierServiceSolutions.Presentation_Access_Layer
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        #region Variables and Objects creation
        //Variables used to retreive user information for registration
        int EmployeeNumber;
        string UserName;
        string UserPassword;
        int UserType;
        //HARDCODE for Administrator Code = 1234
        int AdminCode = 1234;

        //Bool Functions to check if respective information are filled in (Live validation).
        bool CheckEmpNum = false;
        bool CheckUsername = false;
        bool CheckPassword = false;
        bool CheckConfirmPassword = false;
        bool CheckAdminCode = false;
        bool CheckUserType = false;

        //Create Objects of Employee,User and frmLogin for use in this class
        User objUser = new User();
        Employee objEmp = new Employee();
        Form frmLogin = new frmLoginScreen();
        #endregion

        #region Form Load
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            //Boolean variables used for live Validation statuses.(Used to check if all information required are correct and filled in before commencing)
            CheckEmpNum = false;
            CheckUsername = false;
            CheckPassword = false;
            CheckConfirmPassword = false;
            CheckAdminCode = false;
            CheckUserType = false;

            //Show and Hide checkboxes.(Used to show live validation status of input controls)
            pbEmpNumCheck.Hide();
            pbUsernameCheck.Hide();
            pbPasswordCheck.Hide();
            pbConPassCheck.Hide();
            pbAdminCodeCheck.Hide();
            pbUserTypeCheck.Show();
            pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
            cbbUserType.SelectedIndex = -1;
            
            //Sets relevant label messages(Used for validation) for respective input controls
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";
            lblUserType.Text = "Please select option below";

            //sets focus on username on form load
            tbUsername.Focus();
        }
        #endregion

        #region EmployeeNumber Methods
        private void tBEmployeeNumber_Enter(object sender, EventArgs e) //On being active form control, clear textbox for user to enter required information
        {
            tBEmployeeNumber.Clear();
            pbEmpNumCheck.Hide();
        }

        private void tBEmployeeNumber_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tBEmployeeNumber.Text))
            {
                tBEmployeeNumber.Text = "EmployeeNumber";
                pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                CheckEmpNum = false;
                pbEmpNumCheck.Hide();
            }
        }

        private void tBEmployeeNumber_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckEmpNum.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblCheckEmpNum.Text = "";
                e.Handled = false;
            }
        }

        private void tBEmployeeNumber_TextChanged(object sender, EventArgs e) //If textbox text change, check for the following below
        {   //Create list and object of Employee
            List<Employee> listEmployees = new List<Employee>();
            listEmployees = objEmp.GetEmployees();
            //Create list and object of User
            List<User> listUsers = new List<User>();
            listUsers = objUser.GetAllUsers();
            
            try
            {
                int EmployeeNum = 0;

                if ((!String.IsNullOrEmpty(tBEmployeeNumber.Text)) && (tBEmployeeNumber.Text !="EmployeeNumber"))//If valid information are given check for following
                {
                    EmployeeNum = Convert.ToInt32(tBEmployeeNumber.Text);
                    pbEmpNumCheck.Show();

                    foreach (var userval in listUsers) //Runs through list of Users and validates if user already exists or not.
                    {
                        if (EmployeeNum == userval.EmployeeID)
                        {
                            pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                            CheckEmpNum = false;
                            break;
                        }
                        else
                        {
                            if ((EmployeeNum <= listEmployees.Count) && (EmployeeNum >= 1) && (EmployeeNum <= 100))
                            {
                                pbEmpNumCheck.Image = Properties.Resources.checkmark;
                                CheckEmpNum = true;
                            }
                            else
                            {
                                pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                                CheckEmpNum = false;
                            }
                        }
                    }
                }
                else
                {
                    pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                    CheckEmpNum = false;
                    pbEmpNumCheck.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region UserName Methods
        private void tbUsername_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tbUsername.Clear();
            pbUsernameCheck.Hide();
        }

        private void tbUsername_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "Username";
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
                CheckUsername = false;
                pbUsernameCheck.Hide();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckUsername.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblCheckUsername.Text = "";
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

        #region Password Methods
        private void tBPassword_Enter(object sender, EventArgs e)//On being active form control, clear textbox for user to enter required information
        {
            tBPassword.Clear();
            tBPassword.PasswordChar = '*';
        }

        private void tBPassword_Leave(object sender, EventArgs e)//On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tBPassword.Text))
            {
                tBPassword.Text = "Password";
                tBPassword.PasswordChar = '\0';
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
                CheckPassword = false;
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
                pbPasswordCheck.Hide();
            }
        }

        private void tBPassword_TextChanged(object sender, EventArgs e)//If textbox text change, check for the following below
        {
            if (!String.IsNullOrEmpty(tBPassword.Text))//If valid information are given do following
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
            if (!String.IsNullOrEmpty(tBConfirmPassword.Text) && (tBConfirmPassword.Text != "Confirm Password"))//If valid information are given do following
            {
                pbConPassCheck.Show();
                if (tBPassword.Text == tBConfirmPassword.Text)
                {
                    lblCheckPassMatch.Text = "";
                    pbConPassCheck.Image = Properties.Resources.checkmark;
                    CheckConfirmPassword = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(tBPassword.Text))
                    {
                        lblCheckPassMatch.Text = "Passwords not matching";
                        pbConPassCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }
                    else
                    {
                        lblCheckPassMatch.Text = "Please fill in password above";
                        pbConPassCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }
                }
            }
            else
            {
                lblCheckPassMatch.Text = "";
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
            }
        }
        #endregion

        #region Confirm Password Methods
        private void tBConfirmPassword_Enter(object sender, EventArgs e)
        {
            tBConfirmPassword.Clear();
            tBConfirmPassword.PasswordChar = '*';
        }

        private void tBConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBConfirmPassword.Text))
            {
                tBConfirmPassword.Text = "Confirm Password";
                tBConfirmPassword.PasswordChar = '\0';
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
                pbConPassCheck.Hide();
            }
        }

        private void tBConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(tBConfirmPassword.Text)) && (tBConfirmPassword.Text !="Confirm Password"))
            {
                pbConPassCheck.Show();
                if (tBPassword.Text == tBConfirmPassword.Text)
                {
                    lblCheckPassMatch.Text = "";
                    pbConPassCheck.Image = Properties.Resources.checkmark;
                    CheckConfirmPassword = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(tBPassword.Text))
                    {
                        lblCheckPassMatch.Text = "Passwords not matching";
                        pbConPassCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }
                    else
                    {
                        lblCheckPassMatch.Text = "Please fill in password above";
                        pbConPassCheck.Image = Properties.Resources.DeleteMark;
                        CheckConfirmPassword = false;
                    }

                }
            }
            else
            {
                lblCheckPassMatch.Text = "";
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
                CheckConfirmPassword = false;
            }

        }
        #endregion

        #region Administrator Code Methods
        private void tbAdminCode_Enter(object sender, EventArgs e) //On being active form control, clear textbox for user to enter required information
        {
            tbAdminCode.Clear();
            pbAdminCodeCheck.Hide();
        }

        private void tbAdminCode_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tbAdminCode.Text))
            {
                pbAdminCodeCheck.Hide();
                tbAdminCode.Text = "Administrator Code";
                pbAdminCodeCheck.Image = Properties.Resources.DeleteMark;
                CheckAdminCode = false;
            }
        }

        private void tbAdminCode_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Numbers only
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckAdminCode.Text = "Please enter only numbers.";
                e.Handled = true;
            }
            else
            {
                lblCheckAdminCode.Text = "";
                e.Handled = false;
            }
        }

        private void tbAdminCode_TextChanged(object sender, EventArgs e) //If textbox text change, check for the following below
        {
            if ((!String.IsNullOrEmpty(tbAdminCode.Text)) && (tbAdminCode.Text!= "Administrator Code")) //If correct administrator code given then create account access = true, else false
            {
                pbAdminCodeCheck.Show();
                if (AdminCode == Convert.ToInt32(tbAdminCode.Text))
                {
                    pbAdminCodeCheck.Image = Properties.Resources.checkmark;
                    CheckAdminCode = true;
                }
                else
                {
                    pbAdminCodeCheck.Image = Properties.Resources.DeleteMark;
                    CheckAdminCode = false;
                }

            }
            else
            {
                pbAdminCodeCheck.Image = Properties.Resources.DeleteMark;
                CheckAdminCode = false;
            }
        }
        #endregion

        #region ComboBoxList User Type Methods
        private void cbbUserType_Leave(object sender, EventArgs e) //On leaving, if no index selected, reset combobox (And live validation labels/PB's) to default state
        {
            if (cbbUserType.SelectedIndex > -1)//if something is selected
            {
                CheckUserType = true;
                lblUserType.Text = "";
                pbUserTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckUserType = false;
                lblUserType.Text = "Please select option below";
                pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
                
            }
        }

        private void cbbUserType_SelectedIndexChanged(object sender, EventArgs e) //On combobox selection change
        {
            if (cbbUserType.SelectedIndex > -1)//if something is selected do following
            {
                CheckUserType = true;
                lblUserType.Text = "";
                pbUserTypeCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                CheckUserType = false;
                lblUserType.Text = "Please select option below";
                pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        #endregion

        #region Label Login Methods
        private void lblLogin_Click(object sender, EventArgs e) // on click load relevant form (form login)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e) // on mouse entering/hovering change color to indicate it is now clickable
        {
            lblLogin.ForeColor = Color.FromArgb(3, 3, 3);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e) //On mouse leaving clickable space of label/button reset the color to default state
        {
            lblLogin.ForeColor = Color.FromArgb(218, 0, 0);
        }

        #endregion

        #region Button Reset Methods
        private void btnReset_Click(object sender, EventArgs e)//Resets form's controls to default state
        {
            //Reset all Textboxes to default state
            tBEmployeeNumber.Text = "EmployeeNumber";
            tbUsername.Text = "Username";
            tBPassword.Text = "Password";
            tBPassword.PasswordChar = '\0';
            tBConfirmPassword.Text = "Confirm Password";
            tBConfirmPassword.PasswordChar = '\0';
            tbAdminCode.Text = "Administrator Code";
            cbbUserType.SelectedIndex = -1;
            //Clears all labels' text containing relevant error message(if any)
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";
            lblUserType.Text = "Please select option below";
            //Hides and Shows validation marks next to relevant information textboxes
            pbEmpNumCheck.Hide();
            pbUsernameCheck.Hide();
            pbPasswordCheck.Hide();
            pbConPassCheck.Hide();
            pbAdminCodeCheck.Hide();
            pbUserTypeCheck.Show();
            pbUserTypeCheck.Image = Properties.Resources.DeleteMark;
            //Sets focus to username
            tbUsername.Focus();
        }
        #endregion

        #region Button Create Account Methods
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //checks that all information filled in are true, if not then display error message
            if ((CheckEmpNum == false) || (CheckUsername == false) || (CheckPassword == false) || (CheckConfirmPassword == false) || (CheckAdminCode == false) || (CheckUserType == false))
            {
                MessageBox.Show("Please fill in all required information above correctly.");
            }
            else //If all information are gathered, capture it into variables which will be sent for the relevant CRUD operations
            {
                EmployeeNumber = Convert.ToInt32(tBEmployeeNumber.Text);
                UserName = tbUsername.Text;
                UserPassword = tBPassword.Text;
                UserType = cbbUserType.SelectedIndex+1;

                string Salt = objUser.CreateSalt(6);
                string HashPass = objUser.CreateSHA256Hash(UserPassword, Salt);
                User objUserRecord = new User();
                objUserRecord.EmployeeID = EmployeeNumber;
                objUserRecord.UserName = UserName;
                objUserRecord.UserPassword = HashPass;
                objUserRecord.UserSalt = Salt;
                objUserRecord.UserAccessLevel = cbbUserType.SelectedIndex;
                objUserRecord.UserAuthToken = "auth";
                objUserRecord.UserState = "offline";
                objUserRecord.UserAccessLevel = UserType;
                objUser.CreateUser(objUserRecord);
                //After Inserting successfully the form redirects user to Login form.
                this.Hide();
                frmLogin.Show();
            }
        }
        #endregion

        #region Form Exit/Minimize Methods
       
        #endregion


    }
}
