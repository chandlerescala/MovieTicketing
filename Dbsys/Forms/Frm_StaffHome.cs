﻿using Dbsys.AppData;
using Dbsys.Forms;
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
            
        }

        private void Frm_AdminHome_Load(object sender, EventArgs e)
        {

            //txtLoggedUser.Text = UserLogged.GetInstance().UserAccount.userName;

            using (DBSYSEntities db = new DBSYSEntities())
            {
                int userId = UserLogged.GetInstance().UserAccount.userId;

                // Fetch the user information directly from the database
                var user = db.UserAccount
                             .Include("UserInformation")  // Assuming there's a navigation property named "UserInformation"
                             .FirstOrDefault(u => u.userId == userId);

                if (user != null)
                {
                    // Get the first UserInformation record (if any)
                    var userInformation = user.UserInformation.FirstOrDefault();

                    if (userInformation != null && !string.IsNullOrEmpty(userInformation.userInfFname))
                    {
                        txtLoggedUser.Text = userInformation.userInfFname;
                    }
                    else
                    {
                        txtLoggedUser.Text = user.userName;
                    }
                }
            }
        }

        private void picBox_AddMovie_Click(object sender, EventArgs e)
        {
            Frm_Staff_EditShowtimes sh = new Frm_Staff_EditShowtimes();
            sh.Show();
            this.Close();
        }

        private void picBox_ViewMovie_Click(object sender, EventArgs e)
        {
            
        }

        private void picBox_History_Click(object sender, EventArgs e)
        {
            Frm_TransactionHistory hist = new Frm_TransactionHistory();
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
            Frm_TransactionHistory hist = new Frm_TransactionHistory();
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

        private void picBox_UserInfo_Click(object sender, EventArgs e)
        {
            Frm_Staff_UserInformation u = new Frm_Staff_UserInformation();
            u.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Staff_UserInformation u = new Frm_Staff_UserInformation();
            u.Show();
            this.Close();
        }
    }
}
