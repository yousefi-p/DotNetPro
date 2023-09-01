namespace PersonIdentityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.idTxtBox.KeyPress += new KeyPressEventHandler(idTxtBox_KeyPress);
        }

        private void idTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}