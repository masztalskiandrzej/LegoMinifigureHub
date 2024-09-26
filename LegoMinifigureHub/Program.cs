using System;


namespace LegoMinifigureHub
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            

            MinifigureService minifigureService = new MinifigureService();
            MenuActionService actionService = new MenuActionService();
            
            actionService = InitializeMenu(actionService);
            minifigureService.PopulateStarWarsMinifigureList();
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
                        Console.WriteLine("Define minifigure theme by number (1 => StarWars, 2 => Marvel):");
                        var givenThemeInput = Int32.Parse(Console.ReadLine());
                        Minifigure.MinifigureTheme givenTheme = (Minifigure.MinifigureTheme)givenThemeInput;

                       
                        
                        minifigureService.AddMinifigureToCollection(givenId, givenName, givenPrice, givenTheme);
                        minifigureService.UpdateFile();
                        break;
                    case 2:
                        //List<Minifigure> tempList = minifigureService.GetMinifiguresCollection();
                        //Console.WriteLine("ID || Name || Price || Type");
                        //for (int i = 0; i< tempList.Count;i++)
                        //{
                        //    Console.WriteLine($"{tempList[i].Id} || {tempList[i].Name} || {tempList[i].Price} || {tempList[i].Type}");

                        //}
                        FileService fileServiceToRead = new FileService();
                        Console.WriteLine("ID || Name || Price || Theme");
                        fileServiceToRead.ReadFromFile();
                        
                        break;
                    case 3:
                        FileService fileToReadBeforeDeletingFigure = new FileService();
                        fileToReadBeforeDeletingFigure.ReadFromFile();
                        Console.WriteLine("Choose a minifigure to delete from your collection by its name: ");
                        string figureToDelete = Console.ReadLine();
                        minifigureService.RemoveMinifigureFromCollection(figureToDelete);
                        List<Minifigure> temp = minifigureService.GetMinifiguresCollection();
                        minifigureService.UpdateFile();

                        break;
                    case 4:
                        Console.WriteLine("Please type name of minifigure in your collection you wish to search for: ");
                        string writtenName = Console.ReadLine();
                        var returnedMinifigure = minifigureService.SearchForMinifigureByName(writtenName);
                        Console.WriteLine($"{returnedMinifigure.Id} [] {returnedMinifigure.Name} [] {returnedMinifigure.Price} [] {returnedMinifigure.Theme}");
                        Console.WriteLine();
                        break;
                        case 5:
                        Console.WriteLine("Minifigures from which theme you wish to see: ");
                        var chosenTheme = Console.ReadLine();
                        minifigureService.ReadFromFileByTheme(chosenTheme);
                        break;
                    default:
                        Console.WriteLine("Wrong option, try again!");
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
            menuActionService.AddMenuAction(5, "Search minifigures by theme", "MainMenu");
            return menuActionService;
        }
    }
}
