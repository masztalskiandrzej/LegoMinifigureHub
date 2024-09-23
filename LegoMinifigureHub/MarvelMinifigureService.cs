using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LegoMinifigureHub.MarvelMinifigure;

namespace LegoMinifigureHub
{
    public class MarvelMinifigureService : MinifigureService
    {
        private List<MarvelMinifigure> minifiguresCollection;
        FileService fileService = new FileService();
        public void PopulateMinifigureList()
        {
            var tempFile = fileService.GetFilePath;
            string[] lines = File.ReadAllLines(tempFile);

            foreach (var line in lines)
            {
                string[] data = line.Split(" || ");

                if (data.Length == 4)
                {
                    int id = int.Parse(data[0]);
                    string name = data[1];
                    double price = double.Parse(data[2]);
                    MarvelMinifigure.MinifigureType type = 0;
                    if (data[3] == "Avenger")
                    {
                        type = MinifigureType.Avenger;
                    }
                    else if (data[3] == "Titan")
                    {
                        type = MinifigureType.Titan;
                    }
                    else if (data[3] == "Alien")
                    {
                        type = MinifigureType.Alien;
                    }



                    MarvelMinifigure minifigure = new MarvelMinifigure() { Id = id, Name = name, Price = price, Type = type };
                    minifiguresCollection.Add(minifigure);
                }
            }
        }
    }
}
