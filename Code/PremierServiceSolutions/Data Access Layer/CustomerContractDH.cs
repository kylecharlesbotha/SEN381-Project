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
    class CustomerContractDH :IRepositoryBase<CustomerContract>
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        

        private CustomerContract GetCusCon(CustomerContract objCusCon)
        {
            CustomerContract objRecord = new CustomerContract();
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblCustomerContracct
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the CustomerContract
                string SelectQuery = string.Format("SELECT * FROM tblCustomerContract WHERE CustomerContractID = '{0}'", objCusCon.CustomerContractID);
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
                    objRecord.CustomerContractID = (int)sqlDataReader.GetValue(0);
                    objRecord.BusinessID = (int)sqlDataReader.GetValue(1);
                    objRecord.ClientID = (int)sqlDataReader.GetValue(2);
                    objRecord.ContractID = (int)sqlDataReader.GetValue(3);
                    objRecord.CustomerContractStatus = (string)sqlDataReader.GetValue(4);
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

        public bool Create(CustomerContract objCusCon)
        {
            try
            {
                //Checking if the CustomerContract already exists
                int CusConVal = Find(objCusCon);
                if (CusConVal == 1)
                {
                    //If it finds a CustomerContract with same details return message saying CustomerContract already exists
                    MessageBox.Show("CustomerContract Already Exists");
                    return false;
                }
                else if (CusConVal == 0)
                {
                    //If CustomerContract does not exist then check if the Employee Record exists
                    if (CheckTables(objCusCon) == true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblCustomerContract (BusinessID, ClientID, ContractID, CustomerContractStatus, StartDate, EndDate, CustomerState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            objCusCon.BusinessID,
                            objCusCon.ClientID,
                            objCusCon.ContractID,
                            objCusCon.CustomerContractStatus,
                            objCusCon.StartDate,
                            objCusCon.EndDate,
                            objCusCon.CustomerState
                            );
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
            throw new NotImplementedException();
        }

        public bool Update(CustomerContract oldObjCusCon, CustomerContract newObjCusCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTechnician SET BusinessID ='{0}',ClientID ='{1}',ContractID ='{2}',CustomerContractStatus ='{3}',StartDate ='{4}',EndDate ='{4}',CustomerState ='{6}' WHERE CustomerContractID ='{7}'",
                    newObjCusCon.BusinessID,
                    newObjCusCon.ClientID,
                    newObjCusCon.ContractID,
                    newObjCusCon.CustomerContractStatus,
                    newObjCusCon.StartDate,
                    newObjCusCon.EndDate,
                    oldObjCusCon.EndDate
                    );
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
            throw new NotImplementedException();
        }

        public bool Delete(CustomerContract objCusCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblCustomerContract SET CustomerState = 0 WHERE CustomerContractID ='{0}'", objCusCon.CustomerContractID);
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
            throw new NotImplementedException();
        }

        public ICollection<CustomerContract> GetAll()
        {
            try
            {
                //List of type CustomerContract which will store all the records and then return that list
                List<CustomerContract> allCusContracts = new List<CustomerContract>();
                //New SQL Connection which the query will use to perform the Select of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the CustomerContracts
                string SelectQuery = "SELECT * FROM tblCustomerConntract";
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
                    allCusContracts.Add(new CustomerContract(
                        (int)sqlDataReader.GetValue(0),
                        (int)sqlDataReader.GetValue(1),
                        (int)sqlDataReader.GetValue(2),
                        (int)sqlDataReader.GetValue(3),
                        (string)sqlDataReader.GetValue(5),
                        (DateTime)sqlDataReader.GetValue(6),
                        (DateTime)sqlDataReader.GetValue(7),
                        (int)sqlDataReader.GetValue(8)
                        ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of CustomerContracts
                return allCusContracts;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
            throw new NotImplementedException();
        }

        public int Find(CustomerContract objCusCon)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the CustomerContract
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblCustomerContract WHERE BusinessID = '{0}' AND ClientID = '{1}' AND ContractID = '{2}' AND CustomerContractStatus = '{3}'",
                    objCusCon.BusinessID,
                    objCusCon.ClientID,
                    objCusCon.ContractID,
                    objCusCon.CustomerContractStatus
                    );
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
            throw new NotImplementedException();
        }

        public bool CheckTables(CustomerContract objCusCon)
        {
            int ClientCount;
            int ContractCount;
            int BusinessCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblClient WHERE ClientID = '{0}'", objCusCon.ClientID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                ClientCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Clients
                if (ClientCount == 1)
                {
                    //New SQL Connection which the query will use to perform the Select of tblBusiness
                    sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    //Select Query which will store the SQL qeury needed to return all the Business's
                    SelectQuery = string.Format("SELECT COUNT(*) FROM tblBusinesss WHERE BusinessID = '{0}'", objCusCon.BusinessID);
                    //New Command which will take in the sqlCon and UpdateQuery var
                    sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                    //Open the connection to the database
                    sqlCon.Open();
                    //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                    BusinessCount = (Int32)sqlCommand.ExecuteScalar();
                    //Close connection to database
                    sqlCon.Close();
                    //Return Count of Business's
                    if (BusinessCount == 1)
                    {
                        //New SQL Connection which the query will use to perform the Select of tblContract
                        sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        //Select Query which will store the SQL qeury needed to return all the Contracts
                        SelectQuery = string.Format("SELECT COUNT(*) FROM tblContract WHERE ContractID = '{0}'", objCusCon.ContractID);
                        //New Command which will take in the sqlCon and UpdateQuery var
                        sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                        //Open the connection to the database
                        sqlCon.Open();
                        //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                        ContractCount = (Int32)sqlCommand.ExecuteScalar();
                        //Close connection to database
                        sqlCon.Close();
                        //Return Count of Contracts
                        if (ContractCount == 1)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Contract not found. Please Try again");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Business not found. Please Try again");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Client not found. Please Try again");
                    return false;
                }
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a false value
                MessageBox.Show("Error has occured");
                return false;
            }
            throw new NotImplementedException();
        }

        public CustomerContract GetByID(CustomerContract entity)
        {
            throw new NotImplementedException();
        }
    }
    }

