﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class Menu
    {
        Minifigure minifigure = new Minifigure();
        
        public void ChooseMenu()
        {
            Console.WriteLine("Choose an option depending on what you want to do:");
            Console.WriteLine("1. Add/Remove minifigures");
            Console.WriteLine("2. Search minifigures available to buy");
            Console.WriteLine("3. Create a buy now offer for your minifigure");
            Console.WriteLine("4. Create an auction for your minifigure");

            Console.WriteLine("Press 1, 2, 3 or 4...");
            int menuOptionChosen = Int32.Parse(Console.ReadLine());

            if (menuOptionChosen == 1)
            {
                Console.WriteLine("1. Add minifigure");
                Console.WriteLine("2. Remove minifigure");

                int addOrRemoveChosen = Int32.Parse(Console.ReadLine());

                if (addOrRemoveChosen == 1)
                {
                    Console.WriteLine("Add new minifigure - specify Id, Name, Price and Condition(out of 10):");

                    Console.WriteLine("Specify Id:");
                    int newMinifigureId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Specify Name:");
                    string newMinifigureName = Console.ReadLine();
                    Console.WriteLine("Specify Price:");
                    int newMinifigurePrice = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Specify Condition:");
                    int newMinifigureCondition = Int32.Parse(Console.ReadLine());

                    minifigure.AddItem(newMinifigureId, newMinifigureName, newMinifigurePrice, newMinifigureCondition);
                    
                }
                else
                {
                    minifigure.RemoveItem();
                }
            }
        }
    }
}
