using System;
using System.Collections.Generic;

namespace Restaurant.ObjectModel.Lists
{
    public enum DishType
    {
        FirstCourse,
        SecondCourse,
        Dessert
    }

    public class Dish
    {
        private List<string> ingredients;

        public Dish(string name, DishType type)
        {
            this.Name = name;
            this.Type = type;
            this.ingredients = new List<string>();
        }

        public string Name { get; set; }

        public bool IsLenten { get; set; }

        public DishType Type { get; set; }

        public string[] Ingredients
        {
            get
            {
                return this.ingredients.ToArray();
            }
        }

        public void AddIngredient(string ingredientName)
        {
            this.ingredients.Add(ingredientName);
        }
    }
}
