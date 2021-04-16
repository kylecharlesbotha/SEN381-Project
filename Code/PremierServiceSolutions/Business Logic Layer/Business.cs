using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Business : IComparable<Business>
    {
        private int businessID;
        private string businessName;
        private string businessPhone;
        private int businessRegistrationNumber;
        private string businessAddress;
        private string businessState;

        public Business(int businessID, string businessAddress, string businessName, string businessPhone, int businessRegistrationNumber, string businessState)
        {
            this.businessID = businessID;
            this.businessName = businessName;
            this.businessPhone = businessPhone;
            this.businessRegistrationNumber = businessRegistrationNumber;
            this.businessAddress = businessAddress;
            this.businessState = businessState;
        }

        public Business()
        {

        }

        public int BusinessID { get => businessID; set => businessID = value; }
        public string BusinessName { get => businessName; set => businessName = value; }
        public string BusinessPhone { get => businessPhone; set => businessPhone = value; }
        public int BusinessRegistrationNumber { get => businessRegistrationNumber; set => businessRegistrationNumber = value; }
        public string BusinessState { get => businessState; set => businessState = value; }
        public string BusinessAddress { get => businessAddress; set => businessAddress = value; }

        public void GetBusinessDetails()
        {

        }
        public void EditBusinessDetails()
        {

        }


        public int CompareTo(Business other)
        {
            throw new NotImplementedException();
        }

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
