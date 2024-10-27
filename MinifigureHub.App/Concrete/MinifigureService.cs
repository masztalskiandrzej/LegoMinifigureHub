using LegoMinifigureHub.Domain.Entity;
using MinifigureHub.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LegoMinifigureHub.Minifigure;

namespace LegoMinifigureHub.App
{
    public class MinifigureService : BaseService<Minifigure>
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

            foreach (var line in lines)
            {
                string[] data = line.Split(" || ");

                if (data.Length == 4)
                {
                    int id = Int32.Parse(data[0]);
                    string name = data[1];
                    double price = double.Parse(data[2]);
                    Minifigure.MinifigureTheme theme = (Minifigure.MinifigureTheme)Enum.Parse(typeof(Minifigure.MinifigureTheme), data[3]);


                    Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Theme = theme};
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


        public void AddMinifigureToCollection(int id, string name, double price, Minifigure.MinifigureTheme theme)
        {
            if (Enum.IsDefined(typeof(Minifigure.MinifigureTheme), theme))
            {
                Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Theme = theme};
                minifiguresCollection.Add(minifigure);
            }
            else
            {
                Console.WriteLine("Invalid minifigure theme");
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


        public void ReadFromFileByTheme(string givenTheme)
        {
            var tempFile = fileService.GetFilePath;
            string[] lines = File.ReadAllLines(tempFile);

            foreach (var line in lines)
            {
                string[] data = line.Split(" || ");

                if (givenTheme == "StarWars" && data[3] == givenTheme)
                {

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    double price = double.Parse(data[2]);
                    Minifigure.MinifigureTheme theme = (Minifigure.MinifigureTheme)Enum.Parse(typeof(Minifigure.MinifigureTheme), data[3]);

                    Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Theme = theme };
                    Console.WriteLine($"{minifigure.Id} || {minifigure.Name} || {minifigure.Price} || {minifigure.Theme}");
                }
                else if (givenTheme == "Marvel" && data[3] == givenTheme)
                {
                    int id = int.Parse(data[0]);
                    string name = data[1];
                    double price = double.Parse(data[2]);
                    Minifigure.MinifigureTheme theme = (Minifigure.MinifigureTheme)Enum.Parse(typeof(Minifigure.MinifigureTheme), data[3]);

                    Minifigure minifigure = new Minifigure() { Id = id, Name = name, Price = price, Theme = theme };
                    Console.WriteLine($"{minifigure.Id} || {minifigure.Name} || {minifigure.Price} || {minifigure.Theme}");
                }
            }
        }
    }
}
