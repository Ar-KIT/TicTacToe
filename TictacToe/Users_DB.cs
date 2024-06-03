using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    public class Users_DB
    {
        public static List<string[]> users_db = new List<string[]>();
        public Users_DB()
        {
            if (users_db.Count == 0)
            {
                users_db.Add(new string[] { "Admin", "Default Admin", "admin1", "admin123" });
            }
        }
        public void AddUser(string role, string name, string username, string password)
        {
            string[] newUser = { role, name, username, password };
            users_db.Add(newUser);
        }
    }

    // 10 ACTIVITY 1
    public abstract class User
    {
        private string userId;
        protected string userPassword;

        public User(string id, string pass)
        {
            this.userId = id;
            this.userPassword = pass;
        }
        public bool VerifyLogin(string id, string pass)
        {
            return (this.userId.Equals(id) && this.userPassword.Equals(pass));
        }
        public abstract void UpdatePassword(string newPassword);
    }

    public class Administrator : User
    {
        private string adminName;
        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.adminName = name;
        }
        public override void UpdatePassword(string newPassword)
        {
            userPassword = newPassword;
        }
        public void UpdateAdminName(string name)
        {
            this.adminName = name;
        }
    }
    public class Player : User
    {
        private string playerName;
        public Player(string name, string id, string pass) : base(id, pass)
        {
            this.playerName = name;
        }
        public override void UpdatePassword(string newPassword){}
    }
}
