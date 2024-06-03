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
    public partial class Login : Form
    {
        Users_DB db;
        Administrator admin;
        public Login()
        {
            InitializeComponent();
            db = new Users_DB();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            string[] User = Users_DB.users_db.Find(u => u[2] == username);
            if (User != null)
            {
                Administrator admin = new Administrator(User[1], User[2], User[3]);
                if (admin.VerifyLogin(username, password))
                {
                    MessageBox.Show("Login successful!");
                    string[] user = Users_DB.users_db.Find(u => u[2] == username);
                    if (user != null && user[0] == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        Game game = new Game(user[1]);
                        game.Show();
                    }
                    this.Hide();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }       
}
