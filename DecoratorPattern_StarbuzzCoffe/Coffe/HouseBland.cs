using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Coffe
{
    public class HouseBland : Beverage
    {
        public HouseBland()
        {
            description = "House Blend Coffe";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
