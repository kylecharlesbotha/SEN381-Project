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
            TestList.Add("Kyle");
            TestList.Add("Klazam");
            TestList.Add("Claude");
            TestList.Add("Cris");
            TestList.Add("Brent");
            TestList.Add("Zane");
            TestList.Add("Zack");
            flpSearchResults.Left = 9;
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
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 10;
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(218, 0, 0);
            lID.Click += new EventHandler(lblTicketIDClick);



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
            lCus.ForeColor = Color.White;
            lCus.BackColor = Color.FromArgb(218, 0, 0);
            lCus.Click += new EventHandler(lblTicketIDClick);

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

        protected void lblTicketIDClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            MessageBox.Show(lbl.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flpSearchResults.Visible = true;
            CreateEntry("Test","1212");
        }

        private void tBSearchClient_TextChanged(object sender, EventArgs e)
        {
            bool found = false;
            if (String.IsNullOrWhiteSpace(tBSearchClient.Text))
            {
                for (int i = flpSearchResults.Controls.Count-1; i >= 0 ; i--)
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
                string Text = tBSearchClient.Text.ToLower();

                for (int i = 0; i < TestList.Count-1; i++)
                {
                    if(TestList[i].ToLower().StartsWith(Text))
                    {
                        CreateEntry(TestList[i], "Test");
                        found = true;
                    }

                }
                if(found==false)
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

}
