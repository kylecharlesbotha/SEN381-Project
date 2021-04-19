﻿using System;
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
    public partial class frmLoginScreen : Form
    {
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

    }
}
