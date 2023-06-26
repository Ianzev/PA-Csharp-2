using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MeatPizzaMachine : PizzaMachine
    {
        private const int MaxUsesBeforeCleaning = 10;
        private int usesCount;

        public MeatPizzaMachine(string name, FuelType fuel)
        {
            Name = name;
            Fuel = fuel;
            NeedsCleaning = true;
            usesCount = 0;
        }
        public override bool CanBakePizza(Pizza pizza)
        {
            if (NeedsCleaning)
            {
                return false;
            }

             return true;
        }

        public override void BakePizza(Pizza pizza)
        {
            Console.WriteLine($"Baking {pizza.FantasyName} in {Name} machine.");

            Console.WriteLine($"Pizza {pizza.FantasyName} is ready!");

            Console.WriteLine($"Your {pizza.FantasyName} pizza is ready!");

            usesCount++;
            if (usesCount >= MaxUsesBeforeCleaning)
            {
                NeedsCleaning = true;
            }
        }

        public override void Clean()
        {
            Console.WriteLine($"Cleaning {Name} machine...");
            usesCount = 0;
            NeedsCleaning = false;
        }
    }
}
