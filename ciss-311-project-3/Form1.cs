﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ciss_311_project_3
{
    public partial class MainForm : Form
    {
        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["ciss_311_project_3.Properties.Settings.TinyLibraryDBConnectionString"]
                .ConnectionString;

            btnAddAuthor.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            // using (var conn = new SqlConnection(connectionString))
            // using (var adapter = new SqlDataAdapter(
            //     "SELECT * FROM authors", conn))
            // {
            //     var authorDataTable = new DataTable();
            //     adapter.Fill(authorDataTable);
            //
            //     MessageBox.Show($"First author: {authorDataTable.Rows[0]["first_name"].ToString()}");
            // }

            var authorForm = new AddAuthorForm();
            authorForm.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}
