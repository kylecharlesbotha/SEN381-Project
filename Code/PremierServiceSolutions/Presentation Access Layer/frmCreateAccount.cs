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
        User objUser = new User();
        Employee objEmp = new Employee();
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLoginScreen();
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

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form frmdash = new frmDashBoard();
            this.Hide();
            frmdash.Show();
        }

        //The EmployeeNumber entry may only contain numbers and this must be check on textchanged
     

        private void tBEmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBEmployeeNumber.Text))
            {
                tBEmployeeNumber.Text = "EmployeeNumber";
                pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tBPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBPassword.Text))
            {
                tBPassword.Text = "Password";
                tBPassword.PasswordChar = '\0';
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tBConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBConfirmPassword.Text))
            {
                tBConfirmPassword.Text = "Confirm Password";
                tBConfirmPassword.PasswordChar = '\0';
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tBEmployeeNumber.Text = "EmployeeNumber";
            tbUsername.Text = "Username";
            tBPassword.Text = "Password";
            tBPassword.PasswordChar = '\0';
            tBConfirmPassword.Text = "Confirm Password";
            tBConfirmPassword.PasswordChar = '\0';
            tbAdminCode.Text = "Administrator Code";
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";
            //Sets focus to username
            this.tbUsername.SelectionStart = this.tbUsername.Text.Length;
            this.tbUsername.DeselectAll();
        }

        private void tBPassword_Enter(object sender, EventArgs e)
        {
            tBPassword.Clear();
            tBPassword.PasswordChar = '*';
        }

        private void tBConfirmPassword_Enter(object sender, EventArgs e)
        {
            tBConfirmPassword.Clear();
            tBConfirmPassword.PasswordChar = '*';
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            
            lblCheckEmpNum.Text = "";
            lblCheckUsername.Text = "";
            lblCheckAdminCode.Text = "";
            lblCheckPassMatch.Text = "";

            //sets focus on username on form load
            this.tbUsername.SelectionStart = this.tbUsername.Text.Length;
            this.tbUsername.DeselectAll();
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

        private void tBEmployeeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && e.KeyChar!=(char)8 && e.KeyChar != (char)Keys.Delete) 
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

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "Username";
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tBEmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int EmployeeNum=0;
            if (!String.IsNullOrEmpty(tBEmployeeNumber.Text))
                {
                    pbEmpNumCheck.Image = Properties.Resources.checkmark;
                    EmployeeNum = Convert.ToInt32(tBEmployeeNumber);
                }
                else
                {
                    pbEmpNumCheck.Image = Properties.Resources.DeleteMark;
                }

                List<Employee> listEmployees = new List<Employee>();
                listEmployees = objEmp.GetEmployees();

                foreach (var EmpValue in listEmployees)
                {
                    if (EmpValue.EmployeeID == EmployeeNum)
                    {

                    }
                    else
                    {

                    }
                }

            }
            catch
            {

            }
            //runthrough foreach
            //foreach ()
            //{
            //
            //}
            //Call foreach method
            //IF enter else load wrong picturebox(else green arrow);
            //Call method(Get list of employees(Employeenumber //GetEmployee BusinessAccessLayer //call function in data access layer))
            //Check if employee already exists
            //Get list of employees, run through and check if already exists
            //
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

        private void tbAdminCode_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdminCode.Text))
            {
                tbAdminCode.Text = "Administrator Code";
                pbAdminCodeCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tBConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tBPassword == tBConfirmPassword)
            {
                lblCheckPassMatch.Text = "";
                pbConPassCheck.Image = Properties.Resources.checkmark;
            }
            else
            {

                lblCheckPassMatch.Text = "Passwords not matching"; 
                pbConPassCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

            List<User> listUsers = new List<User>();
            listUsers = objUser.GetAllUsers();//check now now
            if (!String.IsNullOrEmpty(tbUsername.Text))
            {
                string username = tbUsername.Text.ToLower();
                foreach (var uservalue in listUsers)
                {
                    if (uservalue.UserName.ToLower() == username)
                    {
                        pbUsernameCheck.Image = Properties.Resources.DeleteMark;
                    }
                    else
                    {
                        pbUsernameCheck.Image = Properties.Resources.checkmark;
                    }
                }
            }
            else
            {
                pbUsernameCheck.Image = Properties.Resources.DeleteMark;
            }
            
            

            
        }

        private void tBPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tBPassword.Text))
            {
                pbPasswordCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
            }
        }

        private void tbAdminCode_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tBPassword.Text))
            {
                pbPasswordCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                pbPasswordCheck.Image = Properties.Resources.DeleteMark;
            }
        }









        //Validation functions in here(call from top events)
        //if passes push to business layer User.cs (Which calls DH for CRUD operations from thereon)
    }
}
