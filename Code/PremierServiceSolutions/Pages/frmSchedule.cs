

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
using System.Net;
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
        private ContextMenuStrip strip;
        DateTime SelectedDate;

        public frmSchedule()
        {
            InitializeComponent();
            ScheduleControl scheduleControlMain = new ScheduleControl();
            this.schedContCal.ItemChanged += ScheduleControl_AutoSave;
           this.schedContCal.Calendar.CalenderGrid.QueryCellInfo += CalendarGrid_Query;
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

        #region AutoSave Schedular
        //Method that will run when any changes are made to save the appointments and then upload it to the FTP and then update SQL Server
        private void SaveUpdate()
        {
            //Will save the changes to the schedule file
            data.CommitChanges();
            //Will upload file to FTP server
            MessageBox.Show("Saved");
            bgwUploadFile.RunWorkerAsync(_inputParameter);
            MessageBox.Show("Uploaded");
            //This will ensure that the FileStream data in SQL has the latest file from FTP server
            UpdateFileStream();
            //Pull the latest filestream from sql and store it inside of Temp folder/Directory
            SelectDoc();


            //Update Calendar with latest information
            data = SimpleScheduleDataProvider.LoadBinary(FullPath);
            data.FileName = FullPath;

            this.schedContCal.ScheduleType = ScheduleViewType.Month;
            this.schedContCal.DataSource = data;
            this.schedContCal.Refresh();
        }

        //Method that will automatically update the schedule file once any changes is made
        private void ScheduleControl_AutoSave(object sender, ScheduleAppointmentEventArgs e)
        {
            if (e.Action == ItemAction.Edit)
            {
                MessageBox.Show("Edit option");
                SaveUpdate();
            }
            else if (e.Action == ItemAction.Delete)
            {
                MessageBox.Show("Delete option");
                SaveUpdate();
            }
            else if (e.Action == ItemAction.Add)
            {
                MessageBox.Show("Add option");
                SaveUpdate();
            }
            else if (e.Action == ItemAction.ItemDrag)
            {
                MessageBox.Show("Drag option");
                SaveUpdate();
            }
            else if (e.Action == ItemAction.TimeDrag)
            {
                MessageBox.Show("Time option");
                SaveUpdate();
            }
        }
        #endregion


        #region Populating Tree View

        private void PopulateTreeView()
        {
            bool assigned = false;
            bool unassigned = false;
            bool progress = false;
            bool newtick = false;
            if (data != null)
            {
                ResetSearch(flpAssigned);
                ResetSearch(flpNewTickets);
                ResetSearch(flpProgress);
                ResetSearch(flpUnassigned);
                for (int i = 0; i < data.MasterList.Count; i++)
                {
                    IScheduleAppointment appointment = data.MasterList[i];

                    if(appointment.MarkerValue == 5)
                    {
                        CreateTreeEntry(flpProgress, appointment.Subject.ToString(), appointment.StartTime.ToString());
                        progress = true;
                    }
                    if (appointment.MarkerValue == 2)
                    {
                        CreateTreeEntry(flpNewTickets, appointment.Subject.ToString(), appointment.StartTime.ToString());
                        newtick = true;
                    }
                    if (appointment.MarkerValue == 1)
                    {
                        CreateTreeEntry(flpAssigned, appointment.Subject.ToString(), appointment.StartTime.ToString());
                        assigned = true;
                    }
                    if (appointment.MarkerValue == 0)
                    {
                        CreateTreeEntry(flpUnassigned, appointment.Subject.ToString(), appointment.StartTime.ToString());
                        unassigned = true;
                    }

                }

                if (assigned == false)
                {
                    CreateNullEntry(flpAssigned, "No Appointments matching criteria");
                }
                if (unassigned == false)
                {
                    CreateNullEntry(flpUnassigned, "No Appointments matching criteria");
                }
                if (newtick == false)
                {
                    CreateNullEntry(flpNewTickets, "No Appointments matching criteria");
                }
                if (progress == false)
                {
                    CreateNullEntry(flpProgress, "No Appointments matching criteria");
                }
            }
        }
        #endregion

        #region Dynamic Tree Entry Creatros

        private void CreateTreeEntry(FlowLayoutPanel flp, string Title, string Date)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ProgressPanel" + (flp.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flp.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }


            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flp.ClientSize.Width - 6, 50);
            flp.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flp.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Appointment Title
            Label lID = new Label();
            lID.Name = "lblTitle" + flp.Controls.Count;
            lID.Text = Title;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width / 2 - 25, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleLeft;
            lID.Left = 10;
            lID.Font = new Font("Arial", 8, FontStyle.Bold);
            lID.ForeColor = Color.White;
            if (flp.Controls.Count % 2 == 0)
            {
                lID.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                lID.BackColor = Color.FromArgb(179, 179, 179);
            }
            

            //Creating Label for Appointment Date
            Label lCus = new Label();
            lCus.Name = "lblDate" + flp.Controls.Count;
            lCus.Text = Date;
            lCus.AutoSize = false;
            lCus.Size = new Size(p.Width / 2 , 30);
            p.Controls.Add(lCus);
            lCus.Top = 10;
            lCus.TextAlign = ContentAlignment.MiddleCenter;
            lCus.Left = p.Width / 2 -15;
            lCus.Font = new Font("Arial", 8, FontStyle.Bold);
            lCus.ForeColor = Color.White;
            if (flp.Controls.Count % 2 == 0)
            {
                lCus.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                lCus.BackColor = Color.FromArgb(179, 179, 179);
            }
            lCus.Click += new EventHandler(lblTreeClicked);

            //Updating the Panel and forcing it to refresh its self
            flp.Height = flp.Controls.Count * p.Height + (8 * flp.Controls.Count);
            flp.Invalidate();
        }

        private void CreateNullEntry(FlowLayoutPanel flp, string CusName)
        {
            //Create Panel Dynamically for each Client Record
            Panel p = new Panel();
            p.Name = "ClientPanel" + (flp.Controls.Count);

            //Statement to alternate the colors of the panels
            if (flp.Controls.Count % 2 == 0)
            {
                p.BackColor = Color.FromArgb(179, 179, 179);
            }
            else
            {
                p.BackColor = Color.FromArgb(209, 209, 209);
            }

            //Setting the Size of Panel and adding it to the main panel
            p.Size = new Size(flp.ClientSize.Width, 50);
            flp.Controls.Add(p);

            //Setting new panel to insert at the top and move rest down
            flp.Controls.SetChildIndex(p, 0);

            //Painting the name on the panel
            p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };


            //Creating Label for Customer Name
            Label lID = new Label();
            lID.Name = "lblCusName" + flp.Controls.Count;
            lID.Text = CusName;
            lID.AutoSize = false;
            lID.Size = new Size(p.Width, 30);
            p.Controls.Add(lID);
            lID.Top = 10;
            lID.TextAlign = ContentAlignment.MiddleCenter;
            lID.Left = 10;
            lID.Font = new Font("Arial", 8, FontStyle.Bold);
            lID.ForeColor = Color.White;
            lID.BackColor = Color.FromArgb(179, 179, 179);

            //Updating the Panel and forcing it to refresh its self
            flp.Height = (flp.Controls.Count) * p.Height + 8;
            flp.Invalidate();
        }

        protected void lblTreeClicked(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            string date = lbl.Text;
            for (int i = 0; i < data.MasterList.Count; i++)
            {
                IScheduleAppointment appointment = data.MasterList[i];

                if(date == appointment.StartTime.ToString())
                {
                    SelectedDate = appointment.StartTime;
                    UpdateMonthFocus();

                }
            }

        }

            private void ResetSearch(FlowLayoutPanel flp)
        {
            for (int i = flp.Controls.Count - 1; i >= 0; i--)
            {
                flp.Controls[i].Dispose();
            }
            flp.Visible = false;
        }
        #endregion

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            
            UploadFile();
            LoadCalendar();
            CustomizeDesign();
            PopulateTreeView();
        }

        private void deleteItemClick(object sender, EventArgs e)
        {
            this.schedContCal.PerformDeleteItemClick();
            SaveUpdate();
        }


        #region Displaying Latest schedule file in the calendar
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
                else //If file does exist it must anyway update it
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
            strip = this.schedContCal.GetScheduleHost().ContextMenuStrip;
            strip.Items.RemoveAt(4);
            ToolStripItem item = new ToolStripMenuItem("Delete Item", (Image)(ScheduleGrid.GetBitmap("Delete.png")), new EventHandler(deleteItemClick));
            strip.Items.Insert(4, item);
            this.schedContCal.Refresh();
        }
        #endregion



        #region Uploading Schedule File



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
            _inputParameter.Username = "PSS";
            _inputParameter.Password = "Fr35h5t@rt2021!";
            _inputParameter.Server = "ftp://flystudio.co.za";
            _inputParameter.FullName = FullPath;
            _inputParameter.FileName = "default.schedule";


        }
        #endregion


        #region Schedule SQL
        //Method used to pull the latest schedule file from FTP server and filestream it into database
        private void UpdateFileStream()
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblScheduleFile SET [FilePath] = (SELECT * FROM OPENROWSET(BULK 'C:\PremierServiceSolutions\Schedular\default.schedule',SINGLE_BLOB) AS Schedule) WHERE FileName = 'Calendar Schedule File'");
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


        //Method used to pull the latest file from the database in filestream and update schedule
        public void SelectDoc()
        {

            string qu = "SELECT FilePath FROM tblScheduleFile WHERE FileName = 'Calendar Schedule File'";
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
        #endregion


        #region Custom Tree View
        private void CustomizeDesign()
        {
            flpAssigned.Visible = false;
            flpProgress.Visible = false;
            flpUnassigned.Visible = false;
            flpNewTickets.Visible = false;
        }


        private void hideSubMenu()
        {
            if (flpUnassigned.Visible == true)
            {
                flpUnassigned.Visible = false;
            }
            if (flpProgress.Visible == true)
            {
                flpProgress.Visible = false;
            }
            if (flpAssigned.Visible == true)
            {
                flpAssigned.Visible = false;
            }
            if (flpNewTickets.Visible == true)
            {
                flpNewTickets.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        #region TreeView Click Events
        private void btnAssigned_Click(object sender, EventArgs e)
        {
            ResetButton(btnAssigned);
            showSubMenu(flpAssigned);
            
        }

        private void btnUnassigned_Click(object sender, EventArgs e)
        {
            ResetButton(btnUnassigned);
            showSubMenu(flpUnassigned);
        }

        private void btnProgressTickets_Click(object sender, EventArgs e)
        {
            ResetButton(btnProgressTickets);
            showSubMenu(flpProgress);
        }

        private void btnNewTickets_Click(object sender, EventArgs e)
        {
            ResetButton(btnNewTickets);
            showSubMenu(flpNewTickets);
        }

        private void ResetButton(Button btn)
        {
            
            if (btn.ForeColor == Color.White)
            {
                btn.ForeColor = Color.FromArgb(124, 204, 196);
                btn.BackColor = Color.White;
                
            }
            else
            {
                btnAssigned.BackColor = Color.White;
                btnNewTickets.BackColor = Color.White;
                btnProgressTickets.BackColor = Color.White;
                btnUnassigned.BackColor = Color.White;

                btnAssigned.ForeColor = Color.FromArgb(124, 204, 196);
                btnNewTickets.ForeColor = Color.FromArgb(124, 204, 196);
                btnProgressTickets.ForeColor = Color.FromArgb(124, 204, 196);
                btnUnassigned.ForeColor = Color.FromArgb(124, 204, 196);

                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(124, 204, 196);
            }
           
        }

        #endregion

        #region Background Worker
        private void bgwUploadFile_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = ((FtpSetting)e.Argument).FileName;
            string fullName = ((FtpSetting)e.Argument).FullName;
            string userName = ((FtpSetting)e.Argument).Username;
            string passWord = ((FtpSetting)e.Argument).Password;
            string server = ((FtpSetting)e.Argument).Server;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}/{2}", server, "Schedular", fileName)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(userName, passWord);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullName);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                if (!bgwUploadFile.CancellationPending)
                {
                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpStream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    bgwUploadFile.ReportProgress((int)percentage);
                }

            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();

        }

        private void bgwUploadFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbUploadProgress.Value = e.ProgressPercentage;
            pbUploadProgress.Update();
        }

        #endregion

        private void UpdateMonthFocus()
        {
            
            
            int monthDiff = ((SelectedDate.Year - this.schedContCal.Calendar.DateValue.Year) * 12) + SelectedDate.Month - this.schedContCal.Calendar.DateValue.Month;
            MessageBox.Show(Convert.ToString(monthDiff));
            if (monthDiff == 0)
            {
                this.schedContCal.Calendar.AdjustSelectionsByMonth(0);
                schedContCal.Calendar.DateValue = SelectedDate;
            }
            else if(monthDiff > 0)
            {
                this.schedContCal.Calendar.AdjustSelectionsByMonth(monthDiff );
                schedContCal.Calendar.DateValue = SelectedDate;
            }
            else if(monthDiff<0)
            {
                this.schedContCal.Calendar.AdjustSelectionsByMonth(monthDiff);
                schedContCal.Calendar.DateValue = SelectedDate;
            }
            this.schedContCal.ResetProvider(this.schedContCal.ScheduleType);
            var method = this.schedContCal.GetScheduleHost().GetType().GetMethod("SetCurrentCellInView", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (method != null)
            {
                this.schedContCal.GetScheduleHost().Model.ResetCurrentCellInfo();
                method.Invoke(this.schedContCal.GetScheduleHost(), new object[] { SelectedDate });
            }
        }

        private void CalendarGrid_Query(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {

            DateTime Day = SelectedDate;
            DateTime isDate;
            if(!string.IsNullOrEmpty(e.Style.CellValue.ToString()) && DateTime.TryParse(e.Style.CellValue.ToString(),out isDate)&& isDate == Day)
            {
                e.Style.BackColor = this.schedContCal.Appearance.NavigationCalendarTodayBackColor;
                e.Style.TextColor = this.schedContCal.Appearance.NavigationCalendarTodayTextColor;
            }
        }


    }
}
