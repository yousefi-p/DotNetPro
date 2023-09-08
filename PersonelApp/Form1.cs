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
            List<Person> employee;
            Person person = new Person();
            var errors = new List<string>();
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
         
        }
    }
}