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

        private void picBox_Search_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = txtSearch.Text;

            // Search for the items based on the search term
            dgv_main.DataSource = userRepo.SearchUserRole(searchTerm);
        }

        private void btnRegistion_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(username))
            {
                errorProviderCustom.SetError(txtUsername, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }
            DBSYSEntities db = new DBSYSEntities();
            db.sp_newUser(txtUsername.Text, txtPassword.Text, 1, (Int32)UserLogged.GetInstance().UserAccount.userId);
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
            String username = txtUsername.Text;
            String pass = txtPassword.Text;
            String strOutputMsg = "";

            if (userSelectedId == null)
            {
                MessageBox.Show("No User Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = userRepo.RemoveUser(userSelectedId, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                //reset the selected id
                userSelectedId = null;

                txtPassword.Clear();
                txtUsername.Clear();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(username))
            {
                errorProviderCustom.SetError(txtUsername, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }

            var userAccount = new UserAccount()
            {
                userName = username,
                userPassword = pass
            };

            ErrorCode retValue = userRepo.UpdateUser(userSelectedId, userAccount, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                // Refresh the data grid
                Frm_Admin_Dashboard_Load(sender, new EventArgs());

                //reset the selected id
                userSelectedId = null;

                txtPassword.Clear();
                txtUsername.Clear();
            
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
