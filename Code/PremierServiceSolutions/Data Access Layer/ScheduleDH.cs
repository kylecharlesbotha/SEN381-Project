using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class ScheduleDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateSchedule(Schedule objSch)
        {
            try
            {
                int ScheduleVal = FindSchedule(objSch);
                if (ScheduleVal == 1)
                {
                    //If it finds a Schedule with same details return message saying Schedule already exists
                    MessageBox.Show("Schedule Already Exists");
                    return false;
                }
                else if (ScheduleVal == 0)
                {
                    //If Schedule does not exist
                    if (CheckAllTables(objSch) == true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblSchedule (ScheduleDate, ScheduleStartTime, ScheduleEndTime, ScheduleStatus, TicketID, ScheduleState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", objSch.ScheduleDate, objSch.ScheduleStartTime, objSch.ScheduleEndTime, objSch.ScheduleStatus, objSch.TicketID, objSch.ScheduleState);
                        SqlCommand InsertCommand = new SqlCommand(InsertQuery, sqlCon);
                        sqlCon.Open();
                        InsertCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        return true;

                    }
                }
                return false;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateSchedule(Schedule newObjSch, Schedule oldObjSch)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblSchedule SET ScheduleDate ='{0}',ScheduleStartTime ='{1}',ScheduleEndTime ='{2}',ScheduleStatus ='{3}' ,TicketID ='{4}' WHERE ScheduleID ='{5}'", newObjSch.ScheduleDate, newObjSch.ScheduleStartTime, newObjSch.ScheduleEndTime, newObjSch.ScheduleStatus, newObjSch.TicketID, oldObjSch.ScheduleID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Perform the Update Query
                UpdateCommand.ExecuteNonQuery();
                //Close the connection to the database
                sqlCon.Close();
                //If it all works it will then return true to indicate update successful
                return true;
            }
            catch (SqlException SQLE)
            {
                //If any error has to occur during the try phase it will display a Error message and will return false to indicate it was unsuccessful
                MessageBox.Show("Error has occured please try again");
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteSchedule(Schedule objSch)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblSchedule to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblSchedule SET ScheduleState = 0 WHERE ScheduleID ='{0}'", objSch.ScheduleID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Perform the Update Query
                UpdateCommand.ExecuteNonQuery();
                //Close the connection to the database
                sqlCon.Close();
                //If it all works it will then return true to indicate update successful
                return true;
            }
            catch (SqlException SQLE)
            {
                //If any error has to occur during the try phase it will display a Error message and will return false to indicate it was unsuccessful
                MessageBox.Show("Error has occured please try again");
                return false;
            }
        }
        //Method used to Get all the records from the table in the database
        private List<Schedule> GetAllSchedule(Schedule objSch)
        {
            try
            {
                //List of type Schedule which will store all the records and then return that list
                List<Schedule> allSch = new List<Schedule>();
                //New SQL Connection which the query will use to perform the Select of tblSchedule
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Schedules
                string SelectQuery = "SELECT * FROM tblSchedule";
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //SQL Datareader which will be used to pull specific fields from the Select Return statement
                SqlDataReader sqlDataReader;
                //Open the connection to the database
                sqlCon.Open();
                //
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    allSch.Add(new Schedule((int)sqlDataReader.GetValue(0), (DateTime)sqlDataReader.GetValue(1), (DateTime)sqlDataReader.GetValue(2), (DateTime)sqlDataReader.GetValue(3), (string)sqlDataReader.GetValue(4), (int)sqlDataReader.GetValue(5), (int)sqlDataReader.GetValue(6)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Schedules
                return allSch;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindSchedule(Schedule objSch)
        {
            //Get count of rows to see if object exists. Refer to ScheduleDH FindSchedule method
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblSchedule
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Schedules
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblSchedule WHERE ScheduleID = '{0}' AND ScheduleStatus = '{1}' AND TicketID = '{2}'", objSch.ScheduleID, objSch.ScheduleStatus, objSch.TicketID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Schedules
                return RecordCount;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                RecordCount = -1;
                return RecordCount;
            }
        }

        //Method which will be called to check that neccessary fields exist in the other tables which have relationships
        private bool CheckAllTables(Schedule objSch)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblSchedule
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Schedules
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblTicket WHERE TicketID = '{0}'", objSch.TicketID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //SQL Datareader which will be used to pull specific fields from the Select Return statement
                SqlDataReader sqlDataReader;
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Schedules
                if (RecordCount == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a false value
                MessageBox.Show("Error has occured");
                return false;
            }
        }
    }
}
