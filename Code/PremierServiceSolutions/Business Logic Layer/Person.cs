using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    abstract class Person
    {
        private int personID;
        private string personName;
        private string personSurname;

        public int PersonID { get => personID; set => personID = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string PersonSurname { get => personSurname; set => personSurname = value; }

        public override string ToString()
        {
            return "ID" + this.personID + "Name:" + this.personName + "Surname" + this.personSurname;
        }
    }
}
