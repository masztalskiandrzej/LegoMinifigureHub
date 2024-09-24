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
        FileService fileService = new FileService();
        public MinifigureService()
        {
            minifiguresCollection = new List<Minifigure>();
        }

        public void PopulateMinifigureList()
        {
            var tempFile = fileService.GetFilePath;
            string[] lines = File.ReadAllLines(tempFile);

            foreach(var line in lines)
            {
                string[] data = line.Split(" || ");

                if(data.Length == 5)
                {
                    int id = int.Parse(data[0]);
                    string name = data[1];
                    double price = double.Parse(data[2]);
                    Minifigure.MinifigureType type = 0;
                    string theme = data[4];
                    if (data[3] == "Clone")
                    {
                        type = MinifigureType.Clone;
                    }
                    else if(data[3] == "Sith")
                    {
                        type = MinifigureType.Sith;
                    }
                    else if (data[3] == "Jedi")
                    {
                        type = MinifigureType.Jedi;
                    }

                    

                    Minifigure minifigure = new Minifigure() {Id = id, Name = name, Price = price, Type = type, Theme = theme };
                    minifiguresCollection.Add(minifigure);
                }
            }
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

        public Minifigure SearchForMinifigureByName(string name) 
        {
            Minifigure minifigure = new Minifigure();
            bool found = false;
            foreach(var minifig in minifiguresCollection)
            {
                if (minifig.Name.Equals(name))
                {
                    minifigure = minifig;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("There is no figure with such name in your collection!");
            }

            return minifigure;
        }
    }
}
