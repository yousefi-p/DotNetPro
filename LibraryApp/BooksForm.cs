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
using LibraryApp.Models;


namespace LibraryApp
{
    public partial class BooksForm : Form
    {
        static Book book;

        public BooksForm()
        {

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


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            book = new Book();
            string Message = "";
            if (isbnTxt.Text.Length == 10 && Helper.NumericCheck(isbnTxt.Text))
            {
                if (!string.IsNullOrEmpty(titileTxt.Text) && !string.IsNullOrEmpty(authorTxt.Text) && !string.IsNullOrEmpty(publisherTxt.Text))
                {
                    if (Helper.YearCheck(yearTxt.Text))
                    {
                        book = new Book();
                        book.Isbn = isbnTxt.Text;
                        book.Author = authorTxt.Text;
                        book.Title = titileTxt.Text;
                        book.Year = DateOnly.ParseExact(yearTxt.Text, "yyyy");
                        book.Publisher = publisherTxt.Text;
                        book.Available = true;
                        Form1 form1 = new Form1(book);
                        this.Close();
                        
                    }
                    else
                    {
                        Message += "Year is not Correct \n";
                    }

                }
                else
                {
                    Message += "Title, Author, and Publisher fields can not be empty\n";
                }
            }
            else { 
                Message += "ISBN just accept 10 Numeric value"; 
                Alert alert = new Alert(Message);
                alert.ShowDialog();
            }


        }


        private void BooksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();


        }
    }
}
