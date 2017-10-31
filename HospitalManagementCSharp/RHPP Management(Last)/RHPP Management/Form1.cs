using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            FileStream fs;
            StreamReader sr;
            int i;
            bool x = false; string[] st;
            if (cboxID.Checked==true && txtFind.Text == "" && cboxName.Checked == false)
            {
                MessageBox.Show("Please enter ID.");
                fs = new FileStream("CheckIn.txt", FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    st = sr.ReadLine().Split('#');
                    ListView.Items.Add(st[0]);
                    i = ListView.Items.Count - 1;
                    ListView.Items[i].SubItems.Add(st[1]);
                    ListView.Items[i].SubItems.Add(st[2]);
                    ListView.Items[i].SubItems.Add(st[3]);
                    ListView.Items[i].SubItems.Add(st[4]);
                    ListView.Items[i].SubItems.Add(st[5]);
                    ListView.Items[i].SubItems.Add(st[6]);
                    ListView.Items[i].SubItems.Add(st[7]);
                    ListView.Items[i].SubItems.Add(st[8]);
                    ListView.Items[i].SubItems.Add(st[9]);
                    ListView.Items[i].SubItems.Add(st[10]);
                    ListView.Items[i].SubItems.Add(st[11]);
                    ListView.Items[i].SubItems.Add(st[13]);
                    ListView.Items[i].SubItems.Add(st[12]);

                }
                sr.Close();
                fs.Close();
                return;
            }
            if (cboxName.Checked == true && txtFind.Text == "" && cboxID.Checked==false)
            {
                MessageBox.Show("Please enter Name.");
                fs = new FileStream("CheckIn.txt", FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    st = sr.ReadLine().Split('#');
                    ListView.Items.Add(st[0]);
                    i = ListView.Items.Count - 1;
                    ListView.Items[i].SubItems.Add(st[1]);
                    ListView.Items[i].SubItems.Add(st[2]);
                    ListView.Items[i].SubItems.Add(st[3]);
                    ListView.Items[i].SubItems.Add(st[4]);
                    ListView.Items[i].SubItems.Add(st[5]);
                    ListView.Items[i].SubItems.Add(st[6]);
                    ListView.Items[i].SubItems.Add(st[7]);
                    ListView.Items[i].SubItems.Add(st[8]);
                    ListView.Items[i].SubItems.Add(st[9]);
                    ListView.Items[i].SubItems.Add(st[10]);
                    ListView.Items[i].SubItems.Add(st[11]);
                    ListView.Items[i].SubItems.Add(st[13]);
                    ListView.Items[i].SubItems.Add(st[12]);

                }
                sr.Close();
                fs.Close();
                return;
            }
            fs = new FileStream("CheckIn.txt", FileMode.Open);
            sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                st = sr.ReadLine().Split('#');
                if (cboxID.Checked == true && cboxName.Checked == false && (txtFind.Text = int.Parse(txtFind.Text).ToString("000")) == st[0])
                {
                    ListView.Items.Add(st[0]);
                    i = ListView.Items.Count - 1;
                    ListView.Items[i].SubItems.Add(st[1]);
                    ListView.Items[i].SubItems.Add(st[2]);
                    ListView.Items[i].SubItems.Add(st[3]);
                    ListView.Items[i].SubItems.Add(st[4]);
                    ListView.Items[i].SubItems.Add(st[5]);
                    ListView.Items[i].SubItems.Add(st[6]);
                    ListView.Items[i].SubItems.Add(st[7]);
                    ListView.Items[i].SubItems.Add(st[8]);
                    ListView.Items[i].SubItems.Add(st[9]);
                    ListView.Items[i].SubItems.Add(st[10]);
                    ListView.Items[i].SubItems.Add(st[11]);
                    // ListView.Items[i].SubItems.Add(st[12]);
                    ListView.Items[i].SubItems.Add(st[13]);
                    ListView.Items[i].SubItems.Add(st[12]);
                    //txtFind.Clear();
                    x = true;
                }
                if (cboxName.Checked == true && cboxID.Checked == false && txtFind.Text == st[1])
                {
                    ListView.Items.Add(st[0]);
                    i = ListView.Items.Count - 1;
                    ListView.Items[i].SubItems.Add(st[1]);
                    ListView.Items[i].SubItems.Add(st[2]);
                    ListView.Items[i].SubItems.Add(st[3]);
                    ListView.Items[i].SubItems.Add(st[4]);
                    ListView.Items[i].SubItems.Add(st[5]);
                    ListView.Items[i].SubItems.Add(st[6]);
                    ListView.Items[i].SubItems.Add(st[7]);
                    ListView.Items[i].SubItems.Add(st[8]);
                    ListView.Items[i].SubItems.Add(st[9]);
                    ListView.Items[i].SubItems.Add(st[10]);
                    ListView.Items[i].SubItems.Add(st[11]);
                    // ListView.Items[i].SubItems.Add(st[12]);
                    ListView.Items[i].SubItems.Add(st[13]);
                    ListView.Items[i].SubItems.Add(st[12]);
                    //txtFind.Clear();
                    x = true;
                }                
                
            }
            sr.Close();
            fs.Close();

            if (x == false && txtFind.Text != "" && cboxID.Checked == true && cboxName.Checked == false || x == false && txtFind.Text != "" && cboxName.Checked == true && cboxID.Checked == false)
            {
                txtFind.Clear();
                MessageBox.Show("Patient not found");
                txtFind.Focus();
            }

           /* if (cboxID.Checked == false && cboxName.Checked == false && txtFind.Text != "" || cboxID.Checked == false && cboxName.Checked == false)
            {
                txtFind.Clear();
                MessageBox.Show("Please check ID or NAME to find.");                
            }
            if (cboxID.Checked == true && cboxName.Checked == true && txtFind.Text != "" || cboxID.Checked == true && cboxName.Checked == true)
            {
                cboxID.Checked = false;
                cboxName.Checked = false;
                txtFind.Clear();
                MessageBox.Show("Please check only one [ID or NAME)].");
            }  */                               

        }
  
        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Image only shows when select the item 
            if (ListView.SelectedItems.Count > 0)
            {
                pictureBox.ImageLocation = ListView.Items[ListView.SelectedIndices[0]].SubItems[13].Text;
            }          
            
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select patient to check-out.");
                return;
            }
            FileStream fs = new FileStream("CheckIn.txt",FileMode.Open);
            FileStream fs1 = new FileStream("CheckOut.txt",FileMode.Append);
            FileStream fs2 = new FileStream("Temp.txt",FileMode.Create);
            FileStream fs3 = new FileStream("Room.txt", FileMode.Open);
            FileStream fs4 = new FileStream("Temp1.txt", FileMode.Create);
            StreamReader srRoom = new StreamReader(fs3);
            StreamWriter swRoom = new StreamWriter(fs4);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs1);
            StreamWriter sw1 = new StreamWriter(fs2);
            //Object DateTime
            DateTime todaysDate = DateTime.Now.Date;
            string day = todaysDate.Day.ToString();
            string month = todaysDate.Month.ToString();
            string year = todaysDate.Year.ToString();
            string[] st;
            string ward="", bed="";
            while (!sr.EndOfStream)
            {
                st = sr.ReadLine().Split('#');
                if (ListView.Items[ListView.SelectedIndices[0]].Text == st[0])
                {
                    sw.WriteLine(ListView.Items[ListView.SelectedIndices[0]].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[1].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[2].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[3].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[4].Text + "#" +
                        ListView.Items[ListView.SelectedIndices[0]].SubItems[5].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[6].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[7].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[8].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[9].Text + "#" +
                        ListView.Items[ListView.SelectedIndices[0]].SubItems[10].Text + "#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[11].Text + "#" +st[12] +"#" + ListView.Items[ListView.SelectedIndices[0]].SubItems[12].Text + "#" + day + "/" + month + "/" + year);

                    ward = ListView.Items[ListView.SelectedIndices[0]].SubItems[7].Text;
                    bed = ListView.Items[ListView.SelectedIndices[0]].SubItems[8].Text;
                }
                if (st[0] != ListView.Items[ListView.SelectedIndices[0]].Text)
                {
                    sw1.WriteLine(st[0] + "#" + st[1] + "#" + st[2] + "#" + st[3] + "#" + st[4] + "#" + st[5] + "#" + st[6] + "#" + st[7] + "#" + st[8] + "#" + st[9] + "#" + st[10] + "#" + st[11] + "#" + st[12] + "#" + st[13] + "#" + st[14]);
                }
            }
            //MessageBox.Show(ward);
           // MessageBox.Show(bed);

            string[] storeRoom;
            while (!srRoom.EndOfStream) {
                storeRoom = srRoom.ReadLine().Split('#');
                if (storeRoom[0].Equals(ward))
                {
                    for (int i = 1; i < storeRoom.Length; i++)
                    {
                        if (storeRoom[i].Equals(bed))
                        {
                            storeRoom[i+1] = "Free";
                            break;
                        }
                    }
                }
                    for (int i = 0; i < storeRoom.Length-1; i++) {
                        swRoom.Write(storeRoom[i] + "#");
                    }
                    swRoom.WriteLine(storeRoom[storeRoom.Length-1]);
            }


            srRoom.Close();
            swRoom.Close();
            sw.Close();
            sw1.Close();
            sr.Close();
            fs.Close();
            fs1.Close();
            fs2.Close();
            fs3.Close();
            fs4.Close();
            ListView.Items.Remove(ListView.SelectedItems[0]);
            pictureBox.ImageLocation = "";
            cboxID.Checked = true;
            cboxName.Checked = false;
            txtFind.Clear();
            File.Delete("Room.txt");
            File.Move("Temp1.txt", "Room.txt");
            File.Delete("CheckIn.txt");
            File.Move("Temp.txt","CheckIn.txt");
            MessageBox.Show("Thank you!!!!!!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            pictureBox.ImageLocation = "";
            ListView.Items.Clear();
            cboxID.Checked = false;
            cboxName.Checked = false;
            txtFind.Clear();
            cboxID.Checked = true;
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            ListView.View = View.Details;
            ListView.GridLines = true;
            ListView.FullRowSelect = true;
            ListView.Columns.Add("ID", ListView.Width/25);
            ListView.Columns[0].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("NAME", ListView.Width / 8);
            ListView.Columns[1].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("SEX", ListView.Width / 22);
            ListView.Columns[2].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("AGE", ListView.Width / 22);
            ListView.Columns[3].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("ADDRESS", ListView.Width / 8);
            ListView.Columns[4].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("CONTACT NUM", ListView.Width / 10);
            ListView.Columns[5].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("DOCTOR", ListView.Width / 8);
            ListView.Columns[6].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("WARD", ListView.Width / 22);
            ListView.Columns[7].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("BED", ListView.Width / 22);
            ListView.Columns[8].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("ILLNESS", ListView.Width / 14);
            ListView.Columns[9].TextAlign = HorizontalAlignment.Center;            
            ListView.Columns.Add("WEIGHT", ListView.Width / 18);
            ListView.Columns[10].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("HEIGHT", ListView.Width / 18);
            ListView.Columns[11].TextAlign = HorizontalAlignment.Center;
            //ListView.Columns.Add("PHOTO", ListView.Width / 10);
            ListView.Columns.Add("CHECK-IN", ListView.Width / 8);
            ListView.Columns[12].TextAlign = HorizontalAlignment.Center;
            ListView.Columns.Add("Photo", ListView.Width * 0);
            
            //ListView.Columns[13].TextAlign = HorizontalAlignment.Center;
            //ListView.Columns.Add("CHECK-OUT", ListView.Width / 14);
            //ListView.Columns[14].TextAlign = HorizontalAlignment.Center;
            cboxID.Checked = true;

            FileStream fs = new FileStream("CheckIn.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] st;    int i;
            string str;
            while(!sr.EndOfStream){
                str = sr.ReadLine();
                st = str.Split('#');
                if (str.Equals("") == false)
                {
                    ListView.Items.Add(st[0]);
                    i = ListView.Items.Count - 1;
                    ListView.Items[i].SubItems.Add(st[1]);
                    ListView.Items[i].SubItems.Add(st[2]);
                    ListView.Items[i].SubItems.Add(st[3]);
                    ListView.Items[i].SubItems.Add(st[4]);
                    ListView.Items[i].SubItems.Add(st[5]);
                    ListView.Items[i].SubItems.Add(st[6]);
                    ListView.Items[i].SubItems.Add(st[7]);
                    ListView.Items[i].SubItems.Add(st[8]);
                    ListView.Items[i].SubItems.Add(st[9]);
                    ListView.Items[i].SubItems.Add(st[10]);
                    ListView.Items[i].SubItems.Add(st[11]);
                    ListView.Items[i].SubItems.Add(st[13]);
                    ListView.Items[i].SubItems.Add(st[12]);
                }
            }
            sr.Close();
            fs.Close();
        }

        private void frmCheckout_MouseClick(object sender, MouseEventArgs e)
        {
            //Click on form to clear SelectedItem and Image
            pictureBox.ImageLocation = "";
            ListView.SelectedItems.Clear();            
        }

        private void cboxID_MouseClick(object sender, MouseEventArgs e)
        {
            if (cboxID.Checked)
            {
                cboxName.Checked = false;
                cboxID.Checked = true;
            }
            else {
                cboxID.Checked = false;
                cboxName.Checked = true;
            }
            txtFind.Clear();
            txtFind.Focus();
        }

        private void cboxName_MouseClick(object sender, MouseEventArgs e)
        {

            if (cboxName.Checked)
            {
                cboxName.Checked = true;
                cboxID.Checked = false;
            }
            else {
                cboxName.Checked = false;
                cboxID.Checked = true;
            }
            txtFind.Clear();
            txtFind.Focus();
        }

        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.MainForm mainform = new WindowsFormsApplication3.MainForm();
            mainform.Show();
            this.Visible = false;
        }
        //Textbox accept only numeric
        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxID.Checked == true && cboxName.Checked == false)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                
            }
        }

        private void txtFind_MouseClick(object sender, MouseEventArgs e)
        {
            txtFind.Clear();
            txtFind.Focus();
        }

    }
}
