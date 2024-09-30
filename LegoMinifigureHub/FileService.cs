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
        private const string accountsFilePath = "C:\\Users\\Admin\\source\\repos\\LegoMinifigureHub\\LegoMinifigureHub\\UserList.txt";


        public string GetFilePath {  get { return filePath; } }
        public string GetUserListFilePath {  get { return accountsFilePath; } }
        public void WriteMinifigureToFile(Minifigure minifigureToWrite)
        {
            TextWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine($"{minifigureToWrite.Id} || {minifigureToWrite.Name} || {minifigureToWrite.Price} || {minifigureToWrite.Theme}");

            sw.Close();
        }

        public void WriteUserToFile(User userToWrite)
        {
            TextWriter sw = new StreamWriter(accountsFilePath, true);

            sw.WriteLine($"{userToWrite.Username} || {userToWrite.Password}");

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
                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        
    }
}
