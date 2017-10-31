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
    public partial class frmPatientReport : Form
    {

        string st;
        public frmPatientReport()
        {
            InitializeComponent();
        }

        public frmPatientReport(String st) {
            this.st = st;
            InitializeComponent();
        }

        private void frmPatientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPatientHIstoryDataset.procFindUserHistory' table. You can move, or remove it, as needed.
            this.procFindUserHistoryTableAdapter.Fill(this.dsPatientHIstoryDataset.procFindUserHistory,st);
            // TODO: This line of code loads data into the 'PatientHistoryDataset.DataTable1' table. You can move, or remove it, as needed.
          

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
