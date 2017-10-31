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
    public partial class frmAllPatientReport : Form
    {
        public frmAllPatientReport()
        {
            InitializeComponent();
        }

        private void frmAllPatientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ListAllVisitPatientDataset.prolistAllVisitPatient' table. You can move, or remove it, as needed.
            this.prolistAllVisitPatientTableAdapter.Fill(this.ListAllVisitPatientDataset.prolistAllVisitPatient);

            this.reportViewer1.RefreshReport();
        }
    }
}
