using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            //a. Wyświetl swoją kolekcję
            //b. Dodaj minifigurkę do swojej kolekcji
            //c. Usuń minifigurkę ze swojej kolekcji
            //d. Wyszukaj minifigurkę po nazwie


            Console.WriteLine("Welcome to LEGO Minifigure Hub!");
            MinifigureService minifigureService = new MinifigureService();
            MenuActionService actionService = new MenuActionService();
            actionService = InitializeMenu(actionService);

            Console.WriteLine("Choose an operation you want to perform:");
            var menu = actionService.GetMenuActionList("MainMenu");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{menu[i].Id}. {menu[i].Name}");
            }

            var chosenOption = Int32.Parse(Console.ReadLine());

            switch(chosenOption)
            {
                case 1:
                    Console.WriteLine("Define minifigure id:");
                    var givenId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Define minifigure name:");
                    var givenName = Console.ReadLine();
                    Console.WriteLine("Define minifigure price in decimal:");
                    var givenPrice = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Define minifigure type:");
                    var givenType = Int32.Parse(Console.ReadLine());

                    minifigureService.AddMinifigureToCollection(givenId, givenName, givenPrice, givenType);
                case 2:

                    
                case 3:

                    
                case 4:

                    
                    default:
                    break;
            }


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
