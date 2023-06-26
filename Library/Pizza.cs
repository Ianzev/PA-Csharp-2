using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Pizza
    {
        public string FantasyName { get; set; }
        public Dictionary<Ingriedient, int> Ingredients { get; set; }

        public bool IsVegetarian()
        {
            foreach (var ingredient in Ingredients)
            {
                if (!ingredient.Key.IsVegetarian)
                    return false;
            }
            return true;
        }
    }
}
