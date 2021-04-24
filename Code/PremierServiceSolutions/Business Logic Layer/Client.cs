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
        private string clientID;
        private string clientEmail;
        private string clientCell;
        private string clientTitle;
        private string clientIDNumber;
        private string clientAddress;
        private string clientGender;
        private int clientState;
        private DateTime clientCreationDate;
        private int clientPriority;

        public Client(string clientIdNumber, string clientiD, string clientname, string clientsurname, string clienttitle, string clientgender,string clientaddress, string clientcell, DateTime clientCreationdate,string clientemail, int clientPriority,int clientstate)
        {
            this.PersonName = clientname;
            this.PersonSurname = clientsurname;
            this.clientID = clientiD;
            this.clientEmail = clientemail;
            this.clientCell = clientcell;
            this.clientTitle = clienttitle;
            this.clientIDNumber = clientIdNumber;
            this.clientAddress = clientaddress;
            this.clientGender = clientgender;
            this.clientState = clientstate;
            this.clientCreationDate = clientCreationdate;
            this.clientPriority = clientPriority;
        }
        public Client()
        {

        }

        


        ClientDH objClientDH = new ClientDH();

        public string ClientID { get => clientID; set => clientID = value; }
        public string ClientEmail { get => clientEmail; set => clientEmail = value; }
        public string ClientCell { get => clientCell; set => clientCell = value; }
        public string ClientTitle { get => clientTitle; set => clientTitle = value; }
        public string ClientIDNumber { get => clientIDNumber; set => clientIDNumber = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        public string ClientGender { get => clientGender; set => clientGender = value; }
        public int ClientState { get => clientState; set => clientState = value; }
        public DateTime ClientCreationDate { get => clientCreationDate; set => clientCreationDate = value; }
        public int ClientPriority { get => clientPriority; set => clientPriority = value; }

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

        public List<Client> GetAll()
        {
            try
            {
                ClientDH objCon = new ClientDH();
                List<Client> lsAll = new List<Client>();
                lsAll = objCon.GetAll().ToList();
                return lsAll;
            }
            catch (Exception e)
            {
                return null;

            }
            
        }
    }
}
