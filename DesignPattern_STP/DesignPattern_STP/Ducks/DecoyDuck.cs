using DesignPattern_STP.Ducks.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks
{
    public class DecoyDuck : Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        public DecoyDuck()
        {
            _flyBehavior = new FLyNoWay();
            _quackBehavior = new MuteSquack();
        }

        public override IFlyBehavior FlyBehavior { get => _flyBehavior; set => _flyBehavior = value; }

        public override IQuackBehavior QuackBehavior => _quackBehavior;
        public override void Display()
        {
            Console.WriteLine("This is a Decoy Duck");
        }
    }
}
