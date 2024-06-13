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
    }
}
