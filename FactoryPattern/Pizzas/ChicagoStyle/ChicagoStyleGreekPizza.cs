using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleGreekPizza : GreekPizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Greek Pizza (Chicago Style");
        }
    }
}
