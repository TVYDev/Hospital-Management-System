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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
            dgvCheckIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckIn.RowHeadersVisible = false;
            dgvCheckIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckOut.RowHeadersVisible = false;
            dgvCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckOut.Columns[4].DefaultCellStyle.Format = "dd-MMM-yy";
            dgvCheckOut.Columns[8].DefaultCellStyle.Format = "dd-MMM-yy";
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            //SSK.ConnectDB_Win("Anonymous");
            //SSK.ConnectDB_Auth("SSK-10", "admin", "admin");
            //Recent List
            SSK.LoadData("SELECT * FROM vwSSKTop5");
            dgvRecent.DataSource = SSK.dt;
            SSK.DisableColumnSorted(dgvRecent);
            //Check-in List
            SSK.LoadData("SELECT * FROM vwSSK");
            dgvCheckIn.DataSource = SSK.dt;
            dgvCheckIn.Columns[9].Visible = false;  //Photo column
            dgvCheckOut.Columns[9].Visible = false;
            SSK.DisableColumnSorted(dgvCheckIn);
            SSK.DisableColumnSorted(dgvCheckOut);
            dgvCheckIn.Columns[0].HeaderText = "No";
            dgvCheckIn.Columns[1].HeaderText = "ID";
            dgvCheckIn.Columns[2].HeaderText = "Name";
            dgvCheckIn.Columns[3].HeaderText = "Sex";
            dgvCheckIn.Columns[4].HeaderText = "Date of Birth";
            dgvCheckIn.Columns[5].HeaderText = "Illness";
            dgvCheckIn.Columns[6].HeaderText = "Bed";
            dgvCheckIn.Columns[7].HeaderText = "Doctor";
            dgvCheckIn.Columns[8].HeaderText = "Date In";
            clearSelection();
        }
        private void btnAddCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                SSK.MoveDataBetweenDataGridViews(dgvCheckIn, dgvCheckOut);
                dgvCheckOut.Rows[dgvCheckOut.RowCount - 1].Cells[10].Value = DateTime.Now.ToString("dd/MM/yyyy");
                clearSelection();
                pictureBox.Image = null;
            }
            catch (Exception exc) {     }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {           
            DataRow drow = SSK.dt.NewRow();
            foreach (DataGridViewRow dgv in dgvCheckOut.SelectedRows)
            {
                for (int i = 0; i < dgvCheckOut.ColumnCount-1; i++)
                {
                    drow[i] = dgv.Cells[i].Value;
                }
                dgvCheckOut.Rows.Remove(dgv);
                SSK.dt.Rows.Add(drow);
                SSK.dt.AcceptChanges();
            }            
            clearSelection();
            pictureBox.Image = null;
        }
        void clearSelection() 
        {
            dgvCheckIn.ClearSelection();
            dgvCheckOut.ClearSelection();
            dgvRecent.ClearSelection();
            txtSearch.Focus();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            clearSelection();
            SSK.SearchDataGridView(dgvCheckIn, txtSearch.Text.ToLower());
            try
            {
                dgvCheckIn_CellClick(dgvCheckIn, new DataGridViewCellEventArgs(1, dgvCheckIn.SelectedRows[0].Index));
            }catch (Exception exc) { }
        }

        private void dgvCheckIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox.Image = null;
            byte[] image = null;
            try
            {
                image = (byte[])dgvCheckIn.Rows[e.RowIndex].Cells[9].Value;
            }
            catch (Exception ex) { }
            if (dgvCheckIn.RowCount > -1)
            {
                if(image != null)
                {
                    pictureBox.Image = SSK.GetImage(image);
                }                
            }
        }
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            clearSelection();
            pictureBox.Image = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clearSelection();
            pictureBox.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCheckOut.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save it?", "SAVE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //SSK.con.Open();
                    SSK.cmm = new SqlCommand("spSSK", Hospital_Management.frmLogin.con);
                    SSK.cmm.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < dgvCheckOut.Rows.Count; i++)
                    {
                        SSK.cmm.Parameters.Clear();     //Solution for "Procedure or function has too many arguments specified"
                        SSK.cmm.Parameters.AddWithValue("@ciNo", int.Parse(dgvCheckOut.Rows[i].Cells[0].Value.ToString()));
                        SSK.cmm.Parameters.AddWithValue("@pID", dgvCheckOut.Rows[i].Cells[1].Value.ToString());
                        SSK.cmm.Parameters.AddWithValue("@bID", dgvCheckOut.Rows[i].Cells[6].Value.ToString());
                        SSK.cmm.ExecuteNonQuery();
                    }
                    clearSelection();
                    pictureBox.Image = null;
                    dgvCheckOut.Rows.Clear();
                }                
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            Form f = new WindowsFormsApplication3.MainForm();
            f.Show();
            this.Hide();
        }

        private void dgvCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox.Image = null;
            byte[] image = null;
            try
            {
                image = (byte[])dgvCheckOut.Rows[e.RowIndex].Cells[9].Value;
            }
            catch (Exception ex) { }
            if (dgvCheckOut.RowCount > -1)
            {
                if (image != null)
                {
                    pictureBox.Image = SSK.GetImage(image);
                }
            }
        }
    }
}