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
        private int services;
        private int slas;
        private int packagestate;

        public Package(int contractID, int serviceID, int slaID, int packagestateID)
        {
            this.contractID = contractID;
            this.services = serviceID;
            this.slas = slaID;
            this.packagestate = packagestateID;
        }
        public Package()
        {
          
        }

        public int ContractID { get => contractID; set => contractID = value; }
        public int ServiceList { get => services; set => services = value; }
        public int SlaList { get => slas; set => slas = value; }

        public int PackageStateID { get => packagestate; set => packagestate = value; }

        public void GetServices()
        {

        }

        public void GetSlas()
        {

        }

        public void GetPackageState()
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
