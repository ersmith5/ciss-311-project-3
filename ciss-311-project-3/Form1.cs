using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciss_311_project_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookForm = new AddBookForm();
            bookForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchBookForm();
            searchForm.Show();
        }
    }
}
