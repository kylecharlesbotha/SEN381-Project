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
    class TechnicianDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateTechnician(Technician objTech)
        {
            try
            {
                //Checking if the technician already exists
                int TechVal = FindTechnician(objTech);
                if(TechVal==1)
                {
                    //If it finds a technicain with same details return message saying Technicain already exists
                    MessageBox.Show("Technician Already Exists");
                    return false;
                }
                else if(TechVal==0)
                {
                    //If Technician does not exist then check if the Employee Record exists
                    if(CheckAllTables(objTech)== true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblTechnician (TechnicianLevel, TechnicianStatus, EmployeeID, TechnicianState) VALUES ('{0}','{1}','{2}','{3}')", objTech.TechnicianLevel, objTech.TechnicianStatus, objTech.EmployeeID, objTech.TechnicianState);
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
        private bool UpdateTechnician(Technician newObjTech, Technician oldObjTech)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTechnician SET TechnicianLevel ='{0}',TechnicianStatus ='{1}',EmployeeID ='{2}',TechnicianState ='{3}' WHERE TechnicianID ='{4}'", newObjTech.TechnicianLevel,newObjTech.TechnicianStatus,newObjTech.EmployeeID,newObjTech.TechnicianState, oldObjTech.TechnicianID);
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
        private bool DeleteTechnician(Technician objTech)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTechnician to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTechnician SET TechnicianState = 0 WHERE TechnicianID ='{0}'", objTech.TechnicianID);
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
        private List<Technician> GetAllTechnician(Technician objTech)
        {        
            try
            {
                //List of type Technician which will store all the records and then return that list
                List<Technician> allTechnicians = new List<Technician>();
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = "SELECT * FROM tblTechnician";
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
                    allTechnicians.Add(new Technician((int)sqlDataReader.GetValue(0), (int)sqlDataReader.GetValue(1), (string)sqlDataReader.GetValue(2), (int)sqlDataReader.GetValue(3), (int)sqlDataReader.GetValue(4)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Technicians
                return allTechnicians;                
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the tablea
        private int FindTechnician(Technician objTech)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblTechnician WHERE TechnicianLevel = '{0}' AND TechnicianStatus = '{1}' AND EmployeeID = '{2}' AND TechnicianState = '{3}'", objTech.TechnicianLevel, objTech.TechnicianStatus, objTech.EmployeeID, objTech.TechnicianState);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Technicians
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
        private bool CheckAllTables(Technician objTech)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblEmployee WHERE EmployeeID = '{0}'", objTech.EmployeeID);
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
                //Return Count of Technicians
                if(RecordCount == 1)
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

        private Technician GetTechnician(Technician objTech)
        {
            Technician objRecord = new Technician();
            try
            {
                //List of type Technician which will store all the records and then return that list
                List<Technician> allTechnicians = new List<Technician>();
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery =string.Format("SELECT * FROM tblTechnician WHERE TechnicianID = '{0}'",objTech.TechnicianID);
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
                    objRecord.TechnicianID = (int)sqlDataReader.GetValue(0);
                    objRecord.TechnicianLevel = (int)sqlDataReader.GetValue(1);
                    objRecord.TechnicianStatus = (string)sqlDataReader.GetValue(2);
                    objRecord.EmployeeID = (int)sqlDataReader.GetValue(3);
                    objRecord.TechnicianState = (int)sqlDataReader.GetValue(4);
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Technicians
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
