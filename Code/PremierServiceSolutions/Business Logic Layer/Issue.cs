using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Issue 
    {
        private string issueName;

        public Issue(string issueName)
        {
            this.issueName = issueName;
        }

        public string IssueName { get => issueName; set => issueName = value; }

        public List<Issue> GetAllIssues()
        {
            IssueDH objIssues = new IssueDH();
            List<Issue> lstIssues = objIssues.GetAll().ToList();
            return lstIssues;


        }

        public Issue()
        {

        }
    }
}
