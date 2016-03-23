using System;

namespace FactoryMethod
{
    public class HawaianPizza : Pizza
    {
        public HawaianPizza()
        {
            this.PizzaName = "Hawaian";
            this.Price = 7.99;
        }

        protected override void AddSauce()
        {
            this.Sauce = "Tomato";
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 1, 0));
        }

        protected override void AddToppings()
        {
            this.Toppings.Add("Ham");
            this.Toppings.Add("Pineapple");
        }

        protected override void Cook()
        {
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 10, 0));
        }
    }
}
