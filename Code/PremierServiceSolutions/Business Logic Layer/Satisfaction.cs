using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Satisfaction
    {
        private int satisfactionID;
        private string satisfactionStatus;
        private Ticket ticketObject;

        public Satisfaction(int satisfactionID, string satisfactionStatus, Ticket ticketObject)
        {
            this.satisfactionID = satisfactionID;
            this.satisfactionStatus = satisfactionStatus;
            this.ticketObject = ticketObject;
        }
        public Satisfaction()
        {

        }

        public int SatisfactionID { get => satisfactionID; set => satisfactionID = value; }
        public string SatisfactionStatus { get => satisfactionStatus; set => satisfactionStatus = value; }
        public Ticket TicketObject { get => ticketObject; set => ticketObject = value; }

        public void GetClientDetails()
        {

        }

        public void ContactClient()
        {

        }

        public void GetTechnicianDetails()
        {

        }

        public void ContactTechnician()
        {

        }

        public void GetTicketDetails()
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
