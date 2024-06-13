using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class LogIn
    {
        User user = new User();
        Menu menu = new Menu();
        bool ifLoggedIn = false;
        public bool CheckCredentials(string inputUsername, string inputPassword)
        {
            if (inputUsername == user.username && inputPassword == user.password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void LoggingIn()
        {
            Console.WriteLine("Please log in:");

            do
            {
                Console.WriteLine("Enter username:");
                string usernameWritten = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string passwordWritten = Console.ReadLine();
                if (CheckCredentials(usernameWritten, passwordWritten))
                {
                    ifLoggedIn = true;
                    Console.WriteLine("You have logged in!");
                    Console.WriteLine();

                    menu.ChooseMenu();
                }
                else
                {
                    Console.WriteLine("Wrong username or password. Try again!");
                    ifLoggedIn = false;
                }
            }
            while (!ifLoggedIn);
        }

    }
}