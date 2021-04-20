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
    class ContractDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateContract(Contract objCon)
        {
            try
            {
                //Checking if the Contract already exists
                int ConVal = FindContract(objCon);
                if (ConVal == 1)
                {
                    //If it finds a Contract with same details return message saying Contract already exists
                    MessageBox.Show("Contract Already Exists");
                    return false;
                }
                else if (ConVal == 0)
                {
                    //If Contract does not exist then insert

                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblContract (ContractDescription, ContractType, ContractState) VALUES ('{0}','{1}','{2}')", objCon.ContractDescription, objCon.ContractType, objCon.ContractState);
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
        private bool UpdateContract(Contract newObjCon, Contract oldObjCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblContract SET ContractDescription ='{0}',ContractType ='{1}',ContractState ='{2}' WHERE ContractID ='{3}'", newObjCon.ContractDescription, newObjCon.ContractType, newObjCon.ContractState, oldObjCon.ContractID);
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
        private bool DeleteContract(Contract objCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblContract to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblContract SET ContractState = 0 WHERE ContractID ='{0}'", objCon.ContractID);
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
        private List<Contract> GetAllContract(Contract objCon)
        {
            try
            {
                //List of type Contract which will store all the records and then return that list
                List<Contract> allCon = new List<Contract>();
                //New SQL Connection which the query will use to perform the Select of tblContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Contract
                string SelectQuery = "SELECT * FROM tblContract";
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
                    allCon.Add(new Contract((int)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1), (string)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Contract
                return allCon;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindContract(Contract objCon)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Contract
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblContract WHERE ContractDescription = '{0}' AND ContractType = '{1}' AND ContractState = '{2}'", objCon.ContractDescription, objCon.ContractType, objCon.ContractState);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Contract
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

        private Contract GetContract(Contract objCon)
        {
            Contract objRecord = new Contract();
            try
            {
                //List of type Contract which will store all the records and then return that list
                List<Contract> allContract = new List<Contract>();
                //New SQL Connection which the query will use to perform the Select of tblContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Contract
                string SelectQuery = string.Format("SELECT * FROM tblContract WHERE ContractID = '{0}'", objCon.ContractID);
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
                    objRecord.ContractID = (int)sqlDataReader.GetValue(0);
                    objRecord.ContractDescription = (string)sqlDataReader.GetValue(1);
                    objRecord.ContractType = (string)sqlDataReader.GetValue(2);
                    objRecord.ContractState = (string)sqlDataReader.GetValue(3);
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Contract
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
