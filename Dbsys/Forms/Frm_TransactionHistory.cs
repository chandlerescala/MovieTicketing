using Dbsys.AppData;
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
    public partial class Frm_TransactionHistory : Form
    {
   
        public Frm_TransactionHistory()
        {
            InitializeComponent();
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            using (var db = new DBSYSEntities())
            {
                // Load transaction history from the view
                var transactionHistory = db.vw_TransactionHistory.ToList();

                // Bind the transaction history to the DataGridView
                dataGridViewTransactionHistory.DataSource = transactionHistory;
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

        private void Frm_Admin_ViewMovies_Load(object sender, EventArgs e)
        {
           
        }

    }
}
