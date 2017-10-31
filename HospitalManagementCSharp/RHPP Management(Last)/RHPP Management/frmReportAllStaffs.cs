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
    public partial class frmReportAllStaffs : Form
    {
        public frmReportAllStaffs()
        {
            InitializeComponent();
        }

        private void frmReportAllStaffs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalManagementDataSet.tbStaff' table. You can move, or remove it, as needed.
            this.tbStaffTableAdapter.Fill(this.HospitalManagementDataSet.tbStaff);

            this.reportViewer1.RefreshReport();
        }
    }
}
