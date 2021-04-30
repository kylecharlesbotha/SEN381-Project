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
    class CallDH :  IRepositoryBase<Call>
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
       
        public bool Create(Call objCall)
        {
            try
            {
                //Checking if the Call already exists
                int CallVal = Find(objCall);
                if (CallVal == 1)
                {
                    //If it finds a call with same details return message saying call already exists
                    MessageBox.Show("Call Already Exists");
                    return false;
                }
                else if (CallVal == 0)
                {
                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblCall (ClientID,EmployeeID,CallStartTime,CallEndTime,CallStatus,TicketID,CallRecording,CallState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                        
                        objCall.ClientID,
                        objCall.EmployeeID,
                        objCall.CallStartTime,
                        objCall.CallEndTime,
                        objCall.Callstatus,
                        objCall.TicketID,
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
                MessageBox.Show(SQLE.Message);
                return false;
            }
            throw new NotImplementedException();
        }

        public bool Update(Call newObjCall, Call oldObjCall)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblCall SET ClientID ='{1}',EmployeeID ='{2}',CallStartTime ='{3}',CallEndTime ='{4}',CallStatus ='{5}',TicketID ='{6}',CallRecording ='{7}',CallState ='{8}' WHERE CallID ='{0}'",
                       oldObjCall.CallID,
                       newObjCall.ClientID,
                       newObjCall.EmployeeID,
                       newObjCall.CallStartTime,
                       newObjCall.CallEndTime,
                       newObjCall.Callstatus,
                       newObjCall.TicketID,
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
                MessageBox.Show(SQLE.Message);
                return false;
            }
            throw new NotImplementedException();
        }

        public bool Delete(Call objCall)
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
            throw new NotImplementedException();
        }

        public ICollection<Call> GetAll()
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
                                (string)sqlDataReader.GetValue(1),
                                (int)sqlDataReader.GetValue(2),
                                (DateTime)sqlDataReader.GetValue(3),
                                (DateTime)sqlDataReader.GetValue(4),
                                (string)sqlDataReader.GetValue(5),
                                (int)sqlDataReader.GetValue(6),
                                (string)sqlDataReader.GetValue(7),
                                (int)sqlDataReader.GetValue(8)
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
            throw new NotImplementedException();
        }

        public int Find(Call objCall)
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
            throw new NotImplementedException();
        }

        public int FindCurrent(int Emp, DateTime StartTime)
        {
            int RecordCount = 0;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTicket
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Tickets
                string SelectQuery = string.Format("SELECT * FROM tblCall WHERE EmployeeID = '{0}' AND CallStartTime = '{1}'", Emp, StartTime);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //SQL Datareader which will be used to pull specific fields from the Select Return statement
                SqlDataReader sqlDataReader;
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    RecordCount = (int)sqlDataReader.GetValue(0);
                }
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
            throw new NotImplementedException();
        }

        public bool CheckTables(Call entity)
        {
            throw new NotImplementedException();
        }

        public Call GetByID(Call entity)
        {
            throw new NotImplementedException();
        }
    }
}
