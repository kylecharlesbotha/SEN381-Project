using PremierServiceSolutions.Presentation_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PremierServiceSolutions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1NjczQDMxMzkyZTMxMmUzMG5iQ0d1SVgxOUFQajJnd3p4WEw4Q1E5T0c4V29vWEZWZWVQMGpOMXZ3Nm89");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashBoard());

        }

    }
}
