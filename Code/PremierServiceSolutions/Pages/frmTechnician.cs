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
    public partial class frmTechnician : Form
    {
        #region Class Objects
        Technician objTechnician = new Technician();
        #endregion

        #region Variables
        List<Technician> lstTechnician = new List<Technician>();
        List<Technician> lstSearchTechnician = new List<Technician>();
        #endregion

        public frmTechnician()
        {
            InitializeComponent();
            LoadTech();
            this.Width = 900;
            this.Height = 740;
            pnlNewTech.Left = 5;
        }


        private void LoadTech()
        {
            lstTechnician = objTechnician.GetTechRecords();
            lstTechnician.Sort();
            PopulateTechnicians();
        }

        public void PopulateTechnicians()
        {
            foreach(Technician tecitem in lstTechnician)
            {
                CreateEntry(tecitem.TechnicianID.ToString(), tecitem.TechNameList, tecitem.TechnicianLevel.ToString(), tecitem.TechnicianStatus, tecitem.TechEmail);
            }
        }

        #region Asset Panel
        private void CreateEntry(string ID, string TecName, string TecLevel, string TechStatus, string TecEmail)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpTechnician.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpTechnician.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTechnician.ClientSize.Width - 25, 50);
            flpTechnician.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTechnician.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lAssName = new Label();
            lAssName.Name = "lblTecID" + flpTechnician.Controls.Count;
            lAssName.Text = ID;
            lAssName.AutoSize = false;
            lAssName.Size = new Size(80, 30);
            p.Controls.Add(lAssName);
            lAssName.Top = 10;
            lAssName.TextAlign = ContentAlignment.MiddleCenter;
            lAssName.Left = 15;
            lAssName.Font = new Font("Arial", 10, FontStyle.Bold);
            lAssName.ForeColor = Color.White;
            lAssName.MouseEnter += new EventHandler(HoverEnter);
            lAssName.MouseLeave += new EventHandler(HoverLeave);
            //lAssName.BackColor = Color.Red;            


            //Creating Label for Name
            Label lCusName = new Label();
            lCusName.Name = "lblTecName" + flpTechnician.Controls.Count;
            lCusName.Text = TecName;
            lCusName.AutoSize = false;
            lCusName.Size = new Size(200, 30);
            p.Controls.Add(lCusName);
            lCusName.Top = 10;
            lCusName.TextAlign = ContentAlignment.MiddleLeft;
            lCusName.Left = (lAssName.Left + lAssName.Width + 20);
            lCusName.Font = new Font("Arial", 10, FontStyle.Bold);
            lCusName.ForeColor = Color.White;
            lCusName.MouseEnter += new EventHandler(HoverEnter);
            lCusName.MouseLeave += new EventHandler(HoverLeave);
            //lCusName.BackColor = Color.Green;

            //Creating Label for Surname
            Label LManu = new Label();
            LManu.Name = "lblLevel" + flpTechnician.Controls.Count;
            LManu.Text = TecLevel;
            LManu.AutoSize = false;
            LManu.Size = new Size(100, 30);
            p.Controls.Add(LManu);
            LManu.Top = 10;
            LManu.TextAlign = ContentAlignment.MiddleLeft;
            LManu.Left = (lCusName.Left + lCusName.Width + 20);
            LManu.Font = new Font("Arial", 10, FontStyle.Bold);
            LManu.ForeColor = Color.White;
            LManu.MouseEnter += new EventHandler(HoverEnter);
            LManu.MouseLeave += new EventHandler(HoverLeave);
            //LManu.BackColor = Color.Blue;


            //Creating Label for Role
            Label LMod = new Label();
            LMod.Name = "lblStatus" + flpTechnician.Controls.Count;
            LMod.Text = TechStatus;
            LMod.AutoSize = false;
            LMod.Size = new Size(150, 30);
            p.Controls.Add(LMod);
            LMod.Top = 10;
            LMod.TextAlign = ContentAlignment.MiddleLeft;
            LMod.Left = (LManu.Left + LManu.Width + 20);
            LMod.Font = new Font("Arial", 10, FontStyle.Bold);
            LMod.ForeColor = Color.White;

            LMod.MouseEnter += new EventHandler(HoverEnter);
            LMod.MouseLeave += new EventHandler(HoverLeave);
            //LMod.BackColor = Color.Purple;

            //Creating Label for Email
            Label lSerial = new Label();
            lSerial.Name = "lblEmail" + flpTechnician.Controls.Count;
            lSerial.Text = TecEmail;
            lSerial.AutoSize = false;
            lSerial.Size = new Size(200, 30);
            p.Controls.Add(lSerial);
            lSerial.Top = 10;
            lSerial.TextAlign = ContentAlignment.MiddleLeft;
            lSerial.Left = (LMod.Left + LMod.Width + 20);
            lSerial.Font = new Font("Arial", 10, FontStyle.Bold);
            lSerial.ForeColor = Color.White;
            lSerial.MouseEnter += new EventHandler(HoverEnter);
            lSerial.MouseLeave += new EventHandler(HoverLeave);
            lSerial.Click += new EventHandler(EmailClicked);
            //lSerial.BackColor = Color.Orange;



            //Updating the Panel and forcing it to refresh its self
            flpTechnician.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpTechnician.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpTechnician.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpTechnician.ClientSize.Width, 50);
            flpTechnician.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpTechnician.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpTechnician.Controls.Count;
            lID.Text = Text;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width - 30, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 15;
            lID.Font = new Font("Arial", 10, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.MouseEnter += new EventHandler(HoverEnter);
            lID.MouseLeave += new EventHandler(HoverLeave);
            //lID.BackColor = Color.Red;            


            //Updating the Panel and forcing it to refresh its self
            flpTechnician.Invalidate();
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
        #endregion



        #region Search for Employee Methods
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "Start Typing TechnicianID/Technician Name")
            {

            }
            else
            {
                flpTechnician.Visible = false;
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                    PopulateTechnicians();
                    flpTechnician.Visible = true;
                }
                else
                {

                    ResetSearch();
                    flpTechnician.Visible = false;
                    string Text = tBSearch.Text.ToLower();



                    foreach (Technician tecitem in lstTechnician)
                    {
                        if ((tecitem.TechnicianID.ToString().StartsWith(Text)) || (tecitem.TechName.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(tecitem.TechnicianID.ToString(), tecitem.TechNameList, tecitem.TechnicianLevel.ToString(), tecitem.TechnicianStatus, tecitem.TechEmail);
                            found = true;

                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("Technician Not Found! Please clear search and try again.");
                    }
                    flpTechnician.Visible = true;
                }
            }
        }


        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tBSearch.Text == "Start Typing TechnicianID/Technician Name")
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
                if (string.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    tBSearch.Text = "Start Typing TechnicianID/Technician Name";
                }
            }
            catch
            {

            }
        }
        private void ResetSearch()
        {
            for (int i = flpTechnician.Controls.Count - 1; i >= 0; i--)
            {
                flpTechnician.Controls[i].Dispose();
            }
            flpTechnician.Visible = false;
        }


        #endregion

        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Escape)
                {
                    tBSearch.Text = "Start Typing TechnicianID/Technician Name";
                    pnlTopTechnician.Focus();
                    flpTechnician.Visible = false;
                    ResetSearch();
                    PopulateTechnicians();
                    flpTechnician.Visible = true;
                }

        }
    }
}
