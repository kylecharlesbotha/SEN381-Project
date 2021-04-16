using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class BusinessContactDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateBusinessContact(BusinessContact objBusCon)
        {
            try 
            {
                //First Check if the record already exsists by calling  FindBusinessContact()
                //If found return false and display a message that it already exists else continue with creating
                //Then you will need to check if the Client Record Exists and also if the Business Record Exists. Call CheckAllTables() as that will check all the tables it needs to
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
            
        }

        //Method which will be used to Update current record within Database
        private bool UpdateBusinessContact(BusinessContact newObjBusCon, BusinessContact oldObjBusCon)
        {
            try
            {
                //Update to new records where it matches the old BusinessID and ClientID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteBusinessContact(BusinessContact objBusCon)
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
        private List<BusinessContact> GetAllBusinessContact(BusinessContact objBusCon)
        {
            //List of type BusinessContact which will store all the records and then return that list
            List<BusinessContact> allBusCon = new List<BusinessContact>();
            
            try
            {
                //Return all records from table
                return allBusCon;
            }
            catch(SqlException SQLE)
            {
                return allBusCon;
            }
        }

        //Method used to find one record within the table
        private int FindBusinessContact(BusinessContact objBusCon)
        {
            //Get count of rows to see if object exists. Refer to TechnicianDH FindTechnician method
            try
            {
                return 0;
            }
            catch (SqlException SQLE)
            {
                return 0;
            }
        }

        //Method which will be called to check that neccessary fields exist in the other tables which have relationships
        private bool CheckAllTables(BusinessContact objBusCon)
        {
            try
            {
                //Check if it exists in tblClient first then if it does continue with checking tblBusiness.
                //If it is not found in tblClient then return false. If it is found within tblBusiness return true else return false
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }
    }
}
