using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using PremierServiceSolutions.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Presentation_Access_Layer
{
    public partial class frmDashBoard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private int Menuoption = 0;
        
       
        Form frmDash = new frmDash();
        Form frmTick = new frmTickets();
        Form frmSched = new frmSchedule();
        Form frmCentre = new frmCentre();
        Form frmCustomers = new frmCustomers();
        public frmDashBoard()
        {
            InitializeComponent();
            frmDash.TopLevel = false;
            frmTick.TopLevel = false;
            frmSched.TopLevel = false;
            frmCentre.TopLevel = false;
            frmCustomers.TopLevel = false;
            
            
        }
       
        private void tbnTechnicians_Click(object sender, EventArgs e)
        {

        }

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

           


        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnTickets.ForeColor = Color.White;
            btnTickets.BackColor = Color.FromArgb(218, 0, 0);

            pnlMainPage.Controls.Add(frmTick);
            frmTick.Show();

        }
        private void HideForms()
        {
            frmDash.Hide();
            frmTick.Hide();
            frmCentre.Hide();
            frmSched.Hide();
            frmCustomers.Hide();
           
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnDashBoard.ForeColor = Color.White;
            btnDashBoard.BackColor = Color.FromArgb(218, 0, 0);

            pnlMainPage.Controls.Add(frmDash);
            frmDash.Show();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnSchedules.ForeColor = Color.White;
            btnSchedules.BackColor = Color.FromArgb(218, 0, 0);
            pnlMainPage.Controls.Add(frmSched);
            frmSched.Show();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            ChangeMenuSelection();
            HideForms();
            btnCallCentre.ForeColor = Color.White;
            btnCallCentre.BackColor = Color.FromArgb(218, 0, 0);

            pnlMainPage.Controls.Add(frmCentre);
            frmCentre.Show();
        }

        private void pnlDailyTicketChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pnlDashboardBottom_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
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

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {

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

        private void minimizeToTaskBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
