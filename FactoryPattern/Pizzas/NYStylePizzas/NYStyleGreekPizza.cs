using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStyleGreekPizza : GreekPizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Greek Pizza (New York Style");
        }
    }
}
