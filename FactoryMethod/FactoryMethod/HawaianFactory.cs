namespace FactoryMethod
{
    public class HawaianFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new HawaianPizza();
        }
    }
}
