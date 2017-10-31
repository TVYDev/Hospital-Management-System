using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class frmLogin : Form
    {
        public static SqlConnection con;
        SqlDataReader dr;
        SqlCommand com, com1;
        SqlDataAdapter da;
        DataTable dtAllLoginList;

        WindowsFormsApplication3.MainForm frmMain;

        public frmLogin()
        {
            InitializeComponent();

            pbUserType.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        ///////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //method to convert Image to Byte array
        static byte[] saveImage(Image img)
        {
            MemoryStream mem = new MemoryStream();  //creates a stream memory
            img.Save(mem, img.RawFormat);           //saves the image (img) to the specified memory (mem) in the specified format (RawFormat)
            return (mem.GetBuffer());               //returns the array of unsigned bytes from which this stream was created (mem)
        }

        //method to convert Byte array to Image
        static Image getImage(byte[] B_img)
        {
            MemoryStream mem = new MemoryStream(B_img);     //creates a stream memory
            return (Image.FromStream(mem));                 //creates an image from the specified data stream (mem)
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Gray;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Gray;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            foreach (DataRow drow in dtAllLoginList.Rows) {
                if (drow[1].ToString() == username && drow[2].ToString() == password) {
                    com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO tbLogin(sID, dateIn, timeIn) VALUES('" + drow[0].ToString() + "', convert(date, getdate()), convert(time, getdate()))";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    frmMain.Show();
                    this.Hide();
                    return;
                }
            }
            lblWarning.Visible = true;
            com.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pbUserType.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.generalUserLogin);
            lblUserType.Text = "General User";
            pbUserType.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserType.BorderStyle = BorderStyle.None;
            //con = new SqlConnection("Data Source = Anonymous ; Initial Catalog = HospitalManagement ; Integrated Security = true ; ");
            con = new SqlConnection("Data Source=DESKTOP-TVY\\SQLEXPRESS;Initial Catalog=HospitalManagement;User ID=tvy;Password=computer");
            //con = new SqlConnection("Data Source=SSK-10;Initial Catalog=HospitalManagement;User ID=admin;Password=admin");
            con.Open();

            da = new SqlDataAdapter("SELECT sID, sName, sPassword FROM tbStaff WHERE sPassword<>''", con);
            dtAllLoginList = new DataTable();
            da.Fill(dtAllLoginList);
            

            frmMain = new WindowsFormsApplication3.MainForm();

            lblWarning.Visible = false;
            txtUsername.Focus();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void chkShowPwd_Click(object sender, EventArgs e)
        {
            if (chkShowPwd.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Focus();
            }
            else {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Focus();
            }
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUsername.Text.Length > 1)
            {
                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.Connection = con;
                com.CommandText = "SELECT sName FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID";
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0].ToString() == txtUsername.Text)
                    {
                        pbUserType.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.adminLogin);
                        lblUserType.Text = "Administrator";
                        dr.Close();
                        return;
                    }
                }
                pbUserType.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.generalUserLogin);
                lblUserType.Text = "General User";
                dr.Close();
                com.Dispose();
            }
        }
    }
}
