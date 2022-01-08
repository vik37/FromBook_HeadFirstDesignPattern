using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Coffe
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
