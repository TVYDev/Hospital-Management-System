namespace RHPP_Management
{
    partial class frmDetailStaffReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalManagementDataSet1 = new RHPP_Management.HospitalManagementDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbStaffTableAdapter = new RHPP_Management.HospitalManagementDataSet1TableAdapters.tbStaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStaffBindingSource
            // 
            this.tbStaffBindingSource.DataMember = "tbStaff";
            this.tbStaffBindingSource.DataSource = this.HospitalManagementDataSet1;
            // 
            // HospitalManagementDataSet1
            // 
            this.HospitalManagementDataSet1.DataSetName = "HospitalManagementDataSet1";
            this.HospitalManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbStaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 733);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbStaffTableAdapter
            // 
            this.tbStaffTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetailStaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 733);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailStaffReport";
            this.Load += new System.EventHandler(this.frmDetailStaffReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalManagementDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbStaffBindingSource;
        private HospitalManagementDataSet1 HospitalManagementDataSet1;
        private HospitalManagementDataSet1TableAdapters.tbStaffTableAdapter tbStaffTableAdapter;
    }
}