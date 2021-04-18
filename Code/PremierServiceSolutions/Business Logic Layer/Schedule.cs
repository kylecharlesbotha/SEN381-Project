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
        private int ticketID;
        private string scheduleStatus;
        private int scheduleState;

        public Schedule(int scheduleID, DateTime scheduleDate, DateTime scheduleStartTime, DateTime scheduleEndTime, string scheduleStatus, int ticketID, int scheduleState)
        {
            this.scheduleID = scheduleID;
            this.scheduleDate = scheduleDate;
            this.scheduleStartTime = scheduleStartTime;
            this.scheduleEndTime = scheduleEndTime;
            this.ticketID = ticketID;
            this.scheduleStatus = scheduleStatus;
            this.scheduleState = scheduleState;
        }
        public Schedule()
        {

        }

        public int ScheduleID { get => scheduleID; set => scheduleID = value; }
        public DateTime ScheduleDate { get => scheduleDate; set => scheduleDate = value; }
        public DateTime ScheduleStartTime { get => scheduleStartTime; set => scheduleStartTime = value; }
        public DateTime ScheduleEndTime { get => scheduleEndTime; set => scheduleEndTime = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public string ScheduleStatus { get => scheduleStatus; set => scheduleStatus = value; }
        public int ScheduleState { get => scheduleState; set => scheduleState = value; }

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
