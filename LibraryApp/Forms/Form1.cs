using LibraryApp.Models;
using LibraryApp.Helper;
using LibraryApp.Forms;

namespace LibraryApp
{

    public partial class Form1 : Form
    {
        List<Book> books;
        List<User> users;
        string BookPath = "\\My Repos\\LibraryApp\\Data\\BookData.json";
        string UserPath = "\\My Repos\\LibraryApp\\Data\\UserData.json";


        public Form1()
        {
            InitializeComponent();
            try
            {
                books = Helper.Helper.ReadBookJsonFile(BookPath);

            }
            catch (Exception ex)
            {

            }

            try
            {
                users = Helper.Helper.ReadUserJsonFile(UserPath);
            }
            catch { }

        }

        public Form1(Book book)
        {
            try
            {
                books.Add(book);
                Helper.Helper.WriteOnBookJsonFile(books, BookPath);
            }
            catch { }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

            bookGridView.DataSource = books;
            userGridData.DataSource = users;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void Form1_Enter(object sender, EventArgs e, Book book)
        {
            AddBookForm addBookForm= new AddBookForm();
            
        }
    }
}