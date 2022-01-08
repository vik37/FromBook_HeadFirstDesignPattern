using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Condiment
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Soy";
        }
        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }       
    }
}
