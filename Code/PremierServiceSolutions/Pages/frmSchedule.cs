

using PremierServiceSolutions.CustomComponents;
using PremierServiceSolutions.Data_Access_Layer;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmSchedule : Form
    {
        DBHandler objHandler = new DBHandler();
        private readonly string DirectoryPath = "{L7016943-D799-P227-S262-S52490120069}";
        public string FullPath;
        SimpleScheduleDataProvider data;

        public frmSchedule()
        {
            InitializeComponent();
            ScheduleControl scheduleControlMain = new ScheduleControl();
            this.schedContCal.ItemChanged += ScheduleControl_AutoSave;
            scheduleControlMain.Location = new Point(82, 12);
            scheduleControlMain.Size = new Size(350, 360);
            this.Controls.Add(scheduleControlMain);
            FullPath = GetTemporaryDirectory();
            FullPath += @"\default.schedule";
        }
        //Method used for Getting Path of %temp% folder on local machine
        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), DirectoryPath);
            return tempDirectory;
        }

        private void ScheduleControl_AutoSave(object sender, ScheduleAppointmentEventArgs e)
        {
            if (e.Action == ItemAction.Edit)
            {
                MessageBox.Show("Edit option");
            }
            else if (e.Action == ItemAction.Delete)
            {
                MessageBox.Show("Delete option");
            }
            else if (e.Action == ItemAction.Add)
            {
                MessageBox.Show("Add option");
            }
            else if (e.Action == ItemAction.ItemDrag)
            {
                MessageBox.Show("Drag option");
            }
            else if (e.Action == ItemAction.TimeDrag)
            {
                MessageBox.Show("Time option");
            }
        }

        private void DisplayData()
        {

            if (data != null)
            {
                for (int i = 0; i < data.MasterList.Count; i++)
                {
                    IScheduleAppointment appointment = data.MasterList[i];
                    MessageBox.Show("Appointment Date is " + appointment.StartTime.ToLongDateString() +
                    "\n" + "Start Time is " + appointment.StartTime.ToLongTimeString() +
                    "\n" + "End Time is " + appointment.EndTime.ToLongTimeString() +
                    "\n" + "Subject is " + appointment.Subject.ToString() +
                    "\n" + "Location is " + appointment.LocationValue.ToString() +
                    "\n" + "Status is" + appointment.MarkerValue.ToString());

                }
            }
        }


        private void CustomizeDesign()
        {
            pnlAssignedSub.Visible = false;
            pnlProgressSub.Visible = false;
            pnlUnassignedSub.Visible = false;
        }



        private void hideSubMenu()
        {
            if(pnlUnassignedSub.Visible==true)
            {
                pnlUnassignedSub.Visible = false;
            }
            if (pnlProgressSub.Visible == true)
            {
                pnlProgressSub.Visible = false;
            }
            if (pnlAssignedSub.Visible == true)
            {
                pnlAssignedSub.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
               //hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void frmSchedule_Load(object sender, EventArgs e)
        {

            LoadCalendar();
            CustomizeDesign();
        }


        private void LoadCalendar()
        {
            //Checkes wheather a direcotry exists inside of the Temp Folders
            if (Directory.Exists(GetTemporaryDirectory()))
            {

                //Checks if the default.schedule file exists inside that file
                if (!File.Exists(FullPath))
                {
                    //This will ensure that the FileStream data in SQL has the latest file from FTP server
                    UpdateFileStream();
                    //Pull the latest filestream from sql and store it inside of Temp folder/Directory
                    SelectDoc();
                }
            }
            else
            {
                //Create Directory then Create file within the directory and pull latest filestream from SQL
                Directory.CreateDirectory(GetTemporaryDirectory());
                UpdateFileStream();
                SelectDoc();
            }


            data = SimpleScheduleDataProvider.LoadBinary(FullPath);
            data.FileName = FullPath;

            this.schedContCal.ScheduleType = ScheduleViewType.Month;
            this.schedContCal.DataSource = data;
        }

        #region Uploading Schedule File
        private void UpdateCalendar()
        {

        }
        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }

        }

        FtpSetting _inputParameter;

        public void UploadFile()
        {
            _inputParameter.Username = "FlyStudio";
            _inputParameter.Password = "Fr35h5t@rt2021!";
            _inputParameter.Server = "ftp://flystudio.co.za";
            _inputParameter.FullName = FullPath;
            _inputParameter.FileName = "default.schedule";


        }
        #endregion


        private void UpdateFileStream()
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE DemoFileStreamTablePrimary SET [FilePath] = (SELECT * FROM OPENROWSET(BULK 'C:\PremierServiceSolutions\default.schedule',SINGLE_BLOB) AS Schedule) WHERE FileName = 'Sample Schedule File 2'");
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Perform the Update Query
                UpdateCommand.ExecuteNonQuery();
                //Close the connection to the database
                sqlCon.Close();
            }
            catch (SqlException SQLE)
            {
                //If any error has to occur during the try phase it will display a Error message and will return false to indicate it was unsuccessful
                MessageBox.Show("Error has occured please try again");
            }
        }


        public void SelectDoc()
        {

            string qu = "SELECT FilePath FROM DemoFileStreamTablePrimary WHERE FileName = 'Sample Schedule File 2'";
            SqlConnection cnn = new SqlConnection(objHandler.ConnectionVal);
            cnn.Open();
            SqlCommand com = new SqlCommand(qu, cnn);

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                var file = (byte[])reader["FilePath"];

                File.WriteAllBytes(FullPath, file);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.CommitChanges();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnAssigned_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAssignedSub);
        }

        private void btnUnassigned_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlUnassignedSub);
        }

        private void btnProgressTickets_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlProgressSub);
        }
    }
}
