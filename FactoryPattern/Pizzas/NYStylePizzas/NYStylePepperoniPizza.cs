using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStylePepperoniPizza : Pepperoni
    {
        public override void TypeOfPizza()
        {
            Console.WriteLine("take your pizza Pepperoni Pizza (New York Style");
        }
    }
}
