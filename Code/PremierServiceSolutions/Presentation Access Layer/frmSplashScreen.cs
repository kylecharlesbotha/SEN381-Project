using PremierServiceSolutions.Serialization;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Presentation_Access_Layer;

namespace PremierServiceSolutions
{
    public partial class frmSplashScreen : Form
    {
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        private readonly string AuthSalt = "bp1cHcfg";
        public string FullPath;
        private string HashToken;
        RememberMe objRemMe = new RememberMe();
        User objUser = new User();
        private Thread loadtrd;
        Form frmLogin = new frmLoginScreen();
        frmLoginScreen objLogin = new frmLoginScreen(); 
        frmDashBoard objDash = new frmDashBoard();
        List<User> lstUsers = new List<User>();

        public frmSplashScreen()
        {
            InitializeComponent();
            FullPath = GetTemporaryDirectory();
            FullPath += @"\489296awbduyg0298lfg.ser";
            lstUsers = objUser.GetAllUsers();
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //Creating New Thread to run background tasks
            loadtrd = new Thread(new ThreadStart(this.BackgroundThread));
            loadtrd.IsBackground = true;
            loadtrd.SetApartmentState(ApartmentState.STA);
            loadtrd.Start();

        }

        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        private void BackgroundThread()
        {
            bool AuthValue = false;
            RememberMe objUserInfo = new RememberMe();

            //Will match if the directory exists
            if (Directory.Exists(GetTemporaryDirectory()))
            {
                //Update labels
                UpdateLabel("Welcome to Premier Serivce Solutions");
                Thread.Sleep(500);
                UpdateLabel("Loading Service");
                Thread.Sleep(500);

                //Create file if it doesnt exist
                if(!File.Exists(FullPath))
                {
                    InsertObject(0, "auth");
                }
                //Method to Update the label of what is being done. 
                UpdateLabel("Reading User Information");
                //Deserializing the file in temp folders to read the values
                objUserInfo = ReadObject();
                Thread.Sleep(500);

                //If the authtoken that is read from the file is not equal to auth it will match
                if (objUserInfo.AuthToken != "auth")
                {
                    //Method to Update the label of what is being done
                    UpdateLabel("Retrieving User Information");
                    //Call Method to hash the Token inside the file and match it against tokens in DB
                    HashToken = CreateSHA256Hash(objUserInfo.AuthToken, AuthSalt);
                    Thread.Sleep(500);

                    //Method to Update the label of what is being done
                    UpdateLabel("Validating User Authorization");
                    foreach (User item in lstUsers)
                    {
                        if(HashToken == item.UserAuthToken)
                        {
                            objUser = item;
                            objLogin.ObjUser = item;
                            AuthValue = true;
                            UpdateLabel("User Found");
                        }
                    }
                    Thread.Sleep(500);

                    //Method to Update the label of what is being done
                    UpdateLabel("Verifying User Information");
                    Thread.Sleep(500);

                    //IF true then the auth code was found in db and user can log in
                    if ((AuthValue == true) && (objUserInfo.Remember == 1))
                    {
                        //Will preload the lists within the program
                        UpdateLabel("Loading Login");
                        Thread.Sleep(500);

                        //Will preload the lists within the program
                        UpdateLabel("Logging User In");
                        Thread.Sleep(500);
                        //Cross-Threading to close this Form
                        this.Invoke(new MethodInvoker(this.Hide));
                        objDash.SetUserOBJ(objUser.UserName, objUser.UserID);
                        this.Invoke(new MethodInvoker(frmLogin.Show));
                        Thread.Sleep(500);
                        this.Invoke(new MethodInvoker(frmLogin.Hide));
                        Thread.Sleep(500);
                        this.Invoke(new MethodInvoker(objDash.Show));
                        //End Thread
                        loadtrd.Abort();

                    }
                    else if ((AuthValue == true) && (objUserInfo.Remember == 0))
                    {
                        //Will preload the lists within the program
                        UpdateLabel("Loading Login");
                        Thread.Sleep(500);
                        //Cross-Threading to close this Form
                        this.Invoke(new MethodInvoker(this.Hide));

                        this.Invoke(new MethodInvoker(frmLogin.Show));
                    }
                    else //if the authvalue is false will match
                    {
                        UpdateLabel("Session ID Expired");
                        Thread.Sleep(500);

                        UpdateLabel("Loading Login");
                        Thread.Sleep(500);

                        this.Invoke(new MethodInvoker(this.Hide));

                        this.Invoke(new MethodInvoker(frmLogin.Show));
                        loadtrd.Abort();
                    }

                }
                else //if authtoken is auth it will match
                {
                    //Will preload the lists within the program
                    UpdateLabel("Loading Login");
                    Thread.Sleep(500);
                    this.Invoke(new MethodInvoker(this.Hide));

                    this.Invoke(new MethodInvoker(frmLogin.Show));
                }
            }
            else //If directory does not exist then it will match
            {
                //Method to Update the label of what is being done. 
                UpdateLabel("Creating User Directory");
                //Creating Directory
                Directory.CreateDirectory(GetTemporaryDirectory());
                Thread.Sleep(500);

                //Method to Update the label of what is being done. 
                UpdateLabel("Creating Authentication");
                //Creating File and fulling with null values
                InsertObject(0, "auth");
                Thread.Sleep(500);

                UpdateLabel("Validating Creation");
                Thread.Sleep(500);

                UpdateLabel("Loading Forms");

                Form frmLogin = new frmLoginScreen();
                //Cross-Threading to close this form
                this.Invoke(new MethodInvoker(this.Hide));
                //Cross-Threading to show Login Form
                this.Invoke(new MethodInvoker(frmLogin.Show));
                //End Thread
                loadtrd.Abort();

            }

        }
        #region Serialization Methods
        private void InsertObject(int Rem, string Token)
        {   
            objRemMe.Remember = Rem;
            objRemMe.AuthToken = Token;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, objRemMe);
            stream.Close();
        }

        private RememberMe ReadObject()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FullPath, FileMode.Open, FileAccess.Read);

            objRemMe = (RememberMe)formatter.Deserialize(stream);
            return objRemMe;
        }
        #endregion
        #region Invoke Label
        private void UpdateLabel(string LabelText)
        {
            if (this.lblLoadingText.InvokeRequired)
            {
                this.lblLoadingText.BeginInvoke((MethodInvoker)delegate () { this.lblLoadingText.Text = LabelText; ; });
            }
            else
            {
                this.lblLoadingText.Text = "Error Occures";
            }
        }
        #endregion
        #region Hashing
        private String CreateSHA256Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256hashstring = new SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToStrng(hash);
        }
        private String CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private static string ByteArrayToStrng(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
        #endregion
    }
}
