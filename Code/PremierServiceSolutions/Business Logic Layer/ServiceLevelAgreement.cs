using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class ServiceLevelAgreement
    {
        SLADH objSLADH = new SLADH();

        private int slaID;
        private string slaTitle;
        private string slaDescription;
        private string slaFile;

        public ServiceLevelAgreement(int slaID, string slaTitle, string slaDescription, string slaFile)
        {
            this.slaID = slaID;
            this.slaTitle = slaTitle;
            this.slaDescription = slaDescription;
            this.slaFile = slaFile;
        }
        public ServiceLevelAgreement(int slaID, string slaDescription, string slaTitle)
        {
            this.slaID = slaID;
            this.slaTitle = slaTitle;
            this.slaDescription = slaDescription;
           
        }
        public ServiceLevelAgreement()
        {

        }

        public int SlaID { get => slaID; set => slaID = value; }
        public string SlaTitle { get => slaTitle; set => slaTitle = value; }
        public string SlaDescription { get => slaDescription; set => slaDescription = value; }
        public string SlaFile { get => slaFile; set => slaFile = value; }

        public void WriteToFile()
        {

        }

        public void DisplayPDF()
        {

        }

        public void EditSLA()
        {

        }

        public void NotifyClient()
        {

        }

        public List<ServiceLevelAgreement> GetConSLA(string ContractID)
        {
            List<ServiceLevelAgreement> newList = new List<ServiceLevelAgreement>();
            try
            {
                newList = objSLADH.GetConSLA(ContractID).ToList();
                return newList;
            }
            catch
            {
                return newList;
            }
        }
    }
}
