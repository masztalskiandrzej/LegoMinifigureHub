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
        FileService fileService = new FileService();
        public MinifigureService()
        {
            minifiguresCollection = new List<Minifigure>();
        }

        public void UpdateFile()
        {
            string path = fileService.GetFilePath;
            File.WriteAllText(path, string.Empty);

            for(int i = 0; i < minifiguresCollection.Count; i++) 
            {
                fileService.WriteMinifigureToFile(minifiguresCollection[i]);
            }
        }


        public void AddMinifigureToCollection(int id, string name, double price, Minifigure.MinifigureType type)
        {
            if (Enum.IsDefined(typeof(Minifigure.MinifigureType), type))
            {
                Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Type = type};
                minifiguresCollection.Add(minifigure);
                FileService file = new FileService();
                file.WriteMinifigureToFile(minifigure);
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

        public void RemoveMinifigureFromCollection(string figureToRemove)
        {
            for (int i = 0; i < minifiguresCollection.Count; i++)
            {
                if (minifiguresCollection[i].Name.Equals(figureToRemove))
                {
                    minifiguresCollection.Remove(minifiguresCollection[i]);
                }
            }
        }
    }
}
