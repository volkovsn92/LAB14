using RestaurantOOP.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.ServiceTypes
{
    public class Dish
    {
        public string Name { get; private set; }
        public MealRecipe Meal { get; private set; }
        public Dish(string name)
        {
            Name = name;
            Meal = new MealRecipe(name);
        }         
    }

    public struct MealRecipe
    {
        public List<IngredientsAvailable> IngredientsForDish;
        public MealRecipe(string nameOfMeal)
        {
            if (nameOfMeal.Equals(DishesNames.SpaghettiBolognese))
            {
                IngredientsForDish = new List<IngredientsAvailable>();
                IngredientsForDish.Add(IngredientsAvailable.Spaghetti);
                IngredientsForDish.Add(IngredientsAvailable.Forcemeat);
                IngredientsForDish.Add(IngredientsAvailable.Tomato);
                IngredientsForDish.Add(IngredientsAvailable.Salt);
            }
            if (nameOfMeal.Equals(DishesNames.Salad))
            {
                IngredientsForDish = new List<IngredientsAvailable>();
                IngredientsForDish.Add(IngredientsAvailable.Tomato);
                IngredientsForDish.Add(IngredientsAvailable.Cucumber);
                IngredientsForDish.Add(IngredientsAvailable.Salt);
            }
            if (nameOfMeal.Equals(DishesNames.Cake))
            {
                IngredientsForDish = new List<IngredientsAvailable>();
                IngredientsForDish.Add(IngredientsAvailable.Flour);
                IngredientsForDish.Add(IngredientsAvailable.Water);
                IngredientsForDish.Add(IngredientsAvailable.Sugar);
            }
            if (nameOfMeal.Equals(DishesNames.Coffee))
            {
                IngredientsForDish = new List<IngredientsAvailable>();
                IngredientsForDish.Add(IngredientsAvailable.InstantCoffee);
                IngredientsForDish.Add(IngredientsAvailable.Water);
                IngredientsForDish.Add(IngredientsAvailable.Sugar);
            }
            else
            {
                IngredientsForDish = null;
            }
        } 
    }

    public enum IngredientsAvailable
    {
        Water,
        InstantCoffee,
        Sugar,
        Tomato,
        Cucumber,
        Salt,
        Spaghetti,
        Forcemeat,
        Flour
    }
}
