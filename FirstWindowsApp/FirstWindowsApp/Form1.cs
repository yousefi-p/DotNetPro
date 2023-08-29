namespace FirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string inputCellPhone = CellPhoneTxtBox.Text;
            if (inputCellPhone.Length == 11 && int.Parse(inputCellPhone[0].ToString()) == 0)
            {
                OutputTxtBox.Text = inputCellPhone;

            }
            else if (inputCellPhone.Length == 13 && (inputCellPhone[0].Equals('+') && inputCellPhone[1].Equals('9') && inputCellPhone[2].Equals('8'))
            {
                OutputTxtBox.Text = '0'+inputCellPhone.Substring(3);
            }
            else
            {
                OutputTxtBox.Text = "Worng Number";
            }
        }
    }
}