using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = System.Drawing.Color.LightBlue;
           

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MainForm main = new MainForm();
            //main.Show();
             this.Close();
        }
    }
}
