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
    [Table(Name = "Library.authors")]
    public class Author
    {
        /// <summary>
        /// Unique ID used by the database.
        /// </summary>
        private int id;

        /// <summary>
        /// First Name of the Author.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Last Name of the Author.
        /// </summary>
        private string lastName;

        /// <summary>
        /// About the Author (description).
        /// </summary>
        private string about;

        /// <summary>
        /// Books this Author wrote.
        /// </summary>
        //private EntitySet<Book> books;

        [Column(Name = "author_id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Column(Name = "first_name")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
               
        [Column(Name = "last_name")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
               
        [Column(Name = "about_the_author")]
        public string About
        {
            get { return about; }
            set { about = value; }
        }

        //[Association(OtherKey = "author_id")]
        //public EntitySet<Book> Books
        //{
        //    get { return books; }
        //    set { books.Assign(value); }
        //}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstName">First Name of the Author.</param>
        /// <param name="lastName">Last Name of the Author.</param>
        /// <param name="aboutAuthor">About the Author (description).</param>
        public Author(string firstName, string lastName, string about)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.about = about;

            // TODO: Add book relations
        }

        public static List<Author> GetAuthorsForBook(int bookId)
        {
            // Local connection variable due to this being a static method.
            string connectionString = ConfigurationManager.ConnectionStrings[
               "ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"
            ].ConnectionString;

            DataTable authorResultsTable = new DataTable();

            // Prepare to establish a database connection.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Set the command to be executed.
                using (SqlCommand comd = new SqlCommand(
                        "SELECT a.* " + 
                        "FROM Library.authors as a " + 
                        "JOIN Library.author_book as ab on ab.author_id = a.author_id " + 
                        "WHERE ab.book_id = @searchString",
                        conn
                    )
                )
                {
                    // Create an adaptor for executing the query with the given variables.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@searchString", bookId.ToString());

                        // Execute the query and save the results.
                        adapter.Fill(authorResultsTable);
                    }
                }
            }

            List<Author> authorList = new List<Author>();

            if (authorResultsTable.Rows.Count > 0)
            {
                foreach (DataRow row in authorResultsTable.Rows)
                {
                    authorList.Add(new Author(
                        row["first_name"].ToString().Trim(),
                        row["last_name"].ToString().Trim(),
                        row["about_the_author"].ToString().Trim()
                    ));
                }
            }

            return authorList;
        }
    }
}
