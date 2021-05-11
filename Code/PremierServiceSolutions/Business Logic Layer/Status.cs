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

        StatusDH objStatus = new StatusDH();


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
            List<Status> lstStatus = new List<Status>();
            try
            {
                lstStatus = objStatus.GetAll().ToList();
                return lstStatus;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                return lstStatus;
            }

        }
    }
}
