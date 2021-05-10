using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class TechnicianDH : IRepositoryBase<Technician>
    {
       
        DBHandler objHandler = new DBHandler();

        

        public bool Create(Technician objTech)
        {
            try
            {
                //Checking if the technician already exists
                int TechVal = Find(objTech);
                if (TechVal == 1)
                {
                    //If it finds a technicain with same details return message saying Technicain already exists
                    MessageBox.Show("Technician Already Exists");
                    return false;
                }
                else if (TechVal == 0)
                {
                    //If Technician does not exist then check if the Employee Record exists
                    if (CheckTables(objTech) == true)
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

        public bool Update(Technician newObjTech, Technician oldObjTech)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTechnician SET TechnicianLevel ='{0}',TechnicianStatus ='{1}',EmployeeID ='{2}',TechnicianState ='{3}' WHERE TechnicianID ='{4}'", newObjTech.TechnicianLevel, newObjTech.TechnicianStatus, newObjTech.EmployeeID, newObjTech.TechnicianState, oldObjTech.TechnicianID);
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

        public bool Delete(Technician objTech)
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

        public ICollection<Technician> GetAll()
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

        public ICollection<Technician> GetTechnicianName()
        {
            try
            {
                //List of type Technician which will store all the records and then return that list
                List<Technician> allTechnicians = new List<Technician>();
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = "SELECT TEC.TechnicianID, EMP.EmployeeName FROM  tblTechnician AS TEC INNER JOIN tblEmployee AS EMP ON  EMP.EmployeeID = TEC.EmployeeID";
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
                    allTechnicians.Add(new Technician((int)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Technicians
                return allTechnicians.ToList();
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }
       
        public int Find(Technician objTech)
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

        public bool CheckTables(Technician objTech)
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
        public string GetTechName(Technician objTech)
        {
            string techName = null; 
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT EMP.EmployeeName FROM  tblTechnician AS TEC INNER JOIN tblEmployee AS EMP ON  EMP.EmployeeID = TEC.EmployeeID WHERE technicianID = {0}", objTech.TechnicianID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                var reader = sqlCommand.ExecuteReader();
                int techNameInt = reader.GetOrdinal("EmployeeName");
                if (!reader.Read())
                    throw new InvalidOperationException("No records were returned.");
                techName = reader.GetString(techNameInt);
                if (reader.Read())
                    throw new InvalidOperationException("Multiple records were returned.");
                //Close connection to database
                sqlCon.Close();
                //Return Count of Technicians
                return techName;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                 
                return techName;
            }
        }
        public Technician GetByID(Technician objTech)
        {
            Technician objRecord = new Technician();
            try
            {

                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT * FROM tblTechnician WHERE TechnicianID = '{0}'", objTech.TechnicianID);
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

        public Technician GetCurrentTec(string Username)
        {
            Technician objRecord = new Technician();
            try
            {

                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT U.UserName, U.EmployeeID,T.TechnicianID FROM tblUser AS U INNER JOIN tblTechnician as T on T.EmployeeID = U.EmployeeID");
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
                    objRecord.TechNameList = (string)sqlDataReader.GetValue(0);
                    objRecord.EmployeeID = (int)sqlDataReader.GetValue(1);
                    objRecord.TechnicianID = (int)sqlDataReader.GetValue(2);

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
