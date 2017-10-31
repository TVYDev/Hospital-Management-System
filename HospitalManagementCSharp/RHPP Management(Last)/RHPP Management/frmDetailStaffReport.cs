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
    public partial class frmDetailStaffReport : Form
    {
        String stID;
        public frmDetailStaffReport(String st)
        {
            InitializeComponent();
            stID = st;
        }

        private void frmDetailStaffReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalManagementDataSet1.tbStaff' table. You can move, or remove it, as needed.
            this.tbStaffTableAdapter.Fill(this.HospitalManagementDataSet1.tbStaff, stID);

            this.reportViewer1.RefreshReport();
        }
    }
}
