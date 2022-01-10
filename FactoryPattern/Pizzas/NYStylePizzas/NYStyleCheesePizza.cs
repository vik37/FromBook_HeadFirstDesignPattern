using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStyleCheesePizza : CheesePizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Cheese Pizza (New York Style");
        }
    }
}
