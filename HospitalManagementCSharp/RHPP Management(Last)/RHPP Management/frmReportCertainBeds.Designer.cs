namespace RHPP_Management
{
    partial class frmReportCertainBeds
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
            this.DataSetCertainBeds = new RHPP_Management.DataSetCertainBeds();
            this.vAllBedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAllBedsTableAdapter = new RHPP_Management.DataSetCertainBedsTableAdapters.vAllBedsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCertainBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAllBedsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vAllBedsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RHPP_Management.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCertainBeds
            // 
            this.DataSetCertainBeds.DataSetName = "DataSetCertainBeds";
            this.DataSetCertainBeds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAllBedsBindingSource
            // 
            this.vAllBedsBindingSource.DataMember = "vAllBeds";
            this.vAllBedsBindingSource.DataSource = this.DataSetCertainBeds;
            // 
            // vAllBedsTableAdapter
            // 
            this.vAllBedsTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCertainBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 669);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportCertainBeds";
            this.Load += new System.EventHandler(this.frmReportCertainBeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCertainBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAllBedsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAllBedsBindingSource;
        private DataSetCertainBeds DataSetCertainBeds;
        private DataSetCertainBedsTableAdapters.vAllBedsTableAdapter vAllBedsTableAdapter;
    }
}