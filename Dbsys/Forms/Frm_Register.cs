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
    public partial class Frm_Register : Form
    {
        public string username = String.Empty;
        DBSYSEntities db; 
        private const string AdminPassword = "admin123";
        private const string StaffPassword = "staff123";
        public Frm_Register()
        {
            InitializeComponent();
            //
            db = new DBSYSEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
        }

        private void cbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Role.ToList();

            cbBoxRole.ValueMember = "roleId";
            cbBoxRole.DisplayMember = "roleName";
            cbBoxRole.DataSource = roles;
          
        }
        private string ShowPasswordInputDialog(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(label);

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private bool VerifyAdminPassword()
        {
            string inputPassword = ShowPasswordInputDialog("Admin Verification", "Enter admin password:");
            return AdminPassword.Equals(inputPassword);
        }

        private bool VerifyStaffPassword()
        {
            string inputPassword = ShowPasswordInputDialog("Staff Verification", "Enter staff password:");
            return StaffPassword.Equals(inputPassword);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }

            if (!txtPassword.Text.Equals(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRepassword, "Password not match");
                return;
            }
            int selectedRoleId = (Int32)cbBoxRole.SelectedValue;

            if (selectedRoleId == 3 && !VerifyAdminPassword())
            {
                MessageBox.Show("Admin password verification failed. Registration aborted.");
                return;
            }

            if (selectedRoleId == 2 && !VerifyStaffPassword())
            {
                MessageBox.Show("Staff password verification failed. Registration aborted.");
                return;
            }


            UserAccount nUserAccount = new UserAccount();
            nUserAccount.userName = txtUsername.Text;
            nUserAccount.userPassword = txtPassword.Text;
            nUserAccount.roleId = (Int32)cbBoxRole.SelectedValue;
            nUserAccount.userStatus = "Active";

            username = txtUsername.Text;

            db.UserAccount.Add(nUserAccount);
            db.SaveChanges();

            txtPassword.Clear();
            txtRepassword.Clear();
            txtUsername.Clear();
            MessageBox.Show("Registered!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
