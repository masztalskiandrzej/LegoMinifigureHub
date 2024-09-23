using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class StarWarsMinifigure : Minifigure
    {
        public MinifigureType CharacterType { get; set; }
        public enum MinifigureType
        {
            Clone = 1,
            Sith = 2,
            Jedi = 3
        }
    }
}
