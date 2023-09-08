using System.Collections.Generic;
using PersonelApp.Models;

namespace PersonelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            /* Declare Variables */
            List<Person> employee;
            Person person = new Person();
            var errors = new List<string>();

            /* Check All the Field */
            if (Validator.CheckIsAlphabet(FirstNameTxt.Text))
            {
                person.FirstName = FirstNameTxt.Text;
            }
            else
            {
                errors.Add(nameof(FirstNameTxt));
            }
            if (Validator.CheckIsAlphabet(LastNameTxt.Text))
            {
                person.LastName = LastNameTxt.Text;
            }
            else { errors.Add(nameof(LastNameTxt)); }
            if (Validator.IsCellPhone(CellPhoneTxt.Text))
            {
                person.CellPhone = Validator.CellPhoneValidating(CellPhoneTxt.Text);
            }
            else
            {
                errors.Add(nameof(CellPhoneTxt));
            }
            if (Validator.NationalIdChecked(NationalIdTxt.Text))
            {
                person.NationalId = NationalIdTxt.Text;
            }
            else { errors.Add(nameof(NationalIdTxt)); }
            if (FemaleRadio.Checked)
            {
                person.Gender = FemaleRadio.Text;
            }
            else if (MaleRadio.Checked)
            {
                person.Gender = MaleRadio.Text;
            }
            else
            {
                errors.Add("Radio Button");
            }

            /* Promt Error */
            if (errors.LongCount() > 0)
            {
                string errorMessage = "You Have Error on ";
                foreach (var error in errors)
                {
                    errorMessage += error;
                }
                Prompt.ShowDialog(errorMessage, "Error");
            }




        }
    }
}