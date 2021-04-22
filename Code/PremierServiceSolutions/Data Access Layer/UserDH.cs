using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//CheckTables and GetByID not implemented
namespace PremierServiceSolutions.Data_Access_Layer
{
    class UserDH : IRepositoryBase<User>
    {
       
        DBHandler objHandler = new DBHandler();

        public bool Create(User objUser)
        {
            try
            {
                //Checking if the client already exists
                int UserVal = Find(objUser);
                if (UserVal == 1)
                {
                    //If it finds a client with same details return message saying Client already exists
                    MessageBox.Show("Client Already Exists");
                    return false;
                }
                else if (UserVal == 0)
                {
                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblUser  EmployeeID, UserAccessLevel, UserAuthToken, UserName, UserPassword, UserState) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                        objUser.EmployeeObject.PersonID,
                        objUser.UserAccessLevel,
                        objUser.UserAuthToken,
                        objUser.UserName,
                        objUser.UserPassword,
                        objUser.UserState

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

        public bool Update(User newObjUser, User oldObjUser)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblUser SET EmployeeID ='{1}',UserAccessLevel ='{2}',UserAuthToken ='{3}',UserName ='{4}',UserPassword ='{5}',UserState ='{6}' WHERE UserID ='{0}'",
                    oldObjUser.UserID,
                    newObjUser.EmployeeID,
                    newObjUser.UserAccessLevel,
                    newObjUser.UserAuthToken,
                    newObjUser.UserName,
                    newObjUser.UserPassword,
                    newObjUser.UserState);

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

        public bool Delete(User objUser)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tbClient to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblUser SET UserState = 'Removed' WHERE UserID ='{0}'", objUser.UserID);
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

        public ICollection<User> GetAll()
        {
            try
            {
                //List of type User which will store all the records and then return that list
                List<User> allUsers = new List<User>();
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = "SELECT * FROM tblUser";
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
                    allUsers.Add(new User(
                                (int)sqlDataReader.GetValue(0),
                                (int)sqlDataReader.GetValue(1),
                                (string)sqlDataReader.GetValue(2),
                                (string)sqlDataReader.GetValue(3),
                                (string)sqlDataReader.GetValue(4),
                                (string)sqlDataReader.GetValue(5),
                                (string)sqlDataReader.GetValue(6),
                                (string)sqlDataReader.GetValue(7)

                                ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allUsers;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public int Find(User objUser)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblUser WHERE UserID = '{0}'", objUser.UserID);
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

        public bool CheckTables(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetByID(User entity)
        {
            throw new NotImplementedException();
        }
        public User GetByUserName(string entity)
        {
            throw new NotImplementedException();
        }
    }
}
