using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RHPP_Management
{
    public partial class frmReportCertainPatient : Form
    {
        string stID;
        public frmReportCertainPatient(string st)
        {
            InitializeComponent();
            stID = st;
        }

        private void frmReportCertainPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCertainPatient.tbPatient' table. You can move, or remove it, as needed.
            this.tbPatientTableAdapter.Fill(this.DataSetCertainPatient.tbPatient, stID);

            this.reportViewer1.RefreshReport();
        }
    }
}
