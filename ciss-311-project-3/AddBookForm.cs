using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ciss_311_project_3
{
    public partial class AddBookForm : Form
    {
        private string connectionString;

        public AddBookForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"]
                .ConnectionString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand(
                "DELETE FROM books; INSERT INTO books VALUES (@title, @copyright_year, @isbn, @location, @copies)", conn))
            {
                conn.Open();

                string bookTitle = txtTitle.Text;

                command.Parameters.AddWithValue("@title", bookTitle);
                command.Parameters.AddWithValue("@copyright_year", txtCopyrightYear.Text);
                command.Parameters.AddWithValue("@isbn", txtISBN.Text);
                command.Parameters.AddWithValue("@location", txtLocation.Text);
                command.Parameters.AddWithValue("@copies", txtNumCopies.Text);
                command.ExecuteScalar();

                MessageBox.Show($"Inserted book: {bookTitle}");
            }

            Close();
        }
    }
}
