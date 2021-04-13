using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Schedule : IComparable<Schedule>
    {
        private int scheduleID;
        private DateTime scheduleDate;
        private DateTime scheduleStartTime;
        private DateTime scheduleEndTime;
        private Ticket ticketObject;
        private string scheduleStatus;

        public Schedule(int scheduleID, DateTime scheduleDate, DateTime scheduleStartTime, DateTime scheduleEndTime, Ticket ticketObject, string scheduleStatus)
        {
            this.scheduleID = scheduleID;
            this.scheduleDate = scheduleDate;
            this.scheduleStartTime = scheduleStartTime;
            this.scheduleEndTime = scheduleEndTime;
            this.ticketObject = ticketObject;
            this.scheduleStatus = scheduleStatus;
        }
        public Schedule()
        {

        }

        public int ScheduleID { get => scheduleID; set => scheduleID = value; }
        public DateTime ScheduleDate { get => scheduleDate; set => scheduleDate = value; }
        public DateTime ScheduleStartTime { get => scheduleStartTime; set => scheduleStartTime = value; }
        public DateTime ScheduleEndTime { get => scheduleEndTime; set => scheduleEndTime = value; }
        public Ticket TicketObject { get => ticketObject; set => ticketObject = value; }
        public string ScheduleStatus { get => scheduleStatus; set => scheduleStatus = value; }

        public int CompareTo(Schedule other)
        {
            throw new NotImplementedException();
        }

        public void GetScheduleDuration()
        {

        }
        public void GetOpenSchedule()
        {

        }

        public void GetTechnicianDetails()
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
