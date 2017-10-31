namespace RHPP_Management
{
    partial class frmReportAllStaffs
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalManagementDataSet = new RHPP_Management.HospitalManagementDataSet();
            this.tbStaffTableAdapter = new RHPP_Management.HospitalManagementDataSetTableAdapters.tbStaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbStaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1254, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbStaffBindingSource
            // 
            this.tbStaffBindingSource.DataMember = "tbStaff";
            this.tbStaffBindingSource.DataSource = this.HospitalManagementDataSet;
            // 
            // HospitalManagementDataSet
            // 
            this.HospitalManagementDataSet.DataSetName = "HospitalManagementDataSet";
            this.HospitalManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStaffTableAdapter
            // 
            this.tbStaffTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportAllStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 521);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportAllStaffs";
            this.Load += new System.EventHandler(this.frmReportAllStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbStaffBindingSource;
        private HospitalManagementDataSet HospitalManagementDataSet;
        private HospitalManagementDataSetTableAdapters.tbStaffTableAdapter tbStaffTableAdapter;
    }
}