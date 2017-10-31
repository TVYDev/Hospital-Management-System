using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
    
{
    public partial class MainForm : Form
    {
        SqlCommand com;
        SqlDataReader dr;

        Color unselectedColorPb = Color.FromArgb(140, 35, 95, 205);
        Color unselectedColorLbl = Color.FromArgb(100, 35, 95, 205);
        Color selectedColorPb = Color.FromArgb(140,150, 170, 185);
        Color selectedColorLbl = Color.FromArgb(100, 150, 170, 185);

        public string lblUserIDText {
            get {
                return lblUserID.Text;
            }
            set {
                lblUserID.Text = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbCheckIn.BackColor = unselectedColorPb;
            pbCheckOut.BackColor = unselectedColorPb;
            pbPatients.BackColor = unselectedColorPb;
            pbDoctors.BackColor = unselectedColorPb;
            pbStaffs.BackColor = unselectedColorPb;
            pbReports.BackColor = unselectedColorPb;

            lblCheckIn.BackColor = unselectedColorLbl;
            lblCheckOut.BackColor = unselectedColorLbl;
            lblPatients.BackColor = unselectedColorLbl;
            lblDoctors.BackColor = unselectedColorLbl;
            lblStaffs.BackColor = unselectedColorLbl;
            lblReports.BackColor = unselectedColorLbl;

            pbUserPicture.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.adminLogin);
            pbUserPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserPicture.BorderStyle = BorderStyle.None;
            
            Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(time_Tick);
            time.Start();

            pnAccountOptions.Visible = false;

            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT TOP 1 lNo, A.sID, sName, sPhoto FROM tbStaff A INNER JOIN tbLogin B ON A.sID=B.sID ORDER BY lNo DESC";
            dr = com.ExecuteReader();
            dr.Read();
            lblUserID.Text = dr[1].ToString();
            lblUsername.Text = dr[2].ToString();

            if (lblUsername.Text != "admin")
            {
                MemoryStream ms;
                ms = new MemoryStream((Byte[])dr[3]);
                pbUserPicture.SizeMode = PictureBoxSizeMode.Zoom;
                pbUserPicture.Image = Image.FromStream(ms);
            }
            else 
            {
                pbUserPicture.Image = (Image)(RHPP_Management.Properties.Resources.adminLogin);
            }
            dr.Close();
            com.Dispose();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString("dd/MM/yyyy      hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            pbCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Check_In1.frmCheckIn checkIn = new Check_In1.frmCheckIn();
            checkIn.Show();
            this.Visible = false;
        }

        private void btnCheckIn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            pbCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          RHPP_Management.frmCheckout Checkout = new RHPP_Management.frmCheckout();
            Checkout.ShowDialog();
            this.Visible = false;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            pbDoctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Doctor.frmDoctors doctor = new Doctor.frmDoctors(lblUserIDText);
            doctor.Show();
            this.Visible = false;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            pbPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //WindowsFormsApplication3.Form2 patient = new WindowsFormsApplication3.Form2();
            RHPP_Management.frmPatientHistory patient = new RHPP_Management.frmPatientHistory();
            patient.Show();
            this.Visible = false;
        }

        private void btnCheckOut_MouseEnter(object sender, EventArgs e)
        {
            pbCheckOut.BackColor = selectedColorPb;
            lblCheckOut.BackColor = selectedColorLbl;
        }

        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            pbCheckOut.BackColor = unselectedColorPb;
            lblCheckOut.BackColor = unselectedColorLbl;
        }

        private void btnCheckIn_MouseEnter(object sender, EventArgs e)
        {
            pbCheckIn.BackColor = selectedColorPb;
            lblCheckIn.BackColor = selectedColorPb;
        }

        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            pbCheckIn.BackColor = unselectedColorLbl;
            lblCheckIn.BackColor = unselectedColorLbl;
        }

        private void btnDoctor_MouseEnter(object sender, EventArgs e)
        {
            pbDoctors.BackColor = selectedColorPb;
            lblDoctors.BackColor = selectedColorLbl;
        }

        private void btnDoctor_MouseLeave(object sender, EventArgs e)
        {
            pbDoctors.BackColor = unselectedColorPb;
            lblDoctors.BackColor = unselectedColorLbl;
        }

        private void btnPatient_MouseEnter(object sender, EventArgs e)
        {
            pbPatients.BackColor = selectedColorPb;
            lblPatients.BackColor = selectedColorLbl;
        }

        private void btnPatient_MouseLeave(object sender, EventArgs e)
        {
            pbPatients.BackColor = unselectedColorPb;
            lblPatients.BackColor = unselectedColorLbl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout fabout= new  FrmAbout();
            fabout.ShowDialog();
            //this.Close();

        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "RHPP", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                com.CommandText = "UPDATE tbLogin SET dateOut=Convert(date,getDate()), timeOut=Convert(time,getDate()) WHERE sID='" + lblUserID.Text + "' AND lNo=(SELECT MAX(lNo) FROM tbLogin)";
                com.ExecuteNonQuery();
                com.Dispose();
                Environment.Exit(0);
            }
            else
            {
                ;
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = System.Drawing.Color.Transparent;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "RHPP", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    com = new SqlCommand();
                    com.Connection = Hospital_Management.frmLogin.con;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "UPDATE tbLogin SET dateOut=Convert(date,getDate()), timeOut=Convert(time,getDate()) WHERE sID='" + lblUserID.Text + "' AND lNo=(SELECT MAX(lNo) FROM tbLogin)";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else {
                e.Cancel = true;
            }
        }

        private void lblManageProfile_MouseEnter(object sender, EventArgs e)
        {
            lblManageProfile.BackColor = Color.LightBlue;
        }

        private void lblManageProfile_MouseLeave(object sender, EventArgs e)
        {
            lblManageProfile.BackColor = Color.Transparent;
        }

        private void lblLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.LightBlue;
        }

        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.Transparent;
        }

        private void btnAccountOptions_Click(object sender, EventArgs e)
        {
            pnAccountOptions.Visible = true;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            pnAccountOptions.Visible = false;
        }

        private void lblManageProfile_Click(object sender, EventArgs e)
        {
            RHPP_Management.frmAccountSettings accSetting = new RHPP_Management.frmAccountSettings(this);
            
            pnAccountOptions.Visible = false;
            accSetting.ShowDialog();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "UPDATE tbLogin SET dateOut=Convert(date,getDate()), timeOut=Convert(time,getDate()) WHERE sID='" + lblUserID.Text +"' AND lNo=(SELECT MAX(lNo) FROM tbLogin)";
            com.ExecuteNonQuery();
            com.Dispose();

            Hospital_Management.frmLogin login = new Hospital_Management.frmLogin();
            pnAccountOptions.Visible = false;
            login.Visible = true;
            this.Visible = false;
        }

        private void lblCheckIn_MouseEnter(object sender, EventArgs e)
        {
            btnCheckIn_MouseEnter(sender, e);
        }

        private void lblCheckIn_MouseLeave(object sender, EventArgs e)
        {
            btnCheckIn_MouseLeave(sender, e);
        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {
            btnCheckIn_Click(sender, e);
        }

        private void lblCheckOut_MouseEnter(object sender, EventArgs e)
        {
            btnCheckOut_MouseEnter(sender, e);
        }

        private void lblCheckOut_MouseLeave(object sender, EventArgs e)
        {
            btnCheckOut_MouseLeave(sender, e);
        }

        private void lblCheckOut_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(sender, e);
        }

        private void lblPatients_MouseEnter(object sender, EventArgs e)
        {
            btnPatient_MouseEnter(sender, e);
        }

        private void lblDoctors_MouseEnter(object sender, EventArgs e)
        {
            btnDoctor_MouseEnter(sender, e);
        }

        private void lblDoctors_MouseLeave(object sender, EventArgs e)
        {
            btnDoctor_MouseLeave(sender, e);
        }

        private void lblDoctors_Click(object sender, EventArgs e)
        {
            btnDoctor_Click(sender, e);
        }

        private void lblPatients_MouseLeave(object sender, EventArgs e)
        {
            btnPatient_MouseLeave(sender, e);
        }

        private void lblPatients_Click(object sender, EventArgs e)
        {
            btnPatient_Click(sender, e);
        }

        private void pbStaffs_Click(object sender, EventArgs e)
        {
            pbStaffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            RHPP_Management.frmStaffs frmStaffs = new RHPP_Management.frmStaffs(lblUserIDText);
            frmStaffs.Show();
            this.Visible = false;
        }

        private void pbStaffs_MouseEnter(object sender, EventArgs e)
        {
            pbStaffs.BackColor = selectedColorPb;
            lblStaffs.BackColor = selectedColorLbl;
        }

        private void pbStaffs_MouseLeave(object sender, EventArgs e)
        {
            pbStaffs.BackColor = unselectedColorPb;
            lblStaffs.BackColor = unselectedColorLbl;
        }

        private void lblStaffs_Click(object sender, EventArgs e)
        {
            pbStaffs_Click(sender, e);
        }

        private void lblStaffs_MouseEnter(object sender, EventArgs e)
        {
            pbStaffs_MouseEnter(sender, e);
        }

        private void lblStaffs_MouseLeave(object sender, EventArgs e)
        {
            pbStaffs_MouseLeave(sender, e);
        }

        private void pbReports_Click(object sender, EventArgs e)
        {
            pbReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            RHPP_Management.frmReport frmRpt = new RHPP_Management.frmReport();
            frmRpt.ShowDialog();
        }

        private void pbReports_MouseEnter(object sender, EventArgs e)
        {
            pbReports.BackColor = selectedColorPb;
            lblReports.BackColor = selectedColorLbl;
        }

        private void pbReports_MouseLeave(object sender, EventArgs e)
        {
            pbReports.BackColor = unselectedColorPb;
            lblReports.BackColor = unselectedColorLbl;
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            pbReports_Click(sender, e);
        }

        private void lblReports_MouseEnter(object sender, EventArgs e)
        {
            pbReports_MouseEnter(sender, e);
        }

        private void lblReports_MouseLeave(object sender, EventArgs e)
        {
            pbReports_MouseLeave(sender, e);
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            pnAccountOptions.Visible = true;
        }

        private void lblUsername_MouseEnter(object sender, EventArgs e)
        {
            lblUsername.Font = new Font(lblUsername.Font, FontStyle.Underline);
        }

        private void lblUsername_MouseLeave(object sender, EventArgs e)
        {
            lblUsername.Font = new Font(lblUsername.Font, FontStyle.Regular);
        }

        private void pbUserPicture_Click(object sender, EventArgs e)
        {
            lblUsername_Click(sender, e);
        }
    }
}
