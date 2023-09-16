using LibraryApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace LibraryApp
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();

        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }
    }
}