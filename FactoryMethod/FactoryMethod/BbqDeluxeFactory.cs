namespace FactoryMethod
{
    public class BbqDeluxeFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new BbqDeluxePizza();
        }
    }
}
