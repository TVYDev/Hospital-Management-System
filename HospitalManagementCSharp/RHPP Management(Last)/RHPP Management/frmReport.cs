using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RHPP_Management
{
    public partial class frmReport : Form
    {
        SqlCommand com;
        SqlDataReader dr;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dtStaffs, dtPatients;


        public frmReport()
        {
            InitializeComponent();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPosition(bool b) {
            chbDoctor.Enabled = b;
            chbNurse.Enabled = b;
            chbReceptionist.Enabled = b;
            chbSecurity.Enabled = b;
            chbCleaner.Enabled = b;
        }

        private void comboBoxStaff(bool b) {
            cboStaffID.Enabled = b;
            cboStaffName.Enabled = b;
        }

        private void comboBoxPatient(bool b) {
            cboPatientID.Enabled = b;
            cboPatientName.Enabled = b;
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpStaffs) {
                if (rdbListAllStaffs.Checked)
                {
                    frmReportAllStaffs rptAllStaffs = new frmReportAllStaffs();
                    rptAllStaffs.ShowDialog();
                }
                else if (rdbListStaffCertainPos.Checked)
                {
                    String[] st = new String[5];
                    CheckBox[] arrChb = { chbDoctor, chbNurse, chbReceptionist, chbSecurity, chbCleaner };
                    String[] arrSt = { "Doctor", "Nurse", "Receptionist", "Security", "Cleaner" };
                    bool b = false;
                    for (int i = 0; i < arrChb.Length; i++)
                    {
                        if (arrChb[i].Checked)
                        {
                            st[i] = arrSt[i];
                            b = true;
                        }
                        else
                        {
                            st[i] = "";
                        }
                    }

                    if (b == false) {
                        MessageBox.Show("You need to choose at least one position");
                        return;
                    }
                    frmReportStaffsCertainPositions rptStaffsCertainPositions = new frmReportStaffsCertainPositions(st);
                    rptStaffsCertainPositions.ShowDialog();
                }
                else {
                    frmDetailStaffReport rptDetailStaff = new frmDetailStaffReport(cboStaffID.Text);
                    rptDetailStaff.ShowDialog();
                }
            }
            else if (tabControl1.SelectedTab == tpBeds) {
                if (rdbListAllBeds.Checked)
                {
                    frmReportListAllBeds rptAllBeds = new frmReportListAllBeds();
                    rptAllBeds.ShowDialog();
                }
                else { 
                    string[] st = new string[4];
                    CheckBox[] arrChb = {chbFree, chbOccupied};
                    string[] arrSt = {"Free", "Occupied"};
                    bool b = false;
                    for(int i=0;i<arrChb.Length;i++){
                        if(arrChb[i].Checked){
                            st[i] = arrSt[i];
                            b = true;
                        }else{
                            st[i] = "";
                        }
                    }

                    if (b == false)
                    {
                        MessageBox.Show("You need to choose at least one position");
                        return;
                    }

                    frmReportCertainBeds rptCertainBeds = new frmReportCertainBeds(st);
                    rptCertainBeds.ShowDialog();
                }
            }
            else if (tabControl1.SelectedTab == tpPatient)
            {
                if (rdbListAllPatients.Checked)
                {
                    frmAllPatientReport rptAllPatients = new frmAllPatientReport();
                    rptAllPatients.ShowDialog();
                }
                else
                {
                    frmPatientReport rptDetailPatient = new frmPatientReport(cboPatientID.Text);
                    MessageBox.Show("cboPatientID.Text" + cboPatientID.Text);
                    rptDetailPatient.ShowDialog();
                }
            }
            else {
                frmReportCheckInDay rptciday = new frmReportCheckInDay(cboDoBYear.Text + "/" + cboDoBMonth.Text + "/" + cboDoBDay.Text);
                rptciday.ShowDialog();
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=TVY\\SQLEXPRESS;Initial Catalog=HospitalManagement;User ID=vannyou;Password=computer");
            //con.Open();

            cboDoBDay.Items.Clear();
            cboDoBMonth.Items.Clear();
            cboDoBYear.Items.Clear();
            cboDoBDay.IntegralHeight = false;
            cboDoBMonth.IntegralHeight = false;
            cboDoBYear.IntegralHeight = false;
            cboDoBDay.MaxDropDownItems = 8;
            cboDoBMonth.MaxDropDownItems = 8;
            cboDoBYear.MaxDropDownItems = 8;
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

            tabControl1.SelectedTab = tpCheckIn;
            rdbSingleDay.Checked = true;

            cboDoBDay.Text = cboDoBDay.Items[0].ToString();
            cboDoBMonth.Text = cboDoBMonth.Items[0].ToString();
            cboDoBYear.Text = cboDoBYear.Items[0].ToString();
        }

        private void rdbListStaffCertainPos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListStaffCertainPos.Checked) {
                checkBoxPosition(true);
                comboBoxStaff(false);
            }
        }

        private void rdbDetailStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDetailStaff.Checked) {
                checkBoxPosition(false);
                comboBoxStaff(true);
                cboStaffID.Items.Clear();
                cboStaffName.Items.Clear();
                da = new SqlDataAdapter("SELECT sID, sName FROM tbStaff WHERE sID<>'A001'", Hospital_Management.frmLogin.con);
                dtStaffs = new DataTable();
                da.Fill(dtStaffs);
                foreach (DataRow row in dtStaffs.Rows) {
                    cboStaffID.Items.Add(row[0].ToString());
                    cboStaffName.Items.Add(row[1].ToString());
                }
                da.Dispose();
                if (cboStaffID.Items.Count > 0)
                {
                    cboStaffID.Text = cboStaffID.Items[0].ToString();
                    cboStaffName.Text = cboStaffName.Items[0].ToString();
                }
            }
        }

        private void rdbListAllStaffs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListAllStaffs.Checked) {
                checkBoxPosition(false);
                comboBoxStaff(false);
            }
        }

        private void cboStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtStaffs.Rows) {
                if (cboStaffID.Text == row[0].ToString()) {
                    cboStaffName.SelectedItem = row[1].ToString();
                }
            }
        }

        private void cboStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtStaffs.Rows)
            {
                if (cboStaffName.Text == row[1].ToString())
                {
                    cboStaffID.SelectedItem = row[0].ToString();
                }
            }
        }

        private void rdbListAllBeds_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListAllBeds.Checked) {
                chbFree.Enabled = false;
                chbOccupied.Enabled = false;
            }
        }

        private void rdbListCertainBeds_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListCertainBeds.Checked) {
                chbFree.Enabled = true;
                chbOccupied.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpCheckIn) {
                rdbSingleDay.Checked = true;
            }
            else if (tabControl1.SelectedTab == tpPatient) {
                rdbListAllPatients.Checked = true;
            }
            else if (tabControl1.SelectedTab == tpStaffs)
            {
                rdbListAllStaffs.Checked = true;
            }
            else {
                rdbListAllBeds.Checked = true;
            }
        }

        private void rdbDetailPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDetailPatient.Checked)
            {
                comboBoxPatient(true);
                cboPatientID.Items.Clear();
                cboPatientName.Items.Clear();
                da = new SqlDataAdapter("SELECT pID, pName FROM tbPatient", Hospital_Management.frmLogin.con);
                dtPatients = new DataTable();
                da.Fill(dtPatients);
                foreach (DataRow row in dtPatients.Rows)
                {
                    cboPatientID.Items.Add(row[0].ToString());
                    cboPatientName.Items.Add(row[1].ToString());
                }
                da.Dispose();
                if (cboPatientID.Items.Count > 0)
                {
                    cboPatientID.Text = cboPatientID.Items[0].ToString();
                    cboPatientName.Text = cboPatientName.Items[0].ToString();
                }
            }
        }

        private void rdbListAllPatients_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListAllPatients.Checked) {
                comboBoxPatient(false);
            }
        }

        private void cboPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtPatients.Rows)
            {
                if (cboPatientID.Text == row[0].ToString())
                {
                    cboPatientName.SelectedItem = row[1].ToString();
                }
            }
        }

        private void cboPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtPatients.Rows)
            {
                if (cboPatientName.Text == row[1].ToString())
                {
                    cboPatientID.SelectedItem = row[0].ToString();
                }
            }
        }

        private void cboDoBMonth_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
