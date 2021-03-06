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
    class BusinessContactDH : IRepositoryBase<BusinessContact>
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();
        

        public bool Create(BusinessContact objBusCon)
        {
            try
            {
                //Checking if the BusinessContact already exists
                int BusConVal = Find(objBusCon);
                if (BusConVal == 1)
                {
                    //If it finds a BusinessContact with same details return message saying BusinessContact already exists
                    MessageBox.Show("BusinessContact Already Exists");
                    return false;
                }
                else if (BusConVal == 0)
                {
                    //If Business does not exist then check if the Client Record exists
                    if (CheckTables(objBusCon) == true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblBusinessContact (BusinessID, ClientID, ContactJobTitle, ContactState) VALUES ('{0}','{1}','{2}','{3}')", objBusCon.ContactBusinessID, objBusCon.ContactClientID, objBusCon.ContactJobTitle, objBusCon.ContactState);
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

        public bool Update(BusinessContact oldObjBusCon, BusinessContact newObjBusCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblBusinessContact SET ContactJobTitle ='{0}',ContactState ='{1}' WHERE BusinessID ='{2}' AND ClientID ='{3}", newObjBusCon.ContactJobTitle, newObjBusCon.ContactState, oldObjBusCon.ContactBusinessID, oldObjBusCon.ContactClientID);
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

        public bool Delete(BusinessContact objBusCon)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblbusinessContact to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblBusinessContact SET ContactState = 0 WHERE BusinessID ='{0}' AND ClientID = '{1}'", objBusCon.ContactBusinessID, objBusCon.ContactClientID);
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

        public ICollection<BusinessContact> GetAll()
        {
            try
            {
                //List of type BusinessContact which will store all the records and then return that list
                List<BusinessContact> allBusinessContacts = new List<BusinessContact>();
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                string SelectQuery = "SELECT * FROM tblBusinessContact";
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
                    allBusinessContacts.Add(new BusinessContact((int)sqlDataReader.GetValue(0), (int)sqlDataReader.GetValue(1), (string)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of BusinessContacts
                return allBusinessContacts;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
            throw new NotImplementedException();
        }

        public int Find(BusinessContact objBusCon)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblBusinessContact WHERE BusinessID = '{0}' AND ClientID = '{1}' ", objBusCon.ContactBusinessID, objBusCon.ContactClientID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of BusinessContacts
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

        public bool CheckTables(BusinessContact objBusCon)
        {
            int ClientCount;
            int BusinessCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblClient WHERE ClientID = '{0}'", objBusCon.ContactClientID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                ClientCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of BusinessContacts
                if (ClientCount == 1)
                {
                    //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                    sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                    SelectQuery = string.Format("SELECT COUNT(*) FROM tblBusiness WHERE BusinessID = '{0}'", objBusCon.ContactBusinessID);
                    //New Command which will take in the sqlCon and UpdateQuery var
                    sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                    //Open the connection to the database
                    sqlCon.Open();
                    //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                    BusinessCount = (Int32)sqlCommand.ExecuteScalar();
                    //Close connection to database
                    sqlCon.Close();
                    //Return Count of BusinessContacts
                    if (BusinessCount == 1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Business not found!.Please try again");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Client not found!.Please try again");
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

        public BusinessContact GetByID(BusinessContact objBusCon)
        {
            BusinessContact objRecord = new BusinessContact();
            try
            {
                //List of type BusinessContact which will store all the records and then return that list
                List<BusinessContact> allBusinessContacts = new List<BusinessContact>();
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContact
                string SelectQuery = string.Format("SELECT * FROM tblBusinessContact WHERE BusinessID = '{0}' AND ClientID = '{1}'", objBusCon.ContactBusinessID, objBusCon.ContactClientID);
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
                    objRecord.ContactBusinessID = (int)sqlDataReader.GetValue(0);
                    objRecord.ContactClientID = (int)sqlDataReader.GetValue(1);
                    objRecord.ContactJobTitle = (string)sqlDataReader.GetValue(2);
                    objRecord.ContactState = (string)sqlDataReader.GetValue(3);
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of BusinessContact
                return objRecord;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
            throw new NotImplementedException();
        }
    }
}
