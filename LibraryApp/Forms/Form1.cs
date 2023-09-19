using LibraryApp.Models;
using LibraryApp.Helper;
using LibraryApp.Forms;

namespace LibraryApp
{

    public partial class Form1 : Form
    {
        List<Book> books;
        List<User> users;
        public Form1()
        {
            InitializeComponent();
            try
            {
                books = Helper.Helper.ReadBookJsonFile("\\My Repos\\LibraryApp\\Data\\BookData.json");

            }
            catch (Exception ex)
            {

            }

            try
            {
                users = Helper.Helper.ReadUserJsonFile("\\My Repos\\LibraryApp\\Data\\UserData.json");
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
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }
    }
}