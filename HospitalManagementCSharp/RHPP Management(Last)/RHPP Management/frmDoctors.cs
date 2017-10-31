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

namespace Doctor
{
    public partial class frmDoctors : Form
    {
        //SqlConnection cnn;
        SqlCommand cmm;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataRow drow;
        SqlDataReader dr;

        string lblUserIDText;

        public frmDoctors(string lblUserIDText)
        {
            InitializeComponent();
            this.lblUserIDText = lblUserIDText;
        }

        private void disablePanel()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
        }
        private void enablePanel()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            txtID.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            disablePanel();
            
            txtSearch.ForeColor = Color.Gray;
            bt_Edit.Enabled = false;
            btDelete.Enabled = false;
         

            cmm = new SqlCommand();

            //cnn = new SqlConnection("Data Source=DESKTOP-1G8FGJM\\SQLEXPRESS;Initial Catalog=HospitalManagement;integrated Security=True;Pooling=false");
            //cnn.Open();

            cmm.Connection = Hospital_Management.frmLogin.con;
            cmm.CommandType = CommandType.Text;


            showData();
        }
     
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (btAdd.Text.Equals("New"))
            {
                ////////////////////////


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
                    cmm = new SqlCommand();
                    cmm.Connection = Hospital_Management.frmLogin.con;
                    cmm.CommandType = CommandType.Text;
                    cmm.CommandText = "SELECT sPassword FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID";
                    dr = cmm.ExecuteReader();
                    string password = "";
                    bool b = false;
                    while (dr.Read())
                    {
                        if (textBox.Text == dr[0].ToString())
                        {
                            b = true;
                        }
                    }
                    dr.Close();
                    cmm.Dispose();


                    if (b == true)
                    {
                        bt_Edit.Text = "Edit";
                        F_Clear();
                        btAdd.Text = "Save";
                        enablePanel();
                        cmm.CommandText = "SELECT sID FROM tbStaff WHERE sID LIKE 'D%'";
                        dr = cmm.ExecuteReader();

                        int id;
                        List<int> lstID = new List<int>();
                        while (dr.Read())
                        {
                            id = int.Parse(dr[0].ToString().Substring(1, 3));
                            lstID.Add(id);
                        }
                        dr.Close();
                        // co.Dispose();

                        if (lstID.Count > 0)
                        {
                            for (int i = 1; i < 1000; i++)
                            {
                                if (i <= lstID.Count)
                                {
                                    if (lstID[i - 1] != i)
                                    {
                                        txtID.Text = "D" + i.ToString("000");
                                        break;
                                    }
                                }
                                else
                                {
                                    txtID.Text = "D" + i.ToString("000");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            int i = 1;
                            txtID.Text = "D" + i.ToString("000");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }


                    ////////////////////////



                }
                    

                }
                else
                {

                    txtCN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtEN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Input Name");
                        txtName.Focus();
                    }
                    else if (txtCN.Text == "")
                    {
                        MessageBox.Show("Input Contact Number");
                        txtCN.Focus();
                    }
                    else if (txtEN.Text == "")
                    {
                        txtEN.Focus();
                        MessageBox.Show("Input Emergency Number ");
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Input Email");
                        txtEmail.Focus();
                    }
                    else if (txtSpecail.Text == "")
                    {
                        MessageBox.Show("Input Specialize");
                        txtSpecail.Focus();
                    }
                    else if (txtAddress.Text == "")
                    {
                        MessageBox.Show("Input Address");
                        txtAddress.Focus();
                    }

                    else if (Photo.Image == null)
                    {
                        MessageBox.Show("Please Select Photo");
                        //lbPhoto.Visible = true;
                    }
                    else
                    {
                        disablePanel();
                        btAdd.Text = "New";
                        char sex;
                        if (rMale.Checked)
                        {
                            sex = 'M';
                        }
                        else
                        {
                            sex = 'F';
                        }
                        MemoryStream Ms = new MemoryStream();

                        Photo.Image.Save(Ms, Photo.Image.RawFormat);


                        //da = new SqlDataAdapter("Select * from tbStaff", Hospital_Management.frmLogin.con);
                        //dt = new DataTable();
                        //da.Fill(dt);

                        //cmb = new SqlCommandBuilder(da);

                        //drow = dt.NewRow();
                        //drow[0] = txtID.Text;
                        //drow[1] = txtName.Text;
                        //drow[2] = sex;
                        //drow[3] = DOB.Text;
                        //drow[4] = txtCN.Text;
                        //drow[5] = txtEN.Text;
                        //drow[6] = txtEmail.Text;
                        //drow[7] = txtAddress.Text;
                        //drow[8] = "Doctor";
                        //drow[9] = txtSpecail.Text;
                        //drow[10] = Ms.GetBuffer();
                        //drow[11] = txtID.Text;

                        //dt.Rows.Add(drow);

                        //da.Update(dt);
                        cmm.CommandText = "INSERT INTO tbStaff VALUES('" + txtID.Text + "','" + txtName.Text + "','" + sex + "','" + DOB.Text + "','" + txtCN.Text + "','" + txtEN.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','Doctor','" + txtSpecail.Text + "',@sPhoto,'" + txtID.Text + "')";
                        cmm.Parameters.Add(new SqlParameter("@sPhoto", Ms.GetBuffer()));
                        cmm.ExecuteNonQuery();

                        F_Clear();
                        showData();
                    }
                }
            
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            Photo.ImageLocation = op.FileName;
     
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (bt_Edit.Text.Equals("Edit"))
            {
                //////
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
                    cmm = new SqlCommand();
                    cmm.Connection = Hospital_Management.frmLogin.con;
                    cmm.CommandType = CommandType.Text;
                    cmm.CommandText = "SELECT sPassword FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID";
                    dr = cmm.ExecuteReader();
                    string password = "";
                    bool b = false;
                    while (dr.Read())
                    {
                        if (textBox.Text == dr[0].ToString()) {
                            b = true;
                            break;
                        }
                    }
                    dr.Close();
                    cmm.Dispose();

                    if (b == true)
                    {
                        bt_Edit.Text = "Update";
                        enablePanel();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                    //////
                }



                
            }
            else
            {
                disablePanel();
                bt_Edit.Text = "Edit";
                if (txtName.Text == "")
                {
                    MessageBox.Show("Input Name");
                    txtName.Focus();
                }
                else if (txtCN.Text == "")
                {
                    MessageBox.Show("Input Contact Number");
                    txtCN.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Input Email");
                    txtEmail.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Input Address");
                    txtAddress.Focus();

                }
                else if (txtSpecail.Text == "")
                {
                    MessageBox.Show("Input Specialize");
                    txtSpecail.Focus();
                }
                else if (Photo.Image == null)
                {
                    MessageBox.Show("Please Select Photo");

                }
                else
                {
                    char sex;
                    if (rMale.Checked)
                    {
                        sex = 'M';
                    }
                    else
                    {
                        sex = 'F';
                    }
                    MemoryStream Ms = new MemoryStream();
                    Photo.Image.Save(Ms, Photo.Image.RawFormat);

                    txtCN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtEN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    cmm.CommandText = "update tbStaff set sID='"+txtID.Text+"',sName='" + txtName.Text + "',sSex='" + sex + "',sDOB='" + DOB.Text + "',sContact='" + txtCN.Text + "',sEmergency='" + txtEN.Text + "',sEmail='" + txtEmail.Text + "',sAddress='" + txtAddress.Text + "',sPos='Doctor',sSkill='" + txtSpecail.Text + "',sPhoto=@sPhoto,sPassword='" + txtID.Text + "' where sID= '"+txtID.Text+"'";
                    cmm.Parameters.Add(new SqlParameter("@sPhoto", Ms.GetBuffer()));
                    cmm.ExecuteNonQuery();
                    showData();
                    F_Clear();
                    cmm.Parameters.Clear();
                }
            }
        }
        public void F_Clear()
        {
            txtID.Clear();
            txtID.ReadOnly = false;
            txtName.Clear();
            rMale.Checked = true;
            txtCN.Clear();
            txtEN.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSpecail.Text = null;
            Photo.Image = null;
            bt_Edit.Enabled = false;
            btDelete.Enabled = false;
           

        }

        private void btDelete_Click(object sender, EventArgs e)
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
                    cmm = new SqlCommand();
                    cmm.Connection = Hospital_Management.frmLogin.con;
                    cmm.CommandType = CommandType.Text;
                    cmm.CommandText = "SELECT sPassword FROM tbStaff A INNER JOIN tbAdminLogin B ON A.sID=B.sID";
                    dr = cmm.ExecuteReader();
                    string password = "";
                    bool b = false;
                    while (dr.Read())
                    {
                        if (textBox.Text == dr[0].ToString())
                        {
                            b = true;
                            break;
                        }
                    }
                    dr.Close();
                    cmm.Dispose();

                    if (b == true)
                    {
                        cmm.CommandText = "delete from tbStaff where sID= '" + txtID.Text + "'";
                        cmm.ExecuteNonQuery();
                        showData();
                        F_Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }

                }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            //Environment.Exit(0);
            WindowsFormsApplication3.MainForm mainform = new WindowsFormsApplication3.MainForm();
            mainform.Show();
            this.Visible = false;
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            btAdd.Text = "New";
            Form1_Load(sender, e);
            txtName.Clear();
            rMale.Checked = true;
            txtCN.Clear();
            txtEN.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSpecail.Text = null;
            Photo.Image = null;
            Photo.ImageLocation = null;
            bt_Edit.Enabled = false;
            btDelete.Enabled = false;
        }
        private void showData()
        {
            da = new SqlDataAdapter("select sID as ID,sName as Name,sSex as Sex,sDOB as DOB,sContact as Contact,sEmergency as Emergency,sEmail as Email,sAddress as Address,sPos as Position,sSkill as Specialization FROM tbStaff where sPos='Doctor'", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGirdviewDoctor.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dataGirdviewDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btAdd.Text = "New";
            bt_Edit.Text="Edit";
            disablePanel();

            MemoryStream Ms;
            if (e.RowIndex >= 0)
            {
                bt_Edit.Enabled = true;
                btDelete.Enabled = true;


                DataGridViewRow row = this.dataGirdviewDoctor.Rows[e.RowIndex];
                String id = row.Cells[0].Value.ToString();
                txtID.Text = id;
                txtName.Text = row.Cells[1].Value.ToString();
                String sex = row.Cells[2].Value.ToString();

                if(sex.Trim().Equals("Male")){
                    rMale.Checked = true;
                }else {
                    rFemale.Checked = true;
                }

               
                
                DOB.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtCN.Text = row.Cells[4].Value.ToString();
                txtEN.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtAddress.Text = row.Cells[7].Value.ToString();
                txtSpecail.Text = row.Cells[9].Value.ToString();

                cmm.CommandText = "select sPhoto from tbStaff where sID= '"+id+"'";

                dr = cmm.ExecuteReader();

                while (dr.Read())
                {
                    Ms = new MemoryStream((Byte[])dr[0]);
                    Photo.SizeMode = PictureBoxSizeMode.Zoom;
                    Photo.Image = Image.FromStream(Ms);
                }
                dr.Close();


            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Font = new Font(txtSearch.Font, FontStyle.Italic);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search here.......";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            //Photo.ImageLocation = op.FileName;
            Photo.Image = Image.FromFile(op.FileName);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("select sID as ID,sName as Name,sSex as Sex,sDOB as DOB,sContact as Contact,sEmergency as Emergency,sEmail as Email,sAddress as Address,sPos as Position,sSkill as Specialization FROM tbStaff where sPos = 'Doctor' and (sID like '" + txtSearch.Text + "%' or sName like '%" + txtSearch.Text + "%')", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGirdviewDoctor.DataSource = dt;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rMale.Checked)
            {
                MessageBox.Show(rMale.Text);
            }
            else
            {
                MessageBox.Show(rFemale.Text);
            }
        }
    }
       
}
