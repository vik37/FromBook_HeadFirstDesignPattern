using FactoryPattern.Pizzas.NYStylePizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public class NYPizzaFactory : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "greek":
                    return new NYStyleGreekPizza();
                case "clam":
                    return new NYStyleClamPizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
