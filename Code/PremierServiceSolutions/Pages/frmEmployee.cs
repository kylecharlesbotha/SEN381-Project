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
    public partial class frmEmployee : Form
    {
        #region Class Objects
        Employee objEmployee = new Employee();
        #endregion

        #region Variables
        List<Employee> lstEmployee = new List<Employee>();
        List<Employee> lstSearchEmployeee = new List<Employee>();
        #endregion
        public frmEmployee()
        {
            InitializeComponent();
            LoadEmp();
        }

        private void LoadEmp()
        {
            lstEmployee = objEmployee.GetEmployees();
            lstEmployee.Sort();
            PopulateEmployee();
        }

        public void PopulateEmployee()
        {
            foreach (Employee empitem in lstEmployee)
            {
                CreateEntry(empitem.EmployeeID.ToString(), empitem.EmployeeName, empitem.EmployeeSurName, empitem.EmployeeRole, empitem.EmployeeEmail);
            }
        }

        #region Asset Panel
        private void CreateEntry(string ID, string EmpName, string EmpSurname, string EmpRole, string EmpEmail)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpEmployee.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpEmployee.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpEmployee.ClientSize.Width - 25, 50);
            flpEmployee.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpEmployee.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lAssName = new Label();
            lAssName.Name = "lblEmpID" + flpEmployee.Controls.Count;
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
            lCusName.Name = "lblEmpName" + flpEmployee.Controls.Count;
            lCusName.Text = EmpName;
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

            //Creating Label for Surname
            Label LManu = new Label();
            LManu.Name = "lblSurname" + flpEmployee.Controls.Count;
            LManu.Text = EmpSurname;
            LManu.AutoSize = false;
            LManu.Size = new Size(150, 30);
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
            LMod.Name = "lblRole" + flpEmployee.Controls.Count;
            LMod.Text = EmpRole;
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
            lSerial.Name = "lblEmail" + flpEmployee.Controls.Count;
            lSerial.Text = EmpEmail;
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
            flpEmployee.Invalidate();
        }

        private void CreateNullEntry(string Text)
        {
            //Create Panel Dynamically for each ticket Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flpEmployee.Controls.Count + 1);

            //Statement to alternate the colors of the panels
            if (flpEmployee.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flpEmployee.ClientSize.Width, 50);
            flpEmployee.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flpEmployee.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for ID
            Label lID = new Label();
            lID.Name = "lblNotFound" + flpEmployee.Controls.Count;
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
            flpEmployee.Invalidate();
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
            if (tBSearch.Text == "Start Typing EmployeeID/EmployeeName")
            {

            }
            else
            {
                flpEmployee.Visible = false;
                bool found = false;
                if (String.IsNullOrWhiteSpace(tBSearch.Text))
                {
                    ResetSearch();
                    PopulateEmployee();
                    flpEmployee.Visible = true;
                }
                else
                {

                    ResetSearch();
                    flpEmployee.Visible = false;
                    string Text = tBSearch.Text.ToLower();



                    foreach (Employee empitem in lstEmployee)
                    {
                        if ((empitem.EmployeeID.ToString().StartsWith(Text)) || (empitem.EmployeeName.ToLower().StartsWith(Text)))
                        {
                            CreateEntry(empitem.EmployeeID.ToString(), empitem.EmployeeName, empitem.EmployeeSurName, empitem.EmployeeRole, empitem.EmployeeEmail);
                            found = true;

                        }
                    }
                    if (found == false)
                    {
                        CreateNullEntry("Employee Not Found! Please clear search and try again.");
                    }
                    flpEmployee.Visible = true;
                }
            }
        }
        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tBSearch.Text = "Start Typing EmployeeID/EmployeeName";
                pnlTopEmployee.Focus();
                flpEmployee.Visible = false;
                ResetSearch();
                PopulateEmployee();
                flpEmployee.Visible = true;
            }
        }

        private void tBSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tBSearch.Text == "Start Typing EmployeeID/EmployeeName")
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
                    tBSearch.Text = "Start Typing EmployeeID/EmployeeName";
                }
            }
            catch
            {

            }
        }
        private void ResetSearch()
        {
            for (int i = flpEmployee.Controls.Count - 1; i >= 0; i--)
            {
                flpEmployee.Controls[i].Dispose();
            }
            flpEmployee.Visible = false;
        }

        #endregion
    }
}
