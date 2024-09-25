using Acropolis_Quest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acropolis_Quest
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        //------Create one Clicked => Show Register Form-------//
        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registrationForm register = new registrationForm();
            register.Show();
        }

        //----------------------username click------------------------//
        private void username_Click(object sender, EventArgs e)
        {
            //check for initial value to change into empty
            if (username.Text == "username" 
                && username.ForeColor == Color.Gray) 
            { 
              username.Text = string.Empty;
            }

            //change the value in password field
            if (string.IsNullOrEmpty(password.Text))
            {
                password.Text = "password";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
        }

        //----------------------password click------------------------//
        private void password_Click(object sender, EventArgs e)
        {
            //check for initial value to change into empty
            if (password.Text == "password" 
                && password.ForeColor == Color.Gray)
            {
                password.Text = string.Empty;
            }
          

            //change the value in username field
            if (string.IsNullOrEmpty(username.Text)) 
            {
                username.Text = "username";
                username.ForeColor = Color.Gray;
            }
        }

        //what the user writes in username
        private void username_TextChanged(object sender, EventArgs e)
        {
            
            username.ForeColor = Color.Black;
            
        }

        //what the user writes in password
        private void password_TextChanged(object sender, EventArgs e)
        {
            //use passwordChar
            password.UseSystemPasswordChar = true;

            //change color to black
            password.ForeColor = Color.Black;

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                //empty username
                MessageBox.Show("The username field is ");
            } 
            else if (username.Text == "username") 
            {
                //not valid username
                MessageBox.Show("The username is not valid");
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                //empty password
                MessageBox.Show("The password field is ");
            }
            else if (password.Text == "password")
            {
                //not valid password
                MessageBox.Show("The password is not valid");
            }
        }

        private void seePswd_Click(object sender, EventArgs e)
        {
            if (password.Text == "password"
                && password.ForeColor == Color.Gray)
            {
                password.UseSystemPasswordChar = false;
            }
            else if (password.UseSystemPasswordChar == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                //seePswd.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.) + "//closedEye.png");
            }

            }
    }
}
