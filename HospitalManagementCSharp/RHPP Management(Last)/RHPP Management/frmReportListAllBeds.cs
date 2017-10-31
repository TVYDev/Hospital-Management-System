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
    public partial class frmReportListAllBeds : Form
    {
        public frmReportListAllBeds()
        {
            InitializeComponent();
        }

        private void frmReportListAllBeds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAllBeds.tbRoom' table. You can move, or remove it, as needed.
            this.vAllBedsTableAdapter.Fill(this.DataSetAllBeds.vAllBeds);
            

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
