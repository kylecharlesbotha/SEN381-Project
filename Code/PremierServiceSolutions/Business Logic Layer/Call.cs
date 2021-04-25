using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Business_Logic_Layer
{
   
    class Call
    {
        CallDH objClientDH = new CallDH();
        private int callID;
        private string clientID;
        private Employee callEmployee;
        private int employeeID; 
        private DateTime callStartTime;
        private DateTime callEndTime;
        private Ticket callTicket;
        private int ticketID;
        private Client callClient;
        private string callRecording;
        private int callState;
        private string callstatus;

        public Call(int callID,Employee callEmployee, DateTime callStartTime, DateTime callEndTime, Ticket callTicket, Client callClient, string callRecording, int callState)
        {
            this.callID = callID;
            this.callEmployee = callEmployee;
            this.callStartTime = callStartTime;
            this.callEndTime = callEndTime;
            this.callTicket = callTicket;
            this.callClient = callClient;
            this.callRecording = callRecording;
            this.callState = callState;
            
        }
        public Call(int callID, string clientID, int employeeID, DateTime callStartTime, DateTime callEndTime, string callStatus, int ticketID, string callRecording, int callState)
        {
            this.callID = callID;
            this.clientID = clientID;
            this.employeeID = employeeID;
            this.callStartTime = callStartTime;
            this.callEndTime = callEndTime;
            this.ticketID = ticketID;
            this.callRecording = callRecording;
            this.callState = callState;
            this.callstatus = callStatus;
            
        }
        public Call()
        {

        }
        public int CallID { get => callID; set => callID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public Employee CallEmployee { get => callEmployee; set => callEmployee = value; }

        public DateTime CallStartTime { get => callStartTime; set => callStartTime = value; }
        public DateTime CallEndTime { get => callEndTime; set => callEndTime = value; }
        public Ticket CallTicket { get => callTicket; set => callTicket = value; }
        public Client CallClient { get => callClient; set => callClient = value; }
        public string CallRecording { get => callRecording; set => callRecording = value; }
        public int CallState { get => callState; set => callState = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public string Callstatus { get => callstatus; set => callstatus = value; }

        public void AnswerCall()
        {

        }

        public void StartTimer()
        {

        }

        public void RedirectCall()
        {

        }

        public void EndCall()
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

        public int ReturnCall(int EmployeeID,DateTime Time)
        {
            int value;
            try
            {
                value = objClientDH.FindCurrent(EmployeeID, Time);
                return value;
            }
            catch (Exception)
            {
                return 0;

            }       
            




        }

        public bool InsertCall(Call objcall)
        {
            try
            {
                bool inserted = objClientDH.Create(objcall);
                return inserted;
            }
            catch (Exception e)
            {
                MessageBox.Show("call.cs file"+e.Message);
                return false;
               
            }
            


        }


    }
}
