using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Pages;
using PremierServiceSolutions.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Presentation_Access_Layer
{
    public partial class frmDashBoard : Form
    {
        #region Public and Private Var
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string loggeduser;
        private string userrole;

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private int Menuoption = 0;
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        public string FullPath;
        #endregion
        #region Form Move Events
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Objects of Forms
        RememberMe objRemMe = new RememberMe();
        Technician CurrentTech = new Technician();
        Form frmDash = new frmDash();
        frmTickets frmTick = new frmTickets();
        Form frmSched = new frmSchedule();
        frmCentre frmCentre = new frmCentre();
        frmCustomers frmCustomers = new frmCustomers();
        frmAssets frmAssets = new frmAssets();
        frmCustomerSupport frmCustomerSupport = new frmCustomerSupport();

        #endregion
        public frmDashBoard()
        {
            InitializeComponent();
            frmDash.TopLevel = false;
            frmTick.TopLevel = false;
            frmSched.TopLevel = false;
            frmCentre.TopLevel = false;
            frmCustomers.TopLevel = false;
            frmAssets.TopLevel = false;
            frmCustomerSupport.TopLevel = false;
            pnlSideMenu.Focus();
            FullPath = GetTemporaryDirectory();
            FullPath += @"\489296awbduyg0298lfg.ser";
            frmCustomers.PopulateClients();


        }

        private void InsertObject(int Rem, string Token)
        {
            objRemMe.Remember = Rem;
            objRemMe.AuthToken = Token;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, objRemMe);
            stream.Close();
        }
        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        public void SetUserOBJ(string username, int userid)
        {
            loggeduser = username;
            lblUserName.Text = username;
            frmCentre.CurrentEmployee = userid;
            CurrentTech = CurrentTech.GetTechID(username);
            frmTick.SetStuff(CurrentTech.TechnicianID); 
        }
       
        private void tbnTechnicians_Click(object sender, EventArgs e)
        {

        }

        #region Dashboard Events
        private void frmDashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmDashBoard_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

            btnDashBoard.BackColor = Color.FromArgb(218, 0, 0);
            btnDashBoard.ForeColor = Color.White;
            
            pnlMainPage.Controls.Add(frmDash);
            frmDash.Show();
        }

        #endregion


        #region Menu Methods and Button Methods
        private void ChangeMenuSelection()
        {
            btnDashBoard.BackColor = Color.White;
            btnCallCentre.BackColor = Color.White;
            btnTickets.BackColor = Color.White;
            btnSchedules.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnCustomerSupport.BackColor = Color.White;
            btnContracts.BackColor = Color.White;
            btnTechnicians.BackColor = Color.White;
            btnEmployees.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnAsset.BackColor = Color.White;

            btnDashBoard.ForeColor = Color.FromArgb(218,0,0);
            btnCallCentre.ForeColor = Color.FromArgb(218, 0, 0);
            btnTickets.ForeColor = Color.FromArgb(218, 0, 0);
            btnSchedules.ForeColor = Color.FromArgb(218, 0, 0);
            btnCustomers.ForeColor = Color.FromArgb(218, 0, 0);
            btnCustomerSupport.ForeColor = Color.FromArgb(218, 0, 0);
            btnContracts.ForeColor = Color.FromArgb(218, 0, 0);
            btnTechnicians.ForeColor = Color.FromArgb(218, 0, 0);
            btnEmployees.ForeColor = Color.FromArgb(218, 0, 0);
            btnReports.ForeColor = Color.FromArgb(218, 0, 0);
            btnAsset.ForeColor = Color.FromArgb(218, 0, 0);



            pbDash.Image = Properties.Resources.DashRed;
            pbCall.Image = Properties.Resources.CallRed;
            pbTickets.Image = Properties.Resources.Tickets_Red;
            pbSchedule.Image = Properties.Resources.ScheduleRed;
            pbCustomer.Image = Properties.Resources.CustomerRed;
            pbSupport.Image = Properties.Resources.CustomerSupportRed;
            pbAssets.Image = Properties.Resources.AssestRed;
            pbContracts.Image = Properties.Resources.ContractRed;
            pbTechnician.Image = Properties.Resources.DashRed;
            pbReports.Image = Properties.Resources.ReportsRed;
            pbEmployee.Image = Properties.Resources.EmployeeRed;

            pbDash.BackColor = Color.White ;
            pbCall.BackColor = Color.White ;
            pbTickets.BackColor = Color.White;
            pbSchedule.BackColor = Color.White;
            pbCustomer.BackColor = Color.White;
            pbSupport.BackColor = Color.White;
            pbAssets.BackColor = Color.White;
            pbContracts.BackColor = Color.White;
            pbTechnician.BackColor = Color.White;
            pbReports.BackColor = Color.White;
            pbEmployee.BackColor = Color.White;



        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnTickets.ForeColor = Color.White;
            btnTickets.BackColor = Color.FromArgb(218, 0, 0);


            pbTickets.BackColor = Color.FromArgb(218, 0, 0);
            pbTickets.Image = Properties.Resources.TicketsWhite;
            pnlMainPage.Controls.Add(frmTick);
            frmTick.Show();

        }
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnDashBoard.ForeColor = Color.White;
            btnDashBoard.BackColor = Color.FromArgb(218, 0, 0);

            pbDash.BackColor = Color.FromArgb(218, 0, 0);
            pbDash.Image = Properties.Resources.DashWhite;
            pnlMainPage.Controls.Add(frmDash);
            frmDash.Show();
        }
        private void btnSchedules_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnSchedules.ForeColor = Color.White;
            btnSchedules.BackColor = Color.FromArgb(218, 0, 0);

            pbSchedule.BackColor = Color.FromArgb(218, 0, 0);
            pbSchedule.Image = Properties.Resources.ScheduleWhite;
            pnlMainPage.Controls.Add(frmSched);
            frmSched.Show();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnCallCentre.ForeColor = Color.White;
            btnCallCentre.BackColor = Color.FromArgb(218, 0, 0);

            pbCall.BackColor = Color.FromArgb(218, 0, 0);
            pbCall.Image = Properties.Resources.CallWhite;
            pnlMainPage.Controls.Add(frmCentre);
            frmCentre.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnCustomers.ForeColor = Color.White;
            btnCustomers.BackColor = Color.FromArgb(218, 0, 0);

            pbCustomer.BackColor = Color.FromArgb(218, 0, 0);
            pbCustomer.Image = Properties.Resources.CustomerWhite;
            pnlMainPage.Controls.Add(frmCustomers);
            frmCustomers.Show();
            
        }

        private void btnAsset_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnAsset.ForeColor = Color.White;
            btnAsset.BackColor = Color.FromArgb(218, 0, 0);

            pbAssets.BackColor = Color.FromArgb(218, 0, 0);
            pbAssets.Image = Properties.Resources.AssestWhite;
            pnlMainPage.Controls.Add(frmAssets);
            frmAssets.Show();
        }

        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnCustomerSupport.ForeColor = Color.White;
            btnCustomerSupport.BackColor = Color.FromArgb(218, 0, 0);

            pbSupport.BackColor = Color.FromArgb(218, 0, 0);
            pbSupport.Image = Properties.Resources.CustomerSupportWhite;
            pnlMainPage.Controls.Add(frmCustomerSupport);
            frmCustomerSupport.Show();
        }
        private void HideForms()
        {
            frmDash.Hide();
            frmTick.Hide();
            frmCentre.Hide();
            frmSched.Hide();
            frmAssets.Hide();
            frmCustomers.Hide();
            frmCustomerSupport.Hide();
        }


        #endregion



        private void pnlDailyTicketChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pnlDashboardBottom_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Moving form and Minimizing Form

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void iPBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmDashBoard_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(500);
            }
        }

        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }
        #endregion


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            InsertObject(0, "auth");
            frmLoginScreen frmlog = new frmLoginScreen();
            frmlog.Show();
            this.Hide();
        }

        #region Hover Events for form controls

        private void iPBExit_MouseEnter(object sender, EventArgs e)
        {
            iPBExit.ForeColor = Color.Black;
        }

        private void iPBExit_MouseLeave(object sender, EventArgs e)
        {
            iPBExit.ForeColor = Color.FromArgb(218, 0, 0);
        }

        private void iPBMinimize_MouseEnter(object sender, EventArgs e)
        {
            iPBMinimize.ForeColor = Color.Black;
        }

        private void iPBMinimize_MouseLeave(object sender, EventArgs e)
        {
            iPBMinimize.ForeColor = Color.FromArgb(218, 0, 0);
        }
        #endregion

        private void iPBExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
