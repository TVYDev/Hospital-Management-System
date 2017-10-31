namespace RHPP_Management
{
    partial class frmPatientHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisplayName = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalTimesVisiting = new System.Windows.Forms.Label();
            this.lblLastVisit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dgvDetailVisit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblBedNumber = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblIll = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbPicUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDisplayName);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 617);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search";
            // 
            // dgvDisplayName
            // 
            this.dgvDisplayName.AllowUserToAddRows = false;
            this.dgvDisplayName.AllowUserToDeleteRows = false;
            this.dgvDisplayName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayName.ColumnHeadersHeight = 25;
            this.dgvDisplayName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplayName.Location = new System.Drawing.Point(11, 79);
            this.dgvDisplayName.Name = "dgvDisplayName";
            this.dgvDisplayName.ReadOnly = true;
            this.dgvDisplayName.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisplayName.RowHeadersVisible = false;
            this.dgvDisplayName.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDisplayName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDisplayName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplayName.Size = new System.Drawing.Size(319, 522);
            this.dgvDisplayName.TabIndex = 21;
            this.dgvDisplayName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayName_CellClick);
            this.dgvDisplayName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayName_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(319, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSearch_PreviewKeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(552, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 26);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            this.lblID.TextChanged += new System.EventHandler(this.lblID_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(552, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(552, 89);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(46, 26);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact number: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total times visiting RHPP";
            // 
            // lblTotalTimesVisiting
            // 
            this.lblTotalTimesVisiting.AutoSize = true;
            this.lblTotalTimesVisiting.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimesVisiting.Location = new System.Drawing.Point(633, 292);
            this.lblTotalTimesVisiting.Name = "lblTotalTimesVisiting";
            this.lblTotalTimesVisiting.Size = new System.Drawing.Size(65, 26);
            this.lblTotalTimesVisiting.TabIndex = 8;
            this.lblTotalTimesVisiting.Text = "label8";
            // 
            // lblLastVisit
            // 
            this.lblLastVisit.AutoSize = true;
            this.lblLastVisit.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastVisit.Location = new System.Drawing.Point(873, 292);
            this.lblLastVisit.Name = "lblLastVisit";
            this.lblLastVisit.Size = new System.Drawing.Size(65, 26);
            this.lblLastVisit.TabIndex = 10;
            this.lblLastVisit.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(873, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Last visit at RHPP";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(747, 156);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(150, 26);
            this.lblContact.TabIndex = 18;
            this.lblContact.Text = "Contact number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(747, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 26);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // dgvDetailVisit
            // 
            this.dgvDetailVisit.AllowUserToAddRows = false;
            this.dgvDetailVisit.AllowUserToDeleteRows = false;
            this.dgvDetailVisit.AllowUserToResizeColumns = false;
            this.dgvDetailVisit.AllowUserToResizeRows = false;
            this.dgvDetailVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailVisit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetailVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailVisit.ColumnHeadersVisible = false;
            this.dgvDetailVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.coDoctorID,
            this.coDoctorName,
            this.Column4,
            this.colDateIn,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDetailVisit.EnableHeadersVisualStyles = false;
            this.dgvDetailVisit.Location = new System.Drawing.Point(362, 376);
            this.dgvDetailVisit.Name = "dgvDetailVisit";
            this.dgvDetailVisit.ReadOnly = true;
            this.dgvDetailVisit.RowHeadersVisible = false;
            this.dgvDetailVisit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailVisit.Size = new System.Drawing.Size(936, 239);
            this.dgvDetailVisit.TabIndex = 21;
            this.dgvDetailVisit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailVisit_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Illness";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // coDoctorID
            // 
            this.coDoctorID.HeaderText = "DoctoreID";
            this.coDoctorID.Name = "coDoctorID";
            this.coDoctorID.ReadOnly = true;
            // 
            // coDoctorName
            // 
            this.coDoctorName.HeaderText = "Doctor Name";
            this.coDoctorName.Name = "coDoctorName";
            this.coDoctorName.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bed Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // colDateIn
            // 
            this.colDateIn.HeaderText = "Date In";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time In";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Out";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time Out";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIn.Location = new System.Drawing.Point(839, 349);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(72, 23);
            this.lblDateIn.TabIndex = 23;
            this.lblDateIn.Text = "Date IN";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.Location = new System.Drawing.Point(953, 349);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(67, 23);
            this.lblTimeIn.TabIndex = 24;
            this.lblTimeIn.Text = "Time In";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOut.Location = new System.Drawing.Point(1064, 349);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(73, 23);
            this.lblDateOut.TabIndex = 25;
            this.lblDateOut.Text = "Date out";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.Location = new System.Drawing.Point(1175, 349);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(78, 23);
            this.lblTimeOut.TabIndex = 26;
            this.lblTimeOut.Text = "Time Out";
            this.lblTimeOut.Click += new System.EventHandler(this.lblTimeOut_Click);
            // 
            // lblBedNumber
            // 
            this.lblBedNumber.AutoSize = true;
            this.lblBedNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedNumber.Location = new System.Drawing.Point(725, 349);
            this.lblBedNumber.Name = "lblBedNumber";
            this.lblBedNumber.Size = new System.Drawing.Size(100, 23);
            this.lblBedNumber.TabIndex = 27;
            this.lblBedNumber.Text = "Bed Number";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(495, 349);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(87, 23);
            this.lblDoctorID.TabIndex = 28;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // lblIll
            // 
            this.lblIll.AutoSize = true;
            this.lblIll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIll.Location = new System.Drawing.Point(385, 349);
            this.lblIll.Name = "lblIll";
            this.lblIll.Size = new System.Drawing.Size(59, 23);
            this.lblIll.TabIndex = 29;
            this.lblIll.Text = "Illness";
            this.lblIll.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(610, 349);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(101, 23);
            this.lblDoctorName.TabIndex = 30;
            this.lblDoctorName.Text = "DoctorName";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::RHPP_Management.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1202, 259);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 37);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::RHPP_Management.Properties.Resources.house_309113_1280;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1241, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(57, 46);
            this.btnHome.TabIndex = 14;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbPicUser
            // 
            this.pbPicUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicUser.Location = new System.Drawing.Point(378, 12);
            this.pbPicUser.Name = "pbPicUser";
            this.pbPicUser.Size = new System.Drawing.Size(160, 203);
            this.pbPicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicUser.TabIndex = 1;
            this.pbPicUser.TabStop = false;
            // 
            // frmPatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 639);
            this.ControlBox = false;
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblIll);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.lblBedNumber);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblDateOut);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.lblDateIn);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDetailVisit);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblLastVisit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalTimesVisiting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbPicUser);
            this.Controls.Add(this.panel1);
            this.Name = "frmPatientHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatientHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbPicUser;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalTimesVisiting;
        private System.Windows.Forms.Label lblLastVisit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dgvDisplayName;
        private System.Windows.Forms.DataGridView dgvDetailVisit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Label lblBedNumber;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblIll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnPrint;
    }
}