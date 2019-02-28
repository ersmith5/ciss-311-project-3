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

        public ViewBookForm(int book_id)
        {
            InitializeComponent();

            // Load the Book from the database.
            book = Book.GetBook(book_id);

            // Set the form fields
            SetFields();
        }

        private void ViewBookFrom_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = book.Title;
        }

        private void SetFields()
        {
            int checkedOutCopies = book.GetCheckedOutCount();

            tbxISBN.Text = book.ISBN;
            tbxCopywriteYear.Text = book.Year.Year.ToString();
            tbxLocation.Text = book.Location;
            tbxTotalCopies.Text = book.Copies.ToString();
            tbxAvailableCopies.Text = book.GetAvailableCount().ToString();

            foreach (Author author in book.GetAuthors())
            {
                lbxAuthors.Items.Add(author.FirstName + " " + author.LastName);
            }

            btnCheckout.Enabled = book.IsAvailableToCheckout();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            var checkoutForm = new CheckoutForm(book);
            checkoutForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
