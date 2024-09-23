using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class MarvelMinifigure : Minifigure
    {
        public MinifigureType Type { get; set; }
        public enum MinifigureType
        {
            Avenger = 1,
            Titan = 2,
            Alien = 3
        }
    }
}
