using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys
{
    public partial class Frm_UserHome : Form
    {
        public Frm_UserHome()
        {
            InitializeComponent();
        }

        private void picBox_m1_Click(object sender, EventArgs e)
        {
            Movie1 mov1 = new Movie1();
            mov1.Show();
            this.Hide();
        }

        private void linkLabel_m1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Movie1 mov1 = new Movie1();
            mov1.Show();
            this.Hide();
        }

        private void picBox_m2_Click(object sender, EventArgs e)
        {
            Movies2 mov2 = new Movies2();
            mov2.Show();
            this.Hide();
        }

        private void linkLabel_m2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Movies2 mov2 = new Movies2();
            mov2.Show();
            this.Hide();
        }

        private void picBox_m3_Click(object sender, EventArgs e)
        {
            Movies3 mov3 = new Movies3();
            mov3.Show();
            this.Hide();
        }

        private void linkLabel_m3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Movies3 mov3 = new Movies3();
            mov3.Show();
            this.Hide();
        }

        private void picBox_m4_Click(object sender, EventArgs e)
        {
            Movies4 mov4 = new Movies4();
            mov4.Show();
            this.Hide();
        }

        private void linkLabel_m4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Movies4 mov4 = new Movies4();
            mov4.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login login = new Frm_Login();
            login.Show();
        }
    }
}
