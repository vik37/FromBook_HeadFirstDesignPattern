using FactoryPattern.Pizzas.ChicagoStyle;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public class ChicagoStylePizzaFactory : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "greek":
                    return new ChicagoStyleGreekPizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                default:
                    return null;

            }
        }
    }
}
