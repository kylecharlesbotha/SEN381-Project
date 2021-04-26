using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class CallCentreContractDH
    {
        DBHandler objHandler = new DBHandler();

        public ICollection<CallCentreContract> GetAll()
        {
            try
            {
                //List of type Business which will store all the records and then return that list
                List<CallCentreContract> allCentreCon = new List<CallCentreContract>();
                //New SQL Connection which the query will use to perform the Select of tblBusiness
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Business
                string SelectQuery = "SELECT CC.ClientID,C.ContractID,  CC.CustomerContractStatus,CT.ContractType, CF.FilePath, CC.EndDate FROM tblCustomerContract AS CC INNER JOIN tblContract AS C ON CC.ContractID = C.ContractID INNER JOIN tblContractFiles AS CF ON C.ContractID = CF.ContractID INNER JOIN tblContractType AS CT ON C.ContractType = CT.ContractChar";
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
                    allCentreCon.Add(new CallCentreContract((string)sqlDataReader.GetValue(0), (string)sqlDataReader.GetValue(1), (string)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3), (byte[])sqlDataReader.GetValue(4),(DateTime)sqlDataReader.GetValue(5)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Business
                return allCentreCon.ToList();
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
