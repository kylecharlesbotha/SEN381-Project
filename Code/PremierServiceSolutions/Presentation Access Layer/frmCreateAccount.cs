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
    }
}
