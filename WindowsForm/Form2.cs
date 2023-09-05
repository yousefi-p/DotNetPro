using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        Person person = new Person();
        private People people;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(People people)
        {
            this.people = people;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            person.FirstName = FirstNameTxt.Text;
            person.LastName = LastNameTxt.Text;
            person.CellPhone = CellPhoneTxt.Text;
            person.Address = AddressTxt.Text;

            people.Add(person);

            FirstNameTxt.Clear();
            LastNameTxt.Clear();
            CellPhoneTxt.Clear();
            AddressTxt.Clear();
        }
    }
}
