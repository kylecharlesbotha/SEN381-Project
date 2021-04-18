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
    class ServiceDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateService(Service objSer)
        {
            try
            {
                //Checking if the Service already exists
                int ServiceVal = FindService(objSer);
                if (ServiceVal == 1)
                {
                    //If it finds a Service with same details return message saying Service already exists
                    MessageBox.Show("Service Already Exists");
                    return false;
                }
                else if (ServiceVal == 0)
                {
                    //Service does not exist
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblService (ServiceDescription, ServiceLevel, ServiceName, ServiceState) VALUES ('{0}','{1}','{2}','{3}')", objSer.ServiceDescription, objSer.ServiceLevel, objSer.ServiceName, objSer.ServiceState);
                        SqlCommand InsertCommand = new SqlCommand(InsertQuery, sqlCon);
                        sqlCon.Open();
                        InsertCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        return true;
                }
                return false;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateService(Service newObjSer, Service oldObjSer)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblService
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblService SET ServiceDescription ='{0}',ServiceLevel ='{1}',ServiceName ='{2}',ServiceState ='{3}' WHERE ServiceID ='{4}'", newObjSer.ServiceDescription, newObjSer.ServiceLevel, newObjSer.ServiceName, newObjSer.ServiceState, oldObjSer.ServiceID);
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
        private bool DeleteService(Service objSer)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblService to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblService SET ServiceState = 0 WHERE ServiceID ='{0}'", objSer.ServiceID);
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
        private List<Service> GetAllService(Service objSer)
        {
            try
            {
                //List of type Services which will store all the records and then return that list
                List<Service> allService = new List<Service>();
                //New SQL Connection which the query will use to perform the Select of tblService
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Services
                string SelectQuery = "SELECT * FROM tblService";
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
                    allService.Add(new Service((int)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1), (int)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3), (int)sqlDataReader.GetValue(4)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Services
                return allService;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindService(Service objSer)
        {
            //Get count of rows to see if object exists. Refer to ServiceDH FindService method
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblService
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Services
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblService WHERE ServiceLevel = '{0}' AND ServiceName = '{1}' AND ServiceState = '{2}'", objSer.ServiceLevel, objSer.ServiceName, objSer.ServiceState);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Services
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
    }
}
