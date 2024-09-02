using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            //b. Wyświetl swoją kolekcję
            //c. Usuń minifigurkę ze swojej kolekcji
            //d. Wyszukaj minifigurkę po nazwie


            Console.WriteLine("Welcome to LEGO Minifigure Hub!");
            MinifigureService minifigureService = new MinifigureService();
            MenuActionService actionService = new MenuActionService();
            actionService = InitializeMenu(actionService);
            while (true)
            {
                Console.WriteLine("Choose an operation you want to perform:");
                var menu = actionService.GetMenuActionList("MainMenu");
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{menu[i].Id}. {menu[i].Name}");
                }

                var chosenOption = Int32.Parse(Console.ReadLine());

                switch (chosenOption)
                {
                    case 1:
                        Console.WriteLine("Define minifigure id:");
                        var givenId = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Define minifigure name:");
                        var givenName = Console.ReadLine();
                        Console.WriteLine("Define minifigure price in decimal:");
                        var givenPrice = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Define minifigure type:");
                        var givenTypeInput = Int32.Parse(Console.ReadLine());
                        Minifigure.MinifigureType givenType = (Minifigure.MinifigureType)givenTypeInput;


                        
                        minifigureService.AddMinifigureToCollection(givenId, givenName, givenPrice, givenType);
                        FileService fileService = new FileService();
                        fileService.WriteToFile($"{givenId} || {givenName} || {givenPrice} || {givenType}");
                        break;
                    case 2:
                        List<Minifigure> tempList = minifigureService.GetMinifiguresCollection();
                        Console.WriteLine("ID || Name || Price || Type");
                        for (int i = 0; i< tempList.Count;i++)
                        {
                            Console.WriteLine($"{tempList[i].Id} || {tempList[i].Name} || {tempList[i].Price} || {tempList[i].Type}");

                        }
                        
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Wybrano niepoprawną opcję, spróbuj ponownie!");
                        break;
                }

            }
        }

        private static MenuActionService InitializeMenu(MenuActionService menuActionService)
        {
            menuActionService.AddMenuAction(1, "Add new minifigure", "MainMenu");
            menuActionService.AddMenuAction(2, "Show my collection", "MainMenu");
            menuActionService.AddMenuAction(3, "Remove existing minifigure", "MainMenu");
            menuActionService.AddMenuAction(4, "Search for minifigure details", "MainMenu");
            return menuActionService;
        }
    }
}
