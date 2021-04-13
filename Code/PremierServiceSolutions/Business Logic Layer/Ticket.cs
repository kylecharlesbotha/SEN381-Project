using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Ticket
    {
        private int ticketID;
        private string ticketTitle;
        private string ticketIssueType;
        private string ticketPriority;
        private string ticketStatus;
        private DateTime ticketLoggedTime;
        private DateTime ticketLastUpdated;
        private DateTime ticketDueDate;
        private string ticketDescription;
        private Technician ticketAssginedTechnician;
        private Client ticketClientObject;
        private Employee ticketEmployeeObject;



        public Ticket(int ticketID, string ticketTitle, string ticketIssueType, string ticketPriority, string ticketStatus, DateTime ticketLoggedTime, DateTime ticketLastUpdated, DateTime ticketDueDate, string ticketDescription, Technician ticketAssginedTechnician, Client ticketClientObject, Employee ticketEmployeeObject)
        {
            this.ticketID = ticketID;
            this.ticketTitle = ticketTitle;
            this.ticketIssueType = ticketIssueType;
            this.ticketPriority = ticketPriority;
            this.ticketStatus = ticketStatus;
            this.ticketLoggedTime = ticketLoggedTime;
            this.ticketLastUpdated = ticketLastUpdated;
            this.ticketDueDate = ticketDueDate;
            this.ticketDescription = ticketDescription;
            this.ticketAssginedTechnician = ticketAssginedTechnician;
            this.ticketClientObject = ticketClientObject;
            this.ticketEmployeeObject = ticketEmployeeObject;
        }

        public Ticket()
        {

        }

        public int TicketID { get => ticketID; set => ticketID = value; }
        public string TicketTitle { get => ticketTitle; set => ticketTitle = value; }
        public string TicketIssueType { get => ticketIssueType; set => ticketIssueType = value; }
        public string TicketPriority { get => ticketPriority; set => ticketPriority = value; }
        public string TicketStatus { get => ticketStatus; set => ticketStatus = value; }
        public DateTime TicketLoggedTime { get => ticketLoggedTime; set => ticketLoggedTime = value; }
        public DateTime TicketLastUpdated { get => ticketLastUpdated; set => ticketLastUpdated = value; }
        public DateTime TicketDueDate { get => ticketDueDate; set => ticketDueDate = value; }
        public string TicketDescription { get => ticketDescription; set => ticketDescription = value; }
        public Technician TicketAssginedTechnician { get => ticketAssginedTechnician; set => ticketAssginedTechnician = value; }
        public Client TicketClientObject { get => ticketClientObject; set => ticketClientObject = value; }
        internal Employee TicketEmployeeObject { get => ticketEmployeeObject; set => ticketEmployeeObject = value; }


        public void CreateTicket()
        {

        }

        public void EsculateTicket()
        {

        }

        public void CloseTicket()
        {

        }

        public void EditTicket()
        {

        }

        public void AssignTechnician()
        {

        }

        public void ChangeTechnician()
        {

        }

        public void NotifyTechnician()
        {

        }

        public void GetEmployeeTickets()
        {

        }

        public void GetTotalTickets()
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
