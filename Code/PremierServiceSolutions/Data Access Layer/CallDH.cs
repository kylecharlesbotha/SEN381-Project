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
    class CallDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateCall(Call objCall)
        {
            try
            {
                //Checking if the Call already exists
                int CallVal = FindCall(objCall);
                if (CallVal == 1)
                {
                    //If it finds a call with same details return message saying call already exists
                    MessageBox.Show("Call Already Exists");
                    return false;
                }
                else if (CallVal == 0)
                {
                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblCall (CallID,ClientID,EmployeeID,CallStartTime,CallEndTime,CallStatus,TicketID,CallRecording,CallState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                        objCall.CallID,
                        objCall.CallClient.PersonID,
                        objCall.CallEmployee.PersonID,
                        objCall.CallStartTime,
                        objCall.CallEndTime,
                        objCall.CallState,
                        objCall.CallTicket.TicketID,
                        objCall.CallRecording,
                        objCall.CallState
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
        private bool UpdateCall(Call newObjCall, Call oldObjCall)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblCall SET CallID ='{0}',ClientID ='{1}',EmployeeID ='{2}',CallStartTime ='{3}',CallEndTime ='{4}',CallStatus ='{4}',CallState ='{6}' WHERE CallID ='{0}'",
                       oldObjCall.CallID,
                       newObjCall.CallClient.PersonID,
                       newObjCall.CallEmployee.PersonID,
                       newObjCall.CallStartTime,
                       newObjCall.CallEndTime,
                       newObjCall.CallState,
                       newObjCall.CallTicket.TicketID,
                       newObjCall.CallRecording,
                       newObjCall.CallState

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
        }

        //Method used to Delete a record from the database
        private bool DeleteCall(Call objCall)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tbClient to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblCall SET CallState = 'Removed' WHERE CallID ='{0}'", objCall.CallID);
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
        private List<Call> GetAllCall(Call objCall)
        {
            //List of type Call which will store all the records and then return that list
            List<Call> allCall = new List<Call>();

            try
            {
                //List of type User which will store all the records and then return that list
                
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = "SELECT * FROM tblCall";
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

                    allCall.Add(new Call(
                                (int)sqlDataReader.GetValue(0),
                                (int)sqlDataReader.GetValue(1),
                                (int)sqlDataReader.GetValue(2),
                                (DateTime)sqlDataReader.GetValue(3),
                                (DateTime)sqlDataReader.GetValue(4),
                                (int)sqlDataReader.GetValue(5),
                                (string)sqlDataReader.GetValue(6),
                                (string)sqlDataReader.GetValue(7)          
                          ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allCall;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindCall(Call objCall)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTicket
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Tickets
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblCall WHERE CallID = '{0}'", objCall.CallID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Tickets
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
