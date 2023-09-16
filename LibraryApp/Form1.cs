using LibraryApp.Models;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp
{

    public partial class Form1 : Form
    {
        static List<Book> books;
        public Form1(Book book = null)
        {
            InitializeComponent();
            if (book == null)
            {
                books = new List<Book> {
                    new Book { Isbn="1803237805", Title="C# 11 and .NET 7 – Modern Cross-Platform Development Fundamentals: Start building websites and services with ASP.NET Core 7", Author="Mark J Price", Publisher="Packt Publishing", Year=DateOnly.ParseExact("2022","yyyy"), Available=true},
                    new Book { Isbn="1491976705", Title="Head First C#: A Learner's Guide to Real-World Programming with C# and .NET Core", Author="Andrew Stellman", Publisher="O'Reilly Media", Year=DateOnly.ParseExact("2021","yyyy"), Available=true}
                };
            }
            else
            {
                books.Add(book);
                this.Activate();
            }

        }



        private void booksBtn_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = books;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            InitializeComponent();
            dataGridView1.DataSource = books;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}