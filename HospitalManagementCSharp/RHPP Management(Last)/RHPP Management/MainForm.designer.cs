namespace WindowsFormsApplication3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblManageProfile = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pnAccountOptions = new System.Windows.Forms.Panel();
            this.lblStaffs = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.pbReports = new System.Windows.Forms.PictureBox();
            this.pbStaffs = new System.Windows.Forms.PictureBox();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.pbDoctors = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCheckOut = new System.Windows.Forms.PictureBox();
            this.pbCheckIn = new System.Windows.Forms.PictureBox();
            this.pbPatients = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pnAccountOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTimer.Enabled = false;
            this.txtTimer.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(277, 158);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(321, 34);
            this.txtTimer.TabIndex = 13;
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.BackColor = System.Drawing.Color.Silver;
            this.lblCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckOut.Location = new System.Drawing.Point(790, 271);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblCheckOut.Size = new System.Drawing.Size(427, 80);
            this.lblCheckOut.TabIndex = 18;
            this.lblCheckOut.Text = "CHECK OUT";
            this.lblCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckOut.Click += new System.EventHandler(this.lblCheckOut_Click);
            this.lblCheckOut.MouseEnter += new System.EventHandler(this.lblCheckOut_MouseEnter);
            this.lblCheckOut.MouseLeave += new System.EventHandler(this.lblCheckOut_MouseLeave);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.BackColor = System.Drawing.Color.Silver;
            this.lblCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckIn.Location = new System.Drawing.Point(218, 271);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblCheckIn.Size = new System.Drawing.Size(427, 80);
            this.lblCheckIn.TabIndex = 19;
            this.lblCheckIn.Text = "CHECK IN";
            this.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckIn.Click += new System.EventHandler(this.lblCheckIn_Click);
            this.lblCheckIn.MouseEnter += new System.EventHandler(this.lblCheckIn_MouseEnter);
            this.lblCheckIn.MouseLeave += new System.EventHandler(this.lblCheckIn_MouseLeave);
            // 
            // lblPatients
            // 
            this.lblPatients.BackColor = System.Drawing.Color.Silver;
            this.lblPatients.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPatients.Location = new System.Drawing.Point(218, 385);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPatients.Size = new System.Drawing.Size(427, 80);
            this.lblPatients.TabIndex = 20;
            this.lblPatients.Text = "PATIENT HISTORY";
            this.lblPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPatients.Click += new System.EventHandler(this.lblPatients_Click);
            this.lblPatients.MouseEnter += new System.EventHandler(this.lblPatients_MouseEnter);
            this.lblPatients.MouseLeave += new System.EventHandler(this.lblPatients_MouseLeave);
            // 
            // lblDoctors
            // 
            this.lblDoctors.BackColor = System.Drawing.Color.Silver;
            this.lblDoctors.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDoctors.Location = new System.Drawing.Point(790, 385);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblDoctors.Size = new System.Drawing.Size(427, 80);
            this.lblDoctors.TabIndex = 21;
            this.lblDoctors.Text = "DOCTORS";
            this.lblDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDoctors.Click += new System.EventHandler(this.lblDoctors_Click);
            this.lblDoctors.MouseEnter += new System.EventHandler(this.lblDoctors_MouseEnter);
            this.lblDoctors.MouseLeave += new System.EventHandler(this.lblDoctors_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(898, 155);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 24);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            this.lblUsername.MouseEnter += new System.EventHandler(this.lblUsername_MouseEnter);
            this.lblUsername.MouseLeave += new System.EventHandler(this.lblUsername_MouseLeave);
            // 
            // lblManageProfile
            // 
            this.lblManageProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblManageProfile.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManageProfile.Location = new System.Drawing.Point(-1, 9);
            this.lblManageProfile.Name = "lblManageProfile";
            this.lblManageProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblManageProfile.Size = new System.Drawing.Size(142, 20);
            this.lblManageProfile.TabIndex = 27;
            this.lblManageProfile.Text = "Manage Profile";
            this.lblManageProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageProfile.Click += new System.EventHandler(this.lblManageProfile_Click);
            this.lblManageProfile.MouseEnter += new System.EventHandler(this.lblManageProfile_MouseEnter);
            this.lblManageProfile.MouseLeave += new System.EventHandler(this.lblManageProfile_MouseLeave);
            // 
            // lblLogOut
            // 
            this.lblLogOut.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOut.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogOut.Location = new System.Drawing.Point(0, 36);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblLogOut.Size = new System.Drawing.Size(141, 20);
            this.lblLogOut.TabIndex = 28;
            this.lblLogOut.Text = "Log out";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            this.lblLogOut.MouseEnter += new System.EventHandler(this.lblLogOut_MouseEnter);
            this.lblLogOut.MouseLeave += new System.EventHandler(this.lblLogOut_MouseLeave);
            // 
            // pnAccountOptions
            // 
            this.pnAccountOptions.BackColor = System.Drawing.Color.AliceBlue;
            this.pnAccountOptions.Controls.Add(this.lblManageProfile);
            this.pnAccountOptions.Controls.Add(this.lblLogOut);
            this.pnAccountOptions.Location = new System.Drawing.Point(902, 182);
            this.pnAccountOptions.Name = "pnAccountOptions";
            this.pnAccountOptions.Size = new System.Drawing.Size(141, 67);
            this.pnAccountOptions.TabIndex = 29;
            // 
            // lblStaffs
            // 
            this.lblStaffs.BackColor = System.Drawing.Color.Silver;
            this.lblStaffs.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStaffs.Location = new System.Drawing.Point(218, 500);
            this.lblStaffs.Name = "lblStaffs";
            this.lblStaffs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblStaffs.Size = new System.Drawing.Size(427, 80);
            this.lblStaffs.TabIndex = 31;
            this.lblStaffs.Text = "STAFFS";
            this.lblStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStaffs.Click += new System.EventHandler(this.lblStaffs_Click);
            this.lblStaffs.MouseEnter += new System.EventHandler(this.lblStaffs_MouseEnter);
            this.lblStaffs.MouseLeave += new System.EventHandler(this.lblStaffs_MouseLeave);
            // 
            // lblReports
            // 
            this.lblReports.BackColor = System.Drawing.Color.Silver;
            this.lblReports.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReports.Location = new System.Drawing.Point(790, 500);
            this.lblReports.Name = "lblReports";
            this.lblReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblReports.Size = new System.Drawing.Size(427, 80);
            this.lblReports.TabIndex = 33;
            this.lblReports.Text = "REPORTS";
            this.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            this.lblReports.MouseEnter += new System.EventHandler(this.lblReports_MouseEnter);
            this.lblReports.MouseLeave += new System.EventHandler(this.lblReports_MouseLeave);
            // 
            // pbReports
            // 
            this.pbReports.BackColor = System.Drawing.Color.DimGray;
            this.pbReports.BackgroundImage = global::RHPP_Management.Properties.Resources.reports;
            this.pbReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReports.Location = new System.Drawing.Point(710, 500);
            this.pbReports.Name = "pbReports";
            this.pbReports.Size = new System.Drawing.Size(80, 80);
            this.pbReports.TabIndex = 32;
            this.pbReports.TabStop = false;
            this.pbReports.Click += new System.EventHandler(this.pbReports_Click);
            this.pbReports.MouseEnter += new System.EventHandler(this.pbReports_MouseEnter);
            this.pbReports.MouseLeave += new System.EventHandler(this.pbReports_MouseLeave);
            // 
            // pbStaffs
            // 
            this.pbStaffs.BackColor = System.Drawing.Color.DimGray;
            this.pbStaffs.BackgroundImage = global::RHPP_Management.Properties.Resources.staffs;
            this.pbStaffs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStaffs.Location = new System.Drawing.Point(138, 500);
            this.pbStaffs.Name = "pbStaffs";
            this.pbStaffs.Size = new System.Drawing.Size(80, 80);
            this.pbStaffs.TabIndex = 30;
            this.pbStaffs.TabStop = false;
            this.pbStaffs.Click += new System.EventHandler(this.pbStaffs_Click);
            this.pbStaffs.MouseEnter += new System.EventHandler(this.pbStaffs_MouseEnter);
            this.pbStaffs.MouseLeave += new System.EventHandler(this.pbStaffs_MouseLeave);
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.pbUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUserPicture.Location = new System.Drawing.Point(843, 143);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(49, 49);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPicture.TabIndex = 24;
            this.pbUserPicture.TabStop = false;
            this.pbUserPicture.Click += new System.EventHandler(this.pbUserPicture_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::RHPP_Management.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(1278, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::RHPP_Management.Properties.Resources.About_us_128;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Location = new System.Drawing.Point(1203, 630);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 60);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 16;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // pbDoctors
            // 
            this.pbDoctors.BackColor = System.Drawing.Color.DimGray;
            this.pbDoctors.BackgroundImage = global::RHPP_Management.Properties.Resources.Head_physician;
            this.pbDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDoctors.Location = new System.Drawing.Point(710, 385);
            this.pbDoctors.Name = "pbDoctors";
            this.pbDoctors.Size = new System.Drawing.Size(80, 80);
            this.pbDoctors.TabIndex = 15;
            this.pbDoctors.TabStop = false;
            this.pbDoctors.Click += new System.EventHandler(this.btnDoctor_Click);
            this.pbDoctors.MouseEnter += new System.EventHandler(this.btnDoctor_MouseEnter);
            this.pbDoctors.MouseLeave += new System.EventHandler(this.btnDoctor_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(260, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbCheckOut
            // 
            this.pbCheckOut.BackColor = System.Drawing.Color.DimGray;
            this.pbCheckOut.BackgroundImage = global::RHPP_Management.Properties.Resources._2_128;
            this.pbCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCheckOut.Location = new System.Drawing.Point(710, 271);
            this.pbCheckOut.Name = "pbCheckOut";
            this.pbCheckOut.Size = new System.Drawing.Size(80, 80);
            this.pbCheckOut.TabIndex = 7;
            this.pbCheckOut.TabStop = false;
            this.pbCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            this.pbCheckOut.MouseEnter += new System.EventHandler(this.btnCheckOut_MouseEnter);
            this.pbCheckOut.MouseLeave += new System.EventHandler(this.btnCheckOut_MouseLeave);
            // 
            // pbCheckIn
            // 
            this.pbCheckIn.BackColor = System.Drawing.Color.DimGray;
            this.pbCheckIn.BackgroundImage = global::RHPP_Management.Properties.Resources.checkin_icon1;
            this.pbCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCheckIn.Location = new System.Drawing.Point(138, 271);
            this.pbCheckIn.Name = "pbCheckIn";
            this.pbCheckIn.Size = new System.Drawing.Size(80, 80);
            this.pbCheckIn.TabIndex = 6;
            this.pbCheckIn.TabStop = false;
            this.pbCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.pbCheckIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCheckIn_MouseClick);
            this.pbCheckIn.MouseEnter += new System.EventHandler(this.btnCheckIn_MouseEnter);
            this.pbCheckIn.MouseLeave += new System.EventHandler(this.btnCheckIn_MouseLeave);
            // 
            // pbPatients
            // 
            this.pbPatients.BackColor = System.Drawing.Color.DimGray;
            this.pbPatients.BackgroundImage = global::RHPP_Management.Properties.Resources._8_128;
            this.pbPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPatients.Location = new System.Drawing.Point(138, 385);
            this.pbPatients.Name = "pbPatients";
            this.pbPatients.Size = new System.Drawing.Size(80, 80);
            this.pbPatients.TabIndex = 5;
            this.pbPatients.TabStop = false;
            this.pbPatients.Click += new System.EventHandler(this.btnPatient_Click);
            this.pbPatients.MouseEnter += new System.EventHandler(this.btnPatient_MouseEnter);
            this.pbPatients.MouseLeave += new System.EventHandler(this.btnPatient_MouseLeave);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(1059, 209);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(35, 13);
            this.lblUserID.TabIndex = 34;
            this.lblUserID.Text = "label1";
            this.lblUserID.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RHPP_Management.Properties.Resources.healthcare_loop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.pbReports);
            this.Controls.Add(this.lblStaffs);
            this.Controls.Add(this.pbStaffs);
            this.Controls.Add(this.pnAccountOptions);
            this.Controls.Add(this.pbUserPicture);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.lblPatients);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pbDoctors);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCheckOut);
            this.Controls.Add(this.pbCheckIn);
            this.Controls.Add(this.pbPatients);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Hospital of Phnom Penh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.pnAccountOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPatients;
        private System.Windows.Forms.PictureBox pbCheckIn;
        private System.Windows.Forms.PictureBox pbCheckOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.PictureBox pbDoctors;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblManageProfile;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Panel pnAccountOptions;
        public System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.PictureBox pbStaffs;
        private System.Windows.Forms.Label lblStaffs;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.PictureBox pbReports;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblUserID;

    }
}

