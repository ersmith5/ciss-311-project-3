using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    [Table(Name = "Membership.borrowers")]
    public abstract class Borrower
    {
        /// <summary>
        /// Unique ID used by the database.
        /// </summary>
        protected int id;

        /// <summary>
        /// First Name of the Borrower.
        /// </summary>
        protected string first_name;

        /// <summary>
        /// Last Name of the Borrower.
        /// </summary>
        protected string last_name;

        /// <summary>
        /// Type of Borrower
        /// </summary>
        protected string type;

        /// <summary>
        /// Number of Books the Borrower is allowed to check out at once.
        /// </summary>
        protected int bookAllotment;

        /// <summary>
        /// Connection string to the local database.
        /// </summary>
        protected string connectionString;

        [Column(Name = "borrower_id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        internal static List<Borrower> GetAllBorrowers()
        {
            throw new NotImplementedException();
        }

        [Column(Name = "first_name")]
        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        [Column(Name = "last_name")]
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        [Column(Name = "type")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="first_name">First Name of the Borrower</param>
        /// <param name="last_name">Last Name of the Borrower</param>
        /// <param name="type">Type of Borrower</param>
        /// <param name="bookAllotment">Number of Books the Borrower is allowed to check out at once.</param>
        public Borrower(int id, string first_name, string last_name, string type, int bookAllotment)
        {
            this.id             = id;
            this.first_name     = first_name.Trim();
            this.last_name      = last_name.Trim();
            this.type           = type.Trim();
            this.bookAllotment  = bookAllotment;

            connectionString = ConfigurationManager.ConnectionStrings[
               "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
           ].ConnectionString;
        }

        /// <summary>
        /// Retrieve all the available Borrowers.
        /// </summary>
        /// <returns>A List of the available Borrowers.</returns>
        public static List<Borrower> GetBorrowers()
        {
            // Local connection variable due to this being a static method.
            string connectionString = ConfigurationManager.ConnectionStrings[
               "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
           ].ConnectionString;

            // Instantiate a 
            List<Borrower> retrivedBorrowers = new List<Borrower>();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT * FROM Membership.borrowers as b",
                        conn
                ))
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Establish a variable for the results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        // Create a borrower object for each record retrieved
                        if (resultsTable.Rows.Count > 0)
                        {
                            foreach (DataRow row in resultsTable.Rows)
                            {
                                if (row["type"].ToString().Trim() == "Student")
                                {
                                    retrivedBorrowers.Add(new StudentBorrower(
                                        int.Parse(row["borrower_id"].ToString().Trim()),
                                        row["first_name"].ToString().Trim(),
                                        row["last_name"].ToString().Trim()
                                    ));
                                }
                                else
                                {
                                    retrivedBorrowers.Add(new FacultyBorrower(
                                        int.Parse(row["borrower_id"].ToString().Trim()),
                                        row["first_name"].ToString().Trim(),
                                        row["last_name"].ToString().Trim()
                                    ));
                                }
                            }
                        }
                    }
                }
            }

            return retrivedBorrowers;
        }

        /// <summary>
        /// Returns a space-concatenated string of the first and last name.
        /// </summary>
        /// <returns>String of "first_name last_name.</returns>
        public string FullName()
        {
            return $"{first_name.Trim()} {last_name.Trim()}";
        }

        /// <summary>
        /// Returns the number of Books this Borrower is allowed to check out at one time.
        /// </summary>
        /// <returns>Integer of the Book Allotment.</returns>
        public int BookAllotment()
        {
            return bookAllotment;
        }

        /// <summary>
        /// Returns the full name of the Borrower.
        /// </summary>
        /// <returns>String of the FullName.</returns>
        public override string ToString()
        {
            return FullName();
        }

        /// <summary>
        /// Gets a list of Books this Borrower currently has checked out.
        /// </summary>
        /// <returns>A List of Books.</returns>
        public List<Book> GetCurrentCheckedOutBooks()
        {
            List<int> bookIds = new List<int>();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT c.book_id " +
                        "FROM Membership.checkout as c " +
                        "WHERE c.borrower_id = @searchString",
                        conn
                ))
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the variables to send along with the command.
                        comd.Parameters.AddWithValue("@searchString", this.ID);

                        // Establish a variable for the results.
                        DataTable resultsTable = new DataTable();

                        // Execute the query and save the results.
                        adapter.Fill(resultsTable);

                        foreach (DataRow row in resultsTable.Rows)
                        {
                            bookIds.Add(int.Parse(row["book_id"].ToString().Trim()));
                        }
                    }
                }
            }

            return Book.GetBooksByID(bookIds);
        }

        /// <summary>
        /// Gets the number of Books this Borrower has currently checked out.
        /// </summary>
        /// <returns></returns>
        public int GetCurrentCheckedOutCount()
        {
            DataTable bookResultsTable = new DataTable();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT COUNT(c.borrower_id) " +
                        "FROM Membership.checkout as c " +
                        "WHERE c.borrower_id = @searchString",
                        conn
                ))
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
        /// Checks to see if this Borrower has a checked out Book that is overdue.
        /// </summary>
        /// <returns>Boolean - True if there are 1 or more overdue Books.</returns>
        public bool HasOverdueBooks()
        {
            DataTable bookResultsTable = new DataTable();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT COUNT(c.borrower_id) " +
                        "FROM Membership.checkout as c " +
                        "WHERE c.borrower_id = @searchString " + 
                        "AND c.date < @searchDate",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        // Set the date to compare to one month prior to today.
                        DateTime date = DateTime.Today.AddMonths(-1);

                        comd.Parameters.AddWithValue("@searchString", this.id.ToString());
                        comd.Parameters.AddWithValue("@searchDate", date.ToString());

                        // Execute the query and save the results.
                        adapter.Fill(bookResultsTable);
                    }
                }
            }

            return int.Parse(bookResultsTable.Rows[0][0].ToString()) > 0;
        }

        /// <summary>
        /// Checks to see if this Borrower has overdue Books or any available Book allotment remaining.
        /// </summary>
        /// <returns>Boolean - True if there are enough Book allotments remaining and no overdue Books.</returns>
        public bool CanCheckoutBooks()
        {
            return GetCurrentCheckedOutCount() < bookAllotment && !HasOverdueBooks();
        }
    }
}
