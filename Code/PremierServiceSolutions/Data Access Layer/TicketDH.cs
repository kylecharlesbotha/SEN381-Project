using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class TicketDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateTicket(Ticket objTic)
        {
            try
            {
                //First Check if the record already exsists by calling  FindTicket()
                //If found return false and display a message that it already exists else continue with creating
                //Then you will need to check if the Call Record Exists and also if the Technician Record Exists. Call CheckAllTables() as that will check all the tables it needs to
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateTicket(Ticket newObjTic, Ticket oldObjTic)
        {
            try
            {
                //Update to new records where it matches the old TicketID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteTicket(Ticket objTic)
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
        private List<Ticket> GetAllTicket(Ticket objTic)
        {
            //List of type Ticket which will store all the records and then return that list
            List<Ticket> allTic = new List<Ticket>();

            try
            {
                //Return all records from table
                return allTic;
            }
            catch (SqlException SQLE)
            {
                return allTic;
            }
        }

        //Method used to find one record within the table
        private Ticket FindTicket(Ticket objTic)
        {
            //Object of type Ticket which will store single record of object to be returned to interface
            Ticket objRecord = new Ticket();
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
        private bool CheckAllTables(Ticket objTic)
        {
            try
            {
                //Check if it exists in tblCall first then if it does continue with checking tblTechnician.
                //If it is not found in tblCall then return false. If it is found within tblTechnician then check if the record exists in tblEmployee. If it does return true else return false
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }
    }
}
