using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStyleClamPizza : ClammPizza
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza  Clam Pizza (New York Style");
        }
    }
}
