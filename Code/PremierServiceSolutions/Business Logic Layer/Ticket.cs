using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Ticket
    {
        TicketDH objTicketDH = new TicketDH();
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
        private string clientID;
        private int employeeID;
        private DateTime ticketDate;
        private int countOnDate;

        private string clientName;


        public Ticket(int ticketID, int technicianID, string clientID, string ticketDescription, DateTime ticketDueDate, int employeeID, string ticketIssueType, DateTime ticketLastUpdated, DateTime ticketLoggedTime, string ticketPriority, string ticketStatus, string ticketTitle)
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
        public Ticket(int ticketID,int techID, string ticketTitle,string clientname, string ticketIssueType, string ticketPriority, string ticketStatus,DateTime datecreated,DateTime datedue,string tickdes)
        {
            this.ticketID = ticketID;
            this.technicianID = techID;
            this.ticketTitle = ticketTitle;
            this.ticketIssueType = ticketIssueType;
            this.ticketPriority = ticketPriority;
            this.ticketStatus = ticketStatus;
            this.clientName = clientname;
            this.ticketLoggedTime = datecreated;
            this.TicketDueDate = datedue;
            this.TicketDescription = tickdes;
        }



        //Constructor for getting date of tickets and number of tickets on that date
        public Ticket(DateTime date, int count)
        {
            this.TicketDate = date;
            this.CountOnDate = count; 
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
        public string ClientID { get => clientID; set => clientID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime TicketDate { get => ticketDate; set => ticketDate = value; }
        public int CountOnDate { get => countOnDate; set => countOnDate = value; }
        public string ClientName { get => clientName; set => clientName = value; }

        public void CreateTicket(Ticket objTicket)
        {
            objTicketDH.Create(objTicket);
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
        public List<Ticket> GetAllTicket()
        {

            try
            {
                TicketDH newobj = new TicketDH();
                List<Ticket> newtick = new List<Ticket>();
                newtick = newobj.GetAllActive();
                return newtick;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
                
            }
        }

        public int TicketCreated(Ticket objTicket)
        {
            try
            {
                int RecordID = objTicketDH.GetTicketCreated(objTicket);
                return RecordID;
            }
            catch (Exception E)
            {
                return 0;
               
            }
            
        }
    }
}
