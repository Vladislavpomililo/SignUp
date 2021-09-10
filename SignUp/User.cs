using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp
{
    class User
    {
        public int id { get; set; }
        private string email, password, login;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public User()
        {
        }

        public User(string email, string password, string login)
        {
            this.email = email;     
            this.password = password;
            this.login = login;
        }
    }
}
