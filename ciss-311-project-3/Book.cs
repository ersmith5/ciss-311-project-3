using System;
using System.Collections.Generic;
//using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    [Table(Name = "books")]
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

        [Column(Name = "id")]
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
        public Book(string title, DateTime year, string isbn, string location, int copies)
        {
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();
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
        public Book(string title, Author author,  DateTime year, string isbn, string location, int copies)
        {
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();
            this.authors.Add(author);
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
        public Book(string title, List<Author> authors,  DateTime year, string isbn, string location, int copies)
        {
            this.title = title;
            this.year = year;
            this.isbn = isbn;
            this.location = location;
            this.copies = copies;
            this.authors = new List<Author>();
            authors.ForEach((author) => {
                this.authors.Add(author);
            });
        }
        
    }
}
