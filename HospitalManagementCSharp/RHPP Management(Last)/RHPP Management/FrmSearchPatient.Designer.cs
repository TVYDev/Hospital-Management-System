namespace RHPP_Management
{
    partial class FrmSearchPatient
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
            this.btnBackToCheckIn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearchPatient = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToCheckIn
            // 
            this.btnBackToCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToCheckIn.Location = new System.Drawing.Point(454, 16);
            this.btnBackToCheckIn.Name = "btnBackToCheckIn";
            this.btnBackToCheckIn.Size = new System.Drawing.Size(174, 30);
            this.btnBackToCheckIn.TabIndex = 1;
            this.btnBackToCheckIn.Text = "Add to Check In";
            this.btnBackToCheckIn.UseVisualStyleBackColor = true;
            this.btnBackToCheckIn.Click += new System.EventHandler(this.btnBackToCheckIn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(436, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dgvSearchPatient
            // 
            this.dgvSearchPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPatient.Location = new System.Drawing.Point(12, 52);
            this.dgvSearchPatient.Name = "dgvSearchPatient";
            this.dgvSearchPatient.Size = new System.Drawing.Size(732, 216);
            this.dgvSearchPatient.TabIndex = 3;
            this.dgvSearchPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchPatient_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(634, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvSearchPatient);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBackToCheckIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmSearchPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToCheckIn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearchPatient;
        private System.Windows.Forms.Button btnCancel;
    }
}