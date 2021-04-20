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
    class ClientDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateClient(Client objClient)
        {
            try
            {
                //Checking if the client already exists
                int ClientVal = FindClient(objClient);
                if (ClientVal == 1)
                {
                    //If it finds a client with same details return message saying Client already exists
                    MessageBox.Show("Client Already Exists");
                    return false;
                }
                else if (ClientVal == 0)
                {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblClient (ClientIDNumber, ClientName, ClientSurname, ClientTitle, ClientGender, ClientAddress, ClientCell, ClientCreationDate, ClientEmail, ClientPriority, ClientState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", 
                            objClient.ClientIdNumber, 
                            objClient.PersonName, 
                            objClient.PersonSurname, 
                            objClient.ClientTitle, 
                            objClient.ClientGender, 
                            objClient.ClientAddress, 
                            objClient.ClientCell, 
                            objClient.ClientCreationDate, 
                            objClient.ClientEmail, 
                            objClient.ClientPriority, 
                            objClient.ClientState
                            
                            );
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
        private bool UpdateClient(Client newObjClient, Client oldObjClient)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblClient SET ClientIDNumber ='{0}',ClientName ='{1}',ClientSurname ='{2}',ClientTitle ='{3}',ClientTitle ='{4}',ClientGender ='{5}',ClientAddress ='{6}',ClientCell ='{7}',ClientEmail ='{8}',ClientPriority ='{9}' WHERE ClientID ='{10}'", 
                    newObjClient.ClientIdNumber, 
                    newObjClient.PersonName, 
                    newObjClient.PersonSurname, 
                    newObjClient.ClientTitle, 
                    newObjClient.ClientGender, 
                    newObjClient.ClientAddress, 
                    newObjClient.ClientCell, 
                    newObjClient.ClientEmail, 
                    newObjClient.ClientPriority, 
                    oldObjClient.PersonID);
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
        private bool DeleteClient(Client objClient)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tbClient to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblClient SET ClientState = 0 WHERE ClientID ='{0}'", objClient.PersonID);
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
        private List<Client> GetAllClient(Client objClient)
        {
            try
            {
                //List of type Client which will store all the records and then return that list
                List<Client> allClients = new List<Client>();
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = "SELECT * FROM tblClient";
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
                    allClients.Add(new Client(
                                (string)sqlDataReader.GetValue(0), 
                                (string)sqlDataReader.GetValue(1), 
                                (string)sqlDataReader.GetValue(2),
                                (string)sqlDataReader.GetValue(3),
                                (string)sqlDataReader.GetValue(4),
                                (string)sqlDataReader.GetValue(5),
                                (string)sqlDataReader.GetValue(6), 
                                (DateTime)sqlDataReader.GetValue(7), 
                                (string)sqlDataReader.GetValue(8) 
                                ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allClients;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindClient(Client objClient)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblClient WHERE ClientIDNumber = '{0}' AND ClientName = '{1}' AND ClientSurname = '{2}''", objClient.ClientIdNumber, objClient.PersonName, objClient.PersonSurname);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Clients
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

        private Client GetClient(Client objClient)
        {
            Client objRecord = new Client();
            try
            {
                //List of type Technician which will store all the records and then return that list
                List<Technician> allTechnicians = new List<Technician>();
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT * FROM tblClient WHERE ClientID = '{0}'", objClient.PersonID);
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
                    objRecord.ClientIdNumber = (string)sqlDataReader.GetValue(0);
                    objRecord.PersonID = (int)sqlDataReader.GetValue(1);
                    objRecord.PersonName = (string)sqlDataReader.GetValue(2);
                    objRecord.PersonSurname = (string)sqlDataReader.GetValue(3);
                    objRecord.ClientTitle = (string)sqlDataReader.GetValue(4);
                    objRecord.ClientGender = (string)sqlDataReader.GetValue(5);
                    objRecord.ClientAddress = (string)sqlDataReader.GetValue(6);
                    objRecord.ClientCell = (string)sqlDataReader.GetValue(7);
                    objRecord.ClientCreationDate = (DateTime)sqlDataReader.GetValue(8);
                    objRecord.ClientEmail = (string)sqlDataReader.GetValue(9);
                    objRecord.ClientPriority = (string)sqlDataReader.GetValue(10);
                    objRecord.ClientState = (string)sqlDataReader.GetValue(11);

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
