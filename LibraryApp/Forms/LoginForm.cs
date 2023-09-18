using LibraryApp.Models;
using LibraryApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (this.usernameTxt.Text.Trim().Length > 0)
            {
                if (this.passwordTxt.Text.Trim().Length > 0)
                {
                    try
                    {
                        // Try to deserialize my Json file as my UserList class
                        List<User> users = Helper.Helper.ReadUserJsonFile("\\My Repos\\LibraryApp\\Data\\UserData.json");

                        if (users != null)
                        {
                            foreach (User user in users)
                            {
                                if (user.Username.Equals(usernameTxt.Text) && user.Password.Equals(passwordTxt.Text))
                                {
                                    if (user.Role == 1)
                                    {
                                         Form1 main = new Form1();
                                        this.Hide();
                                        main.ShowDialog();
                                    }
                                    else
                                    {
                                        UserForm main = new UserForm();
                                        this.Hide();
                                        main.ShowDialog();
                                    }

                                }
                            }
                            this.errorLbl.Text = "Make sure you are provide correct Username and Password";
                        }
                        else
                        {
                            this.errorLbl.Text = "There is problem with our system. Please try later.";
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    this.errorLbl.Text = "Please Enter your password.";
                }
            }
            else
            {
                this.errorLbl.Text = "Please Enter your username.";
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }


    }
}
