using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LegoMinifigureHub.Minifigure;

namespace LegoMinifigureHub
{
    public class MinifigureService
    {

        private List<Minifigure> minifiguresCollection;
        
        public MinifigureService()
        {
            minifiguresCollection = new List<Minifigure>();
        }


        public void AddMinifigureToCollection(int id, string name, double price, Minifigure.MinifigureType type)
        {
            if (Enum.IsDefined(typeof(Minifigure.MinifigureType), type))
            {
                Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Type = type};
                minifiguresCollection.Add(minifigure);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy typ figurki");
            }
            
        }

        public List<Minifigure> GetMinifiguresCollection()
        {
            List<Minifigure> list = new List<Minifigure>();
            foreach (var minifigure in minifiguresCollection)
            {
                list.Add(minifigure);
            }
            return list;
        }
    }
}
