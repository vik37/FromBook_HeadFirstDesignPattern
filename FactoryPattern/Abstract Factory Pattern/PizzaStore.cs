using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            pizza = CreatePizza(type, pizza);
            Console.WriteLine("-------------------");
            if(pizza == null)
            {
                Console.WriteLine("We don't have this cind of pizza");
                return null;
            }
            else
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
                
                return pizza;
            }
            
        }
        protected abstract Pizza CreatePizza(string type, Pizza pizza);
    }
}
