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
    public partial class Frm_Admin_History : Form
    {
        public Frm_Admin_History()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_AdminHome home = new Frm_AdminHome();
            home.Show();
            this.Close();
        }
    }
}
