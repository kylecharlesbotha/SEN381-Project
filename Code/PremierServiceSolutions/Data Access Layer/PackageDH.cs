using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class PackageDH
    {
        //Object of DBHandler which will store the connection string. We do this so that we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreatePackage(Package objPack)
        {
            try
            {
                //First Check if the record already exsists by calling  FindPackage()
                //If found return false and display a message that it already exists else continue with creating
                //Then you will need to check if the Service Record Exists and also if the ServiceLevelAgreement Record Exists and also Contract Record Exists. Call CheckAllTables() as that will check all the tables it needs to
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdatePackage(Package newObjPack, Package oldObjPack)
        {
            try
            {
                //Update to new records where it matches the old ContractID
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeletePackage(Package objPack)
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
        private List<Package> GetAllPackage(Package objPack)
        {
            //List of type Package which will store all the records and then return that list
            List<Package> allPack = new List<Package>();

            try
            {
                //Return all records from table
                return allPack;
            }
            catch (SqlException SQLE)
            {
                return allPack;
            }
        }

        //Method used to find one record within the table
        private Package FindPackage(Package objPack)
        {
            //Object of type Package which will store single record of object to be returned to interface
            Package objRecord = new Package();
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
        private bool CheckAllTables(Package objPack)
        {
            try
            {
                //Check if it exists in tblServiceLevelAgreement first then if it does continue with checking tblService.
                //If it is not found in tblServiceLevelAgreement then return false. If it is found within tlbService start checking tblContract
                //if it is found in tblContract return true else return false
                return true;
            }
            catch (SqlException SQLE)
            {
                return false;
            }
        }
    }
}
