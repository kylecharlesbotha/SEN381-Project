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
    class BusinessDH : IRepositoryBase<Business>
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

       

        public bool Create(Business objBus)
        {
            try
            {
                //Checking if the Business already exists
                int BusVal = Find(objBus);
                if (BusVal == 1)
                {
                    //If it finds a Business with same details return message saying Business already exists
                    MessageBox.Show("Business Already Exists");
                    return false;
                }
                else if (BusVal == 0)
                {
                    //If Business does not exist then insert

                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblBusiness (BusinessAddress, BusinessName, BusinessPhone, BusinessRegistrationNumber, BusinessState) VALUES ('{0}','{1}','{2}','{3}','{4}')", objBus.BusinessAddress, objBus.BusinessName, objBus.BusinessPhone, objBus.BusinessRegistrationNumber, objBus.BusinessState);
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
            throw new NotImplementedException();
        }

        public bool Update(Business oldObjBus, Business newObjBus)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblBusiness
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblBusiness SET BusinessAddress ='{0}',BusinessName ='{1}',BusinessPhone ='{2}',BusinessRegistrationNumber ='{3}',BusinessState ='{4}' WHERE BusinessID ='{5}'", newObjBus.BusinessAddress, newObjBus.BusinessName, newObjBus.BusinessPhone, newObjBus.BusinessRegistrationNumber, newObjBus.BusinessState, oldObjBus.BusinessID);
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

        public bool Delete(Business objBus)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblBusiness to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblBusiness SET BusinessState = 0 WHERE BusinessID ='{0}'", objBus.BusinessID);
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

        public ICollection<Business> GetAll()
        {
            try
            {
                //List of type Business which will store all the records and then return that list
                List<Business> allBus = new List<Business>();
                //New SQL Connection which the query will use to perform the Select of tblBusiness
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Business
                string SelectQuery = "SELECT * FROM tblBusiness";
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
                    allBus.Add(new Business((int)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1), (string)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3), (int)sqlDataReader.GetValue(4), (string)sqlDataReader.GetValue(5)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Business
                return allBus;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
            throw new NotImplementedException();
        }

        public int Find(Business objBus)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblBusiness
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Business
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblBusiness WHERE BusinessAddress = '{0}' AND BusinessName = '{1}' AND BusinessPhone = '{2}' AND BusinessRegistrationNumber = '{3}' AND BusinessState = '{4}'", objBus.BusinessAddress, objBus.BusinessName, objBus.BusinessPhone, objBus.BusinessRegistrationNumber, objBus.BusinessState);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Business
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

        public bool CheckTables(Business objBus)
        {
            
            throw new NotImplementedException();
        }

        public Business GetByID(Business entity)
        {
            throw new NotImplementedException();
        }

        //public Business GetByID(Business objBusCon)
        //{
        //    Business objRecord = new Business();
        //    try
        //    {
        //        //List of type BusinessContact which will store all the records and then return that list
        //        List<Business> allBusiness = new List<Business>();
        //        //New SQL Connection which the query will use to perform the Select of tblBusinessContact
        //        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
        //        //Select Query which will store the SQL qeury needed to return all the BusinessContact
        //        string SelectQuery = string.Format("SELECT * FROM tblBusiness WHERE BusinessID = '{0}'", objBusCon.BusinessID);
        //        //New Command which will take in the sqlCon and UpdateQuery var
        //        SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
        //        //SQL Datareader which will be used to pull specific fields from the Select Return statement
        //        SqlDataReader sqlDataReader;
        //        //Open the connection to the database
        //        sqlCon.Open();
        //        //
        //        sqlDataReader = sqlCommand.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            objRecord.BusinessID = (int)sqlDataReader.GetValue(0);
        //            objRecord.BusinessAddress = (int)sqlDataReader.GetValue(1);
        //            objRecord. = (string)sqlDataReader.GetValue(2);
        //            objRecord.ContactState = (string)sqlDataReader.GetValue(3);
        //        }
        //        //Close connection to database
        //        sqlCon.Close();
        //        //Return List of BusinessContact
        //        return objRecord;
        //    }
        //    catch (SqlException SQLE)
        //    {
        //        //Will catch any errors that occur and will display a error message. it will also return a empty list
        //        MessageBox.Show("Error has occured");
        //        return null;
        //    }
        //    throw new NotImplementedException();
        //}
    }
}
