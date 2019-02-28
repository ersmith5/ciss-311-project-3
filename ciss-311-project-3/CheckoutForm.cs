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
    public partial class CheckoutForm : Form
    {
        /// <summary>
        /// The book to be checked out.
        /// </summary>
        protected Book book;

        /// <summary>
        /// The list of available borrowers
        /// </summary>
        protected List<Borrower> borrowers;

        public CheckoutForm(Book book)
        {
            InitializeComponent();

            this.book = book;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            borrowers = Borrower.GetBorrowers();

            cbxBorrower.DataSource = borrowers;
        }

        private void cbxBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevent a checkout if no Borrower is selectable.
            btnCheckout.Enabled = false;

            if (cbxBorrower.Enabled == true)
            {
                Borrower selectedBorrower = (Borrower)cbxBorrower.SelectedItem;

                tbxBorrower.Text = selectedBorrower.FullName();
                tbxBookCheckoutAllotment.Text = selectedBorrower.BookAllotment().ToString();
                tbxCurrentCheckedOutBooks.Text = selectedBorrower.GetCurrentCheckedOutCount().ToString();
                tbxBookToCheckout.Text = book.Title;

                bool checkout = selectedBorrower.CanCheckoutBooks();
                btnCheckout.Enabled = selectedBorrower.CanCheckoutBooks();
            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (book.CheckoutBy((Borrower)cbxBorrower.SelectedItem))
            {
                MessageBox.Show("This Book has been checked out!");
            }
            else
            {
                MessageBox.Show("There was an error. This Book has NOT been checked out.");
            }

            // TODO: ? Tell the parent to refresh the book's info?
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
