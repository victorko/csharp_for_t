using System;
using System.Text;

namespace Restaurant.ObjectModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var dish = new Dish("Бутерброд с сыром", DishType.Dessert);

            var cheese = new Ingredient();
            cheese.Name = "Сыр";
            cheese.Quantity = 20;
            cheese.Unit = "гр";
            dish.AddIngredient(cheese);

            var bread = new Ingredient();
            bread.Name = "Хлеб";
            bread.Quantity = 50;
            bread.Unit = "гр";
            dish.AddIngredient(bread);

            var calories = new Calories("calories.txt");
            var caloriesValue = calories.GetCaloriesFor(dish);

            Console.WriteLine("{0}: {1}", dish.Name, caloriesValue);
        }





        private static void TestTableFile()
        {
            Console.OutputEncoding = Encoding.Unicode;
            var tableFile = new CaloriesTableFile("calories.txt");
            string name;
            double value;
            while (tableFile.Read(out name, out value))
            {
                Console.WriteLine("{0}: {1}", name, value);
            }
            tableFile.Close();
        }
    }
}
