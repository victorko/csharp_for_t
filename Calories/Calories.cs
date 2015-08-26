using System;

namespace Restaurant.ObjectModel
{
    public class Calories
    {
        private readonly string tableFileName;

        public Calories(string tableFileName)
        {
            this.tableFileName = tableFileName;
        }

        public double GetCaloriesFor(Dish dish)
        {
            // TODO: Написать тело метода, возвращающего калорийность заданного блюда.
            // Значения калорийности ингредиентов брать из текстового файла, путь к которому
            // был передан в конструкторе. Для чтения файла использовать класс CaloriesTableFile.
            throw new NotImplementedException();
        }
    }
}
