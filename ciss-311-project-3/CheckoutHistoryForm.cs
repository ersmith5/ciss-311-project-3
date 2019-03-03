using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutHistory_Form
{
    public partial class CheckoutHistoryForm : Form
    {
        //variable for database connection string
        string connectionString;
        SqlConnection conn;

        public CheckoutHistoryForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"]
                .ConnectionString;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT books.book_id, books.title, checkout.date, borrowers.borrower_id, borrowers.first_name, borrowers.last_name " +
                "FROM Library.books JOIN Membership.checkout ON books.book_id = checkout.book_id JOIN Membership.borrowers ON checkout.borrower_id = borrowers.borrower_id " +
                "WHERE isbn LIKE " + isbnBox.Text, conn))
            {
                adapter.Fill(dt);
                HistoryView.DataSource = dt;



            }

        }
    }
}