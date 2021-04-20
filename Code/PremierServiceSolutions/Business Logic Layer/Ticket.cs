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
        private int technicianID;
        private int clientID;
        private int employeeID;



        public Ticket(int ticketID, int technicianID, int clientID, string ticketDescription, DateTime ticketDueDate, int employeeID, string ticketIssueType, DateTime ticketLastUpdated, DateTime ticketLoggedTime, string ticketPriority, string ticketStatus, string ticketTitle)
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
            this.technicianID = technicianID;
            this.clientID = clientID;
            this.employeeID = employeeID;
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
        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }

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
