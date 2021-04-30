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
    public partial class frmAssets : Form    
    {
        #region Object Var
        Asset objAsset = new Asset();
        #endregion

        #region Variables
        List<Asset> lstAsset = new List<Asset>();
        List<Asset> lstSearchAsset = new List<Asset>();
        #endregion
        public frmAssets()
        {
            InitializeComponent();
            lstAsset = objAsset.GetAll();
            lstAsset.Sort();
            PopulateAssets();
        }

        public void  PopulateAssets()
        {
            foreach (Asset asitem in lstAsset)
            {
                 CreateEntry(asitem.AssetName, asitem.ClientID, asitem.Manufacturer, asitem.Model, asitem.SerialNumber);
            }
        }

        #region Asset Panel
        private void CreateEntry(string AssName, string ClientID, string Manufacturer, string Model, string Serial)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpAssets.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpAssets.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpAssets.ClientSize.Width - 25, 50);
            flpAssets.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpAssets.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lAssName = new Label();
            lAssName.Name = "lblAssetName" + flpAssets.Controls.Count;
            lAssName.Text = AssName;
            lAssName.AutoSize = false;
            lAssName.Size = new Size(130, 30);
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
            lCusName.Name = "lblName" + flpAssets.Controls.Count;
            lCusName.Text = ClientID;
            lCusName.AutoSize = false;
            lCusName.Size = new Size(150, 30);
            p.Controls.Add(lCusName);
            lCusName.Top = 10;
            lCusName.TextAlign = ContentAlignment.MiddleLeft;
            lCusName.Left = (lAssName.Left + lAssName.Width + 20);
            lCusName.Font = new Font("Arial", 10, FontStyle.Bold);
            lCusName.ForeColor = Color.White;
            lCusName.MouseEnter += new EventHandler(HoverEnter);
            lCusName.MouseLeave += new EventHandler(HoverLeave);
            //lCusName.BackColor = Color.Green;

            //Creating Label for Contact
            Label LManu = new Label();
            LManu.Name = "lblManufacturer" + flpAssets.Controls.Count;
            LManu.Text = Manufacturer;
            LManu.AutoSize = false;
            LManu.Size = new Size(150, 30);
            p.Controls.Add(LManu);
            LManu.Top = 10;
            LManu.TextAlign = ContentAlignment.MiddleCenter;
            LManu.Left = (lCusName.Left + lCusName.Width + 20);
            LManu.Font = new Font("Arial", 10, FontStyle.Bold);
            LManu.ForeColor = Color.White;
            LManu.MouseEnter += new EventHandler(HoverEnter);
            LManu.MouseLeave += new EventHandler(HoverLeave);
            //LManu.BackColor = Color.Blue;


            //Creating Label for Email
            Label LMod = new Label();
            LMod.Name = "lblModel" + flpAssets.Controls.Count;
            LMod.Text = Model;
            LMod.AutoSize = false;
            LMod.Size = new Size(200, 30);
            p.Controls.Add(LMod);
            LMod.Top = 10;
            LMod.TextAlign = ContentAlignment.MiddleLeft;
            LMod.Left = (LManu.Left + LManu.Width + 20);
            LMod.Font = new Font("Arial", 10, FontStyle.Bold);
            LMod.ForeColor = Color.White;
            LMod.Click += new EventHandler(EmailClicked);
            LMod.MouseEnter += new EventHandler(HoverEnter);
            LMod.MouseLeave += new EventHandler(HoverLeave);
            //LMod.BackColor = Color.Purple;

            //Creating Label for DateCreated
            Label lSerial = new Label();
            lSerial.Name = "lblSerial" + flpAssets.Controls.Count;
            lSerial.Text = Serial;
            lSerial.AutoSize = false;
            lSerial.Size = new Size(130, 30);
            p.Controls.Add(lSerial);
            lSerial.Top = 10;
            lSerial.TextAlign = ContentAlignment.MiddleLeft;
            lSerial.Left = (LMod.Left + LMod.Width + 20);
            lSerial.Font = new Font("Arial", 10, FontStyle.Bold);
            lSerial.ForeColor = Color.White;
            lSerial.MouseEnter += new EventHandler(HoverEnter);
            lSerial.MouseLeave += new EventHandler(HoverLeave);
            //lSerial.BackColor = Color.Orange;



            //Updating the Panel and forcing it to refresh its self
            flpAssets.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpAssets.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpAssets.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpAssets.ClientSize.Width, 50);
            flpAssets.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpAssets.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpAssets.Controls.Count;
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
            flpAssets.Invalidate();
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
    }
}
