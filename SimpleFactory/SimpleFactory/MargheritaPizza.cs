namespace SimpleFactory
{
    using System;

    public class MargheritaPizza : Pizza
    {
        public MargheritaPizza()
        {
            this.PizzaName = "Margherita";
            this.Price = 6.99;
        }

        protected override void AddSauce()
        {
            this.Sauce = "Tomato";
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 1, 0));
        }

        protected override void AddToppings()
        {
            this.Toppings.Add("Cheese");
            this.Toppings.Add("Tomato");
        }

        protected override void Cook()
        {
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 8, 0));
        }
    }
}