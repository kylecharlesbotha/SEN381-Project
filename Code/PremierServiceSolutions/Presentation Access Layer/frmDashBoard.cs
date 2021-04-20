using PremierServiceSolutions.Pages;
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
    public partial class frmDashBoard : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private int Menuoption = 0;
        Form frmDash = new frmDash();
        public frmDashBoard()
        {
            InitializeComponent();
            frmDash.TopLevel = false;

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
    }
}
