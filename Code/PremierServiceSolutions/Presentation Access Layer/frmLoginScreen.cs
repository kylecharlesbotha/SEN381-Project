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
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
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
                if (checkFieldsEmpty() == true)
                {
                    string userName = tBUsername.Text;
                    string userPassword = tBPassword.Text;
                    User userRecord = new User();
                    bool value = userRecord.attemptLogin(userName, userPassword);
                    if(value==true)
                    {
                        frmLoginScreen FLS = new frmLoginScreen();
                        FLS.Hide();
                        frmDashBoard FDB = new frmDashBoard();
                        FDB.Show();
                    }
                }
                
            }
            catch
            {

            }

            
        }

        public bool checkFieldsEmpty()
        {
            try
            {
                
                
                if (String.IsNullOrEmpty(tBUsername.Text))
                {
                    MessageBox.Show("Please do not leave the username field blank.");
                    return false;
                }
                else if (String.IsNullOrEmpty(tBPassword.Text))
                {
                    MessageBox.Show("Please do not leave the password field blank.");
                    return false;
                }
                if(tBUsername.Text.All(Char.IsLetter))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Username may only contain letters");
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.FromArgb(218, 0, 0);
        }

        private void frmLoginScreen_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(500);
            }
        }

        private void iPBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iPBExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLoginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmLoginScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmLoginScreen_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void iPBMinimize_MouseEnter(object sender, EventArgs e)
        {
            iPBMinimize.ForeColor = Color.White;
        }

        private void iPBMinimize_MouseLeave(object sender, EventArgs e)
        {
            iPBMinimize.ForeColor = Color.FromArgb(218,0,0);
        }

        private void iPBExit_MouseEnter(object sender, EventArgs e)
        {
            iPBExit.ForeColor = Color.White;
        }

        private void iPBExit_MouseLeave(object sender, EventArgs e)
        {
            iPBExit.ForeColor = Color.FromArgb(218, 0, 0);
        }
    }
}
