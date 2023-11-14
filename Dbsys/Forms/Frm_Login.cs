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
using Dbsys.Forms;

namespace Dbsys
{
    
    public partial class Frm_Login : Form
    {
        UserRepository userRepo;
        public Frm_Login()
        {
            InitializeComponent();
            //
            userRepo = new UserRepository();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProviderCustom.SetError(txtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.userPassword.Equals(txtPassword.Text))    
                {

                    UserLogged.GetInstance().UserAccount = userLogged;

                    switch ((Role)userLogged.roleId)
                    {
                        case Role.Customer:
                            // Load user Home
                            new Frm_UserHome().Show();
                            this.Hide();
                            break;
                        case Role.Staff:
                            // Load Teacher Dashboard
                            //new Frm_staff().Show();
                            this.Hide();
                            break;
                        case Role.Admin:
                            // Load Admin Dashboard
                            new Frm_AdminHome().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRigester_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Instantiate new object of class Frm_Register
            Frm_Register frm = new Frm_Register();
            frm.ShowDialog();

            txtUsername.Text = frm.username;

            //using (var frm = new Frm_Register())
            //{
            //    frm.ShowDialog();
            //    txtUsername.Text = frm.username;
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked)
            {
                // Disable password masking
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Enable password masking with asterisks
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
