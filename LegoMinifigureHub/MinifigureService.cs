﻿using System;
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
        public void AddMinifigureToCollection(int id, string name, double price, int type)
        {
            if (Enum.IsDefined(typeof(Minifigure.MinifigureType), type))
            {
                Minifigure.MinifigureType minifigureType = (Minifigure.MinifigureType)type;
                Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Type = minifigureType };

                minifiguresCollection.Add(minifigure);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy typ figurki");
            }
            
        }
    }
}