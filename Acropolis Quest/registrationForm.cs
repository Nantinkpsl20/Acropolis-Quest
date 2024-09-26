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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string initialNf = "fullname";
        private string initialUf = "username";
        private string initialPf = "password";
        private string initialCPf = "confirm password";


        private void checkFields(object sender, EventArgs e)
        {
            bool nf = string.IsNullOrEmpty(name.Text) || name.ForeColor.Equals(Color.Gray);
            bool uf = string.IsNullOrEmpty(username.Text) || username.ForeColor.Equals(Color.Gray);
            bool pf = string.IsNullOrEmpty(password.Text) || password.ForeColor.Equals(Color.Gray);
            bool cpf = string.IsNullOrEmpty(conPassword.Text) || conPassword.ForeColor.Equals(Color.Gray);
            
            if ( nf == true || uf == true || pf == true || cpf == true )
            {
                MessageBox.Show("All fields are required!", "Attention");
            }
        }

        private void initialField(object sender, EventArgs e, String fieldText)
        {
           
        }

        //what the user writes name
        private void name_TextChanged(object sender, EventArgs e)
        {
            name.ForeColor = Color.Black;
        }

        //----------------------name click------------------------//
        private void name_Click(object sender, EventArgs e)
        {
            //check for initial value to change into empty
            if (name.Text == initialNf
                && username.ForeColor == Color.Gray)
            {
                name.Text = string.Empty;
            }

            //change the value in password field
            if (string.IsNullOrEmpty(password.Text))
            {
                password.Text = "password";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
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
            password.ForeColor = Color.Black;
        }

        //what the user writes in conPassword
        private void conPassword_TextChanged(object sender, EventArgs e)
        {
            conPassword.ForeColor = Color.Black;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            checkFields(sender, e);
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {

        }
    }

}
