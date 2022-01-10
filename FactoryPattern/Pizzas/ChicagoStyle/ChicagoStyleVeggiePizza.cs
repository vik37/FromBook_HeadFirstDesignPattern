using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleVeggiePizza : VeggiePizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Veggie Pizza (Chicago Style");
        }
    }
}
