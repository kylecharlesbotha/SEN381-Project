using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Employee : Person, IComparable<Employee>
    {

        EmployeeDH objEmpDH = new EmployeeDH();


        private int employeeID;
        private string employeeName;
        private string employeeSurName;
        private string employeeIDNumber;

        private string employeeCell;
        private string employeeGender;
        private string employeeRole;
        private DateTime employeeStart;
        private string employeeStatus;




        public Employee(int employeeid, string employeename, string employeesurName, string employeeIDNumber, string employeecell, string employeegender, string employeerole, DateTime employeestart, string employeestatus)
        {
            this.employeeID = employeeid;
            this.employeeName = employeename;
            this.employeeSurName = employeesurName;
            this.employeeIDNumber = employeeIDNumber;
            this.employeeCell = employeecell;
            this.EmployeeGender = employeegender;
            this.employeeRole = employeerole;
            this.employeeStart = employeestart;
            this.employeeStatus = employeestatus;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return base.PersonName + base.PersonSurname + "whhyyyy" + base.PersonID;
        }

        public int CompareTo(Employee other)
        {
            throw new NotImplementedException();
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeSurName { get => employeeSurName; set => employeeSurName = value; }
        public string EmployeeIDNumber { get => employeeIDNumber; set => employeeIDNumber = value; }




        public string EmployeeCell { get => employeeCell; set => employeeCell = value; }
        public string EmployeeStatus { get => employeeStatus; set => employeeStatus = value; }
        public string EmployeeGender { get => employeeGender; set => employeeGender = value; }
        public string EmployeeRole { get => employeeRole; set => employeeRole = value; }
        public DateTime EmployeeStart { get => employeeStart; set => employeeStart = value; }
        public string EmployeeStatus1 { get => employeeStatus; set => employeeStatus = value; }

        public void GetEmployeeDuration()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> curEmployees = new List<Employee>();
            try
            {
                curEmployees = objEmpDH.GetAll().ToList();
                return curEmployees;
            }
            catch
            {
                return null;
            }
        }
    }
        
}
