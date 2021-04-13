using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Business FindBusiness(Business objBus)
        {
            //Object of type Business which will store single record of object to be returned to interface
            Business objRecord = new Business();
            try
            {
                //Find record matching to obj and return it in objRecord
                return objRecord;
            }
            catch (SqlException SQLE)
            {
                return objRecord;
            }
        }


    }
}
