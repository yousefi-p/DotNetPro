namespace IdentificationApp
{
    public partial class Main : Form
    {
        Person person = new Person();
        public Main()
        {
            InitializeComponent();
            this.nationalIdTxtBox.KeyPress += new KeyPressEventHandler(NumberLimitation_KeyPress);
            this.cellPhoneTxtBox.KeyPress += new KeyPressEventHandler(NumberLimitation_KeyPress);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberLimitation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void CharecterLimitation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (CheckTxtBoxInput(firstNameTxtBox) && CheckTxtBoxInput(lastNameTxtBox) && CheckTxtBoxInput(nationalIdTxtBox)
                && CheckTxtBoxInput(cellPhoneTxtBox) && genderCombo.SelectedIndex >= 0)
            {
                person.FirstName = firstNameTxtBox.Text;
                person.LastName = lastNameTxtBox.Text;
                person.NationalID = nationalIdTxtBox.Text;
                person.CellPhone = cellPhoneTxtBox.Text;
                person.Gender = genderCombo.SelectedIndex;
                firstNameTxtBox.Text = string.Empty;
                lastNameTxtBox.Text = string.Empty;
                nationalIdTxtBox.Text = string.Empty;
                cellPhoneTxtBox.Text = string.Empty;
                genderCombo.SelectedIndex = 0;
                
            }
            else
            {
                notifyIcon1.Text = "You should fill all the information";
                notifyIcon1.Visible = true;
            }

        }

        private bool CheckTxtBoxInput(TextBox input)
        {
            if (input.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void TxtBoxClean(TextBox input)
        {
            input.BackColor = Color.White;
        }

        private void ErrorColor(TextBox input)
        {
            input.BackColor = Color.MediumVioletRed;
        }

        private void firstNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (!CheckTxtBoxInput(firstNameTxtBox))
            {
                ErrorColor(firstNameTxtBox);
            }
            else
            {
                TxtBoxClean(firstNameTxtBox);
            }
        }

        private void lastNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (!CheckTxtBoxInput(lastNameTxtBox))
            {
                ErrorColor(lastNameTxtBox);
            }
            else
            {
                TxtBoxClean(lastNameTxtBox);
            }
        }

        private void nationalIdTxtBox_Leave(object sender, EventArgs e)
        {
            if (!CheckTxtBoxInput(nationalIdTxtBox))
            {
                ErrorColor(nationalIdTxtBox);
            }
            else
            {
                TxtBoxClean(nationalIdTxtBox);
            }
        }

        private void genderCombo_DragLeave(object sender, EventArgs e)
        {
            if (genderCombo.Items == null)
            {
                genderCombo.BackColor = Color.MediumVioletRed;
            }
            else
            {
                genderCombo.BackColor = Color.White;
            }
        }
    }
}