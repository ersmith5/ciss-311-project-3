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

        public static Book GetBook(int bookId)
        {
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
                    )
                )
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
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", bookId);

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
                return new Book(
                    int.Parse(bookRow[0].ToString()), // id
                    bookRow[1].ToString(), // title
                    authorsList,
                    year,
                    bookRow[3].ToString(), // isbn
                    bookRow[4].ToString(), // location
                    int.Parse(bookRow[5].ToString()) // copies
                );
            }
        }

        public static List<Book> GetBooksByID(List<int> bookIds)
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
                        comd.Parameters.AddWithValue("@searchString", string.Join(", ", bookIds.ToArray()));

                        //// Establish a variable for the results.
                        //DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        //adapter.Fill(resultsTable);
                        adapter.Fill(bookResultsTable);

                        //if (resultsTable.Rows.Count > 0)
                        //{
                        //    foreach (DataRow row in resultsTable.Rows)
                        //    {
                        //        bookList.Add(new Book(
                        //            row[1].ToString(), // title
                        //            new DateTime(int.Parse(row[2].ToString()), 1, 1), // year
                        //            row[3].ToString(), // isbn
                        //            row[4].ToString(), // location
                        //            int.Parse(row[5].ToString()) // copies
                        //        ));
                        //    }
                        //}
                    }
                }
            }

            List<Book> bookList = new List<Book>();

            if (bookResultsTable.Rows.Count > 0)
            {
                foreach (DataRow row in bookResultsTable.Rows)
                {
                    bookList.Add(new Book(
                        int.Parse(row[0].ToString()), // id
                        row[1].ToString(), // title
                        Author.GetAuthorsForBook(int.Parse(row[0].ToString())),
                        new DateTime(int.Parse(row[2].ToString()), 1, 1), // year
                        row[3].ToString(), // isbn
                        row[4].ToString(), // location
                        int.Parse(row[5].ToString()) // copies
                    ));
                }
            }
            
            return bookList;
        }

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

        public int GetAvailableCount()
        {
            return copies - GetCheckedOutCount();
        }

        public bool IsAvailableToCheckout()
        {
            return GetCheckedOutCount() > 0;
        }
    }
}
