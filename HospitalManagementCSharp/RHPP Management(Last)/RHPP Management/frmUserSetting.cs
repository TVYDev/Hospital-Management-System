using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class frmUserSetting : Form
    {
        SqlCommand com;
        SqlDataReader dr;

        string labelUserIDText;

        public frmUserSetting(RHPP_Management.frmAccountSettings formAccountSettings)
        {
            InitializeComponent();
            labelUserIDText = formAccountSettings.labelUserIDText;
        }

        private void frmUserSetting_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        

        

        private void btnSaveTab2_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT sPassword FROM tbStaff WHERE sID='" + labelUserIDText + "'";
            dr = com.ExecuteReader();
            dr.Read();
            string pwd = dr[0].ToString();
            dr.Close();
            com.Dispose();

            bool b = false;
            if (pwd.Equals(txtCurrentPwd.Text))
            {
                if (txtNewPwd.Text.Equals(""))
                {
                    lblWarning.ForeColor = Color.Red;
                    lblWarning.Text = "Password cannot be empty";
                    lblWarning.Visible = true;
                }
                else if (txtNewPwd.Text.Count() < 4) {
                    lblWarning.ForeColor = Color.Red;
                    lblWarning.Text = "Password must contain at least 4 characters";
                    lblWarning.Visible = true;
                }
                else
                {
                    if (txtNewPwd.Text.Equals(txtRetypePwd.Text))
                    {
                        com = new SqlCommand();
                        com.Connection = Hospital_Management.frmLogin.con;
                        com.CommandType = CommandType.Text;
                        com.CommandText = "UPDATE tbStaff SET sPassword='" + txtNewPwd.Text + "' WHERE sID='" + labelUserIDText + "'";
                        //lblPasswordText = txtNewPwd.Text;
                        com.ExecuteNonQuery();
                        com.Dispose();
                        b = true;
                    }
                    else
                    {
                        lblWarning.Text = "New passwords do not match";
                        lblWarning.Visible = true;
                    }
                }
            }
            else
            {
                lblWarning.Visible = true;
            }

            if (b == true)
            {
                btnSave.Enabled = false;
                btnCancel.Text = "Close";
                lblWarning.Text = "Change(s) saved";
                lblWarning.ForeColor = Color.Blue;
                lblWarning.Visible = true;
                txtCurrentPwd.Clear();
                txtNewPwd.Clear();
                txtRetypePwd.Clear();
                txtCurrentPwd.Enabled = false;
                txtNewPwd.Enabled = false;
                txtRetypePwd.Enabled = false;
                
            }
        }

        private void btnCancelTab2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtRetypePwd_Enter(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtNewPwd_Enter(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void txtCurrentPwd_Enter(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void chkShowCurrentPwd_Click(object sender, EventArgs e)
        {
            if (chkShowCurrentPwd.Checked == true)
            {
                txtCurrentPwd.UseSystemPasswordChar = false;
                txtCurrentPwd.Focus();
            }
            else {
                txtCurrentPwd.UseSystemPasswordChar = true;
                txtCurrentPwd.Focus();
            }
        }

        private void chkShowNewPwd_Click(object sender, EventArgs e)
        {
            if (chkShowNewPwd.Checked == true)
            {
                txtNewPwd.UseSystemPasswordChar = false;
                txtNewPwd.Focus();
            }
            else
            {
                txtNewPwd.UseSystemPasswordChar = true;
                txtNewPwd.Focus();
            }
        }

        private void chkShowRetypePwd_Click(object sender, EventArgs e)
        {
            if (chkShowRetypePwd.Checked == true)
            {
                txtRetypePwd.UseSystemPasswordChar = false;
                txtRetypePwd.Focus();
            }
            else
            {
                txtRetypePwd.UseSystemPasswordChar = true;
                txtRetypePwd.Focus();
            }
        }
    }

}
