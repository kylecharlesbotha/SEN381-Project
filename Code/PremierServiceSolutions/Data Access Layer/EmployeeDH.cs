using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CheckTables, FindByID Not complete


namespace PremierServiceSolutions.Data_Access_Layer
{
    class EmployeeDH : IRepositoryBase<Employee>
    {    
        DBHandler objHandler = new DBHandler();
       
        private Employee GetEmployee(Employee objEmp)
        {
            Employee objRecord = new Employee();
            try
            {
                //List of type Technician which will store all the records and then return that list
                List<Employee> allEmployee = new List<Employee>();
                //New SQL Connection which the query will use to perform the Select of tblTechnician
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Technicains
                string SelectQuery = string.Format("SELECT * FROM tblEmployee WHERE EmployeeID = '{0}'", objEmp.EmployeeID);
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
                    objRecord.EmployeeID = (int)sqlDataReader.GetValue(0);
                    objRecord.EmployeeName = (string)sqlDataReader.GetValue(1);
                    objRecord.EmployeeSurName = (string)sqlDataReader.GetValue(2);
                    objRecord.EmployeeIDNumber = (string)sqlDataReader.GetValue(3);
                    objRecord.EmployeeCell = (string)sqlDataReader.GetValue(4);
                    objRecord.EmployeeGender = (string)sqlDataReader.GetValue(5);
                    objRecord.EmployeeRole = (string)sqlDataReader.GetValue(6);
                    objRecord.EmployeeStart = (DateTime)sqlDataReader.GetValue(7);
                    objRecord.EmployeeStatus = (string)sqlDataReader.GetValue(8);
                  

                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Technicians
                return objRecord;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public bool Create(Employee objEmp)
        {
            try
            {
                //Checking if the Employee already exists
                int EmployeeVal = Find(objEmp);
                if (EmployeeVal == 1)
                {
                    //If it finds a client with same details return message saying Client already exists
                    MessageBox.Show("Client Already Exists");
                    return false;
                }
                else if (EmployeeVal == 0)
                {
                    SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    string InsertQuery = string.Format(@"INSERT INTO tblEmployee (EmployeeName,EmployeeSurname,EmployeeIDNumber,EmployeeCell,EmployeeGender,EmployeeRole,EmployeeStartDate,EmployeeStatus) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                        objEmp.EmployeeName,
                        objEmp.EmployeeSurName,
                        objEmp.EmployeeIDNumber,
                        objEmp.EmployeeCell,
                        objEmp.EmployeeGender,
                        objEmp.EmployeeRole,
                        objEmp.EmployeeStart,
                        objEmp.EmployeeStatus
                        );
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

        public bool Update(Employee newObjEmp, Employee oldObjEmp)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblEmployee SET EmployeeName ='{0}',EmployeeSurName ='{1}',EmployeeIDNumber ='{2}',EmployeeCell ='{3}',EmployeeGender ='{4}',EmployeeRole ='{5}',EmployeeStart='{6}',EmployeeStatus='{7}' WHERE EmployeeID ='{8}'",
                    newObjEmp.EmployeeName,
                    newObjEmp.EmployeeSurName,
                    newObjEmp.EmployeeIDNumber,
                    newObjEmp.EmployeeCell,
                    newObjEmp.EmployeeGender,
                    newObjEmp.EmployeeRole,
                    newObjEmp.EmployeeStart,
                    newObjEmp.EmployeeStatus,
                    oldObjEmp.EmployeeID

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

        public bool Delete(Employee objEmp)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblCustomerContract to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblEmployee SET EmployeeStatus = 'Deleted' WHERE EmployeeID ='{0}'", objEmp.EmployeeID);
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

        public ICollection<Employee> GetAll()
        {
            try
            {
                //List of type CustomerContract which will store all the records and then return that list
                List<Employee> allEmp = new List<Employee>();
                //New SQL Connection which the query will use to perform the Select of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the CustomerContracts
                string SelectQuery = "SELECT * FROM tblEmployee";
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
                    allEmp.Add(new Employee(
                        (int)sqlDataReader.GetValue(0),
                        (string)sqlDataReader.GetValue(1),
                        (string)sqlDataReader.GetValue(2),
                        (string)sqlDataReader.GetValue(3),
                        (string)sqlDataReader.GetValue(5),
                        (string)sqlDataReader.GetValue(6),
                        (string)sqlDataReader.GetValue(7),
                        (DateTime)sqlDataReader.GetValue(8),
                        (string)sqlDataReader.GetValue(9)


                        ));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of CustomerContracts
                return allEmp;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        public int Find(Employee objEmp)
        {
            //Get count of rows to see if object exists. Refer to TechnicianDH FindTechnician method
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblCustomerContract
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the CustomerContract
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblEmployee WHERE EmployeeID = '{0}'",
                    objEmp.EmployeeID
                    );
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
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                RecordCount = -1;
                return RecordCount;
            }
        }

        public bool CheckTables(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee GetByID(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
