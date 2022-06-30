using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        protected string surname;
        protected string name;
        protected string email;
        protected string password;
        protected int telphone;

        public User(string surname, string name, string email, string password, int telphone)
        {
            this.surname = surname; 
            this.name = name;
            this.email = email; 
            this.password = password;
            this.telphone = telphone;
        }
    }
}
