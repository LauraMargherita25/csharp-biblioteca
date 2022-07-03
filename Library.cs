using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
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
            //else { 
            //    this.MenuSignupOrLogin(); 
            //}
        }
        public void SignupNewUser()
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

            Console.WriteLine("Ciao {0} {1}", inputNname, inputNname);
        }

        public void LoginUser()
        {
            Console.WriteLine("Email");
            string inputEmail = Console.ReadLine();
            Console.WriteLine("Password");
            string inputPassword = Console.ReadLine();
            bool notFound = true;

            do
            {
                foreach (User user in this.users)
                {
                    if (user.Email == inputEmail && user.Password == inputPassword)
                    {
                        notFound = false;
                        Console.WriteLine("Ciao {0} {1}", user.Name, user.Surname);
                    }
                    
                }

                if (notFound)
                {
                    Console.WriteLine("Nessuno utente trovato, registrati!");
                    this.SignupNewUser();
                }
                else
                {
                    this.menuSearchItem();
                }
            }
            while (notFound);

        }

        public void menuSearchItem()
        {
            string[] menu = { "Visualizza dettagli prodotto", "Richiedi prestito", "Restituisci" };
            string inputUserResearch;
            bool notFound = true;

            do
            {
                Console.WriteLine("Cerca un libro o un dvd");
                inputUserResearch = Console.ReadLine();
                foreach (Item product in this.products)
                {
                    if(inputUserResearch == product.Title)
                    {
                        notFound = false;
                        Console.WriteLine("Prodotto Trovato");
                        for(int i = 0; i < menu.Length; i++)
                        {
                            Console.WriteLine("{0}. {1}", i + 1, menu[i]);
                        }
                        inputUserResearch = Console.ReadLine();
                        if (inputUserResearch == "1")
                        {
                            product.PrintItem();
                        } 
                        else if (inputUserResearch == "2")
                        {

                        }
                    }
                }

                if (notFound)
                {
                    Console.WriteLine("Nessun prodotto trovato, prova a cercare qualcosa'altro!");
                }


            }while (notFound);


            //foreach (Item product in this.products)
            //{
            //    if (inputUserResearch == product.Title)
            //    {
            //        Console.WriteLine("Prodotto Trovato");
            //        product.PrintItem();
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nessun Prodotto Trovato");
            //    }
            //}
        }



    }
}
