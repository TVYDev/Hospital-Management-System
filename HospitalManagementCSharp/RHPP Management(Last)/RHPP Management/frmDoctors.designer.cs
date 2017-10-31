namespace Doctor
{
    partial class frmDoctors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.btClean = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGirdviewDoctor = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.txtEN = new System.Windows.Forms.MaskedTextBox();
            this.txtCN = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSpecail = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdviewDoctor)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(17, 206);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(181, 38);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Photo
            // 
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Photo.Location = new System.Drawing.Point(18, 10);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(181, 190);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 22;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // btClean
            // 
            this.btClean.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.Location = new System.Drawing.Point(900, 14);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(204, 41);
            this.btClean.TabIndex = 7;
            this.btClean.Text = "Clear";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(669, 14);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(204, 41);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(433, 14);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(204, 41);
            this.bt_Edit.TabIndex = 1;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(203, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(204, 42);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "New";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::RHPP_Management.Properties.Resources.house_309113_1280;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1286, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 43);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 39);
            this.label11.TabIndex = 7;
            this.label11.Text = "Doctor Information";
            // 
            // dataGirdviewDoctor
            // 
            this.dataGirdviewDoctor.AllowUserToAddRows = false;
            this.dataGirdviewDoctor.AllowUserToDeleteRows = false;
            this.dataGirdviewDoctor.AllowUserToResizeColumns = false;
            this.dataGirdviewDoctor.AllowUserToResizeRows = false;
            this.dataGirdviewDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGirdviewDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGirdviewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGirdviewDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGirdviewDoctor.EnableHeadersVisualStyles = false;
            this.dataGirdviewDoctor.Location = new System.Drawing.Point(16, 42);
            this.dataGirdviewDoctor.Name = "dataGirdviewDoctor";
            this.dataGirdviewDoctor.ReadOnly = true;
            this.dataGirdviewDoctor.RowHeadersVisible = false;
            this.dataGirdviewDoctor.RowHeadersWidth = 180;
            this.dataGirdviewDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGirdviewDoctor.Size = new System.Drawing.Size(1277, 236);
            this.dataGirdviewDoctor.TabIndex = 8;
            this.dataGirdviewDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirdviewDoctor_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(16, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1277, 29);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Search here.......";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGirdviewDoctor);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(18, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1313, 288);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID";
            // 
            // DOB
            // 
            this.DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.CustomFormat = "";
            this.DOB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB.Location = new System.Drawing.Point(224, 129);
            this.DOB.MaxDate = new System.DateTime(2018, 2, 24, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(146, 34);
            this.DOB.TabIndex = 40;
            this.DOB.Value = new System.DateTime(2017, 1, 28, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 26);
            this.label10.TabIndex = 39;
            this.label10.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 26);
            this.label8.TabIndex = 38;
            this.label8.Text = "Specialization";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(163, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 34);
            this.txtEmail.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Email";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(224, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 34);
            this.txtID.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Emergency Number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(224, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 34);
            this.txtName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(163, 98);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(359, 143);
            this.txtAddress.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 43;
            this.label7.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Photo);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Location = new System.Drawing.Point(18, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 256);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rFemale);
            this.panel2.Controls.Add(this.rMale);
            this.panel2.Controls.Add(this.txtEN);
            this.panel2.Controls.Add(this.txtCN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DOB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(241, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 256);
            this.panel2.TabIndex = 45;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFemale.Location = new System.Drawing.Point(348, 93);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(92, 30);
            this.rFemale.TabIndex = 45;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Checked = true;
            this.rMale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMale.Location = new System.Drawing.Point(227, 92);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(72, 30);
            this.rMale.TabIndex = 44;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEN.Location = new System.Drawing.Point(224, 209);
            this.txtEN.Mask = "(999) 000-0000";
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(224, 34);
            this.txtEN.TabIndex = 43;
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(224, 168);
            this.txtCN.Mask = "(999) 000-0000";
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(224, 34);
            this.txtCN.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSpecail);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(783, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 259);
            this.panel3.TabIndex = 46;
            // 
            // txtSpecail
            // 
            this.txtSpecail.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecail.FormattingEnabled = true;
            this.txtSpecail.Items.AddRange(new object[] {
            "General",
            "Eyes",
            "Heart",
            "Cancer",
            "Brain"});
            this.txtSpecail.Location = new System.Drawing.Point(163, 58);
            this.txtSpecail.Name = "txtSpecail";
            this.txtSpecail.Size = new System.Drawing.Size(265, 34);
            this.txtSpecail.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btAdd);
            this.panel5.Controls.Add(this.bt_Edit);
            this.panel5.Controls.Add(this.btDelete);
            this.panel5.Controls.Add(this.btClean);
            this.panel5.Location = new System.Drawing.Point(18, 331);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1313, 71);
            this.panel5.TabIndex = 47;
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnHome);
            this.Name = "frmDoctors";
            this.Text = "Doctor Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdviewDoctor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGirdviewDoctor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox txtEN;
        private System.Windows.Forms.MaskedTextBox txtCN;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.ComboBox txtSpecail;
    }
}

