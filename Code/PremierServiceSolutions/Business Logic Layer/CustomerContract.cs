using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class CustomerContract
    {

        CustomerContractDH objCusConDH = new CustomerContractDH();
        private int cusconID;
        private int businessID;
        private string clientID;
        private string contractID;
        private string cusconStatus;
        private DateTime startDate;
        private DateTime endDate;
        private int customerState;


        public int CustomerContractID { get => cusconID; set => cusconID = value; }
        public int BusinessID { get => businessID; set => businessID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string ContractID { get => contractID; set => contractID = value; }
        public string CustomerContractStatus { get => cusconStatus; set => cusconStatus = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int CustomerState { get => customerState; set => customerState = value; }

        public CustomerContract()
        {

        }

        public CustomerContract(int cusconID, int businessID, string clientID, string contractID, string cusconStatus, DateTime startDate, DateTime endDate, int customerState)
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

        public bool InsertCustomerContract(CustomerContract objCusCon)
        {
            bool submitted = false;
            try
            {
                submitted = objCusConDH.Create(objCusCon);
                return submitted;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return submitted;
            }
        }
    }
}
