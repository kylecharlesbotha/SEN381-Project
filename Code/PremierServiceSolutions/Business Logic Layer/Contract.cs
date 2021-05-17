using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Contract : IComparable<Contract>
    {
        private string contractID;
        private string contractType;
        private string contractDescription;
        private int contractState;
        private string clientID;
        private DateTime startDate;
        private DateTime endDate;
        private string contractStatus;
        private byte[] contractFilePath;

        public Contract(string contractID, string contractDescription, string contractType, int contractState)
        {
            this.contractID = contractID;
            this.contractDescription = contractDescription;
            this.contractType = contractType;
            this.contractState = contractState;
        }
        public Contract(string contractid, string clientid,string contracttype,DateTime startdate, DateTime enddate, string contractstatus, int contractState)
        {
            this.ContractID = contractid;
            this.clientID = clientid;
            this.contractType = contracttype;
            this.startDate = startdate;
            this.endDate = enddate;
            this.contractStatus = contractstatus;
            this.contractState = contractState;
        }

        public Contract(string contractid, string clientid, string contractdes, DateTime startdate, DateTime enddate, string contracttype, byte[] contractfilepath,int contractState)
        {
            this.ContractID = contractid;
            this.clientID = clientid;
            this.ContractDescription = contractdes;
            this.contractType = contracttype;
            this.startDate = startdate;
            this.endDate = enddate;
            this.contractFilePath = contractfilepath;
            this.contractState = contractState;
        }


        public Contract()
        {

        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string ContractDescription { get => contractDescription; set => contractDescription = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public int ContractState { get => contractState; set => contractState = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string ContractStatus { get => contractStatus; set => contractStatus = value; }
        public byte[] ContractFilePath { get => contractFilePath; set => contractFilePath = value; }

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

        public bool UploadContract(string filepath,string ContractName)
        {
            bool submitted = false;
            try
            {
                objConDH.UpdateFileStream(filepath,ContractName);

                return submitted;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Uploadcontract method" + E.Message);
                return submitted;
            }
        }


        public List<Contract> GetContractRecords()
        {
            List<Contract> newList = new List<Contract>();
            try
            {
                newList = objConDH.GetContractRecords().ToList();
                return newList;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return newList;
            }
        }

        public int CompareTo(Contract other)
        {
            string oldid = this.ContractID;
            string newid = other.ContractID;
            return newid.CompareTo(newid);
        }

        public Contract GetContractDetails(string ContractID)
        {
            Contract newCont = new Contract();
            try
            {
                newCont = objConDH.GetContractDetails(ContractID);
                return newCont;
            }
            catch(Exception E)
            {
                return newCont;
            }
        }

        public bool ActivateContract(string ContractID)
        {
            bool value = false;
            try
            {
                Contract obj = new Contract();
                obj.contractID = ContractID;
                value = objConDH.Activate(obj);
                return value;
            }
            catch(Exception E)
            {
                return value;
            }
        }
        public bool DeleteContract(string ContractID)
        {
            bool value = false;
            try
            {
                Contract obj = new Contract();
                obj.contractID = ContractID;
                value = objConDH.Delete(obj);
                return value;
            }
            catch (Exception E)
            {
                return value;
            }
        }

        public bool CreateContract(Contract objCon)
        {
            bool submitted = false;
            try
            {
               submitted = objConDH.Create(objCon);
                return submitted;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return submitted;
            }
        }

        public string CreateContractID(string ContractTypeNew, int ClientPriorityNew)
        {
            string ContractIDNew = "";
            bool validated = false;
            try 
            {
                while (validated == false)
                {
                    StringBuilder sb = new StringBuilder();
                    int year = DateTime.Now.Year; //Get the year the contract was created
                    sb.Append(Convert.ToString(year));
                    sb.Append(ContractTypeNew);
                    switch (ClientPriorityNew)
                    {
                        case 1:
                            {
                                sb.Append("D");
                                break;
                            }
                        case 2:
                            {
                                sb.Append("C");
                                break;
                            }
                        case 3:
                            {
                                sb.Append("B");
                                break;
                            }
                        case 4:
                            {
                                sb.Append("A");
                                break;
                            }
                        default:
                            break;
                    }

                    //Will get random int value between 1 and 99999999
                    Random rnd = new Random();
                    int number = rnd.Next(1, 999999);
                    string PaddNumber = Convert.ToString(number);

                    //Padding the number by 0 to the lenght of 6
                    PaddNumber = (PaddNumber.PadLeft(6, '0'));

                    sb.Append(PaddNumber);
                    ContractIDNew = sb.ToString();

                    if (objConDH.GetByID(ContractID) == 0)
                    {
                        validated = true;
                        return ContractIDNew;
                    }

                }
                return ContractIDNew;
            }
            catch(Exception E)
            {
                return ContractIDNew;
            }
        }
    }
    
}
