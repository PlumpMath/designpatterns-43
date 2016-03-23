namespace FactoryMethod
{
    using System;

    class BbqDeluxePizza : Pizza
    {
        public BbqDeluxePizza()
        {
            this.PizzaName = "BBQ Deluxe";
            this.Price = 11.99;
        }

        protected override void AddSauce()
        {
            this.Sauce = "BBQ";
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 2, 0));
        }

        protected override void AddToppings()
        {
            this.Toppings.Add("Cheese");
            this.Toppings.Add("Bacon");
            this.Toppings.Add("Sausage");
            this.Toppings.Add("Peppers");
            this.Toppings.Add("Chicken");
            this.Toppings.Add("Chillies");
        }

        protected override void Cook()
        {
            this.TimeToPrepare = this.TimeToPrepare.Add(new TimeSpan(0, 12, 0));
        }
    }
}