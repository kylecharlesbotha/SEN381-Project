using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Client : Person, IComparable<Client>
    {

        private string clientEmail;
        private string clientCell;
        private string clientTitle;
        private string clientIDNumber;
        private string clientAddress;
        private string clientGender;
        private string clientState;
        private DateTime clientCreationDate;
        private string clientPriority;

        public Client(string clientEmail, string clientPhone, string clientTitle, string clientIdNumber, string clientAddress, string clientGender, string clientState, DateTime clientCreationDate, string clientPriority)
        {

            this.clientEmail = clientEmail;
            this.clientCell = clientPhone;
            this.clientTitle = clientTitle;
            this.clientIDNumber = clientIdNumber;
            this.clientAddress = clientAddress;
            this.clientGender = clientGender;
            this.clientState = clientState;
            this.clientCreationDate = clientCreationDate;
            this.clientPriority = clientPriority;
        }
        public Client()
        {

        }

        public string ClientEmail { get => clientEmail; set => clientEmail = value; }
        public string ClientCell { get => clientCell; set => clientCell = value; }
        public string ClientTitle { get => clientTitle; set => clientTitle = value; }
        public string ClientIdNumber { get => clientIDNumber; set => clientIDNumber = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        public string ClientGender { get => clientGender; set => clientGender = value; }
        public string ClientState { get => clientState; set => clientState = value; }
        public DateTime ClientCreationDate { get => clientCreationDate; set => clientCreationDate = value; }
        public string ClientPriority { get => clientPriority; set => clientPriority = value; }

        public int CompareTo(Client other)
        {
            throw new NotImplementedException();
        }

        public void GetClientDetails()
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
