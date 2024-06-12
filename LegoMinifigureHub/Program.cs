using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            LogIn logIn = new LogIn();
            bool ifLoggedIn = false;
            Program program = new Program();

            Console.WriteLine("Welcome to Lego Minifigure Hub!");
            Console.WriteLine("Please log in:");
            
            do
            {
                Console.WriteLine("Enter username:");
                string usernameWritten = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string passwordWritten = Console.ReadLine();
                if (logIn.CheckCredentials(usernameWritten, passwordWritten))
                {
                    ifLoggedIn = true;
                    Console.WriteLine("You have logged in!");
                    Console.WriteLine();

                    program.ChooseMenu();
                }
                else
                {
                    Console.WriteLine("Wrong username or password. Try again!");
                    ifLoggedIn = false;
                }
            }
            while (!ifLoggedIn);



        }

        public void ChooseMenu()
        {
            Console.WriteLine("Choose an option depending on what you want to do:");
            Console.WriteLine("1. Add/Remove minifigures");
            Console.WriteLine("2. Search minifigures available to buy");
            Console.WriteLine("3. Create a buy now offer for your minifigure");
            Console.WriteLine("4. Create an auction for your minifigure");

            Console.WriteLine("Press 1, 2, 3 or 4...");
            string menuOptionChosen = Console.ReadLine();

            Console.WriteLine($"You have chosen option {menuOptionChosen}");
        }
    }
}
