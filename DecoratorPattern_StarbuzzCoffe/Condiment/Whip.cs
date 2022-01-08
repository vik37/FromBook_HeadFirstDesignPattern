using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe.Condiment
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Whip";
        }
        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}
