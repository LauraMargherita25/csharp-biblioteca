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
        public void OpenLibrary()
        {
            Console.WriteLine("Benvenuto nella Biblioteca Online");
            this.MenuSignupOrLogin();
        }

        public void AddNewPreoduct(Item newProduct)
        {
            this.products.Add(newProduct);
        }

        internal void AddNewUser(User newUser)
        {
            this.users.Add(newUser);
        }

        internal void MenuSignupOrLogin()
        {
            Console.WriteLine("Sei già registrato?");

            string input = Console.ReadLine();

            if (input == "no")
            {
                this.SignupNewUser();
            } 
            else if (input == "si")
            {
                this.LoginUser();
            }
            else { 
                this.MenuSignupOrLogin(); 
            }
        }

        private void LoginUser()
        {
            Console.WriteLine("Email");
            string inputEmail = Console.ReadLine();
            Console.WriteLine("Password");
            string inputPassword = Console.ReadLine();

            foreach (User user in this.users)
            {
                if (user.Email == inputEmail && user.Password == inputPassword)
                {
                    Console.WriteLine("Ciao {0} {1}", user.Name, user.Surname);
                    this.menuSearchItem();
                    return;
                }
                else
                {
                    Console.WriteLine("Credenziali non valide");
                    this.LoginUser();
                }
            }
        }

        private void menuSearchItem()
        {
            Console.WriteLine("Cerca un libro o un dvd");
            string inputUserResearch = Console.ReadLine();

            foreach(Item product in this.products)
            {
                if(inputUserResearch == product.Title)
                {

                }
            }
        }

        private void SignupNewUser()
        {
            Console.Write("Cognome: ");
            string inputSurname = Console.ReadLine();
            Console.Write("Nome: ");
            string inputNname = Console.ReadLine();
            Console.Write("Email: ");
            string inputEmail = Console.ReadLine();
            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();
            Console.Write("Numero di telefono: ");
            uint inputTelephone = uint.Parse(Console.ReadLine());

            User newUser = new User(inputSurname, inputNname, inputEmail, inputPassword, inputTelephone);
            users.Add(newUser);
        }


    }
}
