using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Contract
    {
        private string contractID;
        private string contractType;
        private string contractDescription;
        private string contractState;

        public Contract(string contractID, string contractDescription, string contractType, string contractState)
        {
            this.contractID = contractID;
            this.contractDescription = contractDescription;
            this.contractType = contractType;
            this.contractState = contractState;
        }
        public Contract()
        {

        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string ContractDescription { get => contractDescription; set => contractDescription = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string ContractState { get => contractState; set => contractState = value; }
        ContractType objConType = new ContractType();
        ContractDH objConDH = new ContractDH();

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

        public string CreateContractID(Client objClient,Contract objContract)
        {
            List<ContractType> lsAll = objConType.GetAllContractTypes();
            string DateYear = Convert.ToString(DateTime.Now.Year);
            bool validated = false;
            while (validated == false)
            {
                string ContractType = null;
                string ContractID = DateYear;

                int ClientImportance = objClient.ClientPriority;
                string ClientImp = null;

                foreach (ContractType conitem in lsAll)
                {
                    if (objContract.contractType == conitem.ContractName)
                    {
                        ContractType = conitem.ContractChar;
                    }
                }
                ContractID += ContractType;
                switch (ClientImportance)
                {
                    case 1:
                        {
                            ClientImp = "D";
                            break;
                        }
                    case 2:
                        {
                            ClientImp = "C";
                            break;
                        }
                    case 3:
                        {
                            ClientImp = "B";
                            break;
                        }
                    case 4:
                        {
                            ClientImp = "A";
                            break;
                        }
                    default:
                        break;
                }
                ContractID += ClientImp;

                //Will get random int value between 1 and 99999999
                Random rnd = new Random();
                int number = rnd.Next(1, 999999);
                string ContractNumber = Convert.ToString(number);

                //Padding the number by 0 to the lenght of 8
                ContractNumber = (ContractNumber.PadLeft(6, '0'));

                ContractID += ContractNumber;

                if (objConDH.GetByID(ContractID)==0)
                {
                    validated = true;
                    return ContractID;
                }

                
            }
            return null;


        }
    }
    
}
