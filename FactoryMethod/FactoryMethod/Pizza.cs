using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza : IPizza
    {
        public IList<string> Toppings { get; protected set; }

        public bool StuffedCrust { get; protected set; }

        public string Sauce { get; protected set; }

        public double Price { get; protected set; }

        public string PizzaName { get; protected set; }

        public TimeSpan TimeToPrepare { get; protected set; }

        protected Pizza()
        {
            this.Toppings = new List<string>();
        }

        protected void MakeBase()
        {
            var timeToMakeBase = new TimeSpan(0, 5, 0);

            if (this.StuffedCrust)
            {
                timeToMakeBase = timeToMakeBase.Add(new TimeSpan(0, 3, 0));
            }
            this.TimeToPrepare = this.TimeToPrepare.Add(timeToMakeBase);
        }

        protected abstract void AddSauce();

        protected abstract void AddToppings();

        protected abstract void Cook();

        public void MakePizza(bool stuffedCrust)
        {
            this.StuffedCrust = stuffedCrust;
            this.MakeBase();
            this.AddSauce();
            this.AddToppings();
            this.Cook();
        }
    }
}
