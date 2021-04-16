using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //First Check if the record already exsists by calling  FindClient()
                //If found return false and display a message that it already exists else continue with creating

                return true;
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
                //Update to new records where it matches the old ClientID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteClient(Client objClient)
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
        private List<Client> GetAllClient(Client objClient)
        {
            //List of type Client which will store all the records and then return that list
            List<Client> allClient = new List<Client>();

            try
            {
                //Return all records from table
                return allClient;
            }
            catch (SqlException SQLE)
            {
                return allClient;
            }
        }

        //Method used to find one record within the table
        private int FindClient(Client objClient)
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


    }
}
