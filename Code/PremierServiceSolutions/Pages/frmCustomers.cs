using PremierServiceSolutions.Business_Logic_Layer;
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
    public partial class frmCustomers : Form
    {

        #region Class Objects
        Client objclient = new Client();

        Ticket objTicket = new Ticket();
        List<Ticket> listTicket = new List<Ticket>();
        #endregion

        #region Variables
        List<Client> lstClients = new List<Client>();
        #endregion
        public frmCustomers()
        {
            this.Width = 740;
            this.Height = 900;
            InitializeComponent();

            pnlNewClient.Left = 9;
            pnlNewClient.Top = 11;
            lstClients = objclient.GetAll();
            lstClients.Sort();
            PopulateClients();

        }


        public void PopulateClients()
        {
            foreach (Client clitem in lstClients)
            {
                CreateEntry(clitem.ClientID,clitem.PersonName,clitem.ClientCell,clitem.ClientEmail,clitem.ClientCreationDate);
            }
        }



        private void CreateEntry(string ID, string Name, string Contacts,string Email,DateTime DateCreated)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpCustomers.Controls.Count + 1);
            
            //Statement to alternate the colors of the panels
            if (flpCustomers.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpCustomers.ClientSize.Width-25, 50);
            flpCustomers.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpCustomers.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblID" + flpCustomers.Controls.Count;
            lID.Text = ID;
            lID.AutoSize = false;
            lID.Size = new Size(130, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.MouseEnter += new EventHandler(HoverEnter);
            lID.MouseLeave += new EventHandler(HoverLeave);
            //lID.BackColor = Color.Red;            
            
            
            //Creating Label for Name
            Label lTi = new Label();
            lTi.Name = "lblName" + flpCustomers.Controls.Count;
            lTi.Text = Name;
            lTi.AutoSize = false;
            lTi.Size = new Size(150, 30);
            p.Controls.Add(lTi);
            lTi.Top = 10;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = (lID.Left + lID.Width + 20);
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.White;
            lTi.MouseEnter += new EventHandler(HoverEnter);
            lTi.MouseLeave += new EventHandler(HoverLeave);
            //lTi.BackColor = Color.Green;

            //Creating Label for Contact
            Label LCon = new Label();
            LCon.Name = "lblContact" + flpCustomers.Controls.Count;
            LCon.Text = Contacts;
            LCon.AutoSize = false;
            LCon.Size = new Size(150, 30);
            p.Controls.Add(LCon);
            LCon.Top = 10;
            LCon.TextAlign = ContentAlignment.MiddleCenter;
            LCon.Left =(lTi.Left + lTi.Width + 20);
            LCon.Font = new Font("Arial", 10, FontStyle.Bold);
            LCon.ForeColor = Color.White;
            LCon.MouseEnter += new EventHandler(HoverEnter);
            LCon.MouseLeave += new EventHandler(HoverLeave);
            //LCon.BackColor = Color.Blue;


            //Creating Label for Email
            Label lEm = new Label();
            lEm.Name = "lblEmail" + flpCustomers.Controls.Count;
            lEm.Text = Email;
            lEm.AutoSize = false;
            lEm.Size = new Size(200, 30);
            p.Controls.Add(lEm);
            lEm.Top = 10;
            lEm.TextAlign = ContentAlignment.MiddleLeft;
            lEm.Left = (LCon.Left + LCon.Width + 20);
            lEm.Font = new Font("Arial", 10, FontStyle.Bold);
            lEm.ForeColor = Color.White;
            lEm.Click += new EventHandler(EmailClicked);
            lEm.MouseEnter += new EventHandler(HoverEnter);
            lEm.MouseLeave += new EventHandler(HoverLeave);
            //lEm.BackColor = Color.Purple;

            //Creating Label for DateCreated
            DateCreated.ToString("yyyy-MM-dd HH:mm:ss");
            DateCreated.ToString("yyyy-MM-dd");
            Label lDate = new Label();
            lDate.Name = "lblDateCreated" + flpCustomers.Controls.Count;
            lDate.Text = Convert.ToString(DateCreated);
            lDate.AutoSize = false;
            lDate.Size = new Size(130, 30);
            p.Controls.Add(lDate);
            lDate.Top = 10;
            lDate.TextAlign = ContentAlignment.MiddleLeft;
            lDate.Left = (lEm.Left + lEm.Width + 20);
            lDate.Font = new Font("Arial", 10, FontStyle.Bold);
            lDate.ForeColor = Color.White;
            lDate.MouseEnter += new EventHandler(HoverEnter);
            lDate.MouseLeave += new EventHandler(HoverLeave);
            //lDate.BackColor = Color.Orange;



            //Updating the Panel and forcing it to refresh its self
            flpCustomers.Invalidate();
        }
        protected void EmailClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            System.Diagnostics.Process.Start("mailto:" + lbl.Text);
        }
        protected void HoverEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.FromArgb(218, 0, 0);
        }
        protected void HoverLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.White;
        }
        private void btnRAddClient_Click(object sender, EventArgs e)
        {
            pnlNewClient.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewClient.Visible = false;
        }
    }
}
