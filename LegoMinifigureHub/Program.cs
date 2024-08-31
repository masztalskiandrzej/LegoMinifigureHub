using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Przywitanie użytkownika
            //Zapytanie użytkownika jaką operację chce wykonać
            //a. Wyświetl swoją kolekcję
            //b. Dodaj minifigurkę do swojej kolekcji
            //c. Usuń minifigurkę ze swojej kolekcji
            //d. Wyszukaj minifigurkę po nazwie


            Console.WriteLine("Welcome to LEGO Minifigure Hub!");

            MenuActionService actionService = new MenuActionService();
            actionService = InitializeMenu(actionService);

            Console.WriteLine("Choose an operation you want to perform:");




        }

        private static MenuActionService InitializeMenu(MenuActionService menuActionService)
        {
            menuActionService.AddMenuAction(1, "Show my collection", "MainMenu");
            menuActionService.AddMenuAction(2, "Add new minifigure", "MainMenu");
            menuActionService.AddMenuAction(3, "Remove existing minifigure", "MainMenu");
            menuActionService.AddMenuAction(4, "Search for minifigure details", "MainMenu");
            return menuActionService;
        }
    }
}
