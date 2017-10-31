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
using System.Globalization;

namespace Check_In1
{
    public partial class frmCheckIn : Form
    {
        //SqlConnection con;
        SqlCommand com;
        static SqlCommand com1;
        SqlCommandBuilder cmb;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        static SqlDataReader dr1;
        static bool bFromSearch = false;

        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void getRoomIntoCbo()
        {
            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT bID FROM tbRoom WHERE bFree='True'";
            dr = com.ExecuteReader();
            //int roomCount = 0;
            int numRoom = 0;
            List<int> arrNumRoom = new List<int>();
            int roomReceive;
            while (dr.Read())
            {
                roomReceive = int.Parse(dr[0].ToString().Substring(1, 1));
                if (numRoom != roomReceive)
                {
                    //roomCount += 1;
                    arrNumRoom.Add(roomReceive);
                    
                }
                numRoom = roomReceive;
            }
            for (int a = 0; a < arrNumRoom.Count; a++)
            {
                cbward.Items.Add(arrNumRoom[a]);
            }
            dr.Close();
            com.Dispose();
        }

        MemoryStream Ms ;

        static TextBox textBoxID;
        static TextBox textBoxName;
        static RadioButton radioMale, radioFemale;
        static ComboBox cboDay, cboMonth, cboYear;
        static TextBox textBoxAddress;
        static MaskedTextBox maskContact;
        static PictureBox pbPictient;

        private void Form1_Load(object sender, EventArgs e)
        {
            Ms = new MemoryStream();
            picpatient.SizeMode = PictureBoxSizeMode.Zoom;
            picpatient.BorderStyle = BorderStyle.FixedSingle;
            picpatient.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.default_staff);
            picpatient.Image.Save(Ms, picpatient.Image.RawFormat);

            panel1.Enabled = false;
            panel2.Enabled = false;
            txtcino.Visible = true;
            btndeletepatient.Enabled = false;
            //btnsave.Enabled = false;
            btneditpatient.Enabled = true;
            btncheckin.Enabled = false;

            textBoxID = txtid;
            textBoxName = txtfirstname;
            radioMale = rdbMale;
            radioFemale = radioButton2;
            cboDay = cboDoBDay;
            cboMonth = cboDoBMonth;
            cboYear = cboDoBYear;
            textBoxAddress = txtaddress1;
            maskContact = mtxtcontact;
            pbPictient = picpatient;

