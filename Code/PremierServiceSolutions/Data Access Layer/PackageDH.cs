﻿using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                //Checking if the Package already exists
                int PackVal = FindPackage(objPack);
                if (PackVal == 1)
                {
                    //If it finds a Package with same details return message saying Package already exists
                    MessageBox.Show("Package Already Exists");
                    return false;
                }
                else if (PackVal == 0)
                {
                    //If Technician does not exist then check if the Employee Record exists
                    if (CheckAllTables(objPack) == true)
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblPackage (ContractID, ServiceID, SLAID, PackageState) VALUES ('{0}','{1}','{2}','{3}')", objPack.ContractID, objPack.ServiceList, objPack.SlaList, objPack.PackageStateID);
                        SqlCommand InsertCommand = new SqlCommand(InsertQuery, sqlCon);
                        sqlCon.Open();
                        InsertCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        return true;

                    }
                }
                return false;
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
                //New SQL Connection which the query will use to perform the update of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblPackage SET ContractID ='{0}',ServiceID ='{1}',SLAID ='{2}',PackageState ='{3}' WHERE ContractID ='{4}'", newObjPack.ContractID, newObjPack.ServiceList, newObjPack.SlaList, newObjPack.PackageStateID, newObjPack.ContractID);
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
                MessageBox.Show("Error has occured when trying too update please try again");
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeletePackage(Package objPack)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTechnician to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblPackage SET ContractID = 0 WHERE ContractID ='{0}'", objPack.ContractID);
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
                MessageBox.Show("Error has occured during deletion please try again");
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
                //List of type Package which will store all the records and then return that list
                List<Package> allPackages = new List<Package>();
                //New SQL Connection which the query will use to perform the Select of tblPackages
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Packages
                string SelectQuery = "SELECT * FROM tblPackage";
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
                    allPackages.Add(new Package((int)sqlDataReader.GetValue(0), (int)sqlDataReader.GetValue(1), (int)sqlDataReader.GetValue(2), (int)sqlDataReader.GetValue(3)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Packages
                return allPackages;
            }
            catch (SqlException SQLE)
            {
                MessageBox.Show("Error has occured");
                return null;

            }
        }


        //Method used to find one record within the table
        private int FindPackage(Package objPack)
        {
            //Get count of rows to see if object exists. Refer to TechnicianDH FindTechnician method
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblPackages
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Packages
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblPackages WHERE ContractID = '{0}' AND ServiceID = '{1}' AND SLAID = '{2}' AND PackageState = '{3}'", objPack.ContractID, objPack.ServiceList, objPack.SlaList, objPack.PackageStateID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Technicians
                return RecordCount;

            }
            catch (SqlException SQLE)
            {
                MessageBox.Show("Error has occured");
                RecordCount = -1;
                return RecordCount;
            }
        }

        //Method which will be called to check that neccessary fields exist in the other tables which have relationships
        private bool CheckAllTables(Package objPack)
        {
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblPackages
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Packages
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblContract WHERE ContractID = '{0}'", objPack.ContractID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //SQL Datareader which will be used to pull specific fields from the Select Return statement
                SqlDataReader sqlDataReader;
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Packages
                if (RecordCount == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a false value
                MessageBox.Show("Error has occured");
                return false;
            }
        }

        private Package GetPackage(Package objPack)
        {
            Package objRecord = new Package();
            try
            {
                //List of type Package which will store all the records and then return that list
                List<Package> allPackage = new List<Package>();
                //New SQL Connection which the query will use to perform the Select of tblPackage
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Packages
                string SelectQuery = string.Format("SELECT * FROM tblPackage WHERE ContractID = '{0}'", objPack.ContractID);
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
                    objRecord.ContractID = (int)sqlDataReader.GetValue(0);
                    objRecord.ServiceList = (int)sqlDataReader.GetValue(1);
                    objRecord.SlaList = (int)sqlDataReader.GetValue(2);
                    objRecord.PackageStateID = (int)sqlDataReader.GetValue(3);

                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Package
                return objRecord;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }




        }
    }
    }
