using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class TestExampleDH : IRepositoryBase<Business>
    {
        DBHandler objHandler = new DBHandler();

        public bool CheckTables(Business entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(Business entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Business entity)
        {
            throw new NotImplementedException();
        }

        public int Find(Business objEmp)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);

                string InsertQuery = string.Format(@"INSERT INTO tblEmployee (Field1, Field2, and so forth) VALUES ('{0}','{1}')", objEmp.BusinessID, objEmp.EmployeeRole);
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
            throw new NotImplementedException();
        }

        public ICollection<Business> GetAll()
        {
            throw new NotImplementedException();
        }

        public Business GetByID(Business entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Business entity, Business entity2)
        {
            throw new NotImplementedException();
        }

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
