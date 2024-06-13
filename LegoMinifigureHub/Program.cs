using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            LogIn logIn = new LogIn();
            Console.WriteLine("Welcome to Lego Minifigure Hub!");
            logIn.LoggingIn();
        }
    }
}
