using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Call
    {
        private int callID;
        private Employee callEmployee;
        private DateTime callStartTime;
        private DateTime callEndTime;
        private Ticket callTicket;
        private Client callClient;
        private string callRecording;
        private string callState;

        public Call(int callID, Employee callEmployee, DateTime callStartTime, DateTime callEndTime, Ticket callTicket, Client callClient, string callRecording, string callState)
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
        public Call()
        {

        }
        public int CallID { get => callID; set => callID = value; }
        public Employee CallEmployee { get => callEmployee; set => callEmployee = value; }
        public DateTime CallStartTime { get => callStartTime; set => callStartTime = value; }
        public DateTime CallEndTime { get => callEndTime; set => callEndTime = value; }
        public Ticket CallTicket { get => callTicket; set => callTicket = value; }
        public Client CallClient { get => callClient; set => callClient = value; }
        public string CallRecording { get => callRecording; set => callRecording = value; }
        public string CallState { get => callState; set => callState = value; }


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
    }
}
