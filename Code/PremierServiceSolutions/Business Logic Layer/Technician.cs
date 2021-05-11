using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Technician : IComparable<Technician>
    {
        private int technicianID;
        private int technicianLevel;
        private string technicianStatus;
        private int technicianState;
        private int employeeID;
        private string techName;
        private string techEmail;
        private string employeeRole;
        TechnicianDH objTech = new TechnicianDH();
        public Technician(int technicianID, int technicianLevel, string technicianStatus, int employeeid,int technicianstate )
        {
            this.technicianID = technicianID;
            this.technicianStatus = technicianStatus;
            this.technicianLevel = technicianLevel;
            this.technicianState = technicianstate;
            this.employeeID = employeeid;
        }
        public Technician(int technicianid,string techname,int techlevel, string techstatus,string techemail, int technicianstate)
        {
            this.technicianID = technicianid;
            this.techName = techname;
            this.technicianLevel = techlevel;
            this.technicianStatus = techstatus;
            this.techEmail = techemail;
            this.technicianState = technicianstate;
        }

        public Technician(int techid,string techname)
        {
            this.technicianID = techid;
            this.techName = techname;
        }
        public Technician(int techid)
        {
            this.technicianID = techid;
        }
        public Technician(string username, int employeeid, int techid)
        {
            this.techName = username;
            this.employeeID = employeeid;
            this.technicianID = techid;
        }
        public Technician()
        {

        }



        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public string TechnicianStatus { get => technicianStatus; set => technicianStatus = value; }
        public int TechnicianLevel { get => technicianLevel; set => technicianLevel = value; }
        public int TechnicianState { get => technicianState; set => technicianState = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string TechName { get => objTech.GetTechName(this); set => techName = value; }
        public string TechNameList { get => techName; set => techName = value; }
        public string TechEmail { get => techEmail; set => techEmail = value; }
        public string EmployeeRole { get => employeeRole; set => employeeRole = value; }

        public override string ToString()
        {
            return base.ToString();
        }
        public int CompareTo(Technician other)
        {
            string current = this.TechName;
            string newname = other.TechName;
            return newname.CompareTo(current);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        public List<Technician> GetTechNames()
        {
            
            List<Technician> lstTech = objTech.GetTechnicianName().ToList();
            return lstTech;
            
        }

        public Technician GetTechID(string UserName)
        {
            try
            {
                return objTech.GetCurrentTec(UserName);
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return null;
            }
        }

        public List<Technician> GetTechRecords()
        {
            List<Technician> newList = new List<Technician>();
            try
            {
                newList = objTech.GetTechRecords().ToList();
                return newList;
            }
            catch
            {
                return newList;
            }
        }

        public bool GetTechEmpID(int EmpID)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Technician GetTechDetails(int TechID)
        {
            Technician newTech = new Technician();
            try
            {
                newTech = objTech.GetTechDetails(TechID);

                return newTech;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return newTech;
            }
        }
        public bool DeleteTech(Technician Tec)
        {
            bool Submited = false;
            try
            {
                Submited = objTech.Delete(Tec);
                return Submited;
            }
            catch(Exception E)
            {
                return Submited;
            }
        }

    }
}
