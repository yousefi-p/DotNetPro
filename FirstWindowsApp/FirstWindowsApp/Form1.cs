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
            if (inputCellPhone.Length == 11 && inputCellPhone[0].Equals('0'))
            {
                OutputTxtBox.Text = inputCellPhone;

            }
            else if (inputCellPhone.Length == 13 && inputCellPhone.Substring(0, 3).Equals("+98"))
            {
                OutputTxtBox.Text = '0' + inputCellPhone.Substring(3);
            }
            else if (inputCellPhone.Length == 14 && inputCellPhone.Substring(0, 4).Equals("0098"))
            {
                OutputTxtBox.Text = inputCellPhone.Replace("0098", "0");
            }
            else
            {
                OutputTxtBox.Text = "Worng Number";
            }
        }
    }
}