            da = new SqlDataAdapter("select * from pulldata", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
           
            

            dgv.DataSource = dt;

            dgv.Columns[0].HeaderText = "Check In No";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Patient ID";
            dgv.Columns[1].Width = dgv.Width/18;

            dgv.Columns[2].HeaderText = "Patient Name";
            dgv.Columns[2].Width = dgv.Width / 7;

            dgv.Columns[3].HeaderText = "Patient Sex";
            dgv.Columns[3].Width = dgv.Width / 20;

            dgv.Columns[4].HeaderText = "Patient DOB";
            dgv.Columns[4].Width = dgv.Width / 13;

            dgv.Columns[5].HeaderText = "Patient Contact";
            dgv.Columns[5].Width = dgv.Width / 13;

            dgv.Columns[6].HeaderText = "Patient Address";
            dgv.Columns[6].Width = dgv.Width / 6;

            dgv.Columns[7].HeaderText = "Ill";
            dgv.Columns[7].Width = dgv.Width / 7;

            dgv.Columns[8].HeaderText = "Weight";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].HeaderText = "Height";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].HeaderText = "Doctor ID";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].HeaderText = "Doctor Name";
            dgv.Columns[11].Width = dgv.Width / 10;

            dgv.Columns[12].HeaderText = "Contact Doctor";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].HeaderText = "Doctor Specialization";
            dgv.Columns[13].Visible = false;
            
            dgv.Columns[14].HeaderText = "Bed No";
            dgv.Columns[14].Width = dgv.Width / 22;
            
            dgv.Columns[15].HeaderText = "Check In Date";
            dgv.Columns[15].Width = dgv.Width / 13;

            dgv.Columns[16].HeaderText = "Check In Time";
            dgv.Columns[16].Width = dgv.Width / 13;

            dgv.Columns[17].HeaderText = "Check In Status";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].HeaderText = "Patient Picture";
            dgv.Columns[18].Visible = false;
            
                      
            dgv.Font = new Font("Comic Sans MS",11,FontStyle.Bold);

            getRoomIntoCbo();

            cboDoBDay.Items.Clear();
            cboDoBMonth.Items.Clear();
            cboDoBYear.Items.Clear();
            cboDoBDay.IntegralHeight = false;
            cboDoBMonth.IntegralHeight = false;
            cboDoBYear.IntegralHeight = false;
            cboDoBDay.MaxDropDownItems = 10;
            cboDoBMonth.MaxDropDownItems = 10;
            cboDoBYear.MaxDropDownItems = 10;
            for (int i = 1; i <= 30; i++)
            {
                cboDoBDay.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cboDoBMonth.Items.Add(i);
            }
            for (int i = 1980; i <= 2005; i++)
            {
                cboDoBYear.Items.Add(i);
            }

            cboDoBDay.Text = cboDoBDay.Items[0].ToString();
            cboDoBMonth.Text = cboDoBMonth.Items[0].ToString();
            cboDoBYear.Text = cboDoBYear.Items[0].ToString(); ;

            com = new SqlCommand("select sName from tbStaff WHERE sID LIKE 'D%'", Hospital_Management.frmLogin.con);
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                cbodoctorname.Items.Add(dr[0].ToString());
            }
            dr.Close();

            btnsave.Visible = false;
            lbsave.Visible = false;
            
        }

        public static void loadDataFromSearch(string pid) 
        {
            com1 = new SqlCommand();
            com1.Connection = Hospital_Management.frmLogin.con;
            com1.CommandType = CommandType.Text;
            com1.CommandText = "SELECT pid,pName,pSex,convert(varchar(10),pDOB,120),pAddress, pContact,pPhoto FROM tbPatient WHERE pID='" + pid + "'";
            dr1 = com1.ExecuteReader();
            while (dr1.Read()) {
                textBoxID.Text = dr1[0].ToString();
                textBoxName.Text = dr1[1].ToString();
                if (dr1[2].ToString() == "M")
                {
                    radioMale.Checked = true;
                }
                else {
                    radioFemale.Checked = true;
                }
                string[] dobPatient = dr1[3].ToString().Split('-');
                cboYear.Text = dobPatient[0];
                cboMonth.Text = dobPatient[1];
                cboDay.Text = dobPatient[2];
                textBoxAddress.Text = dr1[4].ToString();
                maskContact.Text = dr1[5].ToString();
                MemoryStream ms;
                ms = new MemoryStream((Byte[])dr1[6]);
                pbPictient.Image = Image.FromStream(ms);
            }
            dr1.Close();
            com1.Dispose();
            bFromSearch = true;
            
        }

       
        private void btnadd_Click(object sender, EventArgs e)
        {
            bFromSearch = false;
            DialogResult dialogResult = MessageBox.Show("Old patient?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                RHPP_Management.FrmSearchPatient frmsearch = new RHPP_Management.FrmSearchPatient();
                frmsearch.ShowDialog();
            }
            else
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
                txtid.Enabled = false;
                dtpCheckIn.Enabled = false;
                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btncheckin.Enabled = true;
                
            }

            if (bFromSearch == false)
            {
                picpatient.Image = (Image)(RHPP_Management.Properties.Resources.default_staff);
                com = new SqlCommand("select pID from tbPatient", Hospital_Management.frmLogin.con);
                dr = com.ExecuteReader();

                int id;
                List<int> lstID = new List<int>();
                while (dr.Read())
                {
                    id = int.Parse(dr[0].ToString().Substring(1, 3));
                    lstID.Add(id);
                }
                dr.Close();
                com.Dispose();

                if (lstID.Count > 0)
                {
                    for (int i = 1; i < 1000; i++)
                    {
                        if (i <= lstID.Count)
                        {
                            if (lstID[i - 1] != i)
                            {
                                txtid.Text = "P" + i.ToString("000");
                                break;
                            }
                        }
                        else
                        {
                            txtid.Text = "P" + i.ToString("000");
                            break;
                        }
                    }
                }
                else
                {
                    int i = 1;
                    txtid.Text = "P" + i.ToString("000");
                }

                txtfirstname.Clear();
                cboDoBDay.Text = cboDoBDay.Items[0].ToString();
                cboDoBMonth.Text = cboDoBMonth.Items[0].ToString();
                cboDoBYear.Text = cboDoBYear.Items[0].ToString();
                txtaddress1.Clear();
                mtxtcontact.Clear();
            }
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            string day;
            switch (cboDoBDay.Text) { 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    day = "0" + cboDoBDay.Text;
                    break;
                default:
                    day = cboDoBDay.Text;
                    break;
            }

            string month;
            if (cboDoBMonth.Text == "10" || cboDoBMonth.Text == "11" || cboDoBMonth.Text == "12")
            {
                month = cboDoBMonth.Text;
            }
            else
            {
                month = "0" + cboDoBMonth.Text;
            }

            char sex;
            if (rdbMale.Checked)
            {
                sex = 'M';
            }
            else
            {
                sex = 'F';
            }
            if (txtfirstname.Text == "")
            {
                MessageBox.Show("Please input patient name!!");
                txtfirstname.Focus();
            }
            else if (radioButton2.Checked == false && rdbMale.Checked == false)
            {
                MessageBox.Show("Please choose Patient Sex!!");
                rdbMale.Focus();
            }
            else if (cboDoBDay.Text == "" || cboDoBMonth.Text == "" || cboDoBYear.Text == "")
            {
                MessageBox.Show("Please Input Patient Date Of birth!!");
                cboDoBDay.Focus();
            }
            else if (txtaddress1.Text == "")
            {
                MessageBox.Show("Please Input Address!!");
                txtaddress1.Focus();
            }
            else if (txtweight.Text == "")
            {
                MessageBox.Show("Please Input Patient Weight!!");
                txtweight.Focus();
            }
            else if (txtheight.Text == "")
            {
                MessageBox.Show("Please Input Patient Height!!");
                txtheight.Focus();
            }
            else if (dtpCheckIn.Text == "")
            {
                MessageBox.Show("Please Input Patient Phone Number!!");
                dtpCheckIn.Focus();
            }
            else if (txtillness.Text == "")
            {
                MessageBox.Show("Please Input Patient Illness!!");
            }
            else if (cbbed.Text == "")
            {
                MessageBox.Show("Please Choose Bed");
                cbbed.Focus();
            }
            else if (cbward.Text == "")
            {
                MessageBox.Show("Please Choose Room");
                cbward.Focus();
            }
            else if (cbodoctorname.Text == "")
            {
                MessageBox.Show("Please Choose a Doctor");
                cbodoctorname.Focus();
            }
            else
            {
                try
                {
                    MemoryStream Ms1 = new MemoryStream();
                    picpatient.Image.Save(Ms1, picpatient.Image.RawFormat);

                    com = new SqlCommand("Insertdata", Hospital_Management.frmLogin.con);
                    com.Parameters.Add("@pID", SqlDbType.VarChar).Value = txtid.Text;
                    com.Parameters.Add("@pNAME", SqlDbType.NVarChar).Value = txtfirstname.Text;
                    com.Parameters.Add("@pSEX", SqlDbType.Char).Value = sex;
                    com.Parameters.Add("@pDOB", SqlDbType.Date).Value = DateTime.ParseExact(month + "/" + day + "/" + cboDoBYear.Text, "d", CultureInfo.InvariantCulture);
                    com.Parameters.Add("@pADDRESS", SqlDbType.VarChar).Value = txtaddress1.Text;

                    mtxtcontact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    com.Parameters.Add("@pCONTACT", SqlDbType.VarChar).Value = mtxtcontact.Text;
                    com.Parameters.Add("@pPHOTO", SqlDbType.VarBinary).Value = Ms1.GetBuffer();

                    string roombed = "B" + cbward.Text + "0" + cbbed.Text;
                    com.Parameters.Add("@bID", SqlDbType.VarChar).Value = roombed;

                    com.Parameters.Add("@sID", SqlDbType.VarChar).Value = txtdoctorid.Text;

                    com.Parameters.Add("@ciILL", SqlDbType.VarChar).Value = txtillness.Text;
                    com.Parameters.Add("@ciWEIGHT", SqlDbType.Float).Value = String.Format("{0:0.00}", txtweight.Text);
                    com.Parameters.Add("@ciHEIGHT", SqlDbType.Float).Value = String.Format("{0:0.00}", txtheight.Text);
                    com.CommandType = CommandType.StoredProcedure;
                    com.ExecuteNonQuery();
                }
                catch(Exception)
                {
                }
                

                btncheckin.Enabled = false;
                showdata();
                btnsave.Visible = false;
                clear();
            }
           
        }

        private void cboDoBMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboDoBDay.Items.Clear();
            switch (cboDoBMonth.SelectedItem.ToString())
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    for (int i = 1; i <= 31; i++)
                    {
                        cboDoBDay.Items.Add("" + i);
                    }
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    for (int i = 1; i <= 30; i++)
                    {
                        cboDoBDay.Items.Add("" + i);
                    }
                    if (cboDoBDay.Text == "31")
                    {
                        cboDoBDay.SelectedIndex = 29;
                    }
                    break;
                case "2":
                    cboDoBYear.SelectedItem = cboDoBYear.Text;
                    if ((int.Parse(cboDoBYear.SelectedItem.ToString())) % 4 == 0)
                    {
                        for (int i = 1; i <= 29; i++)
                        {
                            cboDoBDay.Items.Add(i);
                        }
                        if (cboDoBDay.Text == "30" || cboDoBDay.Text == "31")
                        {
                            cboDoBDay.SelectedIndex = 28;
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            cboDoBDay.Items.Add(i);
                        }
                        if (cboDoBDay.Text == "20" || cboDoBDay.Text == "30" || cboDoBDay.Text == "31")
                        {
                            cboDoBDay.SelectedIndex = 27;
                        }
                    }
                    break;
            }
        }

        private void cboDoBYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if ((int.Parse(cboDoBYear.Text) % 4 != 0))
            {
                if (cboDoBMonth.Text == "2")
                {
                    cboDoBDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                    {
                        cboDoBDay.Items.Add(i);
                    }
                    if (cboDoBDay.Text == "29")
                    {
                        cboDoBDay.SelectedIndex = 27;
                    }
                }
            }
            else
            {
                if (cboDoBMonth.Text == "2")
                {
                    cboDoBDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                    {
                        cboDoBDay.Items.Add(i);
                    }
                }
            }
        }

        private void picpatient_Click(object sender, EventArgs e)
        {
            OpenFileDialog picDialog = new OpenFileDialog();
            picDialog.Filter = "JPEG|*.jpg;*.jpeg|PNG |*.png";
            picDialog.ShowDialog();
            if (picDialog.FileName != "")
            {
                picpatient.Image = Image.FromFile(picDialog.FileName);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog picDialog = new OpenFileDialog();
            picDialog.Filter = "JPEG|*.jpg;*.jpeg|PNG |*.png";
            picDialog.ShowDialog();
            if (picDialog.FileName != "")
            {
                picpatient.Image = Image.FromFile(picDialog.FileName);
            }
        }

        bool check = false;

        private void cbward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == false)
            {
                cbbed.Items.Clear();
                cbbed.Text = "";
                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT bID FROM tbRoom WHERE bId LIKE 'B" + cbward.Text + "%' AND bFree='True'";
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    cbbed.Items.Add(int.Parse(dr[0].ToString().Substring(3, 1)+""));
                }

                dr.Close();
                com.Dispose();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditpatient.Enabled = true;
            btndeletepatient.Enabled = true;
            btnadd.Enabled = false;
           

            try
            {
                if (dgv.RowCount >= 0)
                {
                    check = true;

                    DataGridViewRow row = dgv.Rows[e.RowIndex];

                    txtid.Text = row.Cells[1].Value.ToString();
                    txtfirstname.Text = row.Cells[2].Value.ToString();

                    String sex = row.Cells[3].Value.ToString();

                    if (sex == "M")
                        rdbMale.Checked = true;
                    else
                        radioButton2.Checked = true;

                    DateTime rDate = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    cboDoBDay.SelectedItem = rDate.Day;
                    cboDoBMonth.SelectedItem = rDate.Month;
                    cboDoBYear.SelectedItem = rDate.Year;

                    txtweight.Text = row.Cells[8].Value.ToString();
                    txtheight.Text = row.Cells[9].Value.ToString();
                    txtaddress1.Text = row.Cells[6].Value.ToString();

                    txtdoctorid.Text = row.Cells[10].Value.ToString();
                    cbodoctorname.Text = row.Cells[11].Value.ToString();
                    txtdoctornumber.Text = row.Cells[12].Value.ToString();
                    txtspecialize.Text = row.Cells[13].Value.ToString();

                    txtcino.Text = row.Cells[0].Value.ToString();
                    txtcino.Visible = true;

                    mtxtcontact.Text = row.Cells[5].Value.ToString();
                    txtillness.Text = row.Cells[7].Value.ToString();


                    string roombed1 = row.Cells[14].Value.ToString();
                    

                    //MessageBox.Show(roombed1.ToString());
                    
                    cbbed.Text = roombed1.Substring(3,1);
                    //MessageBox.Show(cbbed.Text);
                   
                    cbward.Text = (roombed1.Substring(1, 1));
                   // MessageBox.Show(cbward.Text);
                    
                    MemoryStream ms;
                    ms = new MemoryStream((Byte[])row.Cells[19].Value);
                    picdoctor.Image = Image.FromStream(ms);
                    picdoctor.SizeMode = PictureBoxSizeMode.Zoom;

                    MemoryStream ms2;
                    ms2 = new MemoryStream((Byte[])row.Cells[18].Value);
                    picpatient.Image = Image.FromStream(ms2);
                    picpatient.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    dtpCheckIn.Text = row.Cells[11].Value.ToString();

                   
                }
            }
            catch (Exception)
            {
            }
        }

        private void btndeletepatient_Click(object sender, EventArgs e)
        {
            bool agree=false;

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Cancel This ?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                agree = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                agree = false;
            }
            if (agree == true)
            {
                com = new SqlCommand("cancel", Hospital_Management.frmLogin.con);
                com.Parameters.Add("@ciNo", SqlDbType.Int).Value = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                com.Parameters.Add("@pID", SqlDbType.VarChar).Value = txtid.Text;
                com.Parameters.Add("@bID", SqlDbType.VarChar).Value = cbbed.Text;
                com.CommandType = CommandType.StoredProcedure;
                com.ExecuteNonQuery();

                showdata();

            }
            else
                MessageBox.Show("System: Got It!!!");

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string day;

            switch (cboDoBDay.Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    day = "0" + cboDoBDay.Text;
                    break;
                default:
                    day = cboDoBDay.Text;
                    break;
            }

            string month;
            if (cboDoBMonth.Text == "10" || cboDoBMonth.Text == "11" || cboDoBMonth.Text == "12")
            {
                month = cboDoBMonth.Text;
            }
            else
            {
                month = "0" + cboDoBMonth.Text;
            }

            char sex;
            if (rdbMale.Checked)
            {
                sex = 'M';
            }
            else
            {
                sex = 'F';
            }
            com = new SqlCommand("updatedata", Hospital_Management.frmLogin.con);
            com.Parameters.Add("@pID", SqlDbType.VarChar).Value = txtid.Text;
            com.Parameters.Add("@pNAME", SqlDbType.NVarChar).Value = txtfirstname.Text;
            com.Parameters.Add("@pSEX", SqlDbType.Char).Value = sex;
            com.Parameters.Add("@pDOB", SqlDbType.Date).Value = DateTime.ParseExact(month + "/" + day + "/" + cboDoBYear.Text, "d", CultureInfo.InvariantCulture);
            com.Parameters.Add("@pADDRESS", SqlDbType.VarChar).Value = txtaddress1.Text;
            com.Parameters.Add("@pCONTACT", SqlDbType.VarChar).Value = mtxtcontact.Text;
            MemoryStream ms = new MemoryStream();
            picpatient.Image.Save(ms, picpatient.Image.RawFormat);
            com.Parameters.Add("@pPHOTO", SqlDbType.VarBinary).Value = ms.GetBuffer();

            string roombed = "B" + cbward.Text + "0" + cbbed.Text;

            com.Parameters.Add("@bID", SqlDbType.VarChar).Value = roombed;

            com.Parameters.Add("@sID", SqlDbType.VarChar).Value = txtdoctorid.Text;
            
            com.Parameters.Add("@ciNo",SqlDbType.Int).Value=int.Parse(txtcino.Text);
            com.Parameters.Add("@ciILL", SqlDbType.VarChar).Value = txtillness.Text;
            com.Parameters.Add("@ciWEIGHT", SqlDbType.Float).Value = String.Format("{0:0.00}", txtweight.Text);
            com.Parameters.Add("@ciHEIGHT", SqlDbType.Float).Value = String.Format("{0:0.00}", txtheight.Text);
            com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();

            showdata();
            clear();

            btneditpatient.Visible = true;
            lbedit.Visible = true;
            btnsave.Visible = false;
            lbsave.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            btnadd.Enabled = true;
            btnsave.Enabled = false;


        }

        private void btneditpatient_Click(object sender, EventArgs e)
        {
            btnsave.Visible = true;
            lbsave.Visible = true;
            btncheckin.Enabled = false;
            btnClear.Enabled = true;
            txtid.Enabled = true;


            btncheckin.Enabled = true;

            txtfirstname.Enabled = true;
            txtheight.Enabled = true;
            txtweight.Enabled = true;
            txtaddress1.Enabled = true;

            txtillness.Enabled = true;
            cbward.Enabled = true;
            cbbed.Enabled = true;
            dtpCheckIn.Enabled = true;
            cbodoctorname.Enabled = true;
            btnBrowse.Enabled = true;

            mtxtcontact.Enabled = true;
            cboDoBDay.Enabled = true;
            cboDoBMonth.Enabled = true;
            cboDoBYear.Enabled = true;

            btneditpatient.Visible = false;
            lbedit.Visible = false;
            btnsave.Visible = true;
            lbsave.Visible = true;

            panel1.Enabled = true;
            panel2.Enabled = true;

            txtid.Enabled = false;
            btnadd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnsave.Visible = false;
            lbsave.Visible = false;
            btneditpatient.Visible = true;
            btneditpatient.Enabled = true;
            lbedit.Visible = true;
            btnBrowse.Enabled = false;
            btncheckin.Enabled = false;
            btndeletepatient.Enabled = false;
        }

        public void showdata()
        {
            da = new SqlDataAdapter("select * from dbo.pulldata", Hospital_Management.frmLogin.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void cbodoctorname_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("select sID,sContact,sSkill,sPhoto from tbStaff Where sName='" + cbodoctorname.Text + "'", Hospital_Management.frmLogin.con);
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                try
                {
                    txtdoctorid.Text = dr[0].ToString();
                    txtdoctornumber.Text = dr[1].ToString();
                    txtspecialize.Text = dr[2].ToString();
                    MemoryStream ms;
                    ms = new MemoryStream((Byte[])dr[3]);
                    picdoctor.Image = Image.FromStream(ms);
                    picdoctor.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                }
            }
            dr.Close();
        }

        public void clear()
        {
            txtid.Clear();

            txtfirstname.Clear();
            txtheight.Clear();
            txtweight.Clear();
            txtaddress1.Clear();

            txtillness.Clear();
            cbward.Text = "";
            cbbed.Text = "";
            dtpCheckIn.Text = "";
            cbodoctorname.Text = "";

            mtxtcontact.Clear();
            
            txtdoctorid.Clear();

            txtdoctornumber.Clear();

            radioButton2.Checked = false;
            rdbMale.Checked = false;

            picpatient.Image = (Image)RHPP_Management.Properties.Resources.default_staff;
            picdoctor.Image = null;

            panel1.Enabled = false;
            panel2.Enabled = false;

            btnadd.Enabled = true;
            btneditpatient.Enabled = false;
            btncheckin.Enabled = false;
            btndeletepatient.Enabled = false;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //RHPP_Management.FrmReportPatient report = new RHPP_Management.FrmReportPatient();
            //report.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form f = new WindowsFormsApplication3.MainForm();
            f.Show();
            this.Hide();
        }
    }
}