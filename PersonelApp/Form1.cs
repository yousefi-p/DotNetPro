namespace PersonelApp
{
    public partial class Form1 : Form
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CellPhone { get; set; }
            public string NationalId { get; set; }
            public string Gender { get; set; }
            public bool Admin { get; set; }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}