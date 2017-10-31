using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RHPP_Management
{
    public partial class frmReportCheckInSingleDay : Form
    {
        string stDate;
        public frmReportCheckInSingleDay(string stDate)
        {
            InitializeComponent();
            this.stDate = stDate;
        }

        private void frmReportCheckInSingleDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCheckInSingleDay.pulldata' table. You can move, or remove it, as needed.
            this.pulldataTableAdapter.Fill(this.DataSetCheckInSingleDay.pulldata,stDate);

            this.reportViewer1.RefreshReport();
        }
    }
}
