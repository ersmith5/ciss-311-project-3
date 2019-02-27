using System;
using System.Collections.Generic;
//using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    [Table(Name = "authors")]
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

        [Column(Name = "id")]
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
    }
}
