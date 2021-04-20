using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class CustomerContract
    {
        private int cusconID;
        private int businessID;
        private int clientID;
        private int contractID;
        private string cusconStatus;
        private DateTime startDate;
        private DateTime endDate;
        private int customerState;


        public int CustomerContractID { get => cusconID; set => cusconID = value; }
        public int BusinessID { get => businessID; set => businessID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int ContractID { get => contractID; set => contractID = value; }
        public string CustomerContractStatus { get => cusconStatus; set => cusconStatus = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int CustomerState { get => customerState; set => customerState = value; }

        public CustomerContract()
        {

        }

        public CustomerContract(int cusconID, int businessID, int clientID, int contractID, string cusconStatus, DateTime startDate, DateTime endDate, int customerState)
        {
            this.cusconID = cusconID;
            this.businessID = businessID;
            this.clientID = clientID;
            this.contractID = contractID;
            this.cusconStatus = cusconStatus;
            this.startDate = startDate;
            this.endDate = endDate;
            this.customerState = customerState;
        }

        public void NotifyClient()
        {

        }

        public void GetAvalability()
        {

        }

        public void GetPerformance()
        {

        }

        public void GetClientDetails()
        {

        }

        public void GetBusinessDetails()
        {

        }

        public void GetContractEnd()
        {

        }
    }
}
