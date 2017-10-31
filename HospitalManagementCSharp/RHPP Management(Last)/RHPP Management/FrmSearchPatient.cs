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
    public partial class FrmSearchPatient : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        string pIDSearch;

        public FrmSearchPatient()
        {
            InitializeComponent();
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

        private void FrmSearchPatient_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Search here...";
            txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;

            dgvSearchPatient.Font = new Font("Comic Sans MS", 11);
            dgvSearchPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchPatient.RowHeadersVisible = false;
            dgvSearchPatient.AllowUserToAddRows = false;
            dgvSearchPatient.AllowUserToDeleteRows = false;
            dgvSearchPatient.AllowUserToOrderColumns = false;
            dgvSearchPatient.AllowUserToResizeColumns = false;
            dgvSearchPatient.AllowUserToResizeRows = false;
            dgvSearchPatient.ReadOnly = true;
            dgvSearchPatient.MultiSelect = false;

            da = new SqlDataAdapter("SELECT pID as ID, pName as Name, pSex as Sex, pDOB as [Date of Birth], pContact as [Contact Number] FROM tbPatient", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvSearchPatient.DataSource = dt;
            da.Dispose();
            dt.Dispose();
            dgvSearchPatient.ClearSelection();
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

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.ForeColor == System.Drawing.SystemColors.ScrollBar)
            {
                txtSearch.Text = "";
            }
            else { }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("SELECT pID as ID, pName as Name, pSex as Sex, pDOB as [Date of Birth], pContact as [Contact Number] FROM tbPatient WHERE pID LIKE '" + txtSearch.Text + "%' OR pName LIKE '" + txtSearch.Text + "%'", Hospital_Management.frmLogin.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvSearchPatient.DataSource = dt;
            da.Dispose();
            dt.Dispose();
            dgvSearchPatient.ClearSelection();
        }

        private void btnBackToCheckIn_Click(object sender, EventArgs e)
        {
            //Check_In1.frmCheckIn.pIDFromSearch = pIDSearch;
            Check_In1.frmCheckIn.loadDataFromSearch(pIDSearch);
            this.Close();
            Check_In1.frmCheckIn test = new Check_In1.frmCheckIn();
            
        }

        private void dgvSearchPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSearchPatient.Rows[e.RowIndex];
                pIDSearch = row.Cells[0].Value.ToString();
            }
            else {
                pIDSearch = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
