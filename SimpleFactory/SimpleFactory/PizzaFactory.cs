namespace SimpleFactory
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "Margherita":
                    return new MargheritaPizza();
                case "Hawaian":
                    return new HawaianPizza();
                case "BBQ Deluxe":
                    return new BbqDeluxePizza();
                default:
                    return new MargheritaPizza();
            }
        }
    }
}
