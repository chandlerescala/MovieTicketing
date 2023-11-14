using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;

namespace Dbsys.Forms
{
    public partial class Frm_Admin_LogIn : Form
    {
        UserRepository userRepo;
        public Frm_Admin_LogIn()
        {
            InitializeComponent();
            //
            userRepo = new UserRepository();
        }

        private void Frm_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            dgv_main.DataSource = userRepo.AllUserRole();
            toolStripStatusUser.Text = UserLogged.GetInstance().UserAccount.userName;
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new Frm_UserEntry())
            {
                frm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_AdminHome ah = new Frm_AdminHome();
            ah.Show();

            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login login = new Frm_Login();
            login.Show();
        }

        private void picBox_Search_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = txtSearch.Text;

            // Search for the items based on the search term
            dgv_main.DataSource = userRepo.SearchUserRole(searchTerm);
        }
    }
}
