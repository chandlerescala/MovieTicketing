using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys
{
    public partial class Frm_ProfileSettings : Form
    {

        public Frm_ProfileSettings()
        {
            InitializeComponent();
        }

        private void Frm_ProfileSettings_Load(object sender, EventArgs e)
        {
            txtLoggedUser.Text = UserLogged.GetInstance().UserAccount.userName;
            try
            {
                int userId = UserLogged.GetInstance().UserAccount.userId;
                using (var db = new DBSYSEntities())
                {
                    UserInformation userInfo = db.UserInformation.FirstOrDefault(u => u.userId == userId);

                    if (userInfo != null)
                    {
                        // Update the form fields with the retrieved user information
                        txtLoggedUser.Text = UserLogged.GetInstance().UserAccount.userName;
                        txtLastName.Text = userInfo.userInfLname;
                        txtFirstName.Text = userInfo.userInfFname;
                        txtAddress.Text = userInfo.userInfAddress;
                        txtEmail.Text = userInfo.userInfEmail;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch ((Role)UserLogged.GetInstance().UserAccount.roleId)
            {
                case Role.Customer:
                    // Load user Home
                    new Frm_CustomerHome().Show();
                    this.Hide();
                    break;
                case Role.Staff:
                    // Load staff home
                    new Frm_StaffHome().Show();
                    this.Hide();
                    break;
                case Role.Admin:
                    // Load admin home
                    new Frm_AdminHome().Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("User has no role!");
                    break;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (var db = new DBSYSEntities())
            {
                try
                {
                    // Retrieve the existing user information based on the logged-in user's ID
                    int userId = UserLogged.GetInstance().UserAccount.userId;

                    // Check if the user information already exists
                    UserInformation userInfo = db.UserInformation.FirstOrDefault(u => u.userId == userId);

                    if (userInfo == null)
                    {
                        // If user information doesn't exist, create a new record
                        userInfo = new UserInformation
                        {
                            userId = userId,
                            userInfLname = "Enter Last Name",
                            userInfFname = "Enter First Name",
                            userInfAddress = "Enter Address",
                            userInfEmail = "Enter Email"
                        };

                        db.UserInformation.Add(userInfo);
                    }

                    // Update the user information
                    userInfo.userInfLname = txtLastName.Text;
                    userInfo.userInfFname = txtFirstName.Text;
                    userInfo.userInfAddress = txtAddress.Text;
                    userInfo.userInfEmail = txtEmail.Text;

                    // Save the changes to the database
                    db.SaveChanges();

                    MessageBox.Show("User information updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
