using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class VegetarianPizzaMachine : PizzaMachine
    {
        public VegetarianPizzaMachine(string name, FuelType fuel)
        {
            Name = name;
            Fuel = fuel;
            NeedsCleaning = false;
        }
        public override bool CanBakePizza(Pizza pizza)
        {
            foreach (var ingredient in pizza.Ingredients)
            {
                if (!ingredient.Key.IsVegetarian)
                {
                    return false;
                }
            }
            return true;
        }

        public override void BakePizza(Pizza pizza)
        {
            Console.WriteLine($"Baking {pizza.FantasyName} in {Name} machine.");

            foreach (var ingredient in pizza.Ingredients.Keys)
            {
            }

            Console.WriteLine($"Pizza {pizza.FantasyName} is ready!");
        }

        public override void Clean()
        {
            Console.WriteLine($"{Name} machine doesn't require cleaning.");
        }
    }
}
