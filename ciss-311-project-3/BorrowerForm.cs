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

namespace AddBorrowers
{
    public partial class BorrowerForm : Form
    {
        //declare database connection string
        string connectionString;
        SqlConnection conn;

        //establish connection 
        public BorrowerForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"].ConnectionString;
            //connectionString = ConfigurationManager.ConnectionStrings["AddBorrowers.Properties.Settings.TinyLibraryConnectionString"].ConnectionString;
        }

        //declare variable for radio buttons Student and Faculty
        string borrowerType;
        // if Student button is checked assign it to borrowerType
        private void studentButton_CheckedChanged(object sender, EventArgs e)
        {
            borrowerType = "Student";
        }
        //if Faculty button is checked assign it to borrowerType
        private void facultyButton_CheckedChanged(object sender, EventArgs e)
        {
            borrowerType = "Faculty";
        }

        //Save button will store info in borrower table in database
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString)) using (SqlCommand comd = new SqlCommand("INSERT INTO Membership.borrowers (type, first_name, last_name) " +
                "VALUES ('" + borrowerType + "', @first_name, @last_name)", conn))
            {
                //Assign textbox values to parameters
                conn.Open();
                comd.Parameters.AddWithValue("@first_name", firstNameBox.Text);
                comd.Parameters.AddWithValue("@last_name", lastNameBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Borrower Added.");
            }

        }

        //button to clear the form
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameBox.Clear();
            lastNameBox.Clear();
        }
    }
}
