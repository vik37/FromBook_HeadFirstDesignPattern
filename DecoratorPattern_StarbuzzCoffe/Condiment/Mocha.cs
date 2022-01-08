using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Condiment
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Mocha";
        }
        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        
    }
}
