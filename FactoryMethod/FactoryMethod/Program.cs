using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPizzaFactory pizzaFactory = new BbqDeluxeFactory();
            MakePizza(pizzaFactory, true);

            pizzaFactory = new HawaianFactory();
            MakePizza(pizzaFactory, false);

            Console.ReadLine();
        }

        public static void MakePizza(IPizzaFactory pizzaFactory, bool stuffedCrust)
        {
            var pizza = pizzaFactory.CreatePizza();
            pizza.MakePizza(stuffedCrust);
            Console.WriteLine($"{pizza.PizzaName} : £{pizza.Price} {(pizza.StuffedCrust ? "with stuffed crust" : "with regular crust")}");
            Console.WriteLine($"with {pizza.Sauce} sauce");
            Console.WriteLine("Toppings");
            foreach (var topping in pizza.Toppings)
            {
                Console.WriteLine(topping);
            }

            Console.WriteLine($"Ready in {pizza.TimeToPrepare.TotalMinutes} minutes.");
            Console.WriteLine();
        }
    }
}
