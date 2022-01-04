using DesignPattern_STP.Ducks.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks
{
    public abstract class Duck
    {
        public abstract IFlyBehavior FlyBehavior { get; set; }
        public abstract IQuackBehavior QuackBehavior { get; }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }
        
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        
        public void Swim()
        {
            Console.WriteLine("can swim");
        }
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        
        public abstract void Display();
    }
}
