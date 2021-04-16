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
    class BusinessDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateBusiness(Business objBus)
        {
            try
            {
                //First Check if the record already exsists by calling  FindBusiness()
                //If found return false and display a message that it already exists else continue with creating
                
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateBusiness(Business newObjBus, Business oldObjBus)
        {
            try
            {
                //Update to new records where it matches the old BusinessID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteBusiness(Business objBus)
        {
            try
            {
                //Dont delete the record instead change the state of the record to 0 now as that will be inactive records
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }
        //Method used to Get all the records from the table in the database
        private List<Business> GetAllBusiness(Business objBus)
        {
            //List of type Business which will store all the records and then return that list
            List<Business> allBus = new List<Business>();

            try
            {
                //Return all records from table
                return allBus;
            }
            catch (SqlException SQLE)
            {
                return allBus;
            }
        }

        //Method used to find one record within the table
        private int FindBusiness(Business objBus)
        {
            //Get count of rows to see if object exists. Refer to TechnicianDH FindTechnician method
            try
            {
                
                return 1;
            }
            catch (SqlException SQLE)
            {
                return 0;
            }
        }

        private Business GetBusiness(Business objBus)
        {
            Business objRecord = new Business();
            try
            {
                //List of type Business which will store all the records and then return that list
                List<Business> allBusiness = new List<Business>();
                //New SQL Connection which the query will use to perform the Select of tblBusiness
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Business
                string SelectQuery = string.Format("SELECT * FROM tblBusiness WHERE BusinessID = '{0}'", objBus.BusinessID);
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
                    objRecord.BusinessID = (int)sqlDataReader.GetValue(0);
                    objRecord.BusinessAddress = (string)sqlDataReader.GetValue(1);
                    objRecord.BusinessName = (string)sqlDataReader.GetValue(2);
                    objRecord.BusinessPhone = (string)sqlDataReader.GetValue(3);
                    objRecord.BusinessRegistrationNumber = (int)sqlDataReader.GetValue(4);
                    objRecord.BusinessState = (string)sqlDataReader.GetValue(5);
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
