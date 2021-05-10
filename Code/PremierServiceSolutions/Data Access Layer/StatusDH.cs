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
    class StatusDH
    {
        DBHandler objHandler = new DBHandler();

        public ICollection<Status> GetAll()
        {
            try
            {
                //List of type BusinessContact which will store all the records and then return that list
                List<Status> allStatus = new List<Status>();
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                string SelectQuery = "SELECT * FROM tblTicketStatus";
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
                    allStatus.Add(new Status((int)sqlDataReader.GetValue(0),(string)sqlDataReader.GetValue(1)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of BusinessContacts
                return allStatus.ToList();
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
