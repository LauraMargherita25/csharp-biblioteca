using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        List<Item> products = new List<Item>();
        List<User> users = new List<User>();

        public void AddNewPreoduct(Item newProduct)
        {
            this.products.Add(newProduct);
        }

        internal void AddNewUser(User newUser)
        {
            this.users.Add(newUser);
        }




        //public void OpenLibrary()
        //{
        //    Console.WriteLine("Benvenuto nella Biblioteca Online");
        //    Console.WriteLine("Signup");
        //    Console.WriteLine("LogIn");
        //    Console.ReadLine();

        //    if(Console.ReadLine() == "Signup")
        //    {
        //        BibliotecaOnline.SignupNewUser();
        //    }
        //    else
        //    {
        //        BibliotecaOnline.LoginUser();
        //    }

        //}

        //public SignupNewUser()
        //{
        //    User newUser = new 
        //}
    }
}
