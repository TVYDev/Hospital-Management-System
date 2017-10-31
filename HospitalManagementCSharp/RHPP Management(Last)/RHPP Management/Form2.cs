using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        private string[] st1;
       // int icounter = 0;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chkByID.Checked = true;
            chkByName.Checked = false;
            //txtName.Enabled = false;
            cboName.Enabled = false;
            btnCheckInAgain.Enabled = false;
            btnClear.Enabled = false;
            txtID.Focus();

            FileStream fs = new FileStream("CheckIn.txt", FileMode.Open);
            FileStream fs2 = new FileStream("CheckOut.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            StreamReader sr2 = new StreamReader(fs2);
           // int i = 0;
            
            string store = "";
            while (!sr.EndOfStream)
            {
                store = store + sr.ReadLine() + "@";
            }
            while (!sr2.EndOfStream)
            {
                store = store + sr2.ReadLine() + "@";
            }
            st1 = store.Split('@');
            sr.Close();
            fs.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            bool x = false, y = false ;

            if (txtID.Text == "" && cboName.Text == "")
            {
                MessageBox.Show("Please enter ID or Name to search.","Information is missing",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                y = true;
            }

            
            string[] st;
            for (int i = 0; i < st1.Length - 1; i++)
            {
                st = st1[i].Split('#');
                if (chkByID.Checked)
                {
                    if ((txtID.Text = String.Format("{0:000}",int.Parse(txtID.Text))) == st[0])
                    {
                        txtID.Text = st[0];
                        //txtName.Text = st[1];
                        cboName.Text = st[1];
                        txtSex.Text = st[2];
                        txtAge.Text = st[3];
                        txtAddress.Text = st[4];
                        txtContact.Text = st[5];
                        txtDoctor.Text = st[6];

                        txtWard.Text = st[7];
                        txtBed.Text = st[8];
                        txtIllness.Text = st[9];
                        txtWeight.Text = st[10];
                        txtHeight.Text = st[11];
                        pictureBox.ImageLocation = st[12];
                        txtCheckIn.Text = st[13];
                        txtCheckOut.Text = st[14];
                        x = true;
                        break;
                    }
                }
                else
                {
                    if (cboName.Text.Equals(st[1]))
                    {
                        txtID.Text = st[0];
                        //txtName.Text = st[1];
                        //cboName.Text = st[1];
                        txtSex.Text = st[2];
                        txtAge.Text = st[3];
                        txtAddress.Text = st[4];
                        txtContact.Text = st[5];
                        txtDoctor.Text = st[6];
                        txtWard.Text = st[7];
                        txtBed.Text = st[8];
                        txtIllness.Text = st[9];
                        txtWeight.Text = st[10];
                        txtHeight.Text = st[11];
                        pictureBox.ImageLocation = st[12];
                        txtCheckIn.Text = st[13];
                        txtCheckOut.Text = st[14];
                        x = true;
                        break;
                    }
                }
            }
            if (y == false)
            {
                if (x == false)
                {
                    MessageBox.Show("Patient is not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    txtID.Enabled = false;
                    //txtName.Enabled = false;
                    chkByName.Enabled = false;
                    chkByID.Enabled = false;
                    btnSearch.Enabled = false;
                    btnClear.Enabled = true;
                   // cboName.Enabled = false;
                    if (txtCheckOut.Text.Equals("N/A"))
                    {
                        btnCheckInAgain.Enabled = false;
                    }
                    else {
                        btnCheckInAgain.Enabled = true;
                    }
                }
            }
            else {
                if (chkByID.Checked)
                {
                    txtID.Focus();
                }
                else {
                    //txtName.Focus();
                    cboName.Focus();
                }
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
           // txtName.Text= "";
            txtSex.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtDoctor.Clear();
            txtWard.Clear();
            txtBed.Clear();
            txtIllness.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            pictureBox.ImageLocation= "";
            txtCheckIn.Clear();
            txtCheckOut.Clear();
            btnSearch.Enabled = true;
            btnCheckInAgain.Enabled = false;
            cboName.Text = "";
            
            if (chkByID.Checked)
            {
                txtID.Enabled = true;
                //txtName.Enabled = false;
                cboName.Enabled = false;
                txtID.Focus();
                chkByID.Enabled = true;
                chkByName.Enabled = true;
            }
            else {
                txtID.Enabled = false;
                //txtName.Enabled = true;
                cboName.Enabled = true;
                //txtName.Focus();
                //cboName.Focus();
                chkByID.Enabled = true;
                chkByName.Enabled = true;
            }
            btnClear.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkByID_Click(object sender, EventArgs e)
        {
            if (chkByID.Checked)
            {
                chkByName.Checked = false;
               // txtName.Enabled = false;
                txtID.Enabled = true;
                txtID.Focus();
                //txtName.Clear();
                cboName.Enabled = false;
                cboName.Text = "";
            }
            else {
                chkByName.Checked = true;
                txtID.Enabled = false;
                //txtName.Enabled = true;
                //txtName.Focus();
                txtID.Clear();
                cboName.Enabled = true;
                cboName.Focus();
            }
        }

        private void chkByName_Click(object sender, EventArgs e)
        {
            if (chkByName.Checked)
            {
                chkByID.Checked = false;
                txtID.Enabled = false;
                //txtName.Enabled = true;
               // txtName.Focus();
                txtID.Clear();
                cboName.Enabled = true;
                cboName.Focus();
            }
            else {
                chkByID.Checked = true;
               // txtName.Enabled = false;
                txtID.Enabled = true;
                txtID.Focus();
               // txtName.Clear();
                cboName.Enabled = false;
                cboName.Text = "";
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void cboName_Enter(object sender, EventArgs e)
        {
            cboName.Items.Clear();
            string[] s;
            string s1="";
            for (int i = 0; i < st1.Length-1; i++) {
                
                s = st1[i].Split('#');
                s1 = s1 + "$" + s[1];
            }
            s = s1.Split('$');
            Array.Sort(s);
            //for (int i = 0; i < s.Length-2; i++) {
            //    for (int j = i + 1; j < s.Length - 1; j++) {
            //        if (s[i].Equals(s[j]) == false) { 

            //        }
            //    }
            //}
            for (int i = 1; i < s.Length; i++) {
                cboName.Items.Add(s[i]);
            }
            cboName.DroppedDown = true;
        }

        private void cboName_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSearch_Click_1(sender, e);
        }

        private void cboName_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.MainForm mainform = new WindowsFormsApplication3.MainForm();
            mainform.Show();
            this.Visible = false;
        }

        private void btnCheckInAgain_Click(object sender, EventArgs e)
        {
            Check_In1.frmCheckIn checkIn = new Check_In1.frmCheckIn();
            checkIn.Show();

            string[] stName = cboName.Text.Split(' ');
            checkIn.txtfirstname.Text = stName[0];
            for (int i = 1; i < stName.Length; i++)
            {
                checkIn.txtlastname.Text = checkIn.txtlastname.Text + stName[i];
            }

            checkIn.cbsex.Text = txtSex.Text;
            checkIn.txtage.Text = txtAge.Text;
            checkIn.txtaddress1.Text = txtAddress.Text;
            checkIn.txtcontactnumber.Text = txtContact.Text;
            this.Visible = false;
        }

    }
}
