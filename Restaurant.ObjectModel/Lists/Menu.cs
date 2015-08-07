using System;
using System.Collections.Generic;

namespace Restaurant.ObjectModel.Lists
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public Dish[] GetDishes(DishType dishType)
        {
            var result = new List<Dish>();
            foreach (var dish in this.dishes)
            {
                if (dish.Type == dishType)
                {
                    result.Add(dish);
                }
            }
            return result.ToArray();
        }

        public Dish[] GetDishes(DishType dishType, bool isLenten)
        {
            Predicate<Dish> filter = 
                dish => dish.Type == dishType && dish.IsLenten == isLenten;
            return this.dishes.FindAll(filter).ToArray();
        }
    }
}
