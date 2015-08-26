using System;
using System.Collections.Generic;

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
        private List<Ingredient> ingredients;

        public Dish(string name, DishType type)
        {
            this.Name = name;
            this.Type = type;
            this.ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }

        public bool IsLenten { get; set; }

        public DishType Type { get; set; }

        public Ingredient[] Ingredients
        {
            get
            {
                return this.ingredients.ToArray();
            }
        }

        public void AddIngredient(Ingredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }
    }
}
