namespace WindowsForm
{

    public partial class Form1 : Form
    {
        People people = new People();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (people != null)
            {
                ContactList.Items.Clear();
                foreach (Person person in people)
                {
                    ContactList.Items.Add(person.FirstName + person.LastName);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(people);
            form2.ShowDialog();
        }
    }
}