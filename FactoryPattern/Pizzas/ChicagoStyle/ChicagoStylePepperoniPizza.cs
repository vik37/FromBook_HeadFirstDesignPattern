using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStylePepperoniPizza : Pepperoni
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Pepperoni Pizza (Chicago Style");
        }
    }
}
