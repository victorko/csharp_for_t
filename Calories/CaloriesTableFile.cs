using System;
using System.IO;

namespace Restaurant.ObjectModel
{
    class CaloriesTableFile : IDisposable
    {
        private readonly string path;
        private StreamReader reader;

        public CaloriesTableFile(string path)
        {
            this.path = path;
        }

        public bool Read(out string ingredientName, out double caloricValuePerUnit)
        {
            if (this.reader == null)
            {
                this.reader = File.OpenText(this.path);
            }

            var line = this.reader.ReadLine();
            if (line == null)
            {
                ingredientName = null;
                caloricValuePerUnit = 0;
                return false;
            }

            var tokens = line.Split(':');
            ingredientName = tokens[0].Trim();
            caloricValuePerUnit = double.Parse(tokens[1].Trim());
            return true;
        }

        public void Dispose()
        {
            if (this.reader != null)
            {
                this.reader.Close();
            }
        }
    }
}
