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
    public partial class frmCentre : Form
    {
        public frmCentre()
        {
            InitializeComponent();
            TestList.Add("Darren");
            TestList.Add("Darlien");
            TestList.Add("Darwdwlien");
            TestList.Add("Darlwdwien");
            TestList.Add("Kyle");
            TestList.Add("Kyldwe");
            TestList.Add("Kysdasle");
            TestList.Add("Klazam");
            TestList.Add("Claude");
            TestList.Add("Cladawdude");
            TestList.Add("Claude");
            TestList.Add("Cris");
            TestList.Add("Brent");
            TestList.Add("Brwdent");
            TestList.Add("Brdent");
            TestList.Add("Bresdsant");
            TestList.Add("Zane");
            TestList.Add("Zack");
            TestList.Add("Zdwdack");
            TestList.Add("Zacwdk");
            flpSearchResults.Left = 9;

            flpSearchResults.BringToFront();


        }


        List<string> TestList = new List<string>();


        private void CreateEntry(string CusName, string CusID)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpSearchResults.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpSearchResults.ClientSize.Width-6, 50);
            flpSearchResults.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpSearchResults.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flpSearchResults.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width/2 - 20, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleLeft;
            lID.Left = 10;
            lID.Font = new Font("Arial", 16, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(218, 0, 0);
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                lID.BackColor = Color.FromArgb(209,209,209);
            }
            else
            {
                lID.BackColor = Color.FromArgb(179, 179, 179);
            }
            lID.Click += new EventHandler(lblSearchClicked);
            lID.MouseEnter += new EventHandler(lblMouseEnter);
            lID.MouseLeave += new EventHandler(lblMouseLeave);



            //Creating Label for CustomerDetails
            Label lCus = new Label();
            lCus.Name = "lblCustomerID" + flpSearchResults.Controls.Count;
            lCus.Text = CusID;
            lCus.AutoSize = false;
            lCus.Size = new Size(p.Width/2 - 10, 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = p.Width/2;
            lCus.Font = new Font("Arial", 16, FontStyle.Bold);
            lCus.ForeColor = Color.White;
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                lCus.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                lCus.BackColor = Color.FromArgb(179, 179, 179);
            }
            lCus.Click += new EventHandler(lblSearchClicked);
            lCus.MouseEnter += new EventHandler(lblMouseEnter);
            lCus.MouseLeave += new EventHandler(lblMouseLeave);

            //Updating the Panel and forcing it to refresh its self
            flpSearchResults.Height = flpSearchResults.Controls.Count* p.Height + (8 * flpSearchResults.Controls.Count);
            flpSearchResults.Invalidate();
        }

        private void CreateNullEntry(string CusName)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpSearchResults.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flpSearchResults.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpSearchResults.ClientSize.Width - 6, 50);
            flpSearchResults.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpSearchResults.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flpSearchResults.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width-5, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font =new Font("Arial", 12, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(179,179,179);

            //Updating the Panel and forcing it to refresh its self
            flpSearchResults.Height = (flpSearchResults.Controls.Count ) * p.Height + 8;
            flpSearchResults.Invalidate();
        }

        protected void lblSearchClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            MessageBox.Show(lbl.Name);
        }
        protected void lblMouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.White;
        }
        protected void lblMouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(210,4,45);
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing Client or Business Name")
            {

            }
            else
            {
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    for (int i = flpSearchResults.Controls.Count - 1; i >= 0; i--)
                    {
                        flpSearchResults.Controls[i].Dispose();
                    }
                    flpSearchResults.Visible = false;
                }
                else
                {

                    for (int i = flpSearchResults.Controls.Count - 1; i >= 0; i--)
                    {
                        flpSearchResults.Controls[i].Dispose();
                    }
                    string Text = tBSearch.Text.ToLower();

                    for (int i = 0; i < TestList.Count - 1; i++)
                    {
                        if (TestList[i].ToLower().StartsWith(Text))
                        {
                            CreateEntry(TestList[i], "Test");
                            found = true;
                        }

                    }
                    if (found == false)
                    {
                        CreateNullEntry("CLIENT NOT FOUND! Please clear search and try again.");
                    }
                    flpSearchResults.Visible = true;


                    //flpSearchResults.Visible = true;
                    //int value = Convert.ToInt32(tBSearchClient.Text);
                    //value = flpSearchResults.Controls.Count - value;
                    //flpSearchResults.Controls[value].Dispose();
                }
            }
        }



        private void lblContract_Click(object sender, EventArgs e)
        {

        }

        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if(tBSearch.Text == "Start Typing Client or Business Name")
                {
                    tBSearch.Clear();
                }
            }
            catch
            {

            }
        }

        private void tBSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    tBSearch.Text = "Start Typing Client or Business Name";
                }
            }
            catch
            {

            }
        }
    }

}
