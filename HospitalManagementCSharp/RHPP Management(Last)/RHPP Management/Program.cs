using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RHPP_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Assignment.frmCheckout());
            Application.Run(new Hospital_Management.frmLogin());
            //Application.Run(new WindowsFormsApplication3.MainForm());
            //Application.Run(new Doctor.frmDoctors());
            //Application.Run(new WindowsFormsApplication3.MainForm());
            //Application.Run(new RHPP_Management.frmReportAllStaffs());
            //Application.Run(new RHPP_Management.frmDetailStaffReport());
            //Application.Run(new RHPP_Management.frmReport());
            //Application.Run(new RHPP_Management.frmPatientReport("P"));
            //Application.Run(new RHPP_Management.frmReportAllPatients());
            //Application.Run(new Check_In1.frmCheckIn());
        }
    }
}

