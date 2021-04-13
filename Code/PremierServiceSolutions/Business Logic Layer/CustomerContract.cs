using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class CustomerContract
    {
        private Contract contractObject;
        private Business businessObject;
        private Client clientObject;
        private DateTime startDate;
        private DateTime endDate;
        private string cusconStatus;

        public CustomerContract(Contract contractObject, Business businessObject, Client clientObject, DateTime startDate, DateTime endDate, string cusconStatus)
        {
            this.contractObject = contractObject;
            this.businessObject = businessObject;
            this.clientObject = clientObject;
            this.startDate = startDate;
            this.endDate = endDate;
            this.cusconStatus = cusconStatus;
        }

        public CustomerContract()
        {

        }

        public Contract ContractObject { get => contractObject; set => contractObject = value; }
        public Business BusinessObject { get => businessObject; set => businessObject = value; }
        public Client ClientObject { get => clientObject; set => clientObject = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string CusconStatus { get => cusconStatus; set => cusconStatus = value; }

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
