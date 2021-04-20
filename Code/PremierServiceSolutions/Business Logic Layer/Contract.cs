using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Contract
    {
        private int contractID;
        private string contractType;
        private string contractDescription;
        private string contractState;

        public Contract(int contractID, string contractDescription, string contractType, string contractState)
        {
            this.contractID = contractID;
            this.contractDescription = contractDescription;
            this.contractType = contractType;
            this.contractState = contractState;
        }
        public Contract()
        {

        }

        public int ContractID { get => contractID; set => contractID = value; }
        public string ContractDescription { get => contractDescription; set => contractDescription = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string ContractState { get => contractState; set => contractState = value; }

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
