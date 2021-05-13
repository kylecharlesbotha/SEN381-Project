using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Delete, CheckTables Not Completed

namespace PremierServiceSolutions.Data_Access_Layer
{
    class SLADH : IRepositoryBase<ServiceLevelAgreement>
    {
        DBHandler objHandler = new DBHandler();
       
        
        public bool Create(ServiceLevelAgreement objSLA)
        {
            try
            {
                //Checking if the client already exists
                int SLAVal = Find(objSLA);
                if (SLAVal == 1)
                {
                    //If it finds a client with same details return message saying Client already exists
                    MessageBox.Show("Client Already Exists");
                    return false;
                }
                else if (SLAVal == 0)
                {
                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblServiceLevelAgreement (SLADescription, SLATitle) VALUES ('{0}','{1}')",
                        objSLA.SlaDescription, objSLA.SlaTitle);
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

        public bool Update(ServiceLevelAgreement newObjSLA, ServiceLevelAgreement oldObjSLA)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblServiceLevelAgreement SET SLADescription ='{1}',SLATitle ='{2}' WHERE SLAID ='{0}'",
                    oldObjSLA.SlaID,
                    newObjSLA.SlaDescription,
                    newObjSLA.SlaTitle
                    );
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

        public bool Delete(ServiceLevelAgreement entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<ServiceLevelAgreement> GetAll()
        {
            try
            {
                //List of type Client which will store all the records and then return that list
                List<ServiceLevelAgreement> allSLAs = new List<ServiceLevelAgreement>();
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = "SELECT * FROM tblServiceLevelAgreement";
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
                    allSLAs.Add(new ServiceLevelAgreement(
                                (int)sqlDataReader.GetValue(0),
                                (string)sqlDataReader.GetValue(1),
                                (string)sqlDataReader.GetValue(2)
                                ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allSLAs;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public ICollection<ServiceLevelAgreement> GetConSLA(string ContractID)
        {
            try
            {
                //List of type Client which will store all the records and then return that list
                List<ServiceLevelAgreement> allSLAs = new List<ServiceLevelAgreement>();
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = String.Format("SELECT SLA.SLAID,SLADescription,SLATitle FROM tblServiceLevelAgreement AS SLA INNER JOIN tblPackage AS P ON P.SLAID = SLA.SLAID INNER JOIN tblContract AS C ON C.ContractID = P.ContractID WHERE C.ContractID = '{0}'",ContractID);
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
                    allSLAs.Add(new ServiceLevelAgreement(
                                (int)sqlDataReader.GetValue(0),
                                (string)sqlDataReader.GetValue(1),
                                (string)sqlDataReader.GetValue(2)
                                ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allSLAs;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public int Find(ServiceLevelAgreement objSLA)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblClient
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblServiceLevelAgreement WHERE SLAID = '{0}'", objSLA.SlaID);
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

        public bool CheckTables(ServiceLevelAgreement entity)
        {
            throw new NotImplementedException();
        }

        public ServiceLevelAgreement GetByID(ServiceLevelAgreement objSLA)
        {
            List<ServiceLevelAgreement> allSLAs = GetAll().ToList();
            foreach (ServiceLevelAgreement SLA in allSLAs)
            {
                if (objSLA.SlaID == SLA.SlaID)
                {
                    return SLA;
                }
            }
            return null;
        }
    }
}
