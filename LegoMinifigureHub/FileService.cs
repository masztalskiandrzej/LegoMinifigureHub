using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class FileService
    {
        private const string filePath = "C:\\Users\\Admin\\source\\repos\\LegoMinifigureHub\\LegoMinifigureHub\\MinifigureCollection.txt";
        private const string starWarsFilePath = "C:\\Users\\Admin\\source\\repos\\LegoMinifigureHub\\LegoMinifigureHub\\StarWarsMinifigureCollection.txt";
        private const string marvelFilePath = "C:\\Users\\Admin\\source\\repos\\LegoMinifigureHub\\LegoMinifigureHub\\MarvelMinifigureCollection.txt";

        public string GetFilePath {  get { return filePath; } }
        public string GetStarWarsFilePath {  get { return starWarsFilePath; } }
        public string GetMarvelFilePath {  get { return marvelFilePath; } }
        public void WriteMinifigureToFile(Minifigure minifigureToWrite)
        {
            TextWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine($"{minifigureToWrite.Id} || {minifigureToWrite.Name} || {minifigureToWrite.Price} || {minifigureToWrite.Type}");

            sw.Close();
        }

        public void CombineFiles()
        {

        }


        public void ReadFromFile()
        {
            try
            {
                string line;
                StreamReader sr = new StreamReader(filePath);

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
