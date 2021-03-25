using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Employee : Person, IComparable<Employee>
    {

        private string employeeCell;
        private string employeeStatus;
        private string employeeGender;
        private string employeeRole;
        private DateTime employeeStart;

        public Employee(string employeeCell, string employeeStatus, string employeeGender, string employeeRole, DateTime employeeStart)
        {

            this.employeeCell = employeeCell;
            this.employeeStatus = employeeStatus;
            this.employeeGender = employeeGender;
            this.employeeRole = employeeRole;
            this.employeeStart = employeeStart;
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

        public string EmployeeCell { get => employeeCell; set => employeeCell = value; }
        public string EmployeeStatus { get => employeeStatus; set => employeeStatus = value; }
        public string EmployeeGender { get => employeeGender; set => employeeGender = value; }
        public string EmployeeRole { get => employeeRole; set => employeeRole = value; }
        public DateTime EmployeeStart { get => employeeStart; set => employeeStart = value; }


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
    }
}
