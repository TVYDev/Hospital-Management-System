namespace RHPP_Management
{
    partial class frmReportListAllBeds
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
            this.vAllBedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAllBeds = new RHPP_Management.DataSetAllBeds();
            this.vAllBedsTableAdapter = new RHPP_Management.DataSetAllBedsTableAdapters.vAllBedsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vAllBedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAllBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vAllBedsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // vAllBedsBindingSource
            // 
            this.vAllBedsBindingSource.DataMember = "vAllBeds";
            this.vAllBedsBindingSource.DataSource = this.DataSetAllBeds;
            // 
            // DataSetAllBeds
            // 
            this.DataSetAllBeds.DataSetName = "DataSetAllBeds";
            this.DataSetAllBeds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAllBedsTableAdapter
            // 
            this.vAllBedsTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportListAllBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 669);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportListAllBeds";
            this.Load += new System.EventHandler(this.frmReportListAllBeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vAllBedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAllBeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAllBedsBindingSource;
        private DataSetAllBeds DataSetAllBeds;
        private DataSetAllBedsTableAdapters.vAllBedsTableAdapter vAllBedsTableAdapter;




    }
}