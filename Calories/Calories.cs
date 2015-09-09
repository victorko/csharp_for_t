using System;
using System.Collections.Generic;

namespace Restaurant.ObjectModel
{
    public class Calories
    {
        private readonly string tableFileName;
        private Dictionary<string, double> caloriesTable;

        public Calories(string tableFileName)
        {
            this.tableFileName = tableFileName;
        }

        private Dictionary<string, double> CaloriesTable
        {
            get
            {
                if (this.caloriesTable == null)
                {
                    PopulateCalTable();
                }
                return this.caloriesTable;
            }
        }

        private void PopulateCalTable()
        {
            try
            {
                double cal;
                string ing;
                this.caloriesTable = new Dictionary<string, double>();
                using (var file = new CaloriesTableFile(this.tableFileName))
                {
                    while (file.Read(out ing, out cal))
                    {
                        this.caloriesTable.Add(ing, cal);
                        //this.caloriesTable[ing] = cal;
                    }
                }
            }
            catch (Exception ex)
            {
                //ex.Data["Reason"] = "таблица калорийности";
                //throw;

                throw new InvalidOperationException("Не удалось прочитать таблицу калорийности", ex);
            }          
        }

        public double GetCaloriesFor(Dish dish)
        {
            if (dish == null)
                throw new ArgumentNullException("dish");

            double sum = 0;
            foreach (var ingredient in dish.Ingredients)
            {
                double val;
                if (this.CaloriesTable.TryGetValue(ingredient.Name, out val))
                {
                    sum += val * ingredient.Quantity;
                }
                else
                {
                    throw new Exception(
                        string.Format("не нашли ингредиент {0}", ingredient.Name));
                }
            }
            return sum;
        }
    }
}
