using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Business_Logic_Layer;

namespace PremierServiceSolutions.Presentation_Access_Layer
{
    public partial class frmLoginScreen : Form
    {
        string UserN;
        
        public frmLoginScreen()
        {
            InitializeComponent();
            tBPassword.SelectionLength = 0;

        }

        private void tBUsername_TextChanged(object sender, EventArgs e)
        {
            tBPassword.TabStop = true;
        }

        private void tBUsername_Click(object sender, EventArgs e)
        {
            tBUsername.Clear();
        }

        private void tBPassword_Click(object sender, EventArgs e)
        {
            tBPassword.Clear();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            this.tBPassword.SelectionStart = this.tBPassword.Text.Length;
            this.tBPassword.DeselectAll();
        }

        private void tBPassword_Enter(object sender, EventArgs e)
        {
            tBPassword.Clear();
            tBPassword.PasswordChar = '*';
        }

        private void tBUsername_Leave(object sender, EventArgs e)
        {
            if(tBUsername.TextLength == 0)
            {
                tBUsername.Text = "Username";
            }
            else
            {
                
            }
        }

        private void tBPassword_Leave(object sender, EventArgs e)
        {
            if (tBPassword.TextLength == 0)
            {
                tBPassword.Text = "Password";
                tBPassword.PasswordChar = '\0';
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Form frmCreateAccount = new frmCreateAccount();
            this.Hide();
            frmCreateAccount.Show();
        }

        private void lblSignUp_MouseEnter(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.FromArgb(3, 3, 3);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = tBUsername.Text;
                string userPassword = tBPassword.Text;
                User use = new User(userName, userPassword);
            }
            catch
            {

            }
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.FromArgb(218, 0, 0);
        }
    }
}
