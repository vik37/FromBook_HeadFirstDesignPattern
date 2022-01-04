using DesignPattern_STP.Ducks.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks
{
    public class RubberDuck : Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        public RubberDuck()
        {
            _flyBehavior = new FLyNoWay();
            _quackBehavior = new Squeack();
        }

        public override IFlyBehavior FlyBehavior { get => _flyBehavior; set => _flyBehavior = value; }

        public override IQuackBehavior QuackBehavior => _quackBehavior;
        public override void Display()
        {
            Console.WriteLine("This is a Rubber Duck");
        }

    }
}
