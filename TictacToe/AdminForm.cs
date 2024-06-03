using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TictacToe
{
    public partial class AdminForm : Form
    {
        Users_DB db;
        public AdminForm()
        {
            InitializeComponent();
            updatePlayersCount();
            db = new Users_DB();   
        }
        public void updatePlayersCount()
        {
            playersCount.Text = (Users_DB.users_db.Count - 1).ToString();
        }

        private void CNP_Button_Click(object sender, EventArgs e)
        {
            string new_name = newName.Text;
            string new_username = newUsername.Text;
            string new_password = newPassword.Text;

            bool usernameExists = Users_DB.users_db.Any(user => user[2] == new_username);
            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
            else
            {
                db.AddUser( "Player", new_name, new_username, new_password);
                MessageBox.Show("Player added successfully!");
                newName.Text = "";
                newPassword.Text = "";
                newUsername.Text = "";
                updatePlayersCount();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();
        }

        private void UP_button_Click(object sender, EventArgs e)
        {
            string username = UP_username.Text;
            string UP_newPass = UP_newPassword.Text;
            string UP_cPass = UP_confirmPassword.Text;

            if (UP_newPass == UP_cPass)
            {
                bool userFound = false;
                foreach (string[] user in Users_DB.users_db)
                {
                    if (user[2] == username)
                    {
                        user[3] = UP_newPass;
                        userFound = true;
                        break;
                    }
                }
                if (userFound)
                {
                    MessageBox.Show("Password updated successfully!");
                    UP_username.Text = "";
                    UP_newPassword.Text = "";
                    UP_confirmPassword.Text = ""    ;
                }
                else
                {
                    MessageBox.Show("Username not found!");
                }
            }
            else
            {
                MessageBox.Show("New password and confirm password do not match!");
            }
        }
    }


}
