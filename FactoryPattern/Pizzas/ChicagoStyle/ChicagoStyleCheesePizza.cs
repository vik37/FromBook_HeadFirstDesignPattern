using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleCheesePizza : CheesePizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Cheese Pizza (Chicago Style");
        }
    }
}
