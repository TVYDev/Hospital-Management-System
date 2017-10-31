using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace RHPP_Management
{
    public partial class frmStaffs : Form
    {
        SqlDataAdapter da;
        SqlCommand com;
        SqlCommandBuilder cmb;
        SqlDataReader dr;
        DataTable dt;
        DataRow drow;
        string lblUserIDText;

        public frmStaffs(string lblUserIDText)
        {
            InitializeComponent();
            this.lblUserIDText = lblUserIDText;
        }

        private void frmStaffs_Load(object sender, EventArgs e)
        {
            pbStaffPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbStaffPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbStaffPhoto.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.default_staff);


            btnNew.Image = (Image)RHPP_Management.Properties.Resources.addStaff;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.Image = (Image)RHPP_Management.Properties.Resources.editStaff;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.Image = (Image)RHPP_Management.Properties.Resources.deleteStaff;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnClear.Image = (Image)RHPP_Management.Properties.Resources.clearStaff;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.TextAlign = ContentAlignment.MiddleRight;

            txtID.ReadOnly = true;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            txtID.Enabled = false;
            txtName.Enabled = false;
            gbSex.Enabled = false;
            cboDoBDay.Enabled = false;
            cboDoBMonth.Enabled = false;
            cboDoBYear.Enabled = false;
            mtbContact.Enabled = false;
            txtEmail.Enabled = false;
            cboPosition.Enabled = false;
            txtAddress.Enabled = false;
            btnBrowse.Enabled = false;

            cboPosition.Items.Add("Nurse");
            cboPosition.Items.Add("Receptionist");
            cboPosition.Items.Add("Security");
            cboPosition.Items.Add("Cleaner");

            cboDoBDay.Items.Clear();
            cboDoBMonth.Items.Clear();
            cboDoBYear.Items.Clear();
            cboDoBDay.IntegralHeight = false;
            cboDoBMonth.IntegralHeight = false;
            cboDoBYear.IntegralHeight = false;
            cboDoBDay.MaxDropDownItems = 8;
            cboDoBMonth.MaxDropDownItems = 8;
            cboDoBYear.MaxDropDownItems = 8;
            for (int i = 1; i <= 30; i++) {
                cboDoBDay.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++) {
                cboDoBMonth.Items.Add(i);
            }
            for (int i = 1980; i <= 2005; i++)
            {
                cboDoBYear.Items.Add(i);
            }
            
            txtSearch.Text = "Search here...";
            txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;

            
            dgvAllStaffs.Font = new Font("Comic Sans MS", 11);
            dgvAllStaffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllStaffs.RowHeadersVisible = false;
            dgvAllStaffs.AllowUserToAddRows = false;
            dgvAllStaffs.AllowUserToDeleteRows = false;
            dgvAllStaffs.AllowUserToOrderColumns = false;
            dgvAllStaffs.AllowUserToResizeColumns = false;
            dgvAllStaffs.AllowUserToResizeRows = false;
            //dgvAllStaffs.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAllStaffs.ReadOnly = true;
            dgvAllStaffs.MultiSelect = false;

            da = new SqlDataAdapter("SELECT sID as ID, sName as Name, sSex as Sex, sDOB as [Date of Birth], sContact as [Contact Number], sEmail as Email, sPos as Position, sAddress as Address, sPhoto FROM tbStaff WHERE sID LIKE 'S%' AND sID<>'A001'", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvAllStaffs.DataSource = dt;
            //dgvAllStaffs.Columns[8].Width = 0;
            dgvAllStaffs.Columns[8].Visible = false;
            da.Dispose();
            dt.Dispose();

            dgvAllStaffs.ClearSelection();   
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
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
                confirmation.Click += (sender1, e1) =>
                {
                    prompt.Close();
                };
                textBox.KeyUp += (sender1, e1) =>
                {
                    if (textBox.Text == "")
                    {
                        confirmation.Enabled = false;
                    }
                    else
                    {
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
                    while (dr.Read())
                    {
                        password = dr[0].ToString();
                    }
                    dr.Close();
                    com.Dispose();

                    if (password == textBox.Text)
                    {
                        btnEdit.Enabled = false;
                        btnClear.Enabled = true;
                        btnDelete.Enabled = false;
                        txtID.Enabled = true;
                        txtName.Enabled = true;
                        gbSex.Enabled = true;
                        cboDoBDay.Enabled = true;
                        cboDoBMonth.Enabled = true;
                        cboDoBYear.Enabled = true;
                        mtbContact.Enabled = true;
                        txtEmail.Enabled = true;
                        cboPosition.Enabled = true;
                        txtAddress.Enabled = true;
                        btnBrowse.Enabled = true;

                        btnNew.Image = null;
                        btnNew.Image = (Image)RHPP_Management.Properties.Resources.updateStaff;
                        btnNew.Text = "Save";
                        txtName.Focus();

                        cboDoBDay.Text = "14";
                        cboDoBMonth.Text = "4";
                        cboDoBYear.Text = "1996";

                        cboPosition.Text = cboPosition.Items[0].ToString();

                        rdbMale.Checked = true;

                        txtName.Clear();
                        txtEmail.Clear();
                        mtbContact.Clear();
                        txtAddress.Clear();

                        com = new SqlCommand();
                        com.Connection = Hospital_Management.frmLogin.con;
                        com.CommandType = CommandType.Text;
                        com.CommandText = "SELECT sID FROM tbStaff WHERE sID LIKE 'S%'";
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
                                        txtID.Text = "S" + i.ToString("000");
                                        break;
                                    }
                                }
                                else
                                {
                                    txtID.Text = "S" + i.ToString("000");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            int i = 1;
                            txtID.Text = "S" + i.ToString("000");
                        }
                        cboDoBDay.Text = "14";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }

                }
                
            }
            else
            {
                mtbContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtName.Text == "") {
                    MessageBox.Show("Please input name");
                    txtName.Focus();
                    return;
                }
                if (rdbMale.Checked == false && rdbFemale.Checked == false) {
                    MessageBox.Show("Please input sex");
                    rdbMale.Focus();
                    return;
                }
                if (cboDoBDay.Text == "" || cboDoBMonth.Text == "" || cboDoBYear.Text == "") {
                    MessageBox.Show("Please input date of birth");
                    return;
                }
                if (mtbContact.Text == "") {
                    MessageBox.Show("Please input contact number");
                    mtbContact.Focus();
                    return;
                }
                if (cboPosition.Text == "") {
                    MessageBox.Show("Please input position");
                    cboPosition.Focus();
                    return;
                }
                if (txtAddress.Text == "") {
                    MessageBox.Show("Please input address");
                    txtAddress.Focus();
                    return;
                }
                MemoryStream Ms = new MemoryStream();

                pbStaffPhoto.Image.Save(Ms, pbStaffPhoto.Image.RawFormat);

                da = new SqlDataAdapter("Select * from tbStaff", Hospital_Management.frmLogin.con);
                dt = new DataTable();
                da.Fill(dt);

                cmb = new SqlCommandBuilder(da);

                drow = dt.NewRow();

                drow[0] = txtID.Text;
                drow[1] = txtName.Text;

                char sex;
                if (rdbMale.Checked)
                {
                    sex = 'M';
                }
                else 
                {
                    sex = 'F';
                }

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
                drow[2] = sex;
                drow[3] = DateTime.ParseExact(month + "/" + day + "/" + cboDoBYear.Text, "d", CultureInfo.InvariantCulture);
                
               
                drow[4] = mtbContact.Text;
               
                drow[5] = null;
                drow[6] = txtEmail.Text;
                drow[7] = txtAddress.Text;
                drow[8] = cboPosition.Text;
                drow[9] = null;
                drow[10] = Ms.GetBuffer();
                drow[11] = txtID.Text;

                dt.Rows.Add(drow);

                da.Update(dt);

                
                dt.Dispose();
                da.Dispose();

                dgvAllStaffs.DataSource = null;
                da = new SqlDataAdapter("SELECT sID as ID, sName as Name, sSex as Sex, sDOB as [Date of Birth], sContact as [Contact Number], sEmail as Email, sPos as Position, sAddress as Address, sPhoto FROM tbStaff WHERE sID LIKE 'S%' AND sID<>'A001'", Hospital_Management.frmLogin.con);
                dt = new DataTable();
                da.Fill(dt);
                dgvAllStaffs.DataSource = dt;
                dgvAllStaffs.Columns[8].Width = 0;
                da.Dispose();
                dt.Dispose();

                //DataGridViewRow row = (DataGridViewRow)dgvAllStaffs.Rows[0].Clone();
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(dgvAllStaffs);
                //row.Cells[0].Value = txtID.Text;
                //row.Cells[1].Value = txtName.Text;
                //row.Cells[2].Value = sex;
                //row.Cells[3].Value = cboDoBMonth.Text + "/" + cboDoBDay.Text + "/" + cboDoBYear.Text;
                //row.Cells[4].Value = mtbContact.Text;
                //row.Cells[5].Value = txtEmail.Text;
                //row.Cells[6].Value = cboPosition.Text;
                //row.Cells[7].Value = txtAddress.Text;
                //row.Cells[8].Value = Ms.GetBuffer();
                //dgvAllStaffs.Rows.Add(row);

                //dgvAllStaffs.Sort(dgvAllStaffs.Columns[0], ListSortDirection.Ascending);

                txtID.Clear();
                txtName.Clear();
                cboDoBDay.Text = "";
                cboDoBMonth.Text = "";
                cboDoBYear.Text = "";
                mtbContact.Clear();
                txtEmail.Clear();
                cboPosition.Text = "";
                txtAddress.Clear();
                pbStaffPhoto.Image = (System.Drawing.Image)(RHPP_Management.Properties.Resources.default_staff);

                txtID.Enabled = false;
                txtName.Enabled = false;
                gbSex.Enabled = false;
                cboDoBDay.Enabled = false;
                cboDoBMonth.Enabled = false;
                cboDoBYear.Enabled = false;
                mtbContact.Enabled = false;
                txtEmail.Enabled = false;
                cboPosition.Enabled = false;
                txtAddress.Enabled = false;
                btnBrowse.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                btnNew.Text = "New";

                //MessageBox.Show("Successfully added");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.MainForm mainform = new WindowsFormsApplication3.MainForm();
            mainform.Show();
            this.Visible = false;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.ForeColor == System.Drawing.SystemColors.ScrollBar)
            {
                txtSearch.Text = "";
            }
            else { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (txtSearch.Text == "Search here...")
                {
                    txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
                }
                else
                {
                    txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
            else
            {
                txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
                txtSearch.Text = "Search here...";
            }
            else { }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("SELECT sID as ID, sName as Name, sSex as Sex, sDOB as [Date of Birth], sContact as [Contact Number], sEmail as Email, sPos as Position, sAddress as Address, sPhoto FROM tbStaff WHERE sID <>'A001' AND (sID LIKE '" + txtSearch.Text + "%' OR sName LIKE '" + txtSearch.Text + "%')", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvAllStaffs.DataSource = dt;
            da.Dispose();
            dt.Dispose();
            dgvAllStaffs.ClearSelection();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog picDialog = new OpenFileDialog();
            picDialog.Filter = "JPEG|*.jpg;*.jpeg|PNG |*.png";
            picDialog.ShowDialog();
            if (picDialog.FileName != "") {
                pbStaffPhoto.Image = Image.FromFile(picDialog.FileName);
            }
        }

        private void dgvAllStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEdit.Text = "Edit";
                btnEdit.Image = (Image)RHPP_Management.Properties.Resources.editStaff;
                btnNew.Text = "New";
                btnNew.Image = (Image)RHPP_Management.Properties.Resources.addStaff;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                txtID.Enabled = false;
                txtName.Enabled = false;
                gbSex.Enabled = false;
                cboDoBDay.Enabled = false;
                cboDoBMonth.Enabled = false;
                cboDoBYear.Enabled = false;
                mtbContact.Enabled = false;
                txtEmail.Enabled = false;
                cboPosition.Enabled = false;
                txtAddress.Enabled = false;
                btnBrowse.Enabled = false;
                btnClear.Enabled = true;

                DataGridViewRow row = this.dgvAllStaffs.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "M")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }
                DateTime rDate = Convert.ToDateTime(row.Cells[3].Value.ToString());
                cboDoBDay.SelectedIndex = rDate.Day - 1;
                cboDoBMonth.SelectedIndex = rDate.Month - 1;
                cboDoBYear.SelectedItem = rDate.Year;
                mtbContact.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                cboPosition.SelectedItem = row.Cells[6].Value.ToString();
                txtAddress.Text = row.Cells[7].Value.ToString();

                //com = new SqlCommand();
                //com.Connection = Hospital_Management.frmLogin.con;
                //com.CommandType = CommandType.Text;
                //com.CommandText = "SELECT sPhoto FROM tbStaff WHERE sID='" + row.Cells[0].Value.ToString() +"'";
                //dr = com.ExecuteReader();
                //dr.Read();
                MemoryStream ms;
                ms = new MemoryStream((Byte[])row.Cells[8].Value);
                pbStaffPhoto.Image = Image.FromStream(ms);
                //ms.Close();
                //dr.Close();
                //com.Dispose();
                cboDoBDay.Text = rDate.Day.ToString();
                cboDoBMonth.Text = rDate.Month.ToString();
                cboDoBYear.Text = rDate.Year.ToString() ;
            }
        }

        private void cboDoBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoBDay.Items.Clear();
            switch (cboDoBMonth.SelectedItem.ToString()) { 
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    for (int i = 1; i <= 31; i++) {
                        cboDoBDay.Items.Add("" + i);
                    }
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    for (int i = 1; i <= 30; i++) {
                        cboDoBDay.Items.Add("" + i);
                    }
                    if (cboDoBDay.Text == "31") {
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
                        if (cboDoBDay.Text == "30" || cboDoBDay.Text == "31") {
                            cboDoBDay.SelectedIndex = 28;
                        }
                    }
                    else {
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

        private void cboDoBYear_SelectedIndexChanged(object sender, EventArgs e)
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
            else {
                if (cboDoBMonth.Text == "2") {
                    cboDoBDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                    {
                        cboDoBDay.Items.Add(i);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
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
                confirmation.Click += (sender1, e1) =>
                {
                    prompt.Close();
                };
                textBox.KeyUp += (sender1, e1) =>
                {
                    if (textBox.Text == "")
                    {
                        confirmation.Enabled = false;
                    }
                    else
                    {
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
                    while (dr.Read())
                    {
                        password = dr[0].ToString();
                    }
                    dr.Close();
                    com.Dispose();

                    if (password == textBox.Text)
                    {
                        txtID.Enabled = true;
                        txtName.Enabled = true;
                        gbSex.Enabled = true;
                        cboDoBDay.Enabled = true;
                        cboDoBMonth.Enabled = true;
                        cboDoBYear.Enabled = true;
                        mtbContact.Enabled = true;
                        txtEmail.Enabled = true;
                        cboPosition.Enabled = true;
                        txtAddress.Enabled = true;
                        btnBrowse.Enabled = true;
                        btnEdit.Text = "Update";
                        btnEdit.Image = (Image)RHPP_Management.Properties.Resources.updateStaff;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
            }
            else {

                mtbContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please input name");
                    txtName.Focus();
                    return;
                }
                if (rdbMale.Checked == false && rdbFemale.Checked == false)
                {
                    MessageBox.Show("Please input sex");
                    rdbMale.Focus();
                    return;
                }
                if (cboDoBDay.Text == "" || cboDoBMonth.Text == "" || cboDoBYear.Text == "")
                {
                    MessageBox.Show("Please input date of birth");
                    return;
                }
                if (mtbContact.Text == "")
                {
                    MessageBox.Show("Please input contact number");
                    mtbContact.Focus();
                    return;
                }
                if (cboPosition.Text == "")
                {
                    MessageBox.Show("Please input position");
                    cboPosition.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please input address");
                    txtAddress.Focus();
                    return;
                }

                com = new SqlCommand();
                com.Connection = Hospital_Management.frmLogin.con;
                com.CommandType = CommandType.Text;
                char sex;
                if (rdbMale.Checked)
                {
                    sex = 'M';
                }
                else {
                    sex = 'F';
                }
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
                else {
                    month = "0" + cboDoBMonth.Text;
                }
                DateTime dob = DateTime.ParseExact(month + "/" + day + "/" + cboDoBYear.Text, "d", CultureInfo.InvariantCulture);
                mtbContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                com.CommandText = "UPDATE tbStaff SET sName='" + txtName.Text + "', sSex='" + sex + "', sDOB=@sDOB, sContact='" + mtbContact.Text + "', sEmail='" + txtEmail.Text + "', sPos='" + cboPosition.Text + "', sAddress='" + txtAddress.Text + "', sPhoto=@sPhoto WHERE sID='" + txtID.Text + "'";
                MemoryStream Ms = new MemoryStream();
                pbStaffPhoto.Image.Save(Ms, pbStaffPhoto.Image.RawFormat);
                com.Parameters.Add(new SqlParameter("@sPhoto", Ms.GetBuffer()));
                com.Parameters.AddWithValue("@sDOB", dob);
                com.ExecuteNonQuery();
                com.Dispose();
                com.Parameters.Clear();

                for (int i = 0; i < dgvAllStaffs.Rows.Count; i++)
                {
                    if (dgvAllStaffs.Rows[i].Cells[0].Value.ToString() == txtID.Text)
                    {
                        dgvAllStaffs.Rows[i].Cells[1].Value = txtName.Text;
                        dgvAllStaffs.Rows[i].Cells[2].Value = sex;
                        dgvAllStaffs.Rows[i].Cells[3].Value = cboDoBMonth.Text + "/" + cboDoBDay.Text + "/" + cboDoBYear.Text;
                        dgvAllStaffs.Rows[i].Cells[4].Value = mtbContact.Text;
                        dgvAllStaffs.Rows[i].Cells[5].Value = txtEmail.Text;
                        dgvAllStaffs.Rows[i].Cells[6].Value = cboPosition.Text;
                        dgvAllStaffs.Rows[i].Cells[7].Value = txtAddress.Text;
                        dgvAllStaffs.Rows[i].Cells[8].Value = Ms.GetBuffer();
                        break;
                    }
                }
                dgvAllStaffs.Columns[8].Visible = false;
                txtID.Clear();
                txtName.Clear();
                //cboDoBDay.Text = "";
                //cboDoBMonth.Text = "";
                //cboDoBYear.Text = "";
                mtbContact.Clear();
                txtEmail.Clear();
                //cboPosition.Text = "";
                txtAddress.Clear();
                txtID.Enabled = false;
                txtName.Enabled = false;
                gbSex.Enabled = false;
                cboDoBDay.Enabled = false;
                cboDoBMonth.Enabled = false;
                cboDoBYear.Enabled = false;
                mtbContact.Enabled = false;
                txtEmail.Enabled = false;
                cboPosition.Enabled = false;
                txtAddress.Enabled = false;
                btnEdit.Text = "Edit";
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnBrowse.Enabled = false;
                pbStaffPhoto.Image = (Image)(RHPP_Management.Properties.Resources.default_staff);
                //pbStaffPhoto.Image = null;
                dgvAllStaffs.ClearSelection();
                
                btnEdit.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            confirmation.Click += (sender1, e1) =>
            {
                prompt.Close();
            };
            textBox.KeyUp += (sender1, e1) =>
            {
                if (textBox.Text == "")
                {
                    confirmation.Enabled = false;
                }
                else
                {
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
                while (dr.Read())
                {
                    password = dr[0].ToString();
                }
                dr.Close();
                com.Dispose();

                if (password == textBox.Text)
                {
                    MemoryStream Ms = new MemoryStream();

                    pbStaffPhoto.Image.Save(Ms, pbStaffPhoto.Image.RawFormat);

                    da = new SqlDataAdapter("Select * from tbStaffStopWork", Hospital_Management.frmLogin.con);
                    dt = new DataTable();
                    da.Fill(dt);

                    cmb = new SqlCommandBuilder(da);

                    drow = dt.NewRow();

                    drow[0] = txtID.Text;
                    drow[1] = txtName.Text;

                    char sex;
                    if (rdbMale.Checked)
                    {
                        sex = 'M';
                    }
                    else
                    {
                        sex = 'F';
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
                    drow[2] = sex;
                    drow[3] = DateTime.ParseExact(month + "/" + cboDoBDay.Text + "/" + cboDoBYear.Text, "d", CultureInfo.InvariantCulture);

                    mtbContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    drow[4] = mtbContact.Text;

                    drow[5] = null;
                    drow[6] = txtEmail.Text;
                    drow[7] = txtAddress.Text;
                    drow[8] = cboPosition.Text;
                    drow[9] = null;
                    drow[10] = Ms.GetBuffer();
                    drow[11] = txtID.Text;

                    dt.Rows.Add(drow);

                    da.Update(dt);
                    dt.Dispose();
                    da.Dispose();

                    com = new SqlCommand();
                    com.Connection = Hospital_Management.frmLogin.con;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "DELETE FROM tbStaff WHERE sID='" + txtID.Text + "'";
                    com.ExecuteNonQuery();
                    com.Dispose();

                    for (int i = 0; i < dgvAllStaffs.Rows.Count; i++)
                    {
                        if (dgvAllStaffs.Rows[i].Cells[0].Value.ToString() == txtID.Text)
                        {
                            dgvAllStaffs.Rows.Remove(dgvAllStaffs.Rows[i]);
                            break;
                        }
                    }


                    txtID.Clear();
                    txtName.Clear();
                    txtName.Clear();
                    mtbContact.Clear();
                    txtAddress.Clear();
                    pbStaffPhoto.Image = (Image)RHPP_Management.Properties.Resources.default_staff;
                    btnBrowse.Enabled = false;
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    gbSex.Enabled = false;
                    cboDoBDay.Enabled = false;
                    cboDoBMonth.Enabled = false;
                    cboDoBYear.Enabled = false;
                    mtbContact.Enabled = false;
                    txtAddress.Enabled = false;
                    txtEmail.Enabled = false;
                    cboPosition.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
        }

        private void dgvAllStaffs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            mtbContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            pbStaffPhoto.Image = (Image)RHPP_Management.Properties.Resources.default_staff;

            txtID.Enabled = false;
            txtName.Enabled = false;
            gbSex.Enabled = false;
            cboDoBDay.Enabled = false;
            cboDoBMonth.Enabled = false;
            cboDoBYear.Enabled = false;
            mtbContact.Enabled = false;
            txtEmail.Enabled = false;
            cboPosition.Enabled = false;
            txtAddress.Enabled = false;
            btnBrowse.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnNew.Text = "New";
            btnNew.Image = (Image)RHPP_Management.Properties.Resources.addStaff;
            btnEdit.Text = "Edit";
            btnEdit.Image = (Image)RHPP_Management.Properties.Resources.editStaff;
            btnNew.Enabled = true;
        }

        private void cboDoBDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
