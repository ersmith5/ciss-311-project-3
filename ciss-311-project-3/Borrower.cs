using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
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

        [Column(Name = "id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
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
    }
}
