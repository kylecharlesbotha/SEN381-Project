using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Technician
    {
        private int technicianID;
        private int technicianLevel;
        private string technicianStatus;
        private int technicianState;
        private int employeeID;

        public Technician(int technicianID, int technicianLevel, string technicianStatus, int employeeid,int technicianstate )
        {
            this.technicianID = technicianID;
            this.technicianStatus = technicianStatus;
            this.technicianLevel = technicianLevel;
            this.technicianState = technicianstate;
            this.employeeID = employeeid;
        }

        public Technician()
        {
        }

        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public string TechnicianStatus { get => technicianStatus; set => technicianStatus = value; }
        public int TechnicianLevel { get => technicianLevel; set => technicianLevel = value; }
        public int TechnicianState { get => technicianState; set => technicianState = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }

        public override string ToString()
        {
            return base.ToString();
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
