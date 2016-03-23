namespace SimpleFactory
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var pizza = PizzaFactory.CreatePizza("BBQ Deluxe");
            pizza.MakePizza(false);
            Console.WriteLine($"{pizza.PizzaName} : £{pizza.Price}");
            Console.WriteLine($"with {pizza.Sauce} sauce");
            Console.WriteLine("Toppings");
            foreach (var topping in pizza.Toppings)
            {
                Console.WriteLine(topping);
            }
            if (pizza.StuffedCrust)
            {
                Console.WriteLine("with stuffed crust");
            }
            Console.WriteLine($"Ready in {pizza.TimeToPrepare.TotalMinutes} minutes.");

            Console.ReadLine();
        }
    }
}
