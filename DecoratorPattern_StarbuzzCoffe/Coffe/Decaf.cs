using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Coffe
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaffe";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
