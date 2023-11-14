using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_AdminHome : Form
    {
        public Frm_AdminHome()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login login = new Frm_Login();
            login.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Admin_LogIn al = new Frm_Admin_LogIn();
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
    }
}
