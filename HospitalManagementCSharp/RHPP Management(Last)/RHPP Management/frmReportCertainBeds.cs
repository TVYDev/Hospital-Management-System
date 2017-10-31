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
    public partial class frmReportCertainBeds : Form
    {
        string[] st = new string[2];
        public frmReportCertainBeds(string[] st)
        {
            InitializeComponent();
            this.st = st;
        }

        private void frmReportCertainBeds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCertainBeds.vAllBeds' table. You can move, or remove it, as needed.
            this.vAllBedsTableAdapter.Fill(this.DataSetCertainBeds.vAllBeds, st[0], st[1]);

            this.reportViewer1.RefreshReport();
        }
    }
}
