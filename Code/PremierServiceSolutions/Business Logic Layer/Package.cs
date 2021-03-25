using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Package
    {
        private int contractID;
        private List<Service> services;
        private List<ServiceLevelAgreement> slas;

        public Package(int contractID, List<Service> serviceID, List<ServiceLevelAgreement> slaID)
        {
            this.contractID = contractID;
            this.services = serviceID;
            this.slas = slaID;
        }
        public Package()
        {

        }

        public int ContractID { get => contractID; set => contractID = value; }
        public List<Service> ServiceList { get => services; set => services = value; }
        public List<ServiceLevelAgreement> SlaList { get => slas; set => slas = value; }

        public void GetServices()
        {

        }

        public void GetSlas()
        {

        }

        public void PDFCompile()
        {

        }

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
