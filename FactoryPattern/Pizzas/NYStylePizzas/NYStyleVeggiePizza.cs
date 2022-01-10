using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStyleVeggiePizza : VeggiePizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Veggie Pizza (New York Style");
        }
    }
}
