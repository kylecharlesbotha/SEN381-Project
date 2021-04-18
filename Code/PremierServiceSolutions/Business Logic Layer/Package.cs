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
        private int serviceID;
        private int slaID;
        private int packagestate;

        public Package(int contractID, int serviceID, int slaID, int packagestateID)
        {
            this.contractID = contractID;
            this.serviceID = serviceID;
            this.slaID = slaID;
            this.packagestate = packagestateID;
        }
        public Package()
        {
          
        }

        public int ContractID { get => contractID; set => contractID = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public int SlaID { get => slaID; set => slaID = value; }

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
