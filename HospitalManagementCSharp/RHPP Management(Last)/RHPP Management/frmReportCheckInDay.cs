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
    public partial class frmReportCheckInDay : Form
    {
        string stDate;
        public frmReportCheckInDay(string stDate)
        {
            InitializeComponent();
            this.stDate = stDate;
        }

        private void frmReportCheckInDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCheckInDay.pulldata' table. You can move, or remove it, as needed.
            this.pulldataTableAdapter.Fill(this.DataSetCheckInDay.pulldata, stDate);

            this.reportViewer1.RefreshReport();
        }
    }
}
