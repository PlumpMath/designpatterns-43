namespace FactoryMethod
{
    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract Pizza CreatePizza();
    }
}
