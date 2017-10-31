namespace RHPP_Management
{
    partial class frmReportCheckInDay
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
            this.DataSetCheckInDay = new RHPP_Management.DataSetCheckInDay();
            this.pulldataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pulldataTableAdapter = new RHPP_Management.DataSetCheckInDayTableAdapters.pulldataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCheckInDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulldataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pulldataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(979, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCheckInDay
            // 
            this.DataSetCheckInDay.DataSetName = "DataSetCheckInDay";
            this.DataSetCheckInDay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pulldataBindingSource
            // 
            this.pulldataBindingSource.DataMember = "pulldata";
            this.pulldataBindingSource.DataSource = this.DataSetCheckInDay;
            // 
            // pulldataTableAdapter
            // 
            this.pulldataTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCheckInDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportCheckInDay";
            this.Text = "frmReportCheckInDay";
            this.Load += new System.EventHandler(this.frmReportCheckInDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCheckInDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulldataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pulldataBindingSource;
        private DataSetCheckInDay DataSetCheckInDay;
        private DataSetCheckInDayTableAdapters.pulldataTableAdapter pulldataTableAdapter;
    }
}