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
    /// <summary>
    /// Structure used to hold the selectable dropdown text and the related SQL query.
    /// </summary>
    public struct SearchObject
    {
        /// <summary>
        /// Name to be displayed in the dropdown.
        /// </summary>
        public string Name;

        /// <summary>
        /// SQL command to be executed for this selection.
        /// </summary>
        public string SqlCommandString;
    }

    public partial class SearchBookForm : Form
    {
        /// <summary>
        /// Connection string to the local database.
        /// </summary>
        protected string connectionString;

        /// <summary>
        /// Established database connection.
        /// </summary>
        SqlConnection conn;

        /// <summary>
        /// Searchable criteria for in the database.
        /// </summary>
        protected SearchObject[] searchOptions;

        /// <summary>
        /// Selected searchable criteria to be used for the SQL query.
        /// </summary>
        protected SearchObject selectedSearchOption;

        /// <summary>
        /// String to be searched in the database.
        /// </summary>
        protected string searchString;

        /// <summary>
        /// Table results from the executed SQL query.
        /// </summary>
        protected DataTable resultsTable;

        /// <summary>
        /// Form constructor.
        /// </summary>
        public SearchBookForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"].ConnectionString;

            searchOptions = new SearchObject[] {
                new SearchObject {
                    Name = "Author",
                    SqlCommandString = "SELECT b.book_id, b.title as book_title, CONCAT(a.first_name, ' ', a.last_name) as author " +
                    "FROM Library.books as b " +
                    "JOIN Library.author_book as ab on ab.book_id = b.book_id " +
                    "JOIN Library.authors as a on a.author_id = ab.author_id " +
                    "WHERE CONCAT(a.first_name, ' ', a.last_name) LIKE @searchString",
                },
                new SearchObject{
                    Name = "Title",
                    SqlCommandString = "SELECT b.book_id, b.title as book_title, CONCAT(a.first_name, ' ', a.last_name) as author " +
                    "FROM Library.books as b " +
                    "JOIN Library.author_book as ab on ab.book_id = b.book_id " +
                    "JOIN Library.authors as a on a.author_id = ab.author_id " +
                    "WHERE b.title LIKE @searchString",
                },
                new SearchObject {
                    Name = "ISBN",
                    SqlCommandString = "SELECT b.book_id, b.title as book_title, CONCAT(a.first_name, ' ', a.last_name) as author " +
                    "FROM Library.books as b " +
                    "JOIN Library.author_book as ab on ab.book_id = b.book_id " +
                    "JOIN Library.authors as a on a.author_id = ab.author_id " +
                    "WHERE b.isbn LIKE @searchString",
                },
            };
        }

        /// <summary>
        /// On form load, populate the controls.
        /// </summary>
        /// <param name="sender">Form that triggered the event.</param>
        /// <param name="e">Event Arguments.</param>
        private void SearchBookForm_Load(object sender, EventArgs e)
        {
            this.cbxSearchOptions.DataSource = new object[] {
                "Author",
                "Title",
                "ISBN"
            };
        }

        /// <summary>
        /// Closes the current form.
        /// </summary>
        /// <param name="sender">Form that triggered the event.</param>
        /// <param name="e">Event Arguments.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comd = new SqlCommand(selectedSearchOption.SqlCommandString, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@searchString", '%' + tbxSearchString.Text + '%');

                        resultsTable = new DataTable();

                        adapter.Fill(resultsTable);

                        lvwResults.Clear();

                        if (resultsTable.Rows.Count < 1)
                        {
                            lvwResults.Items.Add("No books found.");
                            lvwResults.Enabled = false;
                        }
                        else
                        {
                            lvwResults.Enabled = true;

                            foreach (DataRow dataRow in resultsTable.Rows)
                            {
                                lvwResults.Items.Add(dataRow[1].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void cbxSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSearchOption = searchOptions[cbxSearchOptions.SelectedIndex];
        }

        private void lvwResults_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lvwResults.SelectedItems[0].Index.ToString());
        }
    }
}
