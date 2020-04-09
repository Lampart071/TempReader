using System.Globalization;
using System.IO;

namespace TempReader
{
    internal class CSVReader
    {
        private string _csvFilePath;

        public CSVReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Temperature[] ReadFirstNTemperatures(int nTemperatures)
        {
            Temperature[] temperatures = new Temperature[nTemperatures];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // read header line
                sr.ReadLine();

                for (int i = 0; i < nTemperatures; i++)
                {
                    string csvLine = sr.ReadLine();
                    temperatures[i] = ReadTemperatureFromCsvFile(csvLine);
                }
            }

            return temperatures;
        }

        public Temperature ReadTemperatureFromCsvFile(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string date = parts[0];
            string time = parts[1];
            float temp1 = float.Parse(parts[2], CultureInfo.InvariantCulture);
            float temp2 = float.Parse(parts[3], CultureInfo.InvariantCulture);

            return new Temperature(date, time, temp1, temp2);
        }
    }
}