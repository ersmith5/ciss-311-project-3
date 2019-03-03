using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    [Table(Name = "Library.books")]
    public class Book
    {
        /// <summary>
        /// Database ID of the Book.
        /// </summary>
        private int id;

        /// <summary>
        /// Title of the Book.
        /// </summary>
        private string title;

        /// <summary>
        /// Year (in DateTime format) the Book was published.
        /// </summary>
        private DateTime year;

        /// <summary>
        /// ISBN (13, digits only form) of the Book.
        /// </summary>
        private string isbn;

        /// <summary>
        /// Shelf location of the Book within the library.
        /// </summary>
        private string location;

        /// <summary>
        /// Number of copies the library owns.
        /// </summary>
        private int copies;

        /// <summary>
        /// Authors of the Book.
        /// </summary>
        private List<Author> authors;

        /// <summary>
        /// Connection string to the local database.
        /// </summary>
        protected string connectionString;

        [Column(Name = "book_id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Column(Name = "title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [Column(Name = "title")]
        public DateTime Year
        {
            get { return year; }
            set { year = value; }
        }

        [Column(Name = "isbn")]
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        [Column(Name = "location")]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [Column(Name = "copies")]
        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        public void AddAuthor(Author author)
        {
            authors.Add(author);
        }

        public List<Author> GetAuthors()
        {
            return authors;
        }

        /// <summary>
        /// Book Constructor without an Author.
        /// </summary>
        /// <param name="title">Title of the Book.</param>
        /// <param name="year">Year the book was published.</param>
        /// <param name="isbn">ISBN (13, digits only) of the Book.</param>
        /// <param name="location">Shelf location of the Book within the library.</param>
        /// <param name="copies">Number of copies the library owns.</param>
        public Book(int id, string title, DateTime year, string isbn, string location, int copies)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();

            connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;
        }

        /// <summary>
        /// Book Constructor with single Author.
        /// </summary>
        /// <param name="title">Title of the Book.</param>
        /// <param name="author">Single Author of the Book.</param>
        /// <param name="year">Year the book was published.</param>
        /// <param name="isbn">ISBN (13, digits only) of the Book.</param>
        /// <param name="location">Shelf location of the Book within the library.</param>
        /// <param name="copies">Number of copies the library owns.</param>
        public Book(int id, string title, Author author,  DateTime year, string isbn, string location, int copies)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();
            this.authors.Add(author);

            connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;
        }

        /// <summary>
        /// Book Constructor with multiple Authors.
        /// </summary>
        /// <param name="title">Title of the Book.</param>
        /// <param name="authors">List of Authors of the Book.</param>
        /// <param name="year">Year the book was published.</param>
        /// <param name="isbn">ISBN (13, digits only) of the Book.</param>
        /// <param name="location">Shelf location of the Book within the library.</param>
        /// <param name="copies">Number of copies the library owns.</param>
        public Book(int id, string title, List<Author> authors,  DateTime year, string isbn, string location, int copies)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();
            authors.ForEach((author) => {
                this.authors.Add(author);
            });

            connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;
        }

        /// <summary>
        /// Retrieve the Book with the given ID.
        /// </summary>
        /// <param name="bookId">ID of the Book to retrieve.</param>
        /// <returns>The requested Book.</returns>
        public static Book GetBook(int bookId)
        {
            // Local connection variable due to this being a static method.
            string connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Instantiate a row to store the single Book record from the database.
                DataRow bookRow;

                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT b.* FROM Library.books as b where b.book_id = @searchString",
                        conn
                ))
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", bookId);

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
                ))
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", bookId);

                        // In-memory table to hold the query results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        foreach (DataRow dataRow in resultsTable.Rows)
                        {
                            // Add the Author to the Authors List.
                            authorsList.Add(
                                new Author(
                                    dataRow["first_name"].ToString(), 
                                    dataRow["last_name"].ToString(), 
                                    dataRow["about_the_author"].ToString()
                                )
                            );
                        }
                    }
                }

                // Create a Book object built from the database records.
                return new Book(
                    int.Parse(bookRow["book_id"].ToString().Trim()),
                    bookRow["title"].ToString().Trim(),
                    authorsList,
                    new DateTime(int.Parse(bookRow["copyright_year"].ToString().Trim()), 1, 1),
                    bookRow["isbn"].ToString().Trim(),
                    bookRow["location"].ToString().Trim(),
                    int.Parse(bookRow["copies"].ToString().Trim())
                );
            }
        }


        /// <summary>
        /// Retrieve a List of Books with the given IDs.
        /// </summary>
        /// <param name="bookIds">IDs of the Books to retrieve.</param>
        /// <returns>A List of the requested Books.</returns>
        public static List<Book> GetBooksByID(List<int> bookIds)
        {
            // Local connection variable due to this being a static method.
            string connectionString = ConfigurationManager.ConnectionStrings[
                "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;

            DataTable bookResultsTable = new DataTable();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT b.* " + 
                        "FROM Library.books as b " + 
                        "WHERE b.book_id IN (@searchString)", 
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Insert the given List of IDs as a comma separated string.
                        comd.Parameters.AddWithValue("@searchString", string.Join(", ", bookIds.ToArray()));

                        // Execute the query and save the results.
                        adapter.Fill(bookResultsTable);
                    }
                }
            }

            // Instantiate a new list of Books.
            List<Book> bookList = new List<Book>();

            if (bookResultsTable.Rows.Count > 0)
            {
                // Build the List of Books from the retrieved results.
                foreach (DataRow row in bookResultsTable.Rows)
                {
                    bookList.Add(new Book(
                        int.Parse(row["book_id"].ToString().Trim()), 
                        row["title"].ToString().Trim(), 
                        Author.GetAuthorsForBook(int.Parse(row["book_id"].ToString().Trim())), 
                        new DateTime(int.Parse(row["copyright_year"].ToString().Trim()), 1, 1), 
                        row["isbn"].ToString().Trim(), 
                        row["location"].ToString().Trim(), 
                        int.Parse(row["copies"].ToString().Trim()) 
                    ));
                }
            }
            
            // Return the List of Books or an empty List of Books.
            return bookList;
        }

        /// <summary>
        /// Gets the number of copies of this Book that are currently checked out.
        /// </summary>
        /// <returns>Integer of the number of copies currently checked out.</returns>
        public int GetCheckedOutCount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
               "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
           ].ConnectionString;

            DataTable bookResultsTable = new DataTable();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT COUNT(c.book_id) " +
                        "FROM Membership.checkout as c " +
                        "WHERE c.book_id = @searchString",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@searchString", this.id.ToString());

                        // Execute the query and save the results.
                        adapter.Fill(bookResultsTable);
                    }
                }
            }

            return int.Parse(bookResultsTable.Rows[0][0].ToString());
        }

        /// <summary>
        /// Gets the number of copies currently available for this Book.
        /// </summary>
        /// <returns>Integer of the number of copies currently available.</returns>
        public int GetAvailableCount()
        {
            return copies - GetCheckedOutCount();
        }

        /// <summary>
        /// Checks to see if at least 1 copy is currently available.
        /// </summary>
        /// <returns>Boolean - True if there is at least 1 copy currently available.</returns>
        public bool IsAvailableToCheckout()
        {
            return GetAvailableCount() > 0;
        }

        /// <summary>
        /// Creates a record of the given Borrower checking out this Book.
        /// </summary>
        /// <param name="borrower">The Borrower checking out this book.</param>
        /// <returns>Boolean - True if the records were created.</returns>
        public bool CheckoutBy(Borrower borrower)
        {
            // Set the current date to be used in the database records.
            DateTime date = DateTime.Today;

            // Create a record in the current checkout table.
            using (var conn = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(
                    "INSERT INTO Membership.checkout (book_id, borrower_id, date)" +
                    "VALUES (@book_id, @borrower_id, @date)",
                    conn
                ))
                {
                    conn.Open();

                    command.Parameters.AddWithValue("@book_id", id);
                    command.Parameters.AddWithValue("@borrower_id", borrower.ID);
                    command.Parameters.AddWithValue("@date", date.ToString());

                    command.ExecuteScalar();
                }
            }

            // Create a record in the checkout history table.
            using (var conn = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(
                    "INSERT INTO Membership.checkout_history (book_id, borrower_id)" +
                    "VALUES (@book_id, @borrower_id)",
                    conn
                ))
                {
                    conn.Open();

                    command.Parameters.AddWithValue("@book_id", id);
                    command.Parameters.AddWithValue("@borrower_id", borrower.ID);

                    command.ExecuteScalar();
                }
            }

            // Return true indicating that there were no issues.
            return true;
        }
    }
}
