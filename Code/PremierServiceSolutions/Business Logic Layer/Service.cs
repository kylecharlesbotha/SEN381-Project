using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Service
    {
        private int serviceID;
        private string serviceName;
        private string serviceDescription;
        private int serviceLevel;
        private int serviceState;

        public Service(int serviceID, string serviceDescription, int serviceLevel, string serviceName, int serviceState)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.serviceDescription = serviceDescription;
            this.serviceLevel = serviceLevel;
            this.serviceState = serviceState;
        }
        public Service()
        {

        }

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string ServiceDescription { get => serviceDescription; set => serviceDescription = value; }
        public int ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public int ServiceState { get => serviceState; set => serviceState = value; }

        public void EditService()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void GetServiceDetails()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
