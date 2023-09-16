using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryApp
{
    public partial class BooksForm : Form
    {
        
        public BooksForm()
        {
            dataGridView1.DataSource = books;
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void authorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public void addBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Isbn = isbnTxt.Text;
            book.Author = authorTxt.Text;
            book.Title = titileTxt.Text;
            book.Year = DateOnly.ParseExact(yearTxt.Text, "yyyy");
            book.Publisher = publisherTxt.Text;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
