using LibraryApp.Helper;
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

namespace LibraryApp.Forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void isbnTxt_Leave(object sender, EventArgs e)
        {
            if (!Helper.Helper.CheckIsbn(isbnTxt.Text))
            {
                isbnError.Visible = true;
            }
            else
            {
                isbnError.Visible = false;
                titleTxt.Focus();
            }
        }

        private void titleTxt_Leave(object sender, EventArgs e)
        {
            if (!Helper.Helper.CheckTxtBox(titleTxt.Text))
            {
                titleError.Visible = true;
            }
            else
            {
                titleError.Visible = false;
                authorTxt.Focus();
            }
        }

        private void authorTxt_Leave(object sender, EventArgs e)
        {
            if (!Helper.Helper.CheckTxtBox(authorTxt.Text))
            {
                authorError.Visible = true;
            }
            else
            {
                authorError.Visible = false;
                yearTxt.Focus();

            }
        }

        private void yearTxt_Leave(object sender, EventArgs e)
        {
            if (!Helper.Helper.CheckYear(yearTxt.Text))
            {
                yearError.Visible = true;
            }
            else
            {
                yearError.Visible = false;
                publisherTxt.Focus();
            }
        }

        private void publisherTxt_Leave(object sender, EventArgs e)
        {
            if (!Helper.Helper.CheckTxtBox(publisherTxt.Text))
            {
                publisherError.Visible = true;
            }
            else { publisherError.Visible = false; }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (!isbnError.Visible && !titleError.Visible && !authorError.Visible && !yearError.Visible && !publisherError.Visible)
            {
                errorMessage.Visible = false;
                Book book = new Book();
                book.Isbn = isbnTxt.Text;
                book.Author = authorTxt.Text;
                book.Publisher = publisherTxt.Text;
                book.Title = titleTxt.Text;
                book.Year = int.Parse(yearTxt.Text);
                book.Available = availableCheckBox.Checked;
                AlertForm alertForm = new AlertForm();
                this.Close();
                alertForm.ShowDialog();
                Form1 form1 = new Form1(book);
                form1.Focus();

            }
            else
            {
                errorMessage.Text = "You sould fill all the inputs correctlly!";
                errorMessage.Visible = true;
            }
        }
    }
}
