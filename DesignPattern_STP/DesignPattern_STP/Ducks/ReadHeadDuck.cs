using DesignPattern_STP.Ducks.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks
{
    public class ReadHeadDuck : Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        public ReadHeadDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }

        public override IFlyBehavior FlyBehavior { get => _flyBehavior; set => _flyBehavior = value; }

        public override IQuackBehavior QuackBehavior => _quackBehavior;
        public override void Display()
        {
            Console.WriteLine("This is a Readhead Duck");
        }

    }
}
