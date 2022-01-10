using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleClamPizza : ClammPizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Clam Pizza (Chicago Style");
        }
    }
}
