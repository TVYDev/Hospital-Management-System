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
    public partial class frmReportStaffsCertainPositions : Form
    {
        String[] st = new String[5];
        public frmReportStaffsCertainPositions(String[] st)
        {
            InitializeComponent();
            this.st = st;
        }

        private void frmReportStaffsCertainPositions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetStaffsCertainPositions.tbStaff' table. You can move, or remove it, as needed.
            this.tbStaffTableAdapter.Fill(this.DataSetStaffsCertainPositions.tbStaff, st[0], st[1], st[2], st[3], st[4]);

            this.reportViewer1.RefreshReport();
        }
    }
}
