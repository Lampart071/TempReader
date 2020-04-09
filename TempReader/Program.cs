using System;

namespace TempReader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = "tempdata.csv";

            CSVReader reader = new CSVReader(filePath);

            Temperature[] temperatures = reader.ReadFirstNTemperatures(10);

            foreach (Temperature temperature in temperatures)
            {
                Console.WriteLine($"Date:{temperature.Date} Hour:{temperature.Time}\n Room 1:{temperature.Temp1}\n Room 2:{temperature.Temp2}\n");
            }
        }
    }
}