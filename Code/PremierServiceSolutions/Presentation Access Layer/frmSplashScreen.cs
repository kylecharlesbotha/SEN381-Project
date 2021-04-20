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
        private readonly string AuthSalt = "JK11GvcE";
        public string FullPath;
        private string HashToken;
        RememberMe objRemMe = new RememberMe();
        User objUser = new User();
        private Thread loadtrd;
        Form frmLogin = new frmLoginScreen();

        public frmSplashScreen()
        {
            InitializeComponent();
            FullPath = GetTemporaryDirectory();
            FullPath += @"\489296awbduyg0298lfg.ser";
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //Creating New Thread to run background tasks
            loadtrd = new Thread(new ThreadStart(this.BackgroundThread));
            loadtrd.IsBackground = true;
            loadtrd.Start();

        }

        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        private void BackgroundThread()
        {
            bool AuthValue = true;
            RememberMe objUserInfo = new RememberMe();
            if (Directory.Exists(GetTemporaryDirectory()))
            {
                UpdateLabel("Welcome to Premier Serivce Solutions");
                Thread.Sleep(500);
                UpdateLabel("Loading");
                Thread.Sleep(500);

                if(!File.Exists(FullPath))
                {
                    InsertObject(0, "null");
                }
                //Method to Update the label of what is being done. 
                UpdateLabel("Reading User Information");
                //Deserializing the file in temp folders to read the values
                objUserInfo = ReadObject();
                Thread.Sleep(500);

                if (objUserInfo.AuthToken != "null1")
                {
                    //Method to Update the label of what is being done
                    UpdateLabel("Encypting User Information");
                    //Call Method to hash the Token inside the file and match it against tokens in DB
                    HashToken = CreateSHA256Hash(objUserInfo.AuthToken, AuthSalt);
                    Thread.Sleep(500);

                    //Method to Update the label of what is being done
                    UpdateLabel("Verifying User Information");
                    //Method to find a match to the AuthToken in db and return a value
                    objUser.ValidateAuthToken(HashToken);
                    Thread.Sleep(500);

                    //IF true then the auth code was found in db and user can log in
                    if(AuthValue== true)
                    {
                        //Will preload the lists within the program
                        UpdateLabel("Random 11");
                        Thread.Sleep(500);
                        UpdateLabel("Random 12");
                        Thread.Sleep(500);
                        UpdateLabel("Random 13");
                        Thread.Sleep(500);

                        
                        //Cross-Threading to close this Form
                        this.Invoke(new MethodInvoker(this.Hide));
                        
                        this.Invoke(new MethodInvoker(frmLogin.Show));
                        //End Thread
                        loadtrd.Abort();
                        
                    }

                }
            }
            else
            {
                //Method to Update the label of what is being done. 
                UpdateLabel("Creating User Directory");
                //Creating Directory
                Directory.CreateDirectory(GetTemporaryDirectory());
                Thread.Sleep(500);

                //Method to Update the label of what is being done. 
                UpdateLabel("Validating File Installation");
                //Creating File and fulling with null values
                InsertObject(0, "null");
                Thread.Sleep(500);

                UpdateLabel("Random 1");
                Thread.Sleep(500);
                UpdateLabel("Random 2");
                Thread.Sleep(500);
                UpdateLabel("Random 3");
                Thread.Sleep(500);
                UpdateLabel("Random 4");
                Thread.Sleep(500);
                UpdateLabel("Random 5");
                Thread.Sleep(500);
                UpdateLabel("Random 6");
                Thread.Sleep(500);
                UpdateLabel("Random 7");
                Thread.Sleep(500);

                Form frmLogin = new frmLoginScreen();
                //Cross-Threading to close this form
                this.Invoke(new MethodInvoker(this.Hide));
                //Cross-Threading to show Login Form
                this.Invoke(new MethodInvoker(frmLogin.Show));
                //End Thread
                loadtrd.Abort();

            }


            while (true)
            {
                if(this.lblLoadingText.InvokeRequired)
                {
                    this.lblLoadingText.BeginInvoke((MethodInvoker)delegate () { this.lblLoadingText.Text = "Darren"; ; });
                }
                else
                {
                    this.lblLoadingText.Text = "Why not";
                }
                Thread.Sleep(1000);
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
