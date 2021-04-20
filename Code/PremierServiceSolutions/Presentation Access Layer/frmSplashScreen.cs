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

namespace PremierServiceSolutions
{
    public partial class frmSplashScreen : Form
    {
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
 
        public frmSplashScreen()
        {
            InitializeComponent();
           
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Thread loadtrd = new Thread(new ThreadStart(this.CheckDirectory));
            loadtrd.IsBackground = true;
            loadtrd.Start();
        }

        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        private void CheckDirectory()
        {
            if(Directory.Exists(GetTemporaryDirectory()))
            {
                MessageBox.Show("Works");
                //Directory Exists
            }
            else
            {
                Directory.CreateDirectory(GetTemporaryDirectory());
            }
            string FullPath = GetTemporaryDirectory();
            FullPath += @"\text.ser";

            RememberMe objRemMe = new RememberMe();
            objRemMe.Remember = 1;
            objRemMe.AuthToken = "2wdadwahnfjehf3427862173612";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, objRemMe);
            stream.Close();



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

        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
