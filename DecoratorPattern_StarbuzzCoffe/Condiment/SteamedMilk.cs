using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Condiment
{
    public class SteamedMilk : CondimentDecorator
    {
        private Beverage _beverage;
        public SteamedMilk(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Steamed Milk";
        }
        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }       
    }
}
