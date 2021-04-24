using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Priority
    {
        private int priorityvalue;
        private string priorityname;

        public int Priorityvalue { get => priorityvalue; set => priorityvalue = value; }
        public string Priorityname { get => priorityname; set => priorityname = value; }

        public Priority(int priorityValue, string priorityName)
        {
            this.priorityname = priorityName;
            this.priorityvalue = priorityValue;
        }

       

        public List<Priority> GetAllPriority()
        {
            PriorityDH objPriority = new PriorityDH();
            List<Priority> lstPriority = objPriority.GetAll().ToList();
            return lstPriority;


        }

        public Priority()
        {

        }
    }
}
