using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;

namespace RHPP_Management
{
    public partial class frmAccountSettings : Form
    {
        SqlCommand com;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        string lblUserIDText;
        string idSelected;

        public frmAccountSettings(WindowsFormsApplication3.MainForm mainForm)
        {
            InitializeComponent();
            lblUserIDText = mainForm.lblUserIDText;
        }

        public string username;

        public string labelUserIDText
        {
            get
            {
                return lblUserIDText;
            }
            set
            {
                lblUserID.Text = value;
            }
        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT sName, sPos, sEmail, sContact, sAddress, sPassword, sPhoto FROM tbStaff WHERE sID='" + lblUserIDText + "'";
            dr = com.ExecuteReader();
            dr.Read();
            lblUsername.Text = dr[0].ToString();
            lblPosition.Text = dr[1].ToString();
            lblEmail.Text = dr[2].ToString();
            lblContact.Text = dr[3].ToString();
            lblAddress.Text = dr[4].ToString();
            lblPassword.Text = dr[5].ToString();

            pbProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfilePhoto.BorderStyle = BorderStyle.None;
            if (lblUsername.Text != "admin")
            {
                MemoryStream ms;
                ms = new MemoryStream((Byte[])dr[6]);
                
                pbProfilePhoto.Image = Image.FromStream(ms);
            }
            else
            {
                pbProfilePhoto.Image = (Image)(RHPP_Management.Properties.Resources.adminLogin);
            }
            dr.Close();
            com.Dispose();

            lblChangePwd.ForeColor = Color.DarkGreen;
            lblChangePwd.Font = new Font(lblChangePwd.Font, FontStyle.Underline);

            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT A.sID FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID WHERE A.sID='" + lblUserIDText + "'";
            dr = com.ExecuteReader();
            bool b = false;
            while (dr.Read()) {
                b = true;
            }
            if (b == true)
            {
                lblUserType.Visible = true;
            }
            else {
                lblUserType.Visible = false;
                tabControl1.TabPages.Remove(tpAllUsers);
            }
            dr.Close();
            com.Dispose();

            da = new SqlDataAdapter("SELECT sID as ID, sName as Name, sDOB as [Birth Date], sContact as [Contact Number], sPos as Position FROM tbStaff WHERE sPassword<>'' AND sID<>'A001' AND sID<>'" + lblUserIDText + "'", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);

            dgvAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllUsers.RowHeadersVisible = false;
            dgvAllUsers.AllowUserToAddRows = false;
            dgvAllUsers.AllowUserToDeleteRows = false;
            dgvAllUsers.AllowUserToOrderColumns = false;
            dgvAllUsers.AllowUserToResizeColumns = false;
            dgvAllUsers.AllowUserToResizeRows = false;
            dgvAllUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAllUsers.MultiSelect = false;
            dgvAllUsers.DataSource = dt;
            da.Dispose();
            dt.Dispose();

            pbUserPhoto.BorderStyle = BorderStyle.None;
            pbUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserPhoto.Image = (Image)(RHPP_Management.Properties.Resources.default_staff);
            pbKeyAdmin.Visible = false;
        }

        private void lblChangePwd_MouseEnter(object sender, EventArgs e)
        {
            lblChangePwd.ForeColor = Color.LightGreen;
        }

        private void lblChangePwd_MouseLeave(object sender, EventArgs e)
        {
            lblChangePwd.ForeColor = Color.DarkGreen;
        }

        private void lblChangePwd_Click(object sender, EventArgs e)
        {
            Hospital_Management.frmUserSetting formUserSetting = new Hospital_Management.frmUserSetting(this);
            formUserSetting.ShowDialog(this);
        }

        private void dgvAllUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgvAllUsers.Rows[e.RowIndex];
                idSelected = row.Cells[0].Value.ToString();
                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT sPhoto FROM tbStaff WHERE sID='" + idSelected + "'";
                dr = com.ExecuteReader();
                dr.Read();

                pbUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                pbUserPhoto.BorderStyle = BorderStyle.None;
                MemoryStream ms;
                ms = new MemoryStream((Byte[])dr[0]);
                pbUserPhoto.Image = Image.FromStream(ms);
                dr.Close();
                com.Dispose();

                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT A.sID FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID WHERE A.sID='" + idSelected + "'";
                dr = com.ExecuteReader();
                bool b = false;
                while (dr.Read())
                {
                    b = true;
                }
                if (b == true)
                {
                    pbKeyAdmin.Visible = true;
                    btnMakeAsAdmin.Text = "Unmake as admin";
                }
                else
                {
                    pbKeyAdmin.Visible = false;
                    btnMakeAsAdmin.Text = "Make as admin";
                }
                dr.Close();
                com.Dispose();
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) {
                dgvAllUsers.ClearSelection();
            }
        }

        private void btnMakeAsAdmin_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 540,
                Height = 210,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "haha",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "To continue, please clarify that you are an administrator" };
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Comic Sans MS", 11);
            Label textLabel1 = new Label() { Left = 50, Top = 60, Text = "Enter your password" };
            textLabel1.AutoSize = true;
            textLabel1.Font = new Font("Comic Sans MS", 11);
            TextBox textBox = new TextBox() { Left = 230, Top = 57, Width = 250 };
            textBox.Font = new Font("Comic Sans MS", 11);
            textBox.PasswordChar = '\u2022';
            Button confirmation = new Button() { Text = "Ok", Left = 240, Width = 100, Height = 40, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Font = new Font("Comic Sans MS", 12);
            confirmation.Enabled = false;
            Button cancelation = new Button() { Text = "Cancel", Left = 360, Width = 100, Height = 40, Top = 100, DialogResult = DialogResult.Cancel };
            cancelation.Font = new Font("Comic Sans MS", 12);
            confirmation.Click += (sender1, e1) => {
                    prompt.Close(); 
            };
            textBox.KeyUp += (sender1, e1) => {
                if (textBox.Text == "")
                {
                    confirmation.Enabled = false;
                }
                else {
                    confirmation.Enabled = true;
                }
            };
            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancelation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT sPassword FROM tbStaff WHERE sID='" + lblUserIDText + "'";
                dr = com.ExecuteReader();
                string password = "";
                while (dr.Read()) {
                    password = dr[0].ToString();
                }
                dr.Close();
                com.Dispose();

                if (password == textBox.Text)
                {
                    com = new SqlCommand();
                    com.Connection = Hospital_Management.frmLogin.con;
                    com.CommandType = CommandType.Text;

                    if (btnMakeAsAdmin.Text == "Make as admin")
                    {
                        com.CommandText = "INSERT INTO tbAdminLogin(sID) VALUES('" + idSelected + "')";
                        pbKeyAdmin.Visible = true;
                        btnMakeAsAdmin.Text = "Unmake as admin";
                    }
                    else
                    {
                        com.CommandText = "DELETE FROM tbAdminLogin WHERE sID='" + idSelected + "'";
                        pbKeyAdmin.Visible = false;
                        btnMakeAsAdmin.Text = "Make as admin";
                    }
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                else {
                    MessageBox.Show("Wrong Password");
                }
            }
        }
    }
}
