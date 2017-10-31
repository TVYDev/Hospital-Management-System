namespace RHPP_Management
{
    partial class frmReportCheckInSingleDay
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
            this.pulldataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCheckInSingleDay = new RHPP_Management.DataSetCheckInSingleDay();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pulldataTableAdapter = new RHPP_Management.DataSetCheckInSingleDayTableAdapters.pulldataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pulldataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCheckInSingleDay)).BeginInit();
            this.SuspendLayout();
            // 
            // pulldataBindingSource
            // 
            this.pulldataBindingSource.DataMember = "pulldata";
            this.pulldataBindingSource.DataSource = this.DataSetCheckInSingleDay;
            // 
            // DataSetCheckInSingleDay
            // 
            this.DataSetCheckInSingleDay.DataSetName = "DataSetCheckInSingleDay";
            this.DataSetCheckInSingleDay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pulldataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1000, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // pulldataTableAdapter
            // 
            this.pulldataTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCheckInSingleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 493);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportCheckInSingleDay";
            this.Load += new System.EventHandler(this.frmReportCheckInSingleDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulldataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCheckInSingleDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pulldataBindingSource;
        private DataSetCheckInSingleDay DataSetCheckInSingleDay;
        private DataSetCheckInSingleDayTableAdapters.pulldataTableAdapter pulldataTableAdapter;
    }
}