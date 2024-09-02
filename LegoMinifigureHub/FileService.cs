using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class FileService
    {
        public const string filePath = "C:\\Users\\Admin\\source\\repos\\LegoMinifigureHub\\LegoMinifigureHub\\MinifigureCollection.txt";
        public void WriteToFile(string minifigureToWrite)
        {
            StreamWriter sw = new StreamWriter(filePath);

            sw.WriteLine(minifigureToWrite);

            sw.Close();
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
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Nie można otworzyć pliku!");
            }
            

        }
    }
}
