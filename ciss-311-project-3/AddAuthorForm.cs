using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ciss_311_project_3
{
    public partial class AddAuthorForm : Form
    {
        private string connectionString;
        private SqlConnection conn;

        public AddAuthorForm()
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
            using (conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand(
                "INSERT INTO Library.authors VALUES (@firstName, @lastName, @about)", conn))
            {
                conn.Open();

                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@about", txtAboutAuthor.Text);
                command.ExecuteScalar();

                MessageBox.Show($"Inserted author: {firstName} {lastName}");
            }

            Close();
        }
    }
}
