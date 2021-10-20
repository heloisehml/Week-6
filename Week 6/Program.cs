using System;
using System.IO;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "ici mettre la localisation";
            string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            try
            {

                using (StreamReader srn = new StreamReader(fileToRead))
                {
                    
                    Console.WriteLine($"Starting to Reading {fileToRead}");
                    string line;

                    while((line = srn.ReadLine()) != null)
                    {
                        Console.WriteLine($"\t{line}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }

    }
}
