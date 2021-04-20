using PremierServiceSolutions.Data_Access_Layer;
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
        private int clientPriority;

        public Client(string clientEmail, string clientPhone, string clientTitle, string clientIdNumber, string clientAddress, string clientGender, string clientState, DateTime clientCreationDate, int clientPriority)
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
        public int ClientPriority { get => clientPriority; set => clientPriority = value; }


        ClientDH objClientDH = new ClientDH();
      

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

        public string CreateClientID()
        {
            string Letter = null;
            bool Valid = false;
            while (Valid==false)
            {
                //Will get rnadom Char between A and E
                Random rndchar = new Random();
                char randomChar = (char)rndchar.Next('A', 'E');
                Letter = Convert.ToString(randomChar);

                //Will get random int value between 1 and 99999999
                Random rnd = new Random();
                int number = rnd.Next(1, 99999999);
                string ClientNumber = Convert.ToString(number);

                //Padding the number by 0 to the lenght of 8
                ClientNumber = (ClientNumber.PadLeft(8, '0'));

                //Joining Letter and ClientNumber
                string ClientID = Letter + ClientNumber;

                if(objClientDH.GetByID(ClientID)==0)
                {
                    Valid = true;
                    return ClientID;
                }



            }
            //Return String
            return Letter;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
