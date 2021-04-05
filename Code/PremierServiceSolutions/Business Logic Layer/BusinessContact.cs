using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class BusinessContact
    {
        private int contactBusinessID;
        private int contactClientID;
        private int contactJobTitle;
        private string contactState;

        public BusinessContact(int contactBusinessID, int contactClientID, int contactJobTitle, string contactState)
        {
            this.contactBusinessID = contactBusinessID;
            this.contactClientID = contactClientID;
            this.contactJobTitle = contactJobTitle;
            this.contactState = contactState;
        }
        public BusinessContact()
        {

        }

        public int ContactBusinessID { get => contactBusinessID; set => contactBusinessID = value; }
        public int ContactClientID { get => contactClientID; set => contactClientID = value; }
        public int ContactJobTitle { get => contactJobTitle; set => contactJobTitle = value; }
        public string ContactState { get => contactState; set => contactState = value; }

        public void GetBusinessContact()
        {

        }
    }
}
