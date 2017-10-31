namespace RHPP_Management
{
    partial class frmReportCertainPatient
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
            this.DataSetCertainPatient = new RHPP_Management.DataSetCertainPatient();
            this.tbPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPatientTableAdapter = new RHPP_Management.DataSetCertainPatientTableAdapters.tbPatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCertainPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbPatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 733);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCertainPatient
            // 
            this.DataSetCertainPatient.DataSetName = "DataSetCertainPatient";
            this.DataSetCertainPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPatientBindingSource
            // 
            this.tbPatientBindingSource.DataMember = "tbPatient";
            this.tbPatientBindingSource.DataSource = this.DataSetCertainPatient;
            // 
            // tbPatientTableAdapter
            // 
            this.tbPatientTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCertainPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 733);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportCertainPatient";
            this.Load += new System.EventHandler(this.frmReportCertainPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCertainPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbPatientBindingSource;
        private DataSetCertainPatient DataSetCertainPatient;
        private DataSetCertainPatientTableAdapters.tbPatientTableAdapter tbPatientTableAdapter;
    }
}