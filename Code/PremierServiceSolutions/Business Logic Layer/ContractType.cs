using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class ContractType
    {
        private string contractName;
        private string contractChar;

        public ContractType(string contractName, string contractChar)
        {
            this.contractName = contractName;
            this.contractChar = contractChar;
        }
        public ContractType()
        {

        }

        public string ContractName { get => contractName; set => contractName = value; }
        public string ContractChar { get => contractChar; set => contractChar = value; }

        public List<ContractType> GetAllContractTypes()
        {
            ContractTypeDH objConType = new ContractTypeDH();
            List<ContractType> lsAll = new List<ContractType>();
            lsAll = objConType.GetAllConTypes();
            return lsAll;
        }
    }
}
