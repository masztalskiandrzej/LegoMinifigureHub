using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class Minifigure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Condition { get; set; }

        public List<Minifigure> listOfMinifigures;

        public Minifigure() 
        {
            listOfMinifigures = new List<Minifigure>();
        }

        public void AddItem(int newMinifigureId, string newMinifigureName, int newMinifigurePrice, int newMinifigureCondition)
        {


            listOfMinifigures.Add(new Minifigure() { Id = newMinifigureId, Name = newMinifigureName, Price = newMinifigurePrice, Condition = newMinifigureCondition });

            Console.WriteLine("You have added new minifigure to your collection:");
            Console.WriteLine($"Id - {newMinifigureId}, Name - {newMinifigureName}, Price - {newMinifigurePrice}, Condition - {newMinifigureCondition}/10");
        }

        public void RemoveItem(int minifigureToRemoveId)
        {
            for (int i = 0; i < listOfMinifigures.Count; i++)
            {
                if (listOfMinifigures[i].Id == minifigureToRemoveId)
                {
                    listOfMinifigures.RemoveAt(i);
                }
            }
        }
    }
}
