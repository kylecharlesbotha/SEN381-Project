using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Status
    {


        private int statusID;
        private string statusName;



        public Status()
        {

        }

        public Status(int statusID, string statusName)
        {
            this.statusID = statusID;
            this.statusName = statusName;
        }

        public int StatusID { get => statusID; set => statusID = value; }
        public string StatusName { get => statusName; set => statusName = value; }

        public List<Status> GetAll()
        {
            StatusDH objStatus = new StatusDH();
            List<Status> lstStatus = objStatus.GetAll().ToList();
            return lstStatus;

        }
    }
}
