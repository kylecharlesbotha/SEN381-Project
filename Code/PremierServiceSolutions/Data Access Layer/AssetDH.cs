using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class AssetDH : IRepositoryBase<Asset>
    {
        DBHandler objHandler = new DBHandler();
        public bool CheckTables(Asset entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(Asset entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Asset entity)
        {
            throw new NotImplementedException();
        }

        public int Find(Asset entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Asset> GetAll()
        {
            try
            {
                //List of type Client which will store all the records and then return that list
                List<Asset> allAssets = new List<Asset>();
                //New SQL Connection which the query will use to perform the Select of tblClients
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Clients
                string SelectQuery = "SELECT * FROM tblAsset";
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
                    allAssets.Add(new Asset(
                                (string)sqlDataReader.GetValue(0),
                                (string)sqlDataReader.GetValue(1),
                                (string)sqlDataReader.GetValue(2),
                                (string)sqlDataReader.GetValue(3),
                                (string)sqlDataReader.GetValue(4)
                                ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Clients
                return allAssets.ToList();
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public Asset GetByID(Asset entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Asset entity, Asset entity2)
        {
            throw new NotImplementedException();
        }
    }
}
