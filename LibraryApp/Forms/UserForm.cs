using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Models;
using LibraryApp.Helper;

namespace LibraryApp.Forms
{
    public partial class UserForm : Form
    {
        List<Book> books;
        public UserForm()
        {
            InitializeComponent();
            books = Helper.Helper.ReadBookJsonFile("\\My Repos\\LibraryApp\\Data\\BookData.json");
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            bookDataGrid.DataSource = this.books;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
