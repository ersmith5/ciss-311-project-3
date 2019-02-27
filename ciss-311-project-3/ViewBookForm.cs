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
    public partial class ViewBookForm : Form
    {
        public Book book;

        /// <summary>
        /// Connection string to the local database.
        /// </summary>
        protected string connectionString;

        /// <summary>
        /// Established database connection.
        /// </summary>
        SqlConnection conn;

        public ViewBookForm(int book_id)
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"].ConnectionString;

            LoadBookFromDatabase(book_id);
        }

        private void ViewBookFrom_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = book.Title;
        }

        /// <summary>
        /// Load the Book's details from the library.
        /// </summary>
        /// <param name="book_id"></param>
        /// <returns></returns>
        protected void LoadBookFromDatabase(int book_id)
        {
            // Prepare to establish a database connection.
            using (conn = new SqlConnection(connectionString))
            {
                // Instantiate a row to store the single Book record from the database.
                DataRow bookRow;

                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT b.* FROM Library.books as b WHERE b.book_id = @searchString",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", book_id);

                        // Establish a variable for the results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        bookRow = resultsTable.Rows[0];
                    }
                }

                // Instantiate a List of Authors for one or more Author records from the database.
                List<Author> authorsList = new List<Author>();

                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT a.* " +
                        "FROM Library.authors as a " +
                        "JOIN Library.author_book as ab on a.author_id = ab.author_id " +
                        "JOIN Library.books as b on ab.book_id = b.book_id " +
                        "WHERE b.book_id = @searchString",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", book_id);

                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        foreach (DataRow dataRow in resultsTable.Rows)
                        {
                            // Add the Author to the Authors List.
                            authorsList.Add(
                                new Author(
                                    dataRow[1].ToString(), // first_name
                                    dataRow[2].ToString(), // last_name
                                    dataRow[3].ToString()  // about_the_author
                                )
                            );
                        }
                    }
                }
                DateTime year = new DateTime(int.Parse(bookRow[2].ToString()), 1, 1);

                // Create a Book object built from the database records.
                book =  new Book(
                    bookRow[1].ToString(), // title
                    authorsList,
                    year,
                    bookRow[3].ToString(), // isbn
                    bookRow[4].ToString(), // location
                    int.Parse(bookRow[5].ToString()) // copies
                );

                SetBookFields(book);
            }
        }

        private void SetBookFields(Book book)
        {
            tbxISBN.Text = book.ISBN;
            tbxCopywriteYear.Text = book.Year.Year.ToString();
            tbxLocation.Text = book.Location;
            tbxTotalCopies.Text = book.Copies.ToString();
            tbxAvailableCopies.Text = "0";

            foreach(Author author in book.GetAuthors())
            {
                lbxAuthors.Items.Add(author.FirstName + " " + author.LastName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
