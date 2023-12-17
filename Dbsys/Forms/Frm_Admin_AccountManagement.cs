using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;

namespace Dbsys
{
    public partial class Frm_Admin_AccountManagement : Form
    {
        UserRepository userRepo;
        int? userSelectedId = null;
        private DBSYSEntities db;
        public Frm_Admin_AccountManagement()
        {
            InitializeComponent();
            //
            userRepo = new UserRepository();
            loadUser();
        }
        private void loadUser()
        {
            dgv_main.DataSource = userRepo.UserAccounts();
        }

        private void Frm_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            dgv_main.DataSource = userRepo.AllUserRole();
            toolStripStatusUser.Text = UserLogged.GetInstance().UserAccount.userName;

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
        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void picBox_Search_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = txtSearch.Text;

            // Search for the items based on the search term
            dgv_main.DataSource = userRepo.SearchUserRole(searchTerm);
        }

        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)dgv_main.Rows[e.RowIndex].Cells[0].Value;
                txtUsername.Text = dgv_main.Rows[e.RowIndex].Cells[1].Value as String;
                txtPassword.Text = dgv_main.Rows[e.RowIndex].Cells[2].Value as String;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBSYSEntities())
                {
                    if (userSelectedId != null)
                    {
                        // Remove user logic
                        db.Database.ExecuteSqlCommand(
                            "sp_RemovedUsers @UserID",
                            new SqlParameter("@UserID", userSelectedId)
                        );

                        MessageBox.Show("User removed successfully!");
                        loadUser();
                        userSelectedId = null;
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please select a user to remove.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBSYSEntities())
                {
                    if (userSelectedId != null)
                    {
                        // Update existing user logic
                        db.Database.ExecuteSqlCommand(
                            "sp_UpdatedUsers @UserID, @UserName, @UserPassword",
                            new SqlParameter("@UserID", userSelectedId),
                            new SqlParameter("@UserName", txtUsername.Text),
                            new SqlParameter("@UserPassword", txtPassword.Text)
                        );

                        MessageBox.Show("User updated successfully!");
                        loadUser();
                    }
                    else
                    {
                        MessageBox.Show("Please select a user to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
        }

       
    }
}
