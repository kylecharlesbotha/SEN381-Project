using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Serialization;

namespace PremierServiceSolutions.Presentation_Access_Layer
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
            tBPassword.SelectionLength = 0;
        }

        #region Variables and Objects Creation

        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        private readonly string AuthSalt = "bp1cHcfg";
        public string FullPath;
        User objUser;
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        internal User ObjUser { get => objUser; set => objUser = value; }
        public int userauthenticated;
        frmDashBoard FDB = new frmDashBoard();
        RememberMe objRemMe = new RememberMe();
        #endregion

        #region Form Load
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            tBUsername.Text = "Username";
            tBPassword.Text = "Password";
            this.tBPassword.SelectionStart = this.tBPassword.Text.Length;
            this.tBPassword.DeselectAll();
            FullPath = GetTemporaryDirectory();
            FullPath += @"\489296awbduyg0298lfg.ser";
            lblCheckLogin.Text = "";
        }
        #endregion

        #region Username Methods
        private void tBUsername_Enter(object sender, EventArgs e) //On being active form control, clear textbox for user to enter required
        {
            tBUsername.Clear();
        }

        private void tBUsername_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tBUsername.Text))
            {
                tBUsername.Text = "Username";
            }
            lblCheckLogin.Text = "";
        }

        private void tBUsername_TextChanged(object sender, EventArgs e) // textchange
        {
            tBPassword.TabStop = true;//the input focus is set to the next control in the tab order
        }

        private void tBUsername_KeyPress(object sender, KeyPressEventArgs e) //Ensures that information entered into textbox are Alphabetic characters only
        {
            if (!char.IsLetter(e.KeyChar) == true && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                lblCheckLogin.Text = "Please enter only Alphabetical characters.";
                e.Handled = true;
            }
            else
            {
                lblCheckLogin.Text = "";
                e.Handled = false;
            }

        }
        #endregion

        #region Password Methods
        private void tBPassword_Enter(object sender, EventArgs e) //On being active form control, clear textbox for user to enter required
        {
            tBPassword.Clear();
            tBPassword.PasswordChar = '*'; //Activate passwordchar to secure user inserting password to the eyes of someone else
        }

        private void tBPassword_Leave(object sender, EventArgs e) //On leaving, if No information given, reset textbox to default state
        {
            if (String.IsNullOrEmpty(tBPassword.Text))
            {
                tBPassword.Text = "Password";
                tBPassword.PasswordChar = '\0'; //Deactivate passwordchar and display password as text for user experience
            }
        }
        #endregion

        #region Label Sign Up Methods
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

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.FromArgb(218, 0, 0);
        }
        #endregion

        #region Button Sign In Methods
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrEmpty(tBUsername.Text)) && (!String.IsNullOrEmpty(tBPassword.Text)) && (tBUsername.Text!="Username") && (tBPassword.Text != "Password"))
                {
                    if(cBRemeberMe.Checked==true)
                    {
                        objRemMe.Remember = 1;
                    }
                    else
                    {
                        objRemMe.Remember = 0;
                    }
                    string userName = tBUsername.Text;
                    string userPassword = tBPassword.Text;
                    User userRecord = new User();
                    var values = userRecord.attemptLogin(userName, userPassword);
                    bool value = values.Item1;
                    userRecord = values.Item2;
                    objUser = userRecord;
                    if(value==true)
                    {
                        FDB.SetUserOBJ(userRecord.UserName,userRecord.EmployeeID);
                        CreateAuthToken();
                        this.Hide();
                        FDB.Show();
                    }
                    else
                    {
                        lblCheckLogin.Text= "Incorrect Username or Password";
                    }
                }
                else
                {
                    lblCheckLogin.Text = "Please fill in required information";
                }   
            }
            catch
            {

            }
        }
        #endregion

        #region Authentication
        public void SetLoginUser()
        {
            FDB.SetUserOBJ(objUser.UserName, objUser.UserID);
        }

        private void CreateAuthToken()
        {
            User newUser = new User();
            string baseauth = newUser.CreateSalt(12);
            string AuthT = newUser.CreateSHA256Hash(baseauth, AuthSalt);
            objUser.UserAuthToken = AuthT;
            objRemMe.AuthToken = baseauth;
            InsertObject();
            newUser.GenerateAuthToken(ObjUser);
        }
        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        private void InsertObject()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, objRemMe);
            stream.Close();
        }
        #endregion

        #region Form Exit/ResizeOptions/ToolStripOptions Methods
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

        #endregion
    }
}
