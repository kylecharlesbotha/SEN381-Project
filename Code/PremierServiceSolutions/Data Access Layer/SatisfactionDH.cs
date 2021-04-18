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
    class SatisfactionDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateSatisfaction(Satisfaction objSat)
        {
            try
            {
                //Checking if the Satisfactions already exists
                int SatVal = FindSatisfaction(objSat);
                if (SatVal == 1)
                {
                    //If it finds a Satisfactions with same details return message saying Satisfactions already exists
                    MessageBox.Show("Satisfactions Already Exists");
                    return false;
                }
                else if (SatVal == 0)
                {
                    //If Satisfactions does not exist then check if the Employee Record exists
                    if (CheckAllTables(objSat) == true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblSatisfaction(SatisfactionID, SatisfactionStatus, TicketID) VALUES ('{0}','{1}','{2}')", objSat.SatisfactionID, objSat.SatisfactionStatus, objSat.TicketObject);
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
        private bool UpdateSatisfaction(Satisfaction newObjSat, Satisfaction oldObjSat)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblSatisfactions
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblSatisfaction SET SatisfactionID ='{0}',SatisfactionStatus ='{1}',TicketID ='{2}'", newObjSat.SatisfactionID, newObjSat.SatisfactionStatus, newObjSat.TicketObject);
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
                MessageBox.Show("Error has occured in updateing please try again");
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteSatisfaction(Satisfaction objSat)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblSatisfaction to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblSatisfaction SET SatisfactionID = 0 WHERE SatisfactionID ='{0}'", objSat.SatisfactionID);
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
        private List<Satisfaction> GetAllSatisfaction(Satisfaction objSat)
        {
            //List of type Satisfaction which will store all the records and then return that list
            List<Satisfaction> allSat = new List<Satisfaction>();

            try
            {
                //List of type Satisfaction which will store all the records and then return that list
                List<Satisfaction> allSatisfactions = new List<Satisfaction>();
                //New SQL Connection which the query will use to perform the Select of tblSatisfaction
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Satisfaction
                string SelectQuery = "SELECT * FROM tblSatisfaction";
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
                    allSatisfactions.Add(new Satisfaction((int)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1), (int)sqlDataReader.GetValue(2)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Satisfactions
                return allSatisfactions;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindSatisfaction(Satisfaction objSat)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblSatisfaction
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Satisfaction
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblSatisfaction WHERE SatisfactionID = '{0}' AND SatisfactionStatus = '{1}' AND TicketID = '{2}'", objSat.SatisfactionID, objSat.SatisfactionStatus, objSat.TicketObject);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Satisfaction
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
        private bool CheckAllTables(Satisfaction objSat)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblSatisfaction
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Satisfactions
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblTicket WHERE TicketID = '{0}'", objSat.TicketObject);
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
                //Return Count of Satisfaction
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

        private Satisfaction GetSatisfaction(Satisfaction objSat)
        {
            Satisfaction objRecord = new Satisfaction();
            try
            {
                //List of type Satisfaction which will store all the records and then return that list
                List<Satisfaction> allSatisfaction = new List<Satisfaction>();
                //New SQL Connection which the query will use to perform the Select of tblSatisfaction
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Satisfactions
                string SelectQuery = string.Format("SELECT * FROM tblSatisfaction WHERE SatisfactionID = '{0}'", objSat.SatisfactionID);
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
                    objRecord.SatisfactionID = (int)sqlDataReader.GetValue(0);
                    objRecord.SatisfactionStatus = (string)sqlDataReader.GetValue(1);
                    objRecord.TicketObject = (int)sqlDataReader.GetValue(2);
                    
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Satisfaction
                return objRecord;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }

        }
        }

}
