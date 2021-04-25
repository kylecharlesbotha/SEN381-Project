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
        //Variables used to retreive user information for registration
        int EmployeeNumber;
        string UserName;
        string UserPassword;
        //HARDCODE for Administrator Code = 1234
        int AdminCode = 1234;


        //Bool Functions to check if respective information are filled in (Live validation).
        bool CheckEmpNum = false;
        bool CheckUsername = false;
        bool CheckPassword = false;
        bool CheckConfirmPassword = false;
        bool CheckAdminCode = false;
        bool UserType = false;

        //Create Objects of Employee and User for use in this class
        User objUser = new User();
        Employee objEmp = new Employee();
        //FRM object to call relevant form on actions
        Form frmLogin = new frmLoginScreen();

        public frmCreateAccount()
        {
            InitializeComponent();
        }
        
        ////////////////////FORM LOAD/////////////////////////
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            CheckEmpNum = false;
            CheckUsername = false;
            CheckPassword = false;
            CheckConfirmPassword = false;
            CheckAdminCode = false;
            pbEmpNumCheck.Hide();
            pbUsernameCheck.Hide();
            pbPasswordCheck.Hide();
            pbConPassCheck.Hide();
            pbAdminCodeCheck.Hide();
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";

            //sets focus on username on form load
            this.tbUsername.SelectionStart = this.tbUsername.Text.Length;
            this.tbUsername.DeselectAll();
        }

        ////////////////////EMPLOYEE NUMBER/////////////////////////
        private void tBEmployeeNumber_Enter(object sender, EventArgs e)
        {
            tBEmployeeNumber.Clear();
            pbEmpNumCheck.Hide();
        }

        private void tBEmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBEmployeeNumber.Text))
            {
                tBEmployeeNumber.Text = "EmployeeNumber";
                pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                CheckEmpNum = false;
                pbEmpNumCheck.Hide();
            }
        }

        private void tBEmployeeNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tBEmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            List<Employee> listEmployees = new List<Employee>();
            listEmployees = objEmp.GetEmployees();

            List<User> listUsers = new List<User>();
            listUsers = objUser.GetAllUsers();
            //obj of emp and users
            try
            {
                int EmployeeNum = 0;

                if (!String.IsNullOrEmpty(tBEmployeeNumber.Text))
                {
                    EmployeeNum = Convert.ToInt32(tBEmployeeNumber.Text);
                    pbEmpNumCheck.Show();

                    foreach (var userval in listUsers)
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

        ////////////////////USERNAME/////////////////////////
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.Clear();
            pbUsernameCheck.Hide();
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "Username";
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
                CheckUsername = false;
                pbUsernameCheck.Hide();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            List<User> listUsers = new List<User>();
            listUsers = objUser.GetAllUsers();//check now now

            if (!String.IsNullOrEmpty(tbUsername.Text))
            {
                pbUsernameCheck.Show();
                string username = tbUsername.Text.ToLower();
                foreach (var uservalue in listUsers)
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

        ////////////////////PASSWORD/////////////////////////
        private void tBPassword_Enter(object sender, EventArgs e)
        {
            tBPassword.Clear();
            tBPassword.PasswordChar = '*';
        }

        private void tBPassword_Leave(object sender, EventArgs e)
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

        private void tBPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tBPassword.Text))
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
            if (!String.IsNullOrEmpty(tBConfirmPassword.Text) && (tBConfirmPassword.Text != "Confirm Password"))
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

        ////////////////////CONFIRM PASSWORD/////////////////////////
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
            if (!String.IsNullOrEmpty(tBConfirmPassword.Text))
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

        ////////////////////ADMIN CODE/////////////////////////
        private void tbAdminCode_Enter(object sender, EventArgs e)
        {
            tbAdminCode.Clear();
            pbAdminCodeCheck.Hide();
        }

        private void tbAdminCode_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdminCode.Text))
            {
                pbAdminCodeCheck.Hide();
                tbAdminCode.Text = "Administrator Code";
                pbAdminCodeCheck.Image = Properties.Resources.DeleteMark;
                CheckAdminCode = false;
            }
        }

        private void tbAdminCode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbAdminCode_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAdminCode.Text))
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

        ////////////////////LABEL LOGIN/////////////////////////
        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.FromArgb(3, 3, 3);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.FromArgb(218, 0, 0);
        }

        ////////////////////BUTTON RESET/////////////////////////
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all Textboxes to deafault state
            tBEmployeeNumber.Text = "EmployeeNumber";
            tbUsername.Text = "Username";
            tBPassword.Text = "Password";
            tBPassword.PasswordChar = '\0';
            tBConfirmPassword.Text = "Confirm Password";
            tBConfirmPassword.PasswordChar = '\0';
            tbAdminCode.Text = "Administrator Code";
            //Clears all labels' text containing relevant error message(if any)
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";
            //Hides validation marks next to relevant information textboxes
            pbEmpNumCheck.Hide();
            pbUsernameCheck.Hide();
            pbPasswordCheck.Hide();
            pbConPassCheck.Hide();
            pbAdminCodeCheck.Hide();
            //Sets focus to username
            this.tbUsername.SelectionStart = this.tbUsername.Text.Length;
            this.tbUsername.DeselectAll();
        }

        ////////////////////BUTTON CREATE ACCOUNT/////////////////////////
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //checks that all information filled in are true, if not then display error message
            if ((CheckEmpNum == false) || (CheckUsername == false) || (CheckPassword == false) || (CheckConfirmPassword == false) || (CheckAdminCode == false))
            {
                MessageBox.Show("Please fill in all required information above correctly.");
            }
            else //If all information are gathered, capture it into variables which will be sent for the relevant CRUD operations
            {
                EmployeeNumber = Convert.ToInt32(tBEmployeeNumber.Text);
                UserName = tbUsername.Text;
                UserPassword = tBPassword.Text;

                string Salt = objUser.CreateSalt(6);
                string HashPass = objUser.CreateSHA256Hash(UserPassword, Salt);
                User objUserRecord = new User();
                objUserRecord.EmployeeID = EmployeeNumber;
                objUserRecord.UserName = UserName;
                objUserRecord.UserPassword = HashPass;
                objUserRecord.UserSalt = Salt;
                objUserRecord.UserAccessLevel = cbbUserType.SelectedIndex;
                objUserRecord.UserAuthToken = "auth";
                objUserRecord.UserState = 1;
                objUser.CreateUser(objUserRecord);


                this.Hide();
                frmLogin.Show();
            }
        }

       
    }
}
