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
            InitializeComponent();
            this.Width = 740;
            this.Height = 900;
            lstClients = objclient.GetAll();
            listTicket = objTicket.GetAllTicket();
            PopulateTickets();

        }

        public void PopulateClients()
        {
            
        }

        private void PopulateTickets()
        {
            foreach (Client clitem in lstClients)
            {
                CreateEntry(clitem.ClientID,clitem.PersonName);
            }
        }



        private void CreateEntry(string ID, string Name)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "TicketPanel" + (flpCustomers.Controls.Count + 1);

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


            //Creating Label for ticketnumber
            Label lID = new Label();
            lID.Name = "lblTicketID" + flpCustomers.Controls.Count;
            lID.Text = ID;
            lID.AutoSize = false;
            lID.Size = new Size(40, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            //lID.BackColor = Color.White;            //Creating Label for tickettitle
            Label lTi = new Label();
            lTi.Name = "lblTicketTitle" + flpCustomers.Controls.Count;
            lTi.Text = Name;
            lTi.AutoSize = false;
            lTi.Size = new Size(100, 30);
            p.Controls.Add(lTi);
            lTi.Top = 10;
            lTi.TextAlign = ContentAlignment.MiddleLeft;
            lTi.Left = 60;
            lTi.Font = new Font("Arial", 10, FontStyle.Bold);
            lTi.ForeColor = Color.White;
            //lTi.BackColor = Color.White;

            

            //Updating the Panel and forcing it to refresh its self
            flpCustomers.Invalidate();
        }


    }
}
