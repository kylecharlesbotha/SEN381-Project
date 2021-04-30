using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class CallCentreContract : IComparable<CallCentreContract>
    {
        CallCentreContractDH objCallConDH = new CallCentreContractDH();
        private string clientID;
        private string contractID;
        private string contractStatus;
        private string contractType;
        private byte[] contractPath;
        private DateTime contractEndTime;

        public CallCentreContract(string clientID, string contractID, string contractStatus, string contractType, byte[] contractPath, DateTime contractendtime)
        {
            this.clientID = clientID;
            this.contractID = contractID;
            this.contractStatus = contractStatus;
            this.contractType = contractType;
            this.contractPath = contractPath;
            this.contractEndTime = contractendtime;
        }
        public CallCentreContract()
        {

        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string ContractID { get => contractID; set => contractID = value; }
        public string ContractStatus { get => contractStatus; set => contractStatus = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public byte[] ContractPath { get => contractPath; set => contractPath = value; }
        public DateTime ContractEndTime { get => contractEndTime; set => contractEndTime = value; }

        public List<CallCentreContract> GetCallContract()
        {
            List<CallCentreContract> lsReturn = objCallConDH.GetAll().ToList();
            return lsReturn;
        }

        public int CompareTo(CallCentreContract other)
        {
            DateTime current = this.contractEndTime;
            DateTime newdate = other.contractEndTime;
            return newdate.CompareTo(current);
        }
    }
}
