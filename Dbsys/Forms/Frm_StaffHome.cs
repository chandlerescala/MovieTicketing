﻿using System;
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
    public partial class Frm_StaffHome : Form
    {
        public Frm_StaffHome()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Admin_AccountManagement al = new Frm_Admin_AccountManagement();
            al.Show();
            this.Close();
        }

        private void Frm_AdminHome_Load(object sender, EventArgs e)
        {
            txtLoggedUser.Text = UserLogged.GetInstance().UserAccount.userName;
        }

        private void picBox_AddMovie_Click(object sender, EventArgs e)
        {
            Frm_Admin_AddMovie add = new Frm_Admin_AddMovie();
            add.Show();
            this.Close();
        }

        private void picBox_ViewMovie_Click(object sender, EventArgs e)
        {
            Frm_Admin_ViewMovies view = new Frm_Admin_ViewMovies();
            view.Show();
            this.Close();
        }

        private void picBox_History_Click(object sender, EventArgs e)
        {
            Frm_Admin_History hist = new Frm_Admin_History();
            hist.Show();
            this.Close();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_History hist = new Frm_Admin_History();
            hist.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login login = new Frm_Login();
            login.Show();
        }

        private void profileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProfileSettings profile = new Frm_ProfileSettings();
            profile.Show();

            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProfileSettings profile = new Frm_ProfileSettings();
            profile.Show();

            this.Close();
        }
    }
}