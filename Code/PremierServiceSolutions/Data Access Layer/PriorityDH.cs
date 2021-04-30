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
    class PriorityDH
    {
        DBHandler objHandler = new DBHandler();

        public ICollection<Priority> GetAll()
        {
            try
            {
                //List of type BusinessContact which will store all the records and then return that list
                List<Priority> allPriority = new List<Priority>();
                //New SQL Connection which the query will use to perform the Select of tblBusinessContact
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the BusinessContacts
                string SelectQuery = "SELECT * FROM tblPriority";
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
                    allPriority.Add(new Priority(
                                 (int)sqlDataReader.GetValue(1),
                                 (string)sqlDataReader.GetValue(2)
                                 ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of BusinessContacts
                return allPriority.ToList();
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
