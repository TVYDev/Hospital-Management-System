using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace RHPP_Management
{
    public class SSK
    {
        public static SqlConnection con;
        public static SqlCommand cmm;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        public static DataRow drow;
        public static void ConnectDB_Win(string dataSource) 
        {
            try
            {
                con = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog=HospitalManagement;Integrated Security=True");
            }
            catch (Exception exc) { }
        }
        public static void ConnectDB_Auth(string dataSource, string id, string password)
        {
            try
            {
                con = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog=HospitalManagement;User ID=" + id + ";Password=" + password);
            }
            catch (Exception exc) { }
        }
        public static void LoadData(string query)
        {
            try
            {
                da = new SqlDataAdapter(query, Hospital_Management.frmLogin.con);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception exc) { }
        }
        public static void DisableColumnSorted(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public static void MoveDataBetweenDataGridViews(DataGridView dgv1, DataGridView dgv2)
        {
            try
            {
                foreach (DataGridViewRow dgv in dgv1.SelectedRows)
                {
                    DataGridViewRow r = dgv.Clone() as DataGridViewRow;
                    for (int i = 0; i < dgv1.ColumnCount; i++)
                    {
                        r.Cells[i].Value = dgv.Cells[i].Value;
                    }
                    dgv1.Rows.Remove(dgv);
                    dgv2.Rows.Add(r);
                }
            }
            catch (Exception exc) { }
        }
        public static void SearchDataGridView(DataGridView dgv, String search_value) 
        {
            try
            {
                bool search = false;
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Equals(search_value.ToLower())
                        || row.Cells[2].Value.ToString().ToLower().Equals(search_value.ToLower()))
                    {
                        rowIndex = row.Index;
                        search = true;
                        break;
                    }
                }
                if (search == true)
                {
                    dgv.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception exc) { } 
        }
        //Convert image to byte
        public static byte[] SaveImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return (ms.GetBuffer()); 
        }
        //Convert byte to image
        public static Image GetImage(byte[] b_img)
        {
            MemoryStream ms = new MemoryStream(b_img);
            return Image.FromStream(ms);
        }

    }
}
