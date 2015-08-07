using System;

namespace Restaurant.ObjectModel.Arrays
{
    public class Menu
    {
        private Dish[] dishes = new Dish[0];

        public void AddDish(Dish dish)
        {
            var newLength = this.dishes.Length;
            var newDishes = new Dish[newLength];
            this.dishes.CopyTo(newDishes, 0);
            newDishes[newLength - 1] = dish;
            this.dishes = newDishes;
        }

        public Dish[] GetDishes(DishType dishType)
        {
            // подготавливаем массив и счетчик для найденных элементов
            var found = new Dish[this.dishes.Length];
            var foundCount = 0;

            // бежим по массиву блюд
            foreach (var dish in this.dishes)
            {
                // если блюдо имеет нудный тип, ...
                if (dish.Type == dishType)
                {
                    // ... то плмещаем его в массив найденных и увеличиваем счетчик на единицу
                    found[foundCount] = dish;
                    foundCount++;
                }
            }

            // создаем массив для результата нужной длинны
            var result = new Dish[foundCount];

            // копируем найденное в результирующий массив
            Array.Copy(found, result, foundCount);

            return result;
        }

        public Dish[] GetDishes(DishType dishType, bool isLenten)
        {
            // создаем экземпляр делегата с помощью "лямбды"
            Predicate<Dish> filter = 
                dish => dish.Type == dishType && dish.IsLenten == isLenten;

            // передаем делегат в стандартный метод и получаем результат
            return Array.FindAll(this.dishes, filter);
        }
    }
}
