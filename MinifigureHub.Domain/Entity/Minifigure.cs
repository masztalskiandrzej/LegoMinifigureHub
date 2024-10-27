using MinifigureHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub.Domain.Entity
{


    public class Minifigure : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MinifigureTheme Theme { get; set; }
        public enum MinifigureTheme
        {
            StarWars = 1,
            Marvel = 2
        }


    }
}
