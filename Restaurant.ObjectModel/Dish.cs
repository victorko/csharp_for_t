using System;

namespace Restaurant.ObjectModel
{
    public enum DishType
    {
        FirstCourse,
        SecondCourse,
        Dessert
    }

    public class Dish
    {
        public Dish(string name, DishType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public bool IsLenten { get; set; }

        public DishType Type { get; set; }

        public string[] Ingredients
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddIngredient(string ingredientName)
        {
            throw new NotImplementedException();
        }
    }
}
