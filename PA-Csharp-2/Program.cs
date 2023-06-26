using Library;

namespace PA_Csharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tomato = new Ingriedient { Name = "Tomato", IsVegetarian = true };
            var cheese = new Ingriedient { Name = "Cheese", IsVegetarian = true };
            var ham = new Ingriedient { Name = "Ham", IsVegetarian = false };

            Pizza pizza = new Pizza
            {
                FantasyName = "Margherita",
                Ingredients = new Dictionary<Ingriedient, int>
                {
                    { tomato, 2 },
                    { cheese, 1 }
                }
            };
            Pizza pizza1 = new Pizza
            {
                FantasyName = "Diabolo",
                Ingredients = new Dictionary<Ingriedient, int>
                {
                    { tomato, 2 },
                    { cheese, 1 },
                    { ham, 2 },
                }
            };

            VegetarianPizzaMachine vegMachine = new VegetarianPizzaMachine("VegMachine", FuelType.Electricity);
            MeatPizzaMachine meatMachine = new MeatPizzaMachine("MeatMachine", FuelType.Gas);

            if (vegMachine.CanBakePizza(pizza1))
            {
                vegMachine.BakePizza(pizza1);
            }
            else if (meatMachine.CanBakePizza(pizza1))
            {
                meatMachine.BakePizza(pizza1);
            }
            else
            {
                Console.WriteLine("No suitable pizza machine found.");
            }

            vegMachine.Clean();
        }
    }
}