using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Service : IComparable<Service>
    {
        ServiceDH objServiceDH = new ServiceDH();

        private int serviceID;
        private string serviceName;
        private string serviceDescription;
        private string serviceLevel;
        private int serviceState;

        public Service(int serviceID, string serviceDescription, string serviceLevel, string serviceName, int serviceState)
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

        public Service(string servicedes, string serviceLevel)
        {
            this.serviceDescription = servicedes;
            this.serviceLevel = serviceLevel;
        }

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string ServiceDescription { get => serviceDescription; set => serviceDescription = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public int ServiceState { get => serviceState; set => serviceState = value; }

        public void EditService()
        {

        }
        public List<Service> GetService()
        {
            List<Service> newList = new List<Service>();
            try
            {
                newList = objServiceDH.GetAll().ToList();
                return newList;
            }
            catch(Exception E)
            {

                return newList;
            }

        }

        public List<Service> GetContractService(string ContractID)
        {
            List<Service> newList = new List<Service>();
            try
            {
                newList = objServiceDH.GetConService(ContractID).ToList();
                return newList;
            }
            catch (Exception E)
            {

                return newList;
            }

        }
        public int CompareTo(Service other)
        {
            string oldid = this.ServiceLevel;
            string newid = other.ServiceLevel;
            return oldid.CompareTo(newid);
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
