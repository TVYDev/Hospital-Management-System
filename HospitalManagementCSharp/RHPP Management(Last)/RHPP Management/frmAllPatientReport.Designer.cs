namespace RHPP_Management
{
    partial class frmAllPatientReport
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
            this.prolistAllVisitPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListAllVisitPatientDataset = new RHPP_Management.ListAllVisitPatientDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prolistAllVisitPatientTableAdapter = new RHPP_Management.ListAllVisitPatientDatasetTableAdapters.prolistAllVisitPatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prolistAllVisitPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListAllVisitPatientDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // prolistAllVisitPatientBindingSource
            // 
            this.prolistAllVisitPatientBindingSource.DataMember = "prolistAllVisitPatient";
            this.prolistAllVisitPatientBindingSource.DataSource = this.ListAllVisitPatientDataset;
            // 
            // ListAllVisitPatientDataset
            // 
            this.ListAllVisitPatientDataset.DataSetName = "ListAllVisitPatientDataset";
            this.ListAllVisitPatientDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PatientHistoryAllDataset";
            reportDataSource1.Value = this.prolistAllVisitPatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1066, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // prolistAllVisitPatientTableAdapter
            // 
            this.prolistAllVisitPatientTableAdapter.ClearBeforeFill = true;
            // 
            // frmAllPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 588);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmAllPatientReport";
            this.Text = "frmAllPatientReport";
            this.Load += new System.EventHandler(this.frmAllPatientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prolistAllVisitPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListAllVisitPatientDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prolistAllVisitPatientBindingSource;
        private ListAllVisitPatientDataset ListAllVisitPatientDataset;
        private ListAllVisitPatientDatasetTableAdapters.prolistAllVisitPatientTableAdapter prolistAllVisitPatientTableAdapter;
    }
}