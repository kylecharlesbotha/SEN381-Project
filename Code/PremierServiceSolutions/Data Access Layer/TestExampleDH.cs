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
    class TestExampleDH
    {
        DBHandler objHandler = new DBHandler();


        private void Run(Employee objEmp)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);

                string InsertQuery = string.Format(@"INSERT INTO tblEmployee (Field1, Field2, and so forth) VALUES ('{0}','{1}')", objEmp.EmployeeCell, objEmp.EmployeeRole);
                SqlCommand InsertCommand = new SqlCommand(InsertQuery, sqlCon);
                sqlCon.Open();
                InsertCommand.ExecuteNonQuery();
                sqlCon.Close();


                string UpdateQuery = string.Format(@"UPDATE tblEmployee SET Field1 ='{0}' WHERE Field2 ='{1}'", objEmp.EmployeeStatus, objEmp.EmployeeStart);
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                sqlCon.Open();
                UpdateCommand.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
