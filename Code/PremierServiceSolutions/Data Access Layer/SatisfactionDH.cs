using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class SatisfactionDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateSatisfaction(Satisfaction objSat)
        {
            try
            {
                //First Check if the record already exsists by calling  FindSatisfaction()
                //If found return false and display a message that it already exists else continue with creating
                //Then you will need to check if the Ticket Record Exists. Call CheckAllTables() as that will check all the tables it needs to
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateSatisfaction(Satisfaction newObjSat, Satisfaction oldObjSat)
        {
            try
            {
                //Update to new records where it matches the old SatisfactionID and TicketID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteSatisfaction(Satisfaction objSat)
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
        private List<Satisfaction> GetAllSatisfaction(Satisfaction objSat)
        {
            //List of type Satisfaction which will store all the records and then return that list
            List<Satisfaction> allSat = new List<Satisfaction>();

            try
            {
                //Return all records from table
                return allSat;
            }
            catch (SqlException SQLE)
            {
                return allSat;
            }
        }

        //Method used to find one record within the table
        private Satisfaction FindSatisfaction(Satisfaction objSat)
        {
            //Object of type Satisfaction which will store single record of object to be returned to interface
            Satisfaction objRecord = new Satisfaction();
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

        //Method which will be called to check that neccessary fields exist in the other tables which have relationships
        private bool CheckAllTables(Satisfaction objSat)
        {
            try
            {
                //Check if it exists in tblTicket first 
                //If it is not found in tblTicket then return false else return true
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }
    }
}
