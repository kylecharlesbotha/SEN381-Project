using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            Panel p = new Panel();
            p.Name = "panel" + (flowLayoutPanel1.Controls.Count + 1);
            p.BackColor = Color.FromArgb(123, R.Next(222), R.Next(222));
            p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 50);
            flowLayoutPanel1.Controls.Add(p);
            flowLayoutPanel1.Controls.SetChildIndex(p, 0);
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };
            Button b = new Button();
            b.Name = p.Name;
            b.Text = p.Name;
            b.Size = new Size(50, 30);
            p.Controls.Add(b);
            b.Paint += (ss, ee) => { ee.Graphics.DrawString(b.Name, Font, Brushes.White, 100,10); };
            b.Left = 100;
            b.Top = 10;
            b.Click += new EventHandler(btnTicketView);
            flowLayoutPanel1.Invalidate();
        }
        protected void btnTicketView(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
