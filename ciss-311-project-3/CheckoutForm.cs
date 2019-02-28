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


namespace ciss_311_project_3
{
    public partial class CheckoutForm : Form
    {
        /// <summary>
        /// Connection string to the local database.
        /// </summary>
        protected string connectionString;

        /// <summary>
        /// The book to be checked out.
        /// </summary>
        protected Book book;

        /// <summary>
        /// The list of available borrowers
        /// </summary>
        protected List<Borrower> borrowers;

        public CheckoutForm(Book book)
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;

            this.book = book;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            borrowers = GetBorrowers();

            cbxBorrower.DataSource = borrowers;
        }

        //protected List<Borrower> GetBorrowers()
        protected List<Borrower> GetBorrowers()
        {
            List<Borrower> retrivedBorrowers = new List<Borrower>();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT * FROM Membership.borrowers as b",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Establish a variable for the results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        // Create a borrower object for each record retrieved
                        if (resultsTable.Rows.Count < 0)
                        {
                            cbxBorrower.Items.Add("No borrowers available");
                            cbxBorrower.Enabled = false;
                        }
                        else
                        {
                            foreach (DataRow row in resultsTable.Rows)
                            {
                                if (row[1].ToString().Trim() == "Student")
                                {
                                    retrivedBorrowers.Add(new StudentBorrower(
                                        int.Parse(row[0].ToString().Trim()), 
                                        row[2].ToString().Trim(), 
                                        row[3].ToString().Trim()
                                    ));
                                }
                                else
                                {
                                    retrivedBorrowers.Add(new FacultyBorrower(
                                        int.Parse(row[0].ToString().Trim()), 
                                        row[2].ToString().Trim(), 
                                        row[3].ToString().Trim()
                                    ));
                                }
                            }
                        }
                    }
                }
            }

            return retrivedBorrowers;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevent a checkout if no Borrower is selectable.
            btnCheckout.Enabled = false;

            if (cbxBorrower.Enabled == true)
            {
                Borrower selectedBorrower = (Borrower)cbxBorrower.SelectedItem;

                int currentCheckedOutBooks = GetCurrentCheckedOutBooksCount(selectedBorrower.ID);

                tbxBorrower.Text = selectedBorrower.FullName();
                tbxBookCheckoutAllotment.Text = selectedBorrower.BookAllotment().ToString();
                tbxCurrentCheckedOutBooks.Text = currentCheckedOutBooks.ToString();
                tbxBookToCheckout.Text = book.Title;

                if (currentCheckedOutBooks < selectedBorrower.BookAllotment())
                {
                    btnCheckout.Enabled = true;
                }
            }
        }

        protected int GetCurrentCheckedOutBooksCount(int borrowerID)
        {
            int booksCheckedOut = 0;

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT COUNT(c.borrower_id) FROM Membership.checkout as c WHERE c.borrower_id = @searchString",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", borrowerID);

                        // Establish a variable for the results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        // Get the returned count (first row, first column)
                        booksCheckedOut = int.Parse(resultsTable.Rows[0][0].ToString());
                    }
                }
            }

            return booksCheckedOut;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // TODO: Do the checkout code
            MessageBox.Show("This book has been checked out.");

            // TODO: ? Tell the parent to refresh the book's info?
            Close();
        }
    }
}
