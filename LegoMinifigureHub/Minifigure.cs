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
        public double Price { get; set; }
        public MinifigureType Type { get; set; }
        public enum MinifigureType
        {
            Clone = 1,
            Sith = 2,
            Jedi = 3
        }

        
    }
}
