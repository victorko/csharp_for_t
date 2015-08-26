using System;

namespace Restaurant.ObjectModel.Arrays
{
    public enum DishType
    {
        FirstCourse,
        SecondCourse,
        Dessert
    }

    public class Dish
    {
        private string[] ingredients = new string[0];

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
                // возвращаем копию массива ингридиентов
                return (string[])this.ingredients.Clone();
            }
        }

        public void AddIngredient(string ingredientName)
        {
            // получаем новый размер массива
            var newLength = this.ingredients.Length + 1;

            // создаем новый массив
            var newIngredients = new string[newLength];

            // копируем элементы старого массива
            this.ingredients.CopyTo(newIngredients, 0);

            // добавляем новый элемент в конец
            newIngredients[newLength - 1] = ingredientName;

            // записываем ссылку на новый массив в поле
            this.ingredients = newIngredients;
        }
    }
}
