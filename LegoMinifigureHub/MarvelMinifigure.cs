using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class MarvelMinifigure : Minifigure
    {
        public MMinifigureType Type { get; set; }
        public enum MMinifigureType
        {
            Avenger = 1,
            Other = 2
        }
    }
}
