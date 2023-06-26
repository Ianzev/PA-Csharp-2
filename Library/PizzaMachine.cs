using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class PizzaMachine
    {
        public string Name { get; set; }
        protected FuelType Fuel { get; set; }
        public bool NeedsCleaning { get; set; }

        public abstract bool CanBakePizza(Pizza pizza);
        public abstract void BakePizza(Pizza pizza);
        public abstract void Clean();
    }
}
