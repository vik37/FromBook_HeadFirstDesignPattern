using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_StarbuzzCoffe
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}
