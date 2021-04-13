using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class DBHandler
    {
        private bool IsOnline = false;
        private readonly string Connection = @"Data Source =flystudio.co.za\FLYSTUDIOSERVER ; Initial Catalog= Premier_Service_Solutions; User ID=PremierServiceSolutions ;Password =BelgiumCampus";

        public string ConnectionVal { get => Connection; }

        private void IsServerConnected(string ConnectionString)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                try
                {
                    sqlCon.Open();
                    IsOnline = true;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    IsOnline = false;
                }

            }
        }

    }
}
