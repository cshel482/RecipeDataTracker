using RecipeData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeData
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginModel model = new LoginModel();
            model.password = txtPassword.Text;
            model.username = txtUsername.Text;
            string password = DBServices.QueryPasswordData(model);
            string username = DBServices.QueryUsernameData(model);
            if (password == null || username == null)
            {
                lblError.Text = "It looks like you did not enter in a valid password and or username. Please Try Again or create an account.";
            }
            else
            {
                int userID = Int32.Parse(DBServices.QueryUserIdData(model));
                Console.WriteLine(userID);
                Form1 mainForm = new Form1(userID);
                mainForm.Show();
                this.Hide();
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Text = "Your Confirm Password does not match the Password you created";
            }
            else 
            {
                LoginModel model = new LoginModel();
                model.password = txtPassword.Text;
                model.username = txtUsername.Text;
                model.firstName = txtFirstName.Text;
                model.lastName = txtLastName.Text;
                if (string.IsNullOrEmpty(model.username))
                {
                    lblError.Text = "Username field must not be left blank bitte.";
                }
                else if (string.IsNullOrEmpty(model.firstName))
                {
                    lblError.Text = "Please enter a valid first name";
                }
                else if (string.IsNullOrEmpty(model.lastName))
                {
                    lblError.Text = "Please enter a valid last name";
                }
                else 
                {
                    string username = DBServices.QueryUsernameData(model);
                    if (username == model.username)
                    {
                        lblError.Text = "It looks like this username has been taken already. Please choose a different username";
                    }
                    else
                    {
                        DBServices.InsertLoginData(model);
                        int userID = Int32.Parse(DBServices.QueryUserIdData(model));
                        Form1 mainForm = new Form1(userID);
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
