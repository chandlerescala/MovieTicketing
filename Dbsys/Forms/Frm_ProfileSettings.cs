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
    public partial class Frm_ProfileSettings : Form
    {
        UserRepository userRepo;
        public Frm_ProfileSettings()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void Frm_ProfileSettings_Load(object sender, EventArgs e)
        {
            txtLoggedUser.Text = UserLogged.GetInstance().UserAccount.userName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch ((Role)UserLogged.GetInstance().UserAccount.roleId)
            {
                case Role.Customer:
                    // Load user Home
                    new Frm_UserHome().Show();
                    this.Hide();
                    break;
                case Role.Staff:
                    // Load staff home
                    //new Frm_StaffHome().Show();
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


    }
}
