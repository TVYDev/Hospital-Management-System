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

namespace RHPP_Management
{
    public partial class frmPatientHistory : Form
    {
        public frmPatientHistory()
        {
            InitializeComponent();
        }

      
        public static SqlCommand com;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        string getPatientID;


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

        string[] store;
        string[] realStore;
        string[] storeForListView;
        private void frmPatientHistory_Load(object sender, EventArgs e)
        {
            //lblDateIn.Text = "ថ្ងៃចូល";
            //lblTimeIn.Text = "ម៉ោងចូល";
            //lblDateOut.Text = "ថ្ងៃចេញ";
            //lblTimeOut.Text = "ម៉ោងចេញ";
            //lblBedNumber.Text = "លេខគ្រែ";
            //lblDoctorID.Text = "";

            //lblDoctorID.Text = "អត្តលេខ";
            //lblIll.Text = "ជំងឺ";

            dgvDisplayName.Font = new Font("Comic Sans MS", 11);
            dgvDisplayName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisplayName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisplayName.RowHeadersVisible = false;
            dgvDisplayName.AllowUserToAddRows = false;
            dgvDisplayName.AllowUserToDeleteRows = false;
            dgvDisplayName.AllowUserToOrderColumns = false;
            dgvDisplayName.AllowUserToResizeColumns = false;
            dgvDisplayName.AllowUserToResizeRows = false;
            dgvDisplayName.ReadOnly = true;
            dgvDisplayName.MultiSelect = false;

            dgvDetailVisit.Font = new Font("Comic Sans MS", 11);
            dgvDetailVisit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailVisit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailVisit.RowHeadersVisible = false;
            dgvDetailVisit.AllowUserToAddRows = false;
            dgvDetailVisit.AllowUserToDeleteRows = false;
            dgvDetailVisit.AllowUserToOrderColumns = false;
            dgvDetailVisit.AllowUserToResizeColumns = false;
            dgvDetailVisit.AllowUserToResizeRows = false;
            dgvDetailVisit.ReadOnly = true;
            dgvDetailVisit.MultiSelect = false;

            //con = new SqlConnection("Data Source = Anonymous ; Initial Catalog = HospitalManagement ; Integrated Security = true ; ");
            //con.Open();
            com = new SqlCommand();
            com.Connection = Hospital_Management.frmLogin.con;
            com.CommandType = CommandType.Text;
            //com.CommandText = "Select * FROM tbPatient";
            da = new SqlDataAdapter("Select pID as [Patient ID],pName as [Patient Name] FROM tbPatient", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);

            dgvDisplayName.DataSource = dt;

            btnPrint.Enabled = false;

        }

       
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            
            frmPatientHistory_Load(sender, e);
        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
       
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.MainForm mainform = new WindowsFormsApplication3.MainForm();
            mainform.Show();
            this.Visible = false;
        }

        private void btnDeleteSelectedRecord_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDeleteWholeHistory_Click(object sender, EventArgs e)
        {
         
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("Select pID,pName FROM tbPatient WHERE pName LIKE '%" + txtSearch.Text + "%' OR pID LIKE '%" + txtSearch.Text + "%'", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
           
            dgvDisplayName.DataSource = dt;
        }

        private void dgvDisplayName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDisplayName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                int i = 0;
                int VisitTime = 0;
                String getID = dgvDisplayName.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                string ill="";
                //com.CommandText = "SELECT p.pID , p.pName , p.pSex , p.pContact ,p.pAddress ,ciDateIn , ciTimeIn , tbCheckOut.coDateOut , tbCheckOut.coTimeOut , ci.bID , ci.rID , ill, pPhoto FROM tbCheckIn as ci, tbPatient as P , tbCheckOut WHERE P.pName = '"+getName+"' AND P.pID = ci.pID AND ci.ciNo = tbCheckOut.ciNo";
               // com.CommandType = CommandType.StoredProcedure();
                
                com.CommandText = " SELECT p.pID , p.pName , p.pSex ,p.pContact , p.pAddress , p.pPhoto , ill ,"
                                        + "s.sID , s.sName ,ci.bID, CONVERT(VARCHAR,ci.ciDateIn,120) , CONVERT(VARCHAR,ci.ciTimeIn,100) ,"
                                        + "	CASE WHEN ci.checkOutStatus='false' THEN 'N/A' ELSE CONVERT(VARCHAR, co.coDateOut,120) END AS coDate,  "
                                        + " CASE WHEN ci.checkOutStatus='false' THEN 'N/A' ELSE CONVERT(VARCHAR, co.coTimeOut,120) END AS coTimeOut "
                                        + "FROM tbPatient p, tbStaff s , tbCheckIn ci, tbCheckOut co , tbRoom r "
                                        + "WHERE p.pID = ci.pID AND s.sID = ci.sID AND r.bID = ci.bID  AND (ci.checkOutStatus = 'false' OR ci.ciNo = co.ciNo) AND p.pID = '"+ getID +"'"; 

                
                dgvDetailVisit.Rows.Clear();
              
                
                dgvDetailVisit.Refresh();
                MemoryStream ms;

                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    getPatientID = dr[0].ToString();

                    lblID.Text =  dr[0].ToString();
                    lblName.Text = dr[1].ToString();
                    lblSex.Text = dr[2].ToString();
                    lblContact.Text = dr[3].ToString();
                    lblAddress.Text = dr[4].ToString();
                  
                    
                    //if (dr[5] != null)
                    //{
                    //    ms = new MemoryStream((byte[])dr[5]);
                    //    pbPicUser.SizeMode = PictureBoxSizeMode.Zoom;
                    //    pbPicUser.Image = Image.FromStream(ms);
                    //}



                    dgvDetailVisit.Rows.Add( dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(),dr[12].ToString(),dr[13].ToString());
                    VisitTime++;
                    lblLastVisit.Text = dr[10].ToString();

                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr[5]);
                    MemoryStream mem = new MemoryStream(data);
                    pbPicUser.Image = Image.FromStream(mem);


                    




                }

                lblTotalTimesVisiting.Text = "Total = " + VisitTime.ToString();
               
                
                dr.Close();
                dr.Dispose();
            }
        }

        private void dgvDetailVisit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            RHPP_Management.frmPatientReport report = new RHPP_Management.frmPatientReport(lblID.Text);
            report.ShowDialog();
       
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeOut_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            if (lblID.Text == "ID")
            {
                btnPrint.Enabled = false;
            }
            else {
                btnPrint.Enabled = true;
            }
        }

        
    }
}